namespace Stock
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Product_Code = new System.Windows.Forms.Label();
            this.Product_Name = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.ProductCode_txt = new System.Windows.Forms.TextBox();
            this.ProductName_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_ComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_Code
            // 
            this.Product_Code.AutoSize = true;
            this.Product_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Code.Location = new System.Drawing.Point(57, 77);
            this.Product_Code.Name = "Product_Code";
            this.Product_Code.Size = new System.Drawing.Size(132, 25);
            this.Product_Code.TabIndex = 0;
            this.Product_Code.Text = "Product Code";
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSize = true;
            this.Product_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Name.Location = new System.Drawing.Point(268, 77);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(136, 25);
            this.Product_Name.TabIndex = 1;
            this.Product_Name.Text = "Product Name";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(483, 77);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(68, 25);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status";
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.Location = new System.Drawing.Point(810, 112);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(140, 55);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(1017, 112);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(140, 55);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // ProductCode_txt
            // 
            this.ProductCode_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCode_txt.Location = new System.Drawing.Point(62, 128);
            this.ProductCode_txt.Name = "ProductCode_txt";
            this.ProductCode_txt.Size = new System.Drawing.Size(183, 30);
            this.ProductCode_txt.TabIndex = 3;
            // 
            // ProductName_txt
            // 
            this.ProductName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName_txt.Location = new System.Drawing.Point(275, 128);
            this.ProductName_txt.Name = "ProductName_txt";
            this.ProductName_txt.Size = new System.Drawing.Size(183, 30);
            this.ProductName_txt.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(62, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 429);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            // 
            // Status_ComboBox
            // 
            this.Status_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_ComboBox.FormattingEnabled = true;
            this.Status_ComboBox.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.Status_ComboBox.Location = new System.Drawing.Point(488, 125);
            this.Status_ComboBox.Name = "Status_ComboBox";
            this.Status_ComboBox.Size = new System.Drawing.Size(183, 33);
            this.Status_ComboBox.TabIndex = 10;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 808);
            this.Controls.Add(this.Status_ComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductName_txt);
            this.Controls.Add(this.ProductCode_txt);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.Product_Code);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product_Code;
        private System.Windows.Forms.Label Product_Name;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox ProductCode_txt;
        private System.Windows.Forms.TextBox ProductName_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox Status_ComboBox;
    }
}