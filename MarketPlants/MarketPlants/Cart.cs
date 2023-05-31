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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();   
            this.Close();    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Favourites favourites = new Favourites();   
            favourites.Show();  
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();    
            profile.Show();
            this.Close();    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EntryPoint entry = new EntryPoint();    
            entry.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPlant plant = new AddPlant();    
            plant.Show();
            this.Close();
        }
    }
}
