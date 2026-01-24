namespace Employee_Form
{
    partial class Product
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
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(505, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 20);
            this.button5.TabIndex = 26;
            this.button5.Text = "ShowAllproduct";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 235);
            this.dataGridView1.TabIndex = 25;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(218, 330);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(61, 20);
            this.Update.TabIndex = 24;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(314, 330);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(55, 20);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(117, 330);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(57, 20);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(218, 215);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(116, 20);
            this.txtPrice.TabIndex = 19;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 161);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "PName";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(409, 330);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(61, 20);
            this.Search.TabIndex = 27;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "PId";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(218, 114);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(116, 20);
            this.txtId.TabIndex = 29;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
    }
}