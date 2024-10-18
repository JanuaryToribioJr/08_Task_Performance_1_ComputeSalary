namespace Employee_Application
{
    partial class frmComputeSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComputeSalary));
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.ratePerHour = new System.Windows.Forms.TextBox();
            this.totalHoursWork = new System.Windows.Forms.TextBox();
            this.computeSalaryBtn = new System.Windows.Forms.Button();
            this.firstNameP = new System.Windows.Forms.Label();
            this.lastNameP = new System.Windows.Forms.Label();
            this.basicSalaryP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.SystemColors.Window;
            this.firstName.Location = new System.Drawing.Point(73, 52);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(290, 26);
            this.firstName.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.SystemColors.Window;
            this.lastName.Location = new System.Drawing.Point(401, 52);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(290, 26);
            this.lastName.TabIndex = 1;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // department
            // 
            this.department.BackColor = System.Drawing.Color.DarkSlateGray;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.ForeColor = System.Drawing.SystemColors.Window;
            this.department.Location = new System.Drawing.Point(73, 120);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(290, 26);
            this.department.TabIndex = 2;
            // 
            // jobTitle
            // 
            this.jobTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.jobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.jobTitle.Location = new System.Drawing.Point(401, 120);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(290, 26);
            this.jobTitle.TabIndex = 3;
            // 
            // ratePerHour
            // 
            this.ratePerHour.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ratePerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratePerHour.ForeColor = System.Drawing.SystemColors.Window;
            this.ratePerHour.Location = new System.Drawing.Point(73, 201);
            this.ratePerHour.Name = "ratePerHour";
            this.ratePerHour.Size = new System.Drawing.Size(290, 26);
            this.ratePerHour.TabIndex = 4;
            // 
            // totalHoursWork
            // 
            this.totalHoursWork.BackColor = System.Drawing.Color.DarkSlateGray;
            this.totalHoursWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursWork.ForeColor = System.Drawing.SystemColors.Window;
            this.totalHoursWork.Location = new System.Drawing.Point(401, 201);
            this.totalHoursWork.Name = "totalHoursWork";
            this.totalHoursWork.Size = new System.Drawing.Size(290, 26);
            this.totalHoursWork.TabIndex = 5;
            this.totalHoursWork.TextChanged += new System.EventHandler(this.totalHoursWork_TextChanged);
            // 
            // computeSalaryBtn
            // 
            this.computeSalaryBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.computeSalaryBtn.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeSalaryBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.computeSalaryBtn.Location = new System.Drawing.Point(291, 249);
            this.computeSalaryBtn.Name = "computeSalaryBtn";
            this.computeSalaryBtn.Size = new System.Drawing.Size(165, 48);
            this.computeSalaryBtn.TabIndex = 6;
            this.computeSalaryBtn.Text = "Compute Salary";
            this.computeSalaryBtn.UseVisualStyleBackColor = false;
            this.computeSalaryBtn.Click += new System.EventHandler(this.computeSalaryBtn_Click);
            // 
            // firstNameP
            // 
            this.firstNameP.AutoSize = true;
            this.firstNameP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.firstNameP.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameP.Location = new System.Drawing.Point(182, 324);
            this.firstNameP.Name = "firstNameP";
            this.firstNameP.Size = new System.Drawing.Size(13, 19);
            this.firstNameP.TabIndex = 7;
            this.firstNameP.Text = " ";
            this.firstNameP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNameP
            // 
            this.lastNameP.AutoSize = true;
            this.lastNameP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lastNameP.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameP.Location = new System.Drawing.Point(182, 357);
            this.lastNameP.Name = "lastNameP";
            this.lastNameP.Size = new System.Drawing.Size(13, 19);
            this.lastNameP.TabIndex = 8;
            this.lastNameP.Text = " ";
            this.lastNameP.Click += new System.EventHandler(this.label2_Click);
            // 
            // basicSalaryP
            // 
            this.basicSalaryP.AutoSize = true;
            this.basicSalaryP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.basicSalaryP.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicSalaryP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.basicSalaryP.Location = new System.Drawing.Point(183, 390);
            this.basicSalaryP.Name = "basicSalaryP";
            this.basicSalaryP.Size = new System.Drawing.Size(13, 19);
            this.basicSalaryP.TabIndex = 9;
            this.basicSalaryP.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(79, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(406, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(79, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(406, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Job Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(79, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rate Per Hour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(406, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Hours Worked:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(79, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(80, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(80, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Basic Salary:";
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basicSalaryP);
            this.Controls.Add(this.lastNameP);
            this.Controls.Add(this.firstNameP);
            this.Controls.Add(this.computeSalaryBtn);
            this.Controls.Add(this.totalHoursWork);
            this.Controls.Add(this.ratePerHour);
            this.Controls.Add(this.jobTitle);
            this.Controls.Add(this.department);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmComputeSalary";
            this.Text = "Employee Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox jobTitle;
        private System.Windows.Forms.TextBox ratePerHour;
        private System.Windows.Forms.TextBox totalHoursWork;
        private System.Windows.Forms.Button computeSalaryBtn;
        private System.Windows.Forms.Label firstNameP;
        private System.Windows.Forms.Label lastNameP;
        private System.Windows.Forms.Label basicSalaryP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

