namespace MarketPlants
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            sellerPanel = new Panel();
            sellerSaveBut = new Button();
            label4 = new Label();
            sellerDeliveryTextBox = new TextBox();
            label1 = new Label();
            buyerPanel = new Panel();
            saveBuyerSettings = new Button();
            label19 = new Label();
            buyerPaymentInfoBox = new TextBox();
            label20 = new Label();
            UserChangePassword = new TextBox();
            label10 = new Label();
            editProfileButton = new Button();
            UserAddressBox = new TextBox();
            UserPhoneBox = new TextBox();
            UserSSNBox = new TextBox();
            UserEmailBox = new TextBox();
            UserUserName = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            button6 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            BuyerPaneli = new Panel();
            label2 = new Label();
            selliPaneli = new Panel();
            label11 = new Label();
            selliGridi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sellerPanel.SuspendLayout();
            buyerPanel.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            BuyerPaneli.SuspendLayout();
            selliPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selliGridi).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(801, 16);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 12;
            button5.Text = "LogOut";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Location = new Point(709, 16);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 11;
            button4.Text = "Profile";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(523, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 9;
            button2.Text = "Cart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(431, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 8;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 89);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // sellerPanel
            // 
            sellerPanel.BackColor = Color.Green;
            sellerPanel.Controls.Add(sellerSaveBut);
            sellerPanel.Controls.Add(label4);
            sellerPanel.Controls.Add(sellerDeliveryTextBox);
            sellerPanel.Controls.Add(label1);
            sellerPanel.Location = new Point(19, 127);
            sellerPanel.Name = "sellerPanel";
            sellerPanel.Size = new Size(405, 162);
            sellerPanel.TabIndex = 26;
            // 
            // sellerSaveBut
            // 
            sellerSaveBut.ForeColor = SystemColors.ActiveCaptionText;
            sellerSaveBut.Location = new Point(159, 120);
            sellerSaveBut.Margin = new Padding(3, 4, 3, 4);
            sellerSaveBut.Name = "sellerSaveBut";
            sellerSaveBut.Size = new Size(86, 31);
            sellerSaveBut.TabIndex = 23;
            sellerSaveBut.Text = "Save";
            sellerSaveBut.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 56);
            label4.Name = "label4";
            label4.Size = new Size(229, 23);
            label4.TabIndex = 6;
            label4.Text = "Delivery/Pickup Information*";
            // 
            // sellerDeliveryTextBox
            // 
            sellerDeliveryTextBox.Location = new Point(6, 85);
            sellerDeliveryTextBox.Margin = new Padding(3, 4, 3, 4);
            sellerDeliveryTextBox.Name = "sellerDeliveryTextBox";
            sellerDeliveryTextBox.Size = new Size(393, 27);
            sellerDeliveryTextBox.TabIndex = 5;
            sellerDeliveryTextBox.TextChanged += sellerDeliveryTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 17);
            label1.Name = "label1";
            label1.Size = new Size(254, 28);
            label1.TabIndex = 0;
            label1.Text = "Your Seller Profile Settings";
            // 
            // buyerPanel
            // 
            buyerPanel.BackColor = Color.Green;
            buyerPanel.Controls.Add(saveBuyerSettings);
            buyerPanel.Controls.Add(label19);
            buyerPanel.Controls.Add(buyerPaymentInfoBox);
            buyerPanel.Controls.Add(label20);
            buyerPanel.Location = new Point(19, 127);
            buyerPanel.Name = "buyerPanel";
            buyerPanel.Size = new Size(405, 159);
            buyerPanel.TabIndex = 37;
            // 
            // saveBuyerSettings
            // 
            saveBuyerSettings.ForeColor = SystemColors.ActiveCaptionText;
            saveBuyerSettings.Location = new Point(149, 120);
            saveBuyerSettings.Margin = new Padding(3, 4, 3, 4);
            saveBuyerSettings.Name = "saveBuyerSettings";
            saveBuyerSettings.Size = new Size(86, 31);
            saveBuyerSettings.TabIndex = 22;
            saveBuyerSettings.Text = "Save";
            saveBuyerSettings.UseVisualStyleBackColor = true;
            saveBuyerSettings.Click += saveBuyerSettings_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(6, 56);
            label19.Name = "label19";
            label19.Size = new Size(178, 23);
            label19.TabIndex = 6;
            label19.Text = "Payment Information*";
            // 
            // buyerPaymentInfoBox
            // 
            buyerPaymentInfoBox.Location = new Point(6, 85);
            buyerPaymentInfoBox.Margin = new Padding(3, 4, 3, 4);
            buyerPaymentInfoBox.Name = "buyerPaymentInfoBox";
            buyerPaymentInfoBox.Size = new Size(393, 27);
            buyerPaymentInfoBox.TabIndex = 5;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(74, 17);
            label20.Name = "label20";
            label20.Size = new Size(256, 28);
            label20.TabIndex = 0;
            label20.Text = "Your Buyer Profile Settings";
            // 
            // UserChangePassword
            // 
            UserChangePassword.Location = new Point(177, 210);
            UserChangePassword.Margin = new Padding(3, 4, 3, 4);
            UserChangePassword.Name = "UserChangePassword";
            UserChangePassword.Size = new Size(207, 27);
            UserChangePassword.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(26, 211);
            label10.Name = "label10";
            label10.Size = new Size(148, 23);
            label10.TabIndex = 35;
            label10.Text = "Change Password:";
            // 
            // editProfileButton
            // 
            editProfileButton.ForeColor = SystemColors.ActiveCaptionText;
            editProfileButton.Location = new Point(149, 392);
            editProfileButton.Margin = new Padding(3, 4, 3, 4);
            editProfileButton.Name = "editProfileButton";
            editProfileButton.Size = new Size(86, 31);
            editProfileButton.TabIndex = 34;
            editProfileButton.Text = "Edit";
            editProfileButton.UseVisualStyleBackColor = true;
            editProfileButton.Click += editProfileButton_Click;
            // 
            // UserAddressBox
            // 
            UserAddressBox.Location = new Point(136, 354);
            UserAddressBox.Margin = new Padding(3, 4, 3, 4);
            UserAddressBox.Name = "UserAddressBox";
            UserAddressBox.Size = new Size(248, 27);
            UserAddressBox.TabIndex = 33;
            // 
            // UserPhoneBox
            // 
            UserPhoneBox.Location = new Point(202, 319);
            UserPhoneBox.Margin = new Padding(3, 4, 3, 4);
            UserPhoneBox.Name = "UserPhoneBox";
            UserPhoneBox.Size = new Size(182, 27);
            UserPhoneBox.TabIndex = 32;
            // 
            // UserSSNBox
            // 
            UserSSNBox.Location = new Point(116, 284);
            UserSSNBox.Margin = new Padding(3, 4, 3, 4);
            UserSSNBox.Name = "UserSSNBox";
            UserSSNBox.Size = new Size(268, 27);
            UserSSNBox.TabIndex = 31;
            // 
            // UserEmailBox
            // 
            UserEmailBox.Location = new Point(126, 245);
            UserEmailBox.Margin = new Padding(3, 4, 3, 4);
            UserEmailBox.Name = "UserEmailBox";
            UserEmailBox.Size = new Size(258, 27);
            UserEmailBox.TabIndex = 30;
            // 
            // UserUserName
            // 
            UserUserName.AutoSize = true;
            UserUserName.Location = new Point(177, 186);
            UserUserName.Name = "UserUserName";
            UserUserName.Size = new Size(58, 20);
            UserUserName.TabIndex = 29;
            UserUserName.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(26, 354);
            label9.Name = "label9";
            label9.Size = new Size(113, 23);
            label9.TabIndex = 28;
            label9.Text = "Your Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(26, 320);
            label8.Name = "label8";
            label8.Size = new Size(170, 23);
            label8.TabIndex = 27;
            label8.Text = "Your Phone Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 285);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 26;
            label7.Text = "Your SSN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 246);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 25;
            label6.Text = "Your Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 183);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 24;
            label5.Text = "Your Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 155);
            label3.Name = "label3";
            label3.Size = new Size(167, 28);
            label3.TabIndex = 23;
            label3.Text = "Your Information";
            label3.Click += label3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(338, 16);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 28;
            button6.Text = "Add Plant";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Green;
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(UserUserName);
            groupBox3.Controls.Add(UserSSNBox);
            groupBox3.Controls.Add(UserEmailBox);
            groupBox3.Controls.Add(UserAddressBox);
            groupBox3.Controls.Add(UserPhoneBox);
            groupBox3.Controls.Add(UserChangePassword);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(editProfileButton);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.ForeColor = Color.Yellow;
            groupBox3.Location = new Point(19, 127);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(405, 431);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Green;
            groupBox2.Controls.Add(BuyerPaneli);
            groupBox2.ForeColor = Color.Yellow;
            groupBox2.Location = new Point(496, 127);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(405, 431);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // BuyerPaneli
            // 
            BuyerPaneli.Controls.Add(label2);
            BuyerPaneli.Location = new Point(6, 0);
            BuyerPaneli.Name = "BuyerPaneli";
            BuyerPaneli.Size = new Size(399, 431);
            BuyerPaneli.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(45, 50);
            label2.Name = "label2";
            label2.Size = new Size(329, 373);
            label2.TabIndex = 0;
            label2.Text = "MarketPlants thank you for your belief in us!";
            // 
            // selliPaneli
            // 
            selliPaneli.BackColor = Color.Green;
            selliPaneli.Controls.Add(selliGridi);
            selliPaneli.Controls.Add(label11);
            selliPaneli.Location = new Point(502, 127);
            selliPaneli.Name = "selliPaneli";
            selliPaneli.Size = new Size(396, 431);
            selliPaneli.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(21, 17);
            label11.Name = "label11";
            label11.Size = new Size(351, 38);
            label11.TabIndex = 0;
            label11.Text = "Plants that you are selling:";
            // 
            // selliGridi
            // 
            selliGridi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selliGridi.Location = new Point(3, 58);
            selliGridi.Name = "selliGridi";
            selliGridi.RowHeadersWidth = 51;
            selliGridi.RowTemplate.Height = 29;
            selliGridi.Size = new Size(390, 370);
            selliGridi.TabIndex = 1;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(selliPaneli);
            Controls.Add(buyerPanel);
            Controls.Add(sellerPanel);
            Controls.Add(groupBox3);
            Controls.Add(button6);
            Controls.Add(groupBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sellerPanel.ResumeLayout(false);
            sellerPanel.PerformLayout();
            buyerPanel.ResumeLayout(false);
            buyerPanel.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            BuyerPaneli.ResumeLayout(false);
            selliPaneli.ResumeLayout(false);
            selliPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selliGridi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button button6;
        private Panel sellerPanel;
        private Label label1;
        private Label label4;
        private TextBox sellerDeliveryTextBox;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox UserEmailBox;
        private Label UserUserName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox UserAddressBox;
        private TextBox UserPhoneBox;
        private TextBox UserSSNBox;
        private TextBox UserChangePassword;
        private Label label10;
        private Button editProfileButton;
        private Panel buyerPanel;
        private Button saveBuyerSettings;
        private Label label19;
        private TextBox buyerPaymentInfoBox;
        private Label label20;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button sellerSaveBut;
        private Panel BuyerPaneli;
        private Label label2;
        private Panel selliPaneli;
        private Label label11;
        private DataGridView selliGridi;
    }
}