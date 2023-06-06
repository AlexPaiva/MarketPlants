namespace MarketPlants
{
    partial class EntryPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPoint));
            label2 = new Label();
            usernameTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            groupBox2 = new GroupBox();
            Logo = new PictureBox();
            groupBox1 = new GroupBox();
            WelcomePanel = new Panel();
            WelcomeRegisterButton = new Button();
            WelcomeLabel = new Label();
            CompanyPanel = new Panel();
            CompanyBackBtn = new Button();
            CompanyRegisterBtn = new Button();
            CompanySSNInput = new TextBox();
            label12 = new Label();
            CompanyPasswordInput = new TextBox();
            label11 = new Label();
            CompanyUsernameInput = new TextBox();
            label10 = new Label();
            CompanyEmailInput = new TextBox();
            label9 = new Label();
            CompanyNameInput = new TextBox();
            label8 = new Label();
            CompanyAddressInput = new TextBox();
            label7 = new Label();
            CompanyPhoneInput = new TextBox();
            CompanyDescriptionInput = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            button1 = new Button();
            ButtonRegisterIndividual = new Button();
            PeopleInputSSN = new TextBox();
            label13 = new Label();
            PeopleInputPassword = new TextBox();
            label14 = new Label();
            PeopleInputUsername = new TextBox();
            label15 = new Label();
            PeopleInputEmail = new TextBox();
            label16 = new Label();
            PeopleInputName = new TextBox();
            label17 = new Label();
            PeopleInputAddress = new TextBox();
            label18 = new Label();
            PeopleInputPhone = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            groupBox1.SuspendLayout();
            WelcomePanel.SuspendLayout();
            CompanyPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 97);
            label2.Name = "label2";
            label2.Size = new Size(77, 35);
            label2.TabIndex = 1;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(26, 193);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(195, 27);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 164);
            label4.Name = "label4";
            label4.Size = new Size(145, 23);
            label4.TabIndex = 4;
            label4.Text = "Username / email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 240);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(26, 269);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(195, 27);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(26, 348);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(86, 31);
            loginButton.TabIndex = 21;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Green;
            groupBox2.ForeColor = Color.Yellow;
            groupBox2.Location = new Point(16, 77);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(223, 357);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // Logo
            // 
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Location = new Point(16, -4);
            Logo.Margin = new Padding(3, 4, 3, 4);
            Logo.Name = "Logo";
            Logo.Size = new Size(248, 73);
            Logo.TabIndex = 25;
            Logo.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Green;
            groupBox1.Controls.Add(WelcomePanel);
            groupBox1.ForeColor = Color.Yellow;
            groupBox1.Location = new Point(257, 77);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(519, 357);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // WelcomePanel
            // 
            WelcomePanel.Controls.Add(WelcomeRegisterButton);
            WelcomePanel.Controls.Add(WelcomeLabel);
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(519, 357);
            WelcomePanel.TabIndex = 27;
            // 
            // WelcomeRegisterButton
            // 
            WelcomeRegisterButton.BackColor = SystemColors.ButtonFace;
            WelcomeRegisterButton.ForeColor = SystemColors.ActiveCaptionText;
            WelcomeRegisterButton.Location = new Point(205, 163);
            WelcomeRegisterButton.Name = "WelcomeRegisterButton";
            WelcomeRegisterButton.Size = new Size(94, 29);
            WelcomeRegisterButton.TabIndex = 1;
            WelcomeRegisterButton.Text = "Register";
            WelcomeRegisterButton.UseVisualStyleBackColor = false;
            WelcomeRegisterButton.Click += WelcomeRegisterButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Location = new Point(80, 105);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(364, 20);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome! Don't have an account yet? Register below!";
            WelcomeLabel.Click += label1_Click_1;
            // 
            // CompanyPanel
            // 
            CompanyPanel.BackColor = Color.Green;
            CompanyPanel.Controls.Add(CompanyBackBtn);
            CompanyPanel.Controls.Add(CompanyRegisterBtn);
            CompanyPanel.Controls.Add(CompanySSNInput);
            CompanyPanel.Controls.Add(label12);
            CompanyPanel.Controls.Add(CompanyPasswordInput);
            CompanyPanel.Controls.Add(label11);
            CompanyPanel.Controls.Add(CompanyUsernameInput);
            CompanyPanel.Controls.Add(label10);
            CompanyPanel.Controls.Add(CompanyEmailInput);
            CompanyPanel.Controls.Add(label9);
            CompanyPanel.Controls.Add(CompanyNameInput);
            CompanyPanel.Controls.Add(label8);
            CompanyPanel.Controls.Add(CompanyAddressInput);
            CompanyPanel.Controls.Add(label7);
            CompanyPanel.Controls.Add(CompanyPhoneInput);
            CompanyPanel.Controls.Add(CompanyDescriptionInput);
            CompanyPanel.Controls.Add(label6);
            CompanyPanel.Controls.Add(label3);
            CompanyPanel.Controls.Add(label1);
            CompanyPanel.Location = new Point(257, 77);
            CompanyPanel.Name = "CompanyPanel";
            CompanyPanel.Size = new Size(522, 363);
            CompanyPanel.TabIndex = 29;
            CompanyPanel.Paint += CompanyPanel_Paint;
            // 
            // CompanyBackBtn
            // 
            CompanyBackBtn.Location = new Point(15, 10);
            CompanyBackBtn.Margin = new Padding(3, 4, 3, 4);
            CompanyBackBtn.Name = "CompanyBackBtn";
            CompanyBackBtn.Size = new Size(48, 32);
            CompanyBackBtn.TabIndex = 23;
            CompanyBackBtn.Text = "Back";
            CompanyBackBtn.UseVisualStyleBackColor = true;
            CompanyBackBtn.Click += CompanyBackBtn_Click;
            // 
            // CompanyRegisterBtn
            // 
            CompanyRegisterBtn.Location = new Point(408, 10);
            CompanyRegisterBtn.Margin = new Padding(3, 4, 3, 4);
            CompanyRegisterBtn.Name = "CompanyRegisterBtn";
            CompanyRegisterBtn.Size = new Size(102, 38);
            CompanyRegisterBtn.TabIndex = 22;
            CompanyRegisterBtn.Text = "Register";
            CompanyRegisterBtn.UseVisualStyleBackColor = true;
            CompanyRegisterBtn.Click += CompanyRegisterBtn_Click;
            // 
            // CompanySSNInput
            // 
            CompanySSNInput.Location = new Point(249, 89);
            CompanySSNInput.Margin = new Padding(3, 4, 3, 4);
            CompanySSNInput.Name = "CompanySSNInput";
            CompanySSNInput.Size = new Size(195, 27);
            CompanySSNInput.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(249, 59);
            label12.Name = "label12";
            label12.Size = new Size(194, 23);
            label12.TabIndex = 20;
            label12.Text = "Social Security Number*";
            // 
            // CompanyPasswordInput
            // 
            CompanyPasswordInput.Location = new Point(249, 311);
            CompanyPasswordInput.Margin = new Padding(3, 4, 3, 4);
            CompanyPasswordInput.Name = "CompanyPasswordInput";
            CompanyPasswordInput.Size = new Size(195, 27);
            CompanyPasswordInput.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(249, 275);
            label11.Name = "label11";
            label11.Size = new Size(87, 23);
            label11.TabIndex = 18;
            label11.Text = "Password*";
            // 
            // CompanyUsernameInput
            // 
            CompanyUsernameInput.Location = new Point(15, 311);
            CompanyUsernameInput.Margin = new Padding(3, 4, 3, 4);
            CompanyUsernameInput.Name = "CompanyUsernameInput";
            CompanyUsernameInput.Size = new Size(195, 27);
            CompanyUsernameInput.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 275);
            label10.Name = "label10";
            label10.Size = new Size(94, 23);
            label10.TabIndex = 16;
            label10.Text = "Username*";
            // 
            // CompanyEmailInput
            // 
            CompanyEmailInput.Location = new Point(249, 234);
            CompanyEmailInput.Margin = new Padding(3, 4, 3, 4);
            CompanyEmailInput.Name = "CompanyEmailInput";
            CompanyEmailInput.Size = new Size(195, 27);
            CompanyEmailInput.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(249, 197);
            label9.Name = "label9";
            label9.Size = new Size(58, 23);
            label9.TabIndex = 14;
            label9.Text = "Email*";
            // 
            // CompanyNameInput
            // 
            CompanyNameInput.Location = new Point(15, 234);
            CompanyNameInput.Margin = new Padding(3, 4, 3, 4);
            CompanyNameInput.Name = "CompanyNameInput";
            CompanyNameInput.Size = new Size(195, 27);
            CompanyNameInput.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 197);
            label8.Name = "label8";
            label8.Size = new Size(63, 23);
            label8.TabIndex = 12;
            label8.Text = "Name*";
            // 
            // CompanyAddressInput
            // 
            CompanyAddressInput.Location = new Point(249, 160);
            CompanyAddressInput.Margin = new Padding(3, 4, 3, 4);
            CompanyAddressInput.Name = "CompanyAddressInput";
            CompanyAddressInput.Size = new Size(195, 27);
            CompanyAddressInput.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(249, 126);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 10;
            label7.Text = "Address*";
            label7.Click += label7_Click;
            // 
            // CompanyPhoneInput
            // 
            CompanyPhoneInput.Location = new Point(15, 160);
            CompanyPhoneInput.Margin = new Padding(3, 4, 3, 4);
            CompanyPhoneInput.Name = "CompanyPhoneInput";
            CompanyPhoneInput.Size = new Size(195, 27);
            CompanyPhoneInput.TabIndex = 9;
            // 
            // CompanyDescriptionInput
            // 
            CompanyDescriptionInput.Location = new Point(15, 88);
            CompanyDescriptionInput.Margin = new Padding(3, 4, 3, 4);
            CompanyDescriptionInput.Name = "CompanyDescriptionInput";
            CompanyDescriptionInput.Size = new Size(195, 27);
            CompanyDescriptionInput.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 126);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 7;
            label6.Text = "Phone Number*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 59);
            label3.Name = "label3";
            label3.Size = new Size(181, 23);
            label3.TabIndex = 5;
            label3.Text = "Company Description*";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 10);
            label1.Name = "label1";
            label1.Size = new Size(310, 35);
            label1.TabIndex = 2;
            label1.Text = "Registering as a Company!";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(radioButtonFemale);
            panel1.Controls.Add(radioButtonMale);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ButtonRegisterIndividual);
            panel1.Controls.Add(PeopleInputSSN);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(PeopleInputPassword);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(PeopleInputUsername);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(PeopleInputEmail);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(PeopleInputName);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(PeopleInputAddress);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(PeopleInputPhone);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Location = new Point(254, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 363);
            panel1.TabIndex = 30;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.ForeColor = SystemColors.ButtonFace;
            radioButtonFemale.Location = new Point(84, 88);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 25;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.ForeColor = SystemColors.ButtonFace;
            radioButtonMale.Location = new Point(15, 89);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 24;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(15, 10);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(48, 32);
            button1.TabIndex = 23;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ButtonRegisterIndividual
            // 
            ButtonRegisterIndividual.Location = new Point(408, 10);
            ButtonRegisterIndividual.Margin = new Padding(3, 4, 3, 4);
            ButtonRegisterIndividual.Name = "ButtonRegisterIndividual";
            ButtonRegisterIndividual.Size = new Size(102, 38);
            ButtonRegisterIndividual.TabIndex = 22;
            ButtonRegisterIndividual.Text = "Register";
            ButtonRegisterIndividual.UseVisualStyleBackColor = true;
            ButtonRegisterIndividual.Click += ButtonRegisterIndividual_Click;
            // 
            // PeopleInputSSN
            // 
            PeopleInputSSN.Location = new Point(249, 89);
            PeopleInputSSN.Margin = new Padding(3, 4, 3, 4);
            PeopleInputSSN.Name = "PeopleInputSSN";
            PeopleInputSSN.Size = new Size(195, 27);
            PeopleInputSSN.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(249, 59);
            label13.Name = "label13";
            label13.Size = new Size(194, 23);
            label13.TabIndex = 20;
            label13.Text = "Social Security Number*";
            // 
            // PeopleInputPassword
            // 
            PeopleInputPassword.Location = new Point(249, 311);
            PeopleInputPassword.Margin = new Padding(3, 4, 3, 4);
            PeopleInputPassword.Name = "PeopleInputPassword";
            PeopleInputPassword.Size = new Size(195, 27);
            PeopleInputPassword.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Control;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(249, 275);
            label14.Name = "label14";
            label14.Size = new Size(87, 23);
            label14.TabIndex = 18;
            label14.Text = "Password*";
            // 
            // PeopleInputUsername
            // 
            PeopleInputUsername.Location = new Point(15, 311);
            PeopleInputUsername.Margin = new Padding(3, 4, 3, 4);
            PeopleInputUsername.Name = "PeopleInputUsername";
            PeopleInputUsername.Size = new Size(195, 27);
            PeopleInputUsername.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.Control;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(15, 275);
            label15.Name = "label15";
            label15.Size = new Size(94, 23);
            label15.TabIndex = 16;
            label15.Text = "Username*";
            // 
            // PeopleInputEmail
            // 
            PeopleInputEmail.Location = new Point(249, 234);
            PeopleInputEmail.Margin = new Padding(3, 4, 3, 4);
            PeopleInputEmail.Name = "PeopleInputEmail";
            PeopleInputEmail.Size = new Size(195, 27);
            PeopleInputEmail.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.Control;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(249, 197);
            label16.Name = "label16";
            label16.Size = new Size(58, 23);
            label16.TabIndex = 14;
            label16.Text = "Email*";
            // 
            // PeopleInputName
            // 
            PeopleInputName.Location = new Point(15, 234);
            PeopleInputName.Margin = new Padding(3, 4, 3, 4);
            PeopleInputName.Name = "PeopleInputName";
            PeopleInputName.Size = new Size(195, 27);
            PeopleInputName.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.Control;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(15, 197);
            label17.Name = "label17";
            label17.Size = new Size(168, 23);
            label17.TabIndex = 12;
            label17.Text = "First and Last Name*";
            // 
            // PeopleInputAddress
            // 
            PeopleInputAddress.Location = new Point(249, 160);
            PeopleInputAddress.Margin = new Padding(3, 4, 3, 4);
            PeopleInputAddress.Name = "PeopleInputAddress";
            PeopleInputAddress.Size = new Size(195, 27);
            PeopleInputAddress.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.Control;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(249, 126);
            label18.Name = "label18";
            label18.Size = new Size(77, 23);
            label18.TabIndex = 10;
            label18.Text = "Address*";
            // 
            // PeopleInputPhone
            // 
            PeopleInputPhone.Location = new Point(15, 160);
            PeopleInputPhone.Margin = new Padding(3, 4, 3, 4);
            PeopleInputPhone.Name = "PeopleInputPhone";
            PeopleInputPhone.Size = new Size(195, 27);
            PeopleInputPhone.TabIndex = 9;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.Control;
            label19.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(15, 126);
            label19.Name = "label19";
            label19.Size = new Size(134, 23);
            label19.TabIndex = 7;
            label19.Text = "Phone Number*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = SystemColors.Control;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(15, 59);
            label20.Name = "label20";
            label20.Size = new Size(73, 23);
            label20.TabIndex = 5;
            label20.Text = "Gender*";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.Control;
            label21.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(77, 10);
            label21.Name = "label21";
            label21.Size = new Size(326, 35);
            label21.TabIndex = 2;
            label21.Text = "Registering as an Individual!";
            label21.Click += label21_Click;
            // 
            // EntryPoint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel1);
            Controls.Add(CompanyPanel);
            Controls.Add(Logo);
            Controls.Add(loginButton);
            Controls.Add(label5);
            Controls.Add(passwordTextBox);
            Controls.Add(label4);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "EntryPoint";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            groupBox1.ResumeLayout(false);
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            CompanyPanel.ResumeLayout(false);
            CompanyPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox usernameTextBox;
        private Label label4;
        private Label label5;
        private TextBox passwordTextBox;
        private Button loginButton;
        private GroupBox groupBox2;
        private PictureBox Logo;
        private GroupBox groupBox1;
        private Panel WelcomePanel;
        private Label WelcomeLabel;
        private Button WelcomeRegisterButton;
        private Panel CompanyPanel;
        private Panel panel1;
        private Button button1;
        private Button ButtonRegisterIndividual;
        private TextBox PeopleInputSSN;
        private Label label13;
        private TextBox PeopleInputPassword;
        private Label label14;
        private TextBox PeopleInputUsername;
        private Label label15;
        private TextBox PeopleInputEmail;
        private Label label16;
        private TextBox PeopleInputName;
        private Label label17;
        private TextBox PeopleInputAddress;
        private Label label18;
        private TextBox PeopleInputPhone;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button CompanyBackBtn;
        private Button CompanyRegisterBtn;
        private TextBox CompanySSNInput;
        private Label label12;
        private TextBox CompanyPasswordInput;
        private Label label11;
        private TextBox CompanyUsernameInput;
        private Label label10;
        private TextBox CompanyEmailInput;
        private Label label9;
        private TextBox CompanyNameInput;
        private Label label8;
        private TextBox CompanyAddressInput;
        private Label label7;
        private TextBox CompanyPhoneInput;
        private TextBox CompanyDescriptionInput;
        private Label label6;
        private Label label3;
        private Label label1;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
    }
}