namespace MarketPlants
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            welcomeLabel = new Label();
            groupBox1 = new GroupBox();
            detailButt = new Button();
            searchButton = new Button();
            plantDetailsProc = new Label();
            fruitCheckBox = new CheckBox();
            label1 = new Label();
            searchTextBox = new TextBox();
            flowerCheckBox = new CheckBox();
            btnAddToCart = new Button();
            groupBox2 = new GroupBox();
            flowerPanel = new Panel();
            buttonGoBack = new Button();
            flowChracteristic = new Label();
            flowerSciFamily = new Label();
            flowerCommomName = new Label();
            fruitChracteristics = new Label();
            fruitScientificName = new Label();
            fruitCName = new Label();
            plantChracteristics = new Label();
            plantEnvironment = new Label();
            label12 = new Label();
            plantKingdom = new Label();
            plantScienName = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            flowerScientific = new Label();
            listaPlantas = new DataGridView();
            button6 = new Button();
            usernameHello = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaPlantas).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(799, 13);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 18;
            button5.Text = "LogOut";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(707, 13);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 17;
            button4.Text = "Profile";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(521, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 15;
            button2.Text = "Cart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(429, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 14;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 89);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(15, 12);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(526, 28);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "View Below our Total Plant Selection available for Purchase!";
            welcomeLabel.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Green;
            groupBox1.Controls.Add(detailButt);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(plantDetailsProc);
            groupBox1.Controls.Add(fruitCheckBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(searchTextBox);
            groupBox1.Controls.Add(flowerCheckBox);
            groupBox1.ForeColor = Color.Yellow;
            groupBox1.Location = new Point(11, 111);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(286, 324);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // detailButt
            // 
            detailButt.BackColor = Color.OliveDrab;
            detailButt.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            detailButt.ForeColor = Color.FloralWhite;
            detailButt.Location = new Point(7, 126);
            detailButt.Name = "detailButt";
            detailButt.Size = new Size(261, 32);
            detailButt.TabIndex = 26;
            detailButt.Text = "View Selected Plant Details";
            detailButt.UseVisualStyleBackColor = false;
            detailButt.Click += detailButt_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.OliveDrab;
            searchButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            searchButton.ForeColor = Color.FloralWhite;
            searchButton.Location = new Point(144, 71);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(111, 43);
            searchButton.TabIndex = 25;
            searchButton.Text = "Search!";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // plantDetailsProc
            // 
            plantDetailsProc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            plantDetailsProc.ForeColor = Color.LemonChiffon;
            plantDetailsProc.Location = new Point(7, 161);
            plantDetailsProc.Name = "plantDetailsProc";
            plantDetailsProc.Size = new Size(261, 155);
            plantDetailsProc.TabIndex = 23;
            plantDetailsProc.Text = "No Plant Selected!\r\n\r\nSelect a plant from our vast list of plants by pressing the left button on each row!";
            plantDetailsProc.Click += plantDetailsProc_Click;
            // 
            // fruitCheckBox
            // 
            fruitCheckBox.AutoSize = true;
            fruitCheckBox.ForeColor = Color.White;
            fruitCheckBox.Location = new Point(7, 103);
            fruitCheckBox.Margin = new Padding(3, 4, 3, 4);
            fruitCheckBox.Name = "fruitCheckBox";
            fruitCheckBox.Size = new Size(95, 24);
            fruitCheckBox.TabIndex = 22;
            fruitCheckBox.Text = "With Fruit";
            fruitCheckBox.UseVisualStyleBackColor = true;
            fruitCheckBox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 12);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 20;
            label1.Text = "Looking for something Specific?";
            label1.Click += label1_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(6, 36);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(274, 27);
            searchTextBox.TabIndex = 19;
            // 
            // flowerCheckBox
            // 
            flowerCheckBox.AutoSize = true;
            flowerCheckBox.ForeColor = Color.White;
            flowerCheckBox.Location = new Point(7, 71);
            flowerCheckBox.Margin = new Padding(3, 4, 3, 4);
            flowerCheckBox.Name = "flowerCheckBox";
            flowerCheckBox.Size = new Size(108, 24);
            flowerCheckBox.TabIndex = 21;
            flowerCheckBox.Text = "With flower";
            flowerCheckBox.UseVisualStyleBackColor = true;
            flowerCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnAddToCart
            // 
            btnAddToCart.ForeColor = Color.DarkSlateGray;
            btnAddToCart.Location = new Point(443, 274);
            btnAddToCart.Margin = new Padding(3, 4, 3, 4);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(98, 31);
            btnAddToCart.TabIndex = 24;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Visible = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Green;
            groupBox2.Controls.Add(flowerPanel);
            groupBox2.Controls.Add(listaPlantas);
            groupBox2.Controls.Add(welcomeLabel);
            groupBox2.ForeColor = Color.Yellow;
            groupBox2.Location = new Point(321, 111);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(563, 324);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            // 
            // flowerPanel
            // 
            flowerPanel.Controls.Add(buttonGoBack);
            flowerPanel.Controls.Add(flowChracteristic);
            flowerPanel.Controls.Add(btnAddToCart);
            flowerPanel.Controls.Add(flowerSciFamily);
            flowerPanel.Controls.Add(flowerCommomName);
            flowerPanel.Controls.Add(fruitChracteristics);
            flowerPanel.Controls.Add(fruitScientificName);
            flowerPanel.Controls.Add(fruitCName);
            flowerPanel.Controls.Add(plantChracteristics);
            flowerPanel.Controls.Add(plantEnvironment);
            flowerPanel.Controls.Add(label12);
            flowerPanel.Controls.Add(plantKingdom);
            flowerPanel.Controls.Add(plantScienName);
            flowerPanel.Controls.Add(label11);
            flowerPanel.Controls.Add(label10);
            flowerPanel.Controls.Add(label9);
            flowerPanel.Controls.Add(label8);
            flowerPanel.Controls.Add(label7);
            flowerPanel.Controls.Add(label6);
            flowerPanel.Controls.Add(label5);
            flowerPanel.Controls.Add(label4);
            flowerPanel.Controls.Add(label3);
            flowerPanel.Controls.Add(label2);
            flowerPanel.Controls.Add(flowerScientific);
            flowerPanel.Location = new Point(0, 2);
            flowerPanel.Name = "flowerPanel";
            flowerPanel.Size = new Size(562, 322);
            flowerPanel.TabIndex = 2;
            // 
            // buttonGoBack
            // 
            buttonGoBack.ForeColor = Color.DarkSlateGray;
            buttonGoBack.Location = new Point(339, 274);
            buttonGoBack.Margin = new Padding(3, 4, 3, 4);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(98, 31);
            buttonGoBack.TabIndex = 25;
            buttonGoBack.Text = "Go Back";
            buttonGoBack.UseVisualStyleBackColor = true;
            buttonGoBack.Visible = false;
            buttonGoBack.Click += button3_Click;
            // 
            // flowChracteristic
            // 
            flowChracteristic.Location = new Point(329, 144);
            flowChracteristic.Name = "flowChracteristic";
            flowChracteristic.Size = new Size(228, 82);
            flowChracteristic.TabIndex = 21;
            flowChracteristic.Text = "Family:";
            // 
            // flowerSciFamily
            // 
            flowerSciFamily.Location = new Point(329, 92);
            flowerSciFamily.Name = "flowerSciFamily";
            flowerSciFamily.Size = new Size(228, 20);
            flowerSciFamily.TabIndex = 20;
            flowerSciFamily.Text = "Family:";
            // 
            // flowerCommomName
            // 
            flowerCommomName.Location = new Point(329, 37);
            flowerCommomName.Name = "flowerCommomName";
            flowerCommomName.Size = new Size(228, 20);
            flowerCommomName.TabIndex = 19;
            flowerCommomName.Text = "Family:";
            // 
            // fruitChracteristics
            // 
            fruitChracteristics.Location = new Point(152, 258);
            fruitChracteristics.Name = "fruitChracteristics";
            fruitChracteristics.Size = new Size(182, 20);
            fruitChracteristics.TabIndex = 18;
            fruitChracteristics.Text = "Family:";
            // 
            // fruitScientificName
            // 
            fruitScientificName.Location = new Point(162, 229);
            fruitScientificName.Name = "fruitScientificName";
            fruitScientificName.Size = new Size(172, 20);
            fruitScientificName.TabIndex = 17;
            fruitScientificName.Text = "Family:";
            // 
            // fruitCName
            // 
            fruitCName.Location = new Point(162, 200);
            fruitCName.Name = "fruitCName";
            fruitCName.Size = new Size(172, 20);
            fruitCName.TabIndex = 16;
            fruitCName.Text = "Family:";
            // 
            // plantChracteristics
            // 
            plantChracteristics.Location = new Point(128, 130);
            plantChracteristics.Name = "plantChracteristics";
            plantChracteristics.Size = new Size(206, 70);
            plantChracteristics.TabIndex = 15;
            plantChracteristics.Text = "Family:";
            // 
            // plantEnvironment
            // 
            plantEnvironment.Location = new Point(108, 101);
            plantEnvironment.Name = "plantEnvironment";
            plantEnvironment.Size = new Size(226, 20);
            plantEnvironment.TabIndex = 14;
            plantEnvironment.Text = "Family:";
            // 
            // label12
            // 
            label12.Location = new Point(69, 69);
            label12.Name = "label12";
            label12.Size = new Size(265, 20);
            label12.TabIndex = 13;
            label12.Text = "Family:";
            // 
            // plantKingdom
            // 
            plantKingdom.Location = new Point(87, 37);
            plantKingdom.Name = "plantKingdom";
            plantKingdom.Size = new Size(247, 20);
            plantKingdom.TabIndex = 12;
            plantKingdom.Text = "Kingdom:";
            // 
            // plantScienName
            // 
            plantScienName.Location = new Point(128, 10);
            plantScienName.Name = "plantScienName";
            plantScienName.Size = new Size(206, 20);
            plantScienName.TabIndex = 11;
            plantScienName.Text = "Scientific Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(366, 124);
            label11.Name = "label11";
            label11.Size = new Size(155, 20);
            label11.TabIndex = 10;
            label11.Text = "Flower Characteristics:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(358, 69);
            label10.Name = "label10";
            label10.Size = new Size(164, 20);
            label10.TabIndex = 9;
            label10.Text = "Flower Scientific Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(357, 10);
            label9.Name = "label9";
            label9.Size = new Size(165, 20);
            label9.TabIndex = 8;
            label9.Text = "Flower Common Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 229);
            label8.Name = "label8";
            label8.Size = new Size(149, 20);
            label8.TabIndex = 7;
            label8.Text = "Fruit Scientific Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 258);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 6;
            label7.Text = "Fruit Characteristics:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 200);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 5;
            label6.Text = "Fruit Common Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 130);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 4;
            label5.Text = "Characteristics:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 101);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Environment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 69);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Family:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 38);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Kingdom:";
            // 
            // flowerScientific
            // 
            flowerScientific.AutoSize = true;
            flowerScientific.Location = new Point(15, 10);
            flowerScientific.Name = "flowerScientific";
            flowerScientific.Size = new Size(116, 20);
            flowerScientific.TabIndex = 0;
            flowerScientific.Text = "Scientific Name:";
            // 
            // listaPlantas
            // 
            listaPlantas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPlantas.Location = new Point(7, 49);
            listaPlantas.Margin = new Padding(3, 4, 3, 4);
            listaPlantas.Name = "listaPlantas";
            listaPlantas.RowHeadersWidth = 51;
            listaPlantas.RowTemplate.Height = 25;
            listaPlantas.Size = new Size(550, 267);
            listaPlantas.TabIndex = 1;
            listaPlantas.CellContentClick += listaPlantas_CellContentClick;
            // 
            // button6
            // 
            button6.Location = new Point(336, 13);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 27;
            button6.Text = "Add Plant";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // usernameHello
            // 
            usernameHello.AutoSize = true;
            usernameHello.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameHello.Location = new Point(368, 65);
            usernameHello.Name = "usernameHello";
            usernameHello.Size = new Size(239, 37);
            usernameHello.TabIndex = 28;
            usernameHello.Text = "Olá x! Bem-Vindo!";
            usernameHello.Click += usernameHello_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 451);
            Controls.Add(usernameHello);
            Controls.Add(button6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowerPanel.ResumeLayout(false);
            flowerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaPlantas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label welcomeLabel;
        private GroupBox groupBox1;
        private CheckBox fruitCheckBox;
        private Label label1;
        private TextBox searchTextBox;
        private CheckBox flowerCheckBox;
        private GroupBox groupBox2;
        private Button button6;
        private DataGridView listaPlantas;
        private Label usernameHello;
        private Label plantDetailsProc;
        private Button btnAddToCart;
        private Button searchButton;
        private Panel flowerPanel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label flowerScientific;
        private Label flowChracteristic;
        private Label flowerSciFamily;
        private Label flowerCommomName;
        private Label fruitChracteristics;
        private Label fruitScientificName;
        private Label fruitCName;
        private Label plantChracteristics;
        private Label plantEnvironment;
        private Label label12;
        private Label plantKingdom;
        private Label plantScienName;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button detailButt;
        private Button buttonGoBack;
    }
}