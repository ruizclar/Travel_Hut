using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Hut
{
    public partial class TravelHut : Form
    {
        Location FieldMuseum = new Location(1, "The Field Museum", "1400 S Lake Shore Dr", "Chicago", 60605);


        public TravelHut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.displayTravelInfo.Text = (" Name of Location: " + FieldMuseum.LocationName + " is located at " + FieldMuseum.Address + ", " + FieldMuseum.City + ", " + FieldMuseum.Zip + ".");
            this.displayTravelInfo.Text = FieldMuseum.listTravelInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.btnGetInfo.Click += new EventHandler(button1_Click);
        }

      
    }
}
