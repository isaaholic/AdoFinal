using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AdoFinal;

public partial class AddProduct : Form
{
    SqlConnection conn = null;
    string connectionString = null;

    public AddProduct()
    {
        InitializeComponent();
        Configure();
    }


    private void Configure()
    {
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + "../../../../")
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        connectionString = configuration.GetConnectionString("ProductDb");
        conn = new SqlConnection(connectionString);
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {

        if (Ratingtxtbox.Text == null ||
        Nametxtbox.Text == null ||
        CatIdtxtbox.Text == null ||
        Pricetxtbox.Text == null ||
        Quantitytxtbox.Text == null)
        {
            MessageBox.Show("Please fill all textboxes ");
            return;
        }

        try
        {
            SqlCommand addCommand = new SqlCommand()
            {
                CommandText = "dbo.usp_AddProduct",
                Connection = conn,
                CommandType = CommandType.StoredProcedure,
            };
            addCommand.Parameters.AddWithValue("@pName", SqlDbType.NVarChar).Value = Nametxtbox.Text;
            addCommand.Parameters.AddWithValue("@pPrice", SqlDbType.Decimal).Value = Pricetxtbox.Text;
            addCommand.Parameters.AddWithValue("@pQuantity", SqlDbType.Int).Value = Quantitytxtbox.Text;
            addCommand.Parameters.AddWithValue("@pCategoryId", SqlDbType.Int).Value = CatIdtxtbox.Text;
            addCommand.Parameters.AddWithValue("@pRating", SqlDbType.Decimal).Value = Ratingtxtbox.Text;

            conn.Open();
            addCommand.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn.Close();
            Close();
        }
    }


    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

}
