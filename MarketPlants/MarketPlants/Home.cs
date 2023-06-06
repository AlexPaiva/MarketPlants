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
namespace MarketPlants
{
    public partial class Home : Form
    {

        public string Username { get; set; }

        bool plantInCart = false;

        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=MarketPlants;Integrated Security=True;Encrypt=False";


        public Home(string username = "User")
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
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
            Cart cart = new Cart();
            cart.Show();
            this.Close();    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Favourites fav = new Favourites();  
            fav.Show(); 
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
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
            usernameHello.Text = $"Olá {Username}!";
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
                listaPlantas.Columns["Nome"].HeaderText = "Nome";
                listaPlantas.Columns["Nome Cientifico"].HeaderText = "Nome Científico";
                listaPlantas.Columns["Classification"].HeaderText = "Classificação";
                listaPlantas.Columns["Ambiente"].HeaderText = "Ambiente";
                listaPlantas.Columns["Caracteristicas"].HeaderText = "Características";

                // Update column widths
                listaPlantas.Columns["Nome"].Width = 150;
                listaPlantas.Columns["Nome Cientifico"].Width = 200;
                listaPlantas.Columns["Classification"].Width = 150;
                listaPlantas.Columns["Ambiente"].Width = 100;
                listaPlantas.Columns["Caracteristicas"].Width = 400;

                // Update row heights
                listaPlantas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                listaPlantas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void listaPlantas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that the row index is valid (not a header row)
            {
                // Get the common name of the clicked plant
                string nomeComum = listaPlantas.Rows[e.RowIndex].Cells["Nome"].Value.ToString();

                // Use it to call the stored procedure and get the plant details
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetPlantDetails", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NomeComum", nomeComum);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Update the label text with plant details
                                plantDetailsProc.Text = $"Nome Cientifico: {reader["NomeCientifico"].ToString()} \nReino: {reader["Reino"].ToString()} \nFamilia: {reader["Familia"].ToString()} \nAmbiente: {reader["Ambiente"].ToString()} \nCaracteristicas: {reader["Caracteristicas"].ToString()}";
                            }
                            btnAddToCart.Visible = true;
                        }
                    }
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AddPlant plant = new AddPlant();
            plant.Show();
            this.Close();
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

            // Show the appropriate message based on whether the plant is already in the cart or not
            if (plantInCart)
            {
                MessageBox.Show("Already added to cart!", "Cart Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                plantInCart = true;
                MessageBox.Show("Added to cart", "Cart Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Perform the necessary actions to add the plant to the cart
            }
        }
    }
}
