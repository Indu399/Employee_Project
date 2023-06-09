﻿namespace EmployeeApplication_WinForm
{
    partial class EmployeeData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeData));
            this.txtView = new System.Windows.Forms.RichTextBox();
            this.BtnGetallEmp = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.RichTextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.txtEmpName = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.RichTextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.txtGender = new System.Windows.Forms.RichTextBox();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(659, 218);
            this.txtView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(863, 480);
            this.txtView.TabIndex = 0;
            this.txtView.Text = "";
            // 
            // BtnGetallEmp
            // 
            this.BtnGetallEmp.Location = new System.Drawing.Point(16, 128);
            this.BtnGetallEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGetallEmp.Name = "BtnGetallEmp";
            this.BtnGetallEmp.Size = new System.Drawing.Size(253, 42);
            this.BtnGetallEmp.TabIndex = 1;
            this.BtnGetallEmp.Text = "GetAllEmployee ";
            this.BtnGetallEmp.UseVisualStyleBackColor = true;
            this.BtnGetallEmp.Click += new System.EventHandler(this.BtnGetallEmp_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(233, 258);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(252, 41);
            this.txtId.TabIndex = 2;
            this.txtId.Text = "1";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(329, 128);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(253, 42);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Employee";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(233, 354);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(252, 41);
            this.txtEmpName.TabIndex = 4;
            this.txtEmpName.Text = "indu";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(233, 460);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 41);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "indureddy5a5@gmail.com";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(659, 128);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(253, 42);
            this.btnAddEmp.TabIndex = 6;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(969, 128);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(253, 42);
            this.btnUpdateEmployee.TabIndex = 7;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(1269, 128);
            this.btnDeleteEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(253, 42);
            this.btnDeleteEmp.TabIndex = 8;
            this.btnDeleteEmp.Text = "Delete Employee";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(233, 554);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(252, 41);
            this.txtGender.TabIndex = 9;
            this.txtGender.Text = "Singal";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(233, 657);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(252, 41);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.Text = "Singal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 554);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(25, 657);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(60, 24);
            this.Status.TabIndex = 15;
            this.Status.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 729);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(488, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Instruction-1.For View Employee Insert Only Employee Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 769);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(579, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "2.For Add Employee insert EMP Name,Emp Id,Gender,Status feilds ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(593, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(498, 39);
            this.label7.TabIndex = 19;
            this.label7.Text = "Employee Management System";
            // 
            // EmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1723, 826);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.BtnGetallEmp);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.btnDeleteEmp);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEmpName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeData";
            this.Text = "EmployeeData";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtView;
        private System.Windows.Forms.Button BtnGetallEmp;
        private System.Windows.Forms.RichTextBox txtId;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.RichTextBox txtEmpName;
        private System.Windows.Forms.RichTextBox txtEmail;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.RichTextBox txtGender;
        private System.Windows.Forms.RichTextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}