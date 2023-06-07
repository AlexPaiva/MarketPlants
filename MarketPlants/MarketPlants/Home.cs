using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MarketPlants
{
    public partial class Home : Form
    {

        public string Username { get; set; }

        public string commonName;

        bool plantInCart = false;

        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=MarketPlants;Integrated Security=True;Encrypt=False";


        public Home(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(Username);
            cart.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(Username);
            profile.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnAddToCart.Visible = false;
            flowerPanel.Visible = false;
            detailButt.Visible = false;
            usernameHello.Text = $"Olá {Username}! Bem-Vindo!";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM vw_PlantaHome", conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                listaPlantas.DataSource = dt;
                listaPlantas.DefaultCellStyle.ForeColor = Color.Black;

                listaPlantas.CellClick += listaPlantas_CellClick;

                // Update column header names
                listaPlantas.Columns["Common Name"].HeaderText = "Common Name";
                listaPlantas.Columns["Scientific Name"].HeaderText = "Scientific Name";
                listaPlantas.Columns["Classification"].HeaderText = "Classification";
                listaPlantas.Columns["Environment"].HeaderText = "Environment";
                listaPlantas.Columns["Characteristics"].HeaderText = "Characteristics";
                listaPlantas.Columns["Fruit Common Name"].HeaderText = "Fruit Common Name";
                listaPlantas.Columns["Fruit Scientific Name"].HeaderText = "Fruit Scientific Name";
                listaPlantas.Columns["Fruit Characteristics"].HeaderText = "Fruit Characteristics";
                listaPlantas.Columns["Flower Common Name"].HeaderText = "Flower Common Name";
                listaPlantas.Columns["Flower Scientific Name"].HeaderText = "Flower Scientific Name";
                listaPlantas.Columns["Flower Characteristics"].HeaderText = "Flower Characteristics";

                // Update column widths
                listaPlantas.Columns["Common Name"].Width = 150;
                listaPlantas.Columns["Scientific Name"].Width = 200;
                listaPlantas.Columns["Classification"].Width = 150;
                listaPlantas.Columns["Environment"].Width = 100;
                listaPlantas.Columns["Characteristics"].Width = 400;
                listaPlantas.Columns["Fruit Common Name"].Width = 150;
                listaPlantas.Columns["Fruit Scientific Name"].Width = 200;
                listaPlantas.Columns["Fruit Characteristics"].Width = 400;
                listaPlantas.Columns["Flower Common Name"].Width = 150;
                listaPlantas.Columns["Flower Scientific Name"].Width = 200;
                listaPlantas.Columns["Flower Characteristics"].Width = 400;

                // Update row heights
                listaPlantas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                listaPlantas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            } catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            } finally
            {
                conn.Close();
            }
        }

        private void listaPlantas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that the row index is valid (not a header row)
            {
                // Get the common name of the clicked plant
                commonName = listaPlantas.Rows[e.RowIndex].Cells["Common Name"].Value.ToString();

                // Use it to call the stored procedure and get the plant details
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPlantDetails", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CommonName", commonName);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Update the label text with plant details
                                bool hasFruit = !string.IsNullOrEmpty(reader["Fruit Scientific Name"].ToString()) && reader["Fruit Scientific Name"].ToString() != "No Info!";
                                bool hasFlower = !string.IsNullOrEmpty(reader["Flower Scientific Name"].ToString()) && reader["Flower Scientific Name"].ToString() != "No Info!";

                                plantDetailsProc.Text = $"Scientific Name: {reader["Scientific Name"].ToString()} \nCommon Name: {reader["Common Name"].ToString()} \nFruit: {(hasFruit ? "Yes" : "No")} \nFlower: {(hasFlower ? "Yes" : "No")}";

                                // Fill in panel details
                                plantScienName.Text = reader["Scientific Name"].ToString();
                                plantKingdom.Text = reader["Kingdom"].ToString();
                                plantEnvironment.Text = reader["Environment"].ToString();
                                plantChracteristics.Text = reader["Characteristics"].ToString();
                                fruitCName.Text = hasFruit ? reader["Fruit Common Name"].ToString() : "No Info!";
                                fruitScientificName.Text = hasFruit ? reader["Fruit Scientific Name"].ToString() : "No Info!";
                                fruitChracteristics.Text = hasFruit ? reader["Fruit Characteristics"].ToString() : "No Info!";
                                flowerCommomName.Text = hasFlower ? reader["Flower Common Name"].ToString() : "No Info!";
                                flowerSciFamily.Text = hasFlower ? reader["Flower Scientific Name"].ToString() : "No Info!";
                                flowChracteristic.Text = hasFlower ? reader["Flower Characteristics"].ToString() : "No Info!";
                            }
                            detailButt.Visible = true;
                        }
                    }
                }
            }
        }


        //Botão de efetuar pesquisa, que filtra as coisas na tabela
        private void searchButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=MarketPlants;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("sp_SearchPlants", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@searchTerm", searchTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@flowers", flowerCheckBox.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@fruits", fruitCheckBox.Checked ? 1 : 0);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        listaPlantas.DataSource = dt;

                        // Update column header names
                        listaPlantas.Columns["Common Name"].HeaderText = "Common Name";
                        listaPlantas.Columns["Scientific Name"].HeaderText = "Scientific Name";
                        listaPlantas.Columns["Kingdom"].HeaderText = "Kingdom";
                        listaPlantas.Columns["Family"].HeaderText = "Family";
                        listaPlantas.Columns["Environment"].HeaderText = "Environment";
                        listaPlantas.Columns["Characteristics"].HeaderText = "Characteristics";
                        listaPlantas.Columns["Flower Common Name"].HeaderText = "Flower Common Name";
                        listaPlantas.Columns["Flower Scientific Name"].HeaderText = "Flower Scientific Name";
                        listaPlantas.Columns["Flower Characteristics"].HeaderText = "Flower Characteristics";
                        listaPlantas.Columns["Fruit Common Name"].HeaderText = "Fruit Common Name";
                        listaPlantas.Columns["Fruit Scientific Name"].HeaderText = "Fruit Scientific Name";
                        listaPlantas.Columns["Fruit Characteristics"].HeaderText = "Fruit Characteristics";
                        listaPlantas.Columns["Season"].HeaderText = "Season";
                    }
                }
            }

            // Update the label text after the search
            UpdateWelcomeLabel();
        }

        //Atualiza a label de texto dependendo da pesquisa efetuada!
        private void UpdateWelcomeLabel()
        {
            string searchPhrase = searchTextBox.Text.Trim();
            bool isFruitChecked = fruitCheckBox.Checked;
            bool isFlowerChecked = flowerCheckBox.Checked;

            if (string.IsNullOrEmpty(searchPhrase) && !isFruitChecked && !isFlowerChecked)
            {
                welcomeLabel.Text = "View Below our Total Plant Selection available for Purchase!";
            } else if (string.IsNullOrEmpty(searchPhrase) && isFruitChecked && !isFlowerChecked)
            {
                welcomeLabel.Text = "Search Results for All Plants with Fruit and no Flower";
            } else if (string.IsNullOrEmpty(searchPhrase) && !isFruitChecked && isFlowerChecked)
            {
                welcomeLabel.Text = "Search Results for All Plants with Flower and no Fruit";
            } else if (string.IsNullOrEmpty(searchPhrase) && isFruitChecked && isFlowerChecked)
            {
                welcomeLabel.Text = "Search Results for All Plants with Fruit and Flower";
            } else
            {
                welcomeLabel.Text = "Search Results for: " + searchPhrase;

                if (isFruitChecked && isFlowerChecked)
                {
                    welcomeLabel.Text += " - With Fruit and Flower";
                } else if (isFruitChecked)
                {
                    welcomeLabel.Text += " - With Fruit and no Flower";
                } else if (isFlowerChecked)
                {
                    welcomeLabel.Text += " - With Flower and no Fruit";
                }
            }
        }


        //Visit 'AddPlant' section
        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=MarketPlants;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("IsUserSeller", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@username", Username); // Assuming 'Username' is the variable storing the username of the logged in user

                        var isSellerParam = new SqlParameter("@IsSeller", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(isSellerParam);

                        cmd.ExecuteNonQuery();

                        bool isSeller = (bool)isSellerParam.Value;

                        if (isSeller)
                        {
                            // The user is a 'Vendedor'
                            AddPlant plant = new AddPlant(Username);
                            plant.Show();
                            this.Close();
                        } else
                        {
                            // The user is not a 'Vendedor'
                            MessageBox.Show("You are not a seller. You cannot add a plant.");
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void usernameHello_Click(object sender, EventArgs e)
        {

        }

        private void listaPlantas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void plantDetailsProc_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=MarketPlants;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check and create Carrinho for the user
                    int carrinhoID;
                    using (SqlCommand cmdCheckAndCreateCarrinho = new SqlCommand("CheckAndCreateCarrinho", conn))
                    {
                        cmdCheckAndCreateCarrinho.CommandType = CommandType.StoredProcedure;

                        cmdCheckAndCreateCarrinho.Parameters.AddWithValue("@username", Username);
                        cmdCheckAndCreateCarrinho.Parameters.Add("@carrinhoID", SqlDbType.Int).Direction = ParameterDirection.Output;

                        cmdCheckAndCreateCarrinho.ExecuteNonQuery();

                        carrinhoID = (int)cmdCheckAndCreateCarrinho.Parameters["@carrinhoID"].Value;
                    }

                    // Add Artigo to Carrinho
                    using (SqlCommand cmdAddArtigoToCarrinho = new SqlCommand("AddArtigoToCarrinho", conn))
                    {
                        cmdAddArtigoToCarrinho.CommandType = CommandType.StoredProcedure;

                        cmdAddArtigoToCarrinho.Parameters.AddWithValue("@username", Username);
                        cmdAddArtigoToCarrinho.Parameters.AddWithValue("@commonName", commonName);

                        cmdAddArtigoToCarrinho.ExecuteNonQuery();

                        MessageBox.Show("Plant added to the Cart!");
                    }
                }
            } catch (SqlException ex)
            {
                if (ex.Number == 50000) // Assuming the trigger raises a custom error with number 50000
                {
                    MessageBox.Show(ex.Message);
                } else
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        //View flower Details
        private void detailButt_Click(object sender, EventArgs e)
        {
            buttonGoBack.Visible = true;
            flowerPanel.Visible = true;
            btnAddToCart.Visible = true;
        }

        //Return to the table
        private void button3_Click(object sender, EventArgs e)
        {
            buttonGoBack.Visible = false;
            flowerPanel.Visible = false;
            btnAddToCart.Visible = false;
        }
    }
}
