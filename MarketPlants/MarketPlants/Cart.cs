using Azure.Identity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MarketPlants
{
    public partial class Cart : Form
    {

        public string Username { get; set; }

        public Cart(string username)
        {
            Username = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home(Username);
            home.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(Username);
            profile.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EntryPoint entry = new EntryPoint();
            entry.Show();
            this.Close();
        }

        //Visit 'AddPlant' section
        private void button7_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=MarketPlants;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Step 1: Check and create the Carrinho using the stored procedure
                using (SqlCommand cmdCheckAndCreateCarrinho = new SqlCommand("CheckAndCreateCarrinho", conn))
                {
                    cmdCheckAndCreateCarrinho.CommandType = CommandType.StoredProcedure;

                    cmdCheckAndCreateCarrinho.Parameters.AddWithValue("@username", Username);
                    cmdCheckAndCreateCarrinho.Parameters.Add("@carrinhoID", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmdCheckAndCreateCarrinho.ExecuteNonQuery();

                    int carrinhoID = (int)cmdCheckAndCreateCarrinho.Parameters["@carrinhoID"].Value;

                    // Step 2: Retrieve the Artigo details using the stored procedure
                    DataTable dataTable = new DataTable();

                    using (SqlCommand cmdRetrieveArtigos = new SqlCommand("GetArtigosByCarrinhoID", conn))
                    {
                        cmdRetrieveArtigos.CommandType = CommandType.StoredProcedure;

                        cmdRetrieveArtigos.Parameters.AddWithValue("@carrinhoID", carrinhoID);

                        SqlDataReader reader = cmdRetrieveArtigos.ExecuteReader();
                        dataTable.Load(reader);
                    }

                    // Step 3: Bind the Artigo details to the gridCarrinho DataGridView
                    gridCarrinho.DataSource = dataTable;
                }
            }
        }
    }
}
