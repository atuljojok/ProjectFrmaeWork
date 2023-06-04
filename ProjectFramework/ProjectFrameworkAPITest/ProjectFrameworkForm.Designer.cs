namespace ProjectFrameworkAPITest
{
    partial class ProjectFrameworkForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMainHeading = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAppName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxResponseData = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelAuthTokenValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Number = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxWeb = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxCoName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSet);
            this.groupBox1.Controls.Add(this.buttonGet);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMainHeading);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxAppName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(57, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 202);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure Settings Data";
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(705, 79);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(171, 31);
            this.buttonSet.TabIndex = 10;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_ClickAsync);
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(705, 30);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(171, 31);
            this.buttonGet.TabIndex = 10;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_ClickAsync);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(181, 124);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(501, 46);
            this.textBoxDescription.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description";
            // 
            // textBoxMainHeading
            // 
            this.textBoxMainHeading.Location = new System.Drawing.Point(181, 79);
            this.textBoxMainHeading.Name = "textBoxMainHeading";
            this.textBoxMainHeading.Size = new System.Drawing.Size(501, 22);
            this.textBoxMainHeading.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Main Heading";
            // 
            // textBoxAppName
            // 
            this.textBoxAppName.Location = new System.Drawing.Point(181, 34);
            this.textBoxAppName.Name = "textBoxAppName";
            this.textBoxAppName.Size = new System.Drawing.Size(501, 22);
            this.textBoxAppName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Application Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxResponseData);
            this.groupBox2.Location = new System.Drawing.Point(58, 742);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 134);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Response Data";
            // 
            // textBoxResponseData
            // 
            this.textBoxResponseData.Location = new System.Drawing.Point(6, 23);
            this.textBoxResponseData.Multiline = true;
            this.textBoxResponseData.Name = "textBoxResponseData";
            this.textBoxResponseData.Size = new System.Drawing.Size(893, 93);
            this.textBoxResponseData.TabIndex = 14;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(690, 882);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(266, 34);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelAuthTokenValue);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonLogin);
            this.groupBox3.Controls.Add(this.textBoxPassword);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxUserID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxURL);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(58, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(918, 148);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Authenticate User";
            // 
            // labelAuthTokenValue
            // 
            this.labelAuthTokenValue.Location = new System.Drawing.Point(109, 119);
            this.labelAuthTokenValue.Name = "labelAuthTokenValue";
            this.labelAuthTokenValue.Size = new System.Drawing.Size(570, 22);
            this.labelAuthTokenValue.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Auth Token";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(718, 69);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(171, 31);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_ClickAsync);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(459, 75);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(220, 22);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(109, 77);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(220, 22);
            this.textBoxUserID.TabIndex = 12;
            this.textBoxUserID.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "User ID";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(106, 32);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(779, 22);
            this.textBoxURL.TabIndex = 10;
            this.textBoxURL.Text = "https://localhost:44359/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Web URL";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.Number);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBoxNumber);
            this.groupBox4.Controls.Add(this.textBoxWeb);
            this.groupBox4.Controls.Add(this.textBoxAdress);
            this.groupBox4.Controls.Add(this.textBoxCoName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(64, 386);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(911, 350);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Settings";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(15, 225);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(110, 17);
            this.Number.TabIndex = 7;
            this.Number.Text = "Contact Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Web URL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Adress";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(145, 225);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(506, 22);
            this.textBoxNumber.TabIndex = 4;
            // 
            // textBoxWeb
            // 
            this.textBoxWeb.Location = new System.Drawing.Point(145, 167);
            this.textBoxWeb.Name = "textBoxWeb";
            this.textBoxWeb.Size = new System.Drawing.Size(506, 22);
            this.textBoxWeb.TabIndex = 3;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(145, 95);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(506, 37);
            this.textBoxAdress.TabIndex = 2;
            // 
            // textBoxCoName
            // 
            this.textBoxCoName.Location = new System.Drawing.Point(145, 44);
            this.textBoxCoName.Name = "textBoxCoName";
            this.textBoxCoName.Size = new System.Drawing.Size(506, 22);
            this.textBoxCoName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProjectFrameworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 928);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectFrameworkForm";
            this.Text = "Form API Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAppName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMainHeading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxResponseData;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelAuthTokenValue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxWeb;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxCoName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

