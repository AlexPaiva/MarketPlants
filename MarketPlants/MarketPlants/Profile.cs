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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home mainpage = new Home();
            mainpage.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Cart cart = new Cart();
            //cart.Show();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Favourites favourites = new Favourites();
            favourites.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EntryPoint entryPoint = new EntryPoint();
            entryPoint.Show();
            this.Hide();
        }
    }
}
