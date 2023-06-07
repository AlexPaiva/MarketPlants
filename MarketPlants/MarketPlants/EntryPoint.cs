using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace MarketPlants
{
    public partial class EntryPoint : Form
    {
        public EntryPoint()
        {
            InitializeComponent();
            CompanyPanel.Visible = false;
            panel1.Visible = false;
            WelcomePanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
            } else
            {
                // Show an error message
                MessageBox.Show("Invalid username or password");
            }

        }

        //Press the Register button and redirect to the correct panel, depending on what type of register the user wants
        private void WelcomeRegisterButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to register as a Individual? (Select No if you are a Company)", "Registration Type (Individual or Company)", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CompanyPanel.Visible = false;
                WelcomePanel.Visible = false;
                panel1.Visible = true;
            } else
            {
                panel1.Visible = false;
                WelcomePanel.Visible = false;
                CompanyPanel.Visible = true;
            }
        }


        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterCompany(string username, string password, string email, int NIF, string descricao, int nrTelefone, string morada, string nome)
        {

            var result = MessageBox.Show("Do you want to register as a Buyer? (Select No if you want to be a Seller)", "Registration Type (Buyer or Seller)", MessageBoxButtons.YesNo);
            string userType = result == DialogResult.Yes ? "C" : "V";

            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //Usamos o Stored Procedure RegisterCompany para registar a empresa
                using (SqlCommand cmdRegisterCompany = new SqlCommand("RegisterCompany", conn))
                {
                    cmdRegisterCompany.CommandType = CommandType.StoredProcedure;

                    cmdRegisterCompany.Parameters.AddWithValue("@username", username);
                    cmdRegisterCompany.Parameters.AddWithValue("@password", password);
                    cmdRegisterCompany.Parameters.AddWithValue("@email", email);
                    cmdRegisterCompany.Parameters.AddWithValue("@nif", NIF);
                    cmdRegisterCompany.Parameters.AddWithValue("@userType", userType);
                    cmdRegisterCompany.Parameters.AddWithValue("@descricao", descricao);
                    cmdRegisterCompany.Parameters.AddWithValue("@nrTelefone", nrTelefone);
                    cmdRegisterCompany.Parameters.AddWithValue("@morada", morada);
                    cmdRegisterCompany.Parameters.AddWithValue("@nome", nome);

                    try
                    {
                        cmdRegisterCompany.ExecuteNonQuery();
                        MessageBox.Show("Your Company was registered successfully! Please feel free to now log in.", "Success!");
                    } catch (SqlException ex)
                    {
                        MessageBox.Show($"An error occurred during registration: {ex.Message}");
                    }
                }
            }
            panel1.Visible = false;
            CompanyPanel.Visible = false;
            WelcomePanel.Visible = true;
        }


        private bool Login(string username, string password)
        {
            // Define connection string
            //string connectionString = @"Data Source=(local);Initial Catalog=MarketPlants;Integrated Security=True";
            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

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

        //Register a Company Button Clicked
        private void CompanyRegisterBtn_Click(object sender, EventArgs e)
        {
            string username = CompanyUsernameInput.Text;
            string password = CompanyPasswordInput.Text;
            string email = CompanyEmailInput.Text;
            int NIF = int.TryParse(CompanySSNInput.Text, out int parsedNIF) ? parsedNIF : -1; //Try to parse as int, if error then it is not in the right format
            string descricao = CompanyDescriptionInput.Text;
            int nrTelefone = int.TryParse(CompanyPhoneInput.Text, out int parsedNrTelefone) ? parsedNrTelefone : -1; //Try to parse as int, if error then it is not in the right format
            string morada = CompanyAddressInput.Text;
            string nome = CompanyNameInput.Text;

            // check if inputs are valid
            var emailValid = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            var nameValid = !nome.Any(char.IsDigit);
            var usernamePasswordValid = username.Length <= 12 && password.Length <= 12;

            if (!emailValid)
            {
                MessageBox.Show("Email format is not valid. Please try again.", "Error!");
                return;
            }
            if (!nameValid)
            {
                MessageBox.Show("Name format is not valid. Please try again.", "Error!");
                return;
            }
            if (!usernamePasswordValid)
            {
                MessageBox.Show("Username and Password must be less than 12 characters. Please try again.", "Error!");
                return;
            }

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                NIF == -1 ||
                string.IsNullOrWhiteSpace(descricao) ||
                nrTelefone == -1 ||
                string.IsNullOrWhiteSpace(morada) ||
                string.IsNullOrWhiteSpace(nome) ||
                !emailValid ||
                !nameValid ||
                !usernamePasswordValid)
            {
                MessageBox.Show("All fields must be populated and valid. Make sure you left no empty fields, the SSN and Phone Number fields only contain digits, the username and password do not exceed 12 characters, the email must be valid, and the name doesn't contain numbers.", "Error!");
                return;
            }
            RegisterCompany(username, password, email, NIF, descricao, nrTelefone, morada, nome);
        }

        //Register a Individual Button Clicked
        private void ButtonRegisterIndividual_Click(object sender, EventArgs e)
        {
            string username = PeopleInputUsername.Text;
            string password = PeopleInputPassword.Text;
            string email = PeopleInputEmail.Text;
            string nome = PeopleInputName.Text;
            string morada = PeopleInputAddress.Text;
            int NIF = int.TryParse(PeopleInputSSN.Text, out int parsedNIF) ? parsedNIF : -1;
            int nrTelefone = int.TryParse(PeopleInputPhone.Text, out int parsedNrTelefone) ? parsedNrTelefone : -1;

            string genero;
            if (radioButtonMale.Checked)
                genero = "M";
            else if (radioButtonFemale.Checked)
                genero = "F";
            else
            {
                MessageBox.Show("Please select a gender.", "Error!");
                return;
            }

            // check if inputs are valid
            var emailValid = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            var nameValid = !nome.Any(char.IsDigit);
            var usernamePasswordValid = username.Length <= 12 && password.Length <= 12;

            if (!emailValid)
            {
                MessageBox.Show("Email format is not valid. Please try again.", "Error!");
                return;
            }
            if (!nameValid)
            {
                MessageBox.Show("Name format is not valid. Please try again.", "Error!");
                return;
            }
            if (!usernamePasswordValid)
            {
                MessageBox.Show("Username and Password must be less than 12 characters. Please try again.", "Error!");
                return;
            }

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                NIF == -1 ||
                nrTelefone == -1 ||
                string.IsNullOrWhiteSpace(morada) ||
                string.IsNullOrWhiteSpace(nome) ||
                !emailValid ||
                !nameValid ||
                !usernamePasswordValid)
            {
                MessageBox.Show("All fields must be populated and valid. Make sure you left no empty fields, the SSN and Phone Number fields only contain digits, the username and password do not exceed 12 characters, the email must be valid, and the name doesn't contain numbers.", "Error!");
                return;
            }
            RegisterIndividual(username, password, email, NIF, nrTelefone, morada, nome, genero);
        }

        //Register Individual
        private void RegisterIndividual(string username, string password, string email, int NIF, int nrTelefone, string morada, string fullName, string genero)
        {
            if (string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Please select a gender.", "Error!");
                return;
            }

            var names = fullName.Split(' ');

            if (names.Length < 2)
            {
                MessageBox.Show("Please enter both first name and last name, separated by a space.", "Error!");
                return;
            }

            string primeiroNome = names[0];
            string ultimoNome = string.Join(" ", names.Skip(1));

            var result = MessageBox.Show("Do you want to register as a Buyer? (Select No if you want to be a Seller)", "Registration Type (Buyer or Seller)", MessageBoxButtons.YesNo);
            string userType = result == DialogResult.Yes ? "C" : "V";
            string connectionString = @"Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p3g4;Persist Security Info=True; uid=p3g4;password=161852733@BDP;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmdRegisterIndividual = new SqlCommand("RegisterIndividual", conn))
                {
                    cmdRegisterIndividual.CommandType = CommandType.StoredProcedure;

                    cmdRegisterIndividual.Parameters.AddWithValue("@username", username);
                    cmdRegisterIndividual.Parameters.AddWithValue("@password", password);
                    cmdRegisterIndividual.Parameters.AddWithValue("@email", email);
                    cmdRegisterIndividual.Parameters.AddWithValue("@nif", NIF);
                    cmdRegisterIndividual.Parameters.AddWithValue("@nrTelefone", nrTelefone);
                    cmdRegisterIndividual.Parameters.AddWithValue("@morada", morada);
                    cmdRegisterIndividual.Parameters.AddWithValue("@primeiroNome", primeiroNome);
                    cmdRegisterIndividual.Parameters.AddWithValue("@ultimoNome", ultimoNome);
                    cmdRegisterIndividual.Parameters.AddWithValue("@userType", userType);
                    cmdRegisterIndividual.Parameters.AddWithValue("@genero", genero);

                    try
                    {
                        cmdRegisterIndividual.ExecuteNonQuery();
                        MessageBox.Show("Your registration as an Individual was successful! Please feel free to now log in.", "Success!");
                    } catch (SqlException ex)
                    {
                        MessageBox.Show($"An error occurred during registration: {ex.Message}");
                    }
                }
            }
            panel1.Visible = false;
            CompanyPanel.Visible = false;
            WelcomePanel.Visible = true;
        }

        //Go back from the Company Register panel to the Welcome Panel
        private void CompanyBackBtn_Click(object sender, EventArgs e)
        {
            CompanyPanel.Visible = false;
            panel1.Visible = false;
            WelcomePanel.Visible = true;
        }

        //Go back button from the Individual Register panel to the Welcome Panel
        private void button1_Click(object sender, EventArgs e)
        {
            CompanyPanel.Visible = false;
            panel1.Visible = false;
            WelcomePanel.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CompanyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}