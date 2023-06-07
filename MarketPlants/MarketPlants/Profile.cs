using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
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
    public partial class Profile : Form
    {

        public string Username { get; set; }//Guarda o username do utilizador

        private string userType;//Para saber que tipo de utilizar é, Pessoa ou Empresa

        public Profile(string username)
        {
            InitializeComponent();
            Username = username;
        }

        //Quando o Form carrega, verificar se o utilizador é vendedor ou comprador
        private void Profile_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd;

                cmd = new SqlCommand("SELECT Username, Email, NIF, dbo.FormatPhoneNumber(NrTelefone) as NrTelefone, Morada FROM MarketPlants.Empresa WHERE Username = @username", conn);
                cmd.Parameters.AddWithValue("@username", Username);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        UserUserName.Text = Username;
                        UserEmailBox.Text = reader["Email"].ToString();
                        UserSSNBox.Text = reader["NIF"].ToString();
                        UserPhoneBox.Text = reader["NrTelefone"].ToString();
                        UserAddressBox.Text = reader["Morada"].ToString();
                    }
                }

                if (UserEmailBox.Text == "")//Se não for Empresa, é Pessoa
                {
                    cmd = new SqlCommand("SELECT Username, Email, NIF, dbo.FormatPhoneNumber(NrTelefone) as NrTelefone, Morada FROM MarketPlants.Pessoa WHERE Username = @username", conn);
                    cmd.Parameters.AddWithValue("@username", Username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserUserName.Text = Username;
                            UserEmailBox.Text = reader["Email"].ToString();
                            UserSSNBox.Text = reader["NIF"].ToString();
                            UserPhoneBox.Text = reader["NrTelefone"].ToString();
                            UserAddressBox.Text = reader["Morada"].ToString();
                            userType = "Pessoa";
                        }
                    }
                } else //É Empresa
                {
                    userType = "Empresa";
                }

                using (SqlCommand cmdSeller = new SqlCommand("IsUserSeller", conn))
                {
                    cmdSeller.CommandType = CommandType.StoredProcedure;

                    cmdSeller.Parameters.AddWithValue("@username", Username);
                    SqlParameter isSellerParam = new SqlParameter("@IsSeller", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    cmdSeller.Parameters.Add(isSellerParam);

                    cmdSeller.ExecuteNonQuery();

                    bool isSeller = (bool)cmdSeller.Parameters["@IsSeller"].Value;

                    if (isSeller)
                    {
                        // If the user is a seller, load their conditions.
                        using (SqlCommand cmdGet = new SqlCommand("GetVendedorConditions", conn))
                        {
                            cmdGet.CommandType = CommandType.StoredProcedure;

                            cmdGet.Parameters.AddWithValue("@username", Username);

                            using (SqlDataReader reader = cmdGet.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    sellerDeliveryTextBox.Text = reader["CondicoesDeLevantamentoEntrega"].ToString();
                                }
                            }
                        }
                        string query = "SELECT * FROM MarketPlants.View_UserPlants WHERE Username = @Username";

                        using (SqlCommand cmd5 = new SqlCommand(query, conn))
                        {
                            cmd5.Parameters.AddWithValue("@Username", Username);
                            SqlDataReader reader = cmd5.ExecuteReader();
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            selliGridi.DataSource = dataTable;
                        }
                        sellerPanel.Visible = true;
                        selliPaneli.Visible = true;
                        buyerPanel.Visible = false;
                        BuyerPaneli.Visible = false;
                    } else
                    {
                        // Check if the user is a buyer.
                        using (SqlCommand cmdBuyer = new SqlCommand("IsUserBuyer", conn))
                        {
                            cmdBuyer.CommandType = CommandType.StoredProcedure;

                            cmdBuyer.Parameters.AddWithValue("@username", Username);
                            SqlParameter isBuyerParam = new SqlParameter("@IsBuyer", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                            cmdBuyer.Parameters.Add(isBuyerParam);

                            cmdBuyer.ExecuteNonQuery();

                            bool isBuyer = (bool)cmdBuyer.Parameters["@IsBuyer"].Value;

                            if (isBuyer)
                            {
                                // If the user is a buyer, load their payment info.
                                using (SqlCommand cmdGet = new SqlCommand("GetCompradorPaymentInfo", conn))
                                {
                                    cmdGet.CommandType = CommandType.StoredProcedure;

                                    cmdGet.Parameters.AddWithValue("@username", Username);

                                    using (SqlDataReader reader = cmdGet.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            buyerPaymentInfoBox.Text = reader["DadosDePagamento"].ToString();
                                        }
                                    }
                                }
                                buyerPanel.Visible = true;
                                BuyerPaneli.Visible = true;
                                sellerPanel.Visible = false;
                                selliPaneli.Visible = false;
                            } else
                            {
                                MessageBox.Show("You are not a buyer or a seller. Please contact the administrator.", "Error");
                            }
                        }
                    }
                }
            }
        }

        //Guardar alterações feitas ao perfil
        private void editProfileButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

            string phoneNumber = UserPhoneBox.Text;
            // Check if the phone number is in the correct format
            Regex regex = new Regex(@"^\d{3}-\d{3}-\d{3}$");
            if (!regex.IsMatch(phoneNumber)) // While we also have a check in the database, we want to give the user a heads up before they send the data to the database.
            {
                MessageBox.Show("Phone number format is incorrect. It must be 'XXX-XXX-XXX'.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateUserData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@newPassword", UserChangePassword.Text);
                    cmd.Parameters.AddWithValue("@newEmail", UserEmailBox.Text);
                    cmd.Parameters.AddWithValue("@newNIF", UserSSNBox.Text);
                    cmd.Parameters.AddWithValue("@newPhone", phoneNumber);
                    cmd.Parameters.AddWithValue("@newAddress", UserAddressBox.Text);
                    cmd.Parameters.AddWithValue("@userType", userType);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Profile information updated successfully!");
                    } catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }


        //Clicar botão de atualizar informações sobre o vendedor
        private void sellerSaveBut_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateVendedorConditions", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@condicoes", sellerDeliveryTextBox.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Seller Information updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Clicar botão de atualizar informações de pagamento do Comprador
        private void saveBuyerSettings_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("UpdateCompradorPaymentInfo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", Username);
                    cmd.Parameters.AddWithValue("@dadosDePagamento", buyerPaymentInfoBox.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Buyer Payment Information updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home mainpage = new Home(Username);
            mainpage.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Cart cart = new Cart(Username);
            cart.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            EntryPoint entry = new EntryPoint();
            entry.Show();
            this.Close();
        }


        //Visit Add Plant Page
        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sellerDeliveryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
