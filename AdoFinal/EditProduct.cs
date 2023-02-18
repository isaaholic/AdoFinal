using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace AdoFinal;

public partial class EditProduct : Form
{
    SqlConnection conn = null;
    SqlCommand command = null;
    SqlTransaction transaction = null;
    string connectionString = null;
    int id;
    public EditProduct(int id)
    {
        InitializeComponent();
        this.id = id;
        Configure();
    }

    private void Configure()
    {
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + "../../../../")
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        connectionString = configuration.GetConnectionString("ProductDb");
        conn = new SqlConnection(connectionString);
        fillData(id);
    }

    private async Task fillData(int id)
    {
        try
        {
            conn.Open();
            command = new SqlCommand("SELECT Product.[Name] AS [Name],Product.[Price] AS [Price],Product.[Quantity] AS [Quantity],Product.[CategoryId] AS [CatId],Product.[Rating] AS [Rating] FROM Product WHERE Id=@id", conn);
            command.Parameters.AddWithValue("@id", id);
            DbDataReader dataReader = await command.ExecuteReaderAsync();
            Idtxtbox.Text = id.ToString();
            while (dataReader.Read())
            {
                Nametxtbox.Text = dataReader["Name"].ToString();
                Ratingtxtbox.Text = dataReader["Rating"].ToString();
                Pricetxtbox.Text = dataReader["Price"].ToString();
                Quantitytxtbox.Text = dataReader["Quantity"].ToString();
                CatIdtxtbox.Text = dataReader["CatId"].ToString();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn.Close();

        }
    }


    private void SaveBtn_Click(object sender, EventArgs e)
    {
        try
        {
            conn.Open();
            transaction = conn.BeginTransaction();
            SqlCommand updateCommand = new SqlCommand()
            {
                CommandText = "dbo.usp_UpdateProduct",
                Connection = conn,
                CommandType = CommandType.StoredProcedure,
                Transaction = transaction
            };
            updateCommand.Parameters.AddWithValue("@pId", SqlDbType.NVarChar).Value = Idtxtbox.Text;
            updateCommand.Parameters.AddWithValue("@pName", SqlDbType.NVarChar).Value = Nametxtbox.Text;
            updateCommand.Parameters.AddWithValue("@pPrice", SqlDbType.Decimal).Value = decimal.Parse(Pricetxtbox.Text);
            updateCommand.Parameters.AddWithValue("@pQuantity", SqlDbType.Int).Value = int.Parse(Quantitytxtbox.Text);
            updateCommand.Parameters.AddWithValue("@pRating", SqlDbType.Decimal).Value = decimal.Parse(Ratingtxtbox.Text);
            updateCommand.Parameters.AddWithValue("@pCategoryId", SqlDbType.Int).Value = int.Parse(CatIdtxtbox.Text);

            updateCommand.ExecuteNonQuery();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn.Close();Close();
        }
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

}
