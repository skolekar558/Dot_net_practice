namespace Employee_Form
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmpName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(214, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(116, 20);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(214, 223);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(116, 20);
            this.txtSalary.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(214, 179);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(116, 20);
            this.txtCity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salary";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(113, 294);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(57, 20);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(310, 294);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(55, 20);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(214, 294);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(61, 20);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(478, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(61, 20);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 235);
            this.dataGridView1.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(489, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 20);
            this.button5.TabIndex = 15;
            this.button5.Text = "ShowAllEmp";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 333);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
    }
}

