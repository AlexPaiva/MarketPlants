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
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home mainpage = new Home();
            mainpage.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Cart cart = new Cart(); 
            cart.Show();    
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Favourites fav = new Favourites();
            fav.Show(); 
            this.Close();   
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            EntryPoint entry = new EntryPoint();    
            entry.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPlant plant = new AddPlant();
            plant.Show();
            this.Close();
        }
    }
}
