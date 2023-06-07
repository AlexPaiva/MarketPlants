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

namespace MarketPlants
{
    public partial class AddPlant : Form
    {

        public string Username { get; set; }


        public AddPlant(string username)
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

        private void button5_Click(object sender, EventArgs e)
        {
            EntryPoint entry = new EntryPoint();
            entry.Show();
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        //Adicionar uma nova Planta
        private void addNewPlant_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    // Check if the plant information is filled
                    if (!string.IsNullOrEmpty(plantScientificName.Text) && !string.IsNullOrEmpty(plantCommonName.Text) && !string.IsNullOrEmpty(plantKingDom.Text) && !string.IsNullOrEmpty(plantFamily.Text) && !string.IsNullOrEmpty(plantEnvironment.Text) && !string.IsNullOrEmpty(plantCharacteristics.Text))
                    {
                        using (SqlCommand cmd = new SqlCommand("procAddPlant", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@ScientificName", plantScientificName.Text);
                            cmd.Parameters.AddWithValue("@CommonName", plantCommonName.Text);
                            cmd.Parameters.AddWithValue("@Kingdom", plantKingDom.Text);
                            cmd.Parameters.AddWithValue("@Family", plantFamily.Text);
                            cmd.Parameters.AddWithValue("@Environment", plantEnvironment.Text);
                            cmd.Parameters.AddWithValue("@Characteristics", plantCharacteristics.Text);
                            cmd.Parameters.AddWithValue("@Username", Username);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Plant added successfully.");
                    }

                    // Check if the flower information is filled
                    if (!string.IsNullOrEmpty(flowerScientificName.Text) && !string.IsNullOrEmpty(flowerCommonName.Text) && !string.IsNullOrEmpty(flowerCharacteristics.Text))
                    {
                        using (SqlCommand cmd = new SqlCommand("procAddFlower", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@ScientificName", flowerScientificName.Text);
                            cmd.Parameters.AddWithValue("@CommonName", flowerCommonName.Text);
                            cmd.Parameters.AddWithValue("@Characteristics", flowerCharacteristics.Text);
                            cmd.Parameters.AddWithValue("@PlantScientificName", plantScientificName.Text);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Flower added successfully.");
                    }

                    // Check if the fruit information is filled
                    if (!string.IsNullOrEmpty(fruitScientificName.Text) && !string.IsNullOrEmpty(fruitCommonName.Text) && !string.IsNullOrEmpty(fruitCharacteristics.Text) && !string.IsNullOrEmpty(fruitSeason.Text) && !string.IsNullOrEmpty(fruitReplantable.Text))
                    {
                        using (SqlCommand cmd = new SqlCommand("procAddFruit", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@ScientificName", fruitScientificName.Text);
                            cmd.Parameters.AddWithValue("@CommonName", fruitCommonName.Text);
                            cmd.Parameters.AddWithValue("@Characteristics", fruitCharacteristics.Text);
                            cmd.Parameters.AddWithValue("@Season", fruitSeason.Text);
                            cmd.Parameters.AddWithValue("@Replantable", fruitReplantable.Text);
                            cmd.Parameters.AddWithValue("@FlowerScientificName", flowerScientificName.Text);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Fruit added successfully.");
                    }
                } catch (SqlException ex)
                {
                    // Catch SqlException separately to handle SQL Server errors
                    if (ex.Number == 50000) // 50000 is the error number for user-defined messages, like the RAISERROR used in the trigger expected for this
                    {
                        MessageBox.Show("Failed to add plant: " + ex.Message);
                    } else
                    {
                        MessageBox.Show("An unexpected database error occurred: " + ex.Message);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

                conn.Close();
            }
        }
    }
}
