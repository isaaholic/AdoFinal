namespace AdoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RefreshDbBtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.Searchtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox_Category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RefreshDbBtn
            // 
            this.RefreshDbBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshDbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshDbBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshDbBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshDbBtn.Location = new System.Drawing.Point(636, 39);
            this.RefreshDbBtn.Name = "RefreshDbBtn";
            this.RefreshDbBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshDbBtn.TabIndex = 19;
            this.RefreshDbBtn.Text = "Refresh";
            this.RefreshDbBtn.UseVisualStyleBackColor = false;
            this.RefreshDbBtn.Click += new System.EventHandler(this.SearchBtn_ClickAsync);
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(8, 68);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 305);
            this.listView.TabIndex = 18;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.Location = new System.Drawing.Point(717, 8);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 24);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.Black;
            this.EditBtn.Location = new System.Drawing.Point(636, 9);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 16;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(556, 8);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(74, 24);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(462, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 24);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_ClickAsync);
            // 
            // Searchtxtbox
            // 
            this.Searchtxtbox.Location = new System.Drawing.Point(272, 12);
            this.Searchtxtbox.Multiline = true;
            this.Searchtxtbox.Name = "Searchtxtbox";
            this.Searchtxtbox.Size = new System.Drawing.Size(184, 24);
            this.Searchtxtbox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category";
            // 
            // cmbBox_Category
            // 
            this.cmbBox_Category.FormattingEnabled = true;
            this.cmbBox_Category.Location = new System.Drawing.Point(71, 15);
            this.cmbBox_Category.Name = "cmbBox_Category";
            this.cmbBox_Category.Size = new System.Drawing.Size(132, 23);
            this.cmbBox_Category.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.RefreshDbBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Searchtxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox_Category);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RefreshDbBtn;
        private ListView listView;
        public Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Label label2;
        private Button SearchBtn;
        private TextBox Searchtxtbox;
        private Label label1;
        private ComboBox cmbBox_Category;
    }
}