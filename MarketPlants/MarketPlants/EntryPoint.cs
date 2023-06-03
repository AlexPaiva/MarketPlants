using Microsoft.Data.SqlClient;
using System.Data;

namespace MarketPlants
{
    public partial class EntryPoint : Form
    {
        public EntryPoint()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home mainPage = new Home();
            mainPage.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            //TODO: Replace with actual login logic
            if (Login(username, password))
            {
                Home mainPage = new Home(username);
                mainPage.Show();
                this.Hide();
            }
            else
            {
                // Show an error message
                MessageBox.Show("Invalid username or password");
            }
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register(string username, string password)
        {
            string connectionString = @"Data Source=DESKTOP-SOPSA3N\SQLEXPRESS;Initial Catalog=MarketPlants;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkUserExistsQuery = "SELECT COUNT(*) FROM Utilizador WHERE Username = @username;";

                using (SqlCommand cmdCheckUserExists = new SqlCommand(checkUserExistsQuery, conn))
                {
                    cmdCheckUserExists.Parameters.AddWithValue("@username", username);
                    int userExists = (int)cmdCheckUserExists.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("User already exists.");
                    }
                    else
                    {
                        string registerQuery = "INSERT INTO Utilizador (Username, Senha) VALUES (@username, @password);";

                        using (SqlCommand cmdRegister = new SqlCommand(registerQuery, conn))
                        {
                            cmdRegister.Parameters.AddWithValue("@username", username);
                            cmdRegister.Parameters.AddWithValue("@password", password);
                            cmdRegister.ExecuteNonQuery();
                            MessageBox.Show("User registered successfully!");
                        }
                    }
                }
            }
        }


        private bool Login(string username, string password)
            {
            // Define connection string
            //string connectionString = @"Data Source=(local);Initial Catalog=MarketPlants;Integrated Security=True";
            string connectionString = @"Data Source=DESKTOP-SOPSA3N\SQLEXPRESS;Initial Catalog=MarketPlants;Integrated Security=True;TrustServerCertificate=true";

            // Create SQL command to find user with matching username and password
            string query = "SELECT COUNT(*) FROM MarketPlants.Utilizador WHERE Username = @Username AND Senha = @Password";

                // Create connection and command
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Define parameters used in command execution
                        SqlParameter paramUsername = new SqlParameter("@Username", SqlDbType.NVarChar);
                        SqlParameter paramPassword = new SqlParameter("@Password", SqlDbType.NVarChar);
                        paramUsername.Value = username;
                        paramPassword.Value = password;

                        cmd.Parameters.Add(paramUsername);
                        cmd.Parameters.Add(paramPassword);

                        conn.Open();

                        // Execute command and return true if count > 0
                        int userCount = (int)cmd.ExecuteScalar();

                        return userCount > 0;
                    }
                }
            }

}
        
}