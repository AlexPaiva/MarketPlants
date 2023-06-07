namespace MarketPlants
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            gridCarrinho = new DataGridView();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCarrinho).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(717, 13);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 23;
            button4.Text = "Profile";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Location = new Point(531, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 21;
            button2.Text = "Cart";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(439, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 20;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 89);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(285, 392);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(296, 31);
            button5.TabIndex = 26;
            button5.Text = "$ Checkout! $";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(179, 15);
            label1.Name = "label1";
            label1.Size = new Size(500, 37);
            label1.TabIndex = 25;
            label1.Text = "Your Cart (Hopefully filled with Plants!):";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Green;
            groupBox1.Controls.Add(gridCarrinho);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button5);
            groupBox1.ForeColor = Color.Yellow;
            groupBox1.Location = new Point(14, 132);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(883, 431);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // gridCarrinho
            // 
            gridCarrinho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCarrinho.Location = new Point(15, 55);
            gridCarrinho.Name = "gridCarrinho";
            gridCarrinho.RowHeadersWidth = 51;
            gridCarrinho.RowTemplate.Height = 29;
            gridCarrinho.Size = new Size(862, 330);
            gridCarrinho.TabIndex = 27;
            // 
            // button6
            // 
            button6.Location = new Point(808, 13);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 25;
            button6.Text = "LogOut";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(346, 13);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 31);
            button7.TabIndex = 29;
            button7.Text = "Add Plant";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 600);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCarrinho).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button5;
        private Label label1;
        private GroupBox groupBox1;
        private Button button6;
        private Button button7;
        private DataGridView gridCarrinho;
    }
}