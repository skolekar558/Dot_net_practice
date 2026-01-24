namespace ReadWriteForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStreamWrite = new System.Windows.Forms.Button();
            this.btnStreamRead = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.XmlRead_Click = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(166, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(129, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(166, 162);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(129, 20);
            this.txtSalary.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(12, 272);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(108, 272);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(370, 272);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(146, 23);
            this.btnCreateFile.TabIndex = 8;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(189, 272);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(156, 23);
            this.btnCreateDirectory.TabIndex = 9;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(392, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 84);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnStreamWrite
            // 
            this.btnStreamWrite.Location = new System.Drawing.Point(404, 162);
            this.btnStreamWrite.Name = "btnStreamWrite";
            this.btnStreamWrite.Size = new System.Drawing.Size(103, 26);
            this.btnStreamWrite.TabIndex = 11;
            this.btnStreamWrite.Text = "Stream Write";
            this.btnStreamWrite.UseVisualStyleBackColor = true;
            this.btnStreamWrite.Click += new System.EventHandler(this.btnStreamWrite_Click);
            // 
            // btnStreamRead
            // 
            this.btnStreamRead.Location = new System.Drawing.Point(581, 165);
            this.btnStreamRead.Name = "btnStreamRead";
            this.btnStreamRead.Size = new System.Drawing.Size(103, 26);
            this.btnStreamRead.TabIndex = 12;
            this.btnStreamRead.Text = "Stream Read";
            this.btnStreamRead.UseVisualStyleBackColor = true;
            this.btnStreamRead.Click += new System.EventHandler(this.btnStreamRead_Click);
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(12, 328);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWrite.TabIndex = 13;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(12, 376);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(75, 23);
            this.btnXmlWrite.TabIndex = 14;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(122, 328);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryRead.TabIndex = 15;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // XmlRead_Click
            // 
            this.XmlRead_Click.Location = new System.Drawing.Point(122, 376);
            this.XmlRead_Click.Name = "XmlRead_Click";
            this.XmlRead_Click.Size = new System.Drawing.Size(75, 23);
            this.XmlRead_Click.TabIndex = 16;
            this.XmlRead_Click.Text = "XML Read";
            this.XmlRead_Click.UseVisualStyleBackColor = true;
            this.XmlRead_Click.Click += new System.EventHandler(this.XmlRead_Click_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(12, 415);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSoapWrite.TabIndex = 17;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(122, 415);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(75, 23);
            this.btnSoapRead.TabIndex = 18;
            this.btnSoapRead.Text = "SOAP Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(12, 453);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(75, 23);
            this.btnJsonWrite.TabIndex = 19;
            this.btnJsonWrite.Text = "JSON Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.btnJsonWrite_Click);
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(122, 453);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(75, 23);
            this.btnJsonRead.TabIndex = 20;
            this.btnJsonRead.Text = "JSON Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.XmlRead_Click);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.btnStreamRead);
            this.Controls.Add(this.btnStreamWrite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStreamWrite;
        private System.Windows.Forms.Button btnStreamRead;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button XmlRead_Click;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnJsonWrite;
        private System.Windows.Forms.Button btnJsonRead;
    }
}

