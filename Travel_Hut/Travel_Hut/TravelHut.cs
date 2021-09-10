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
        Museum FieldMuseum = new Museum();

        public TravelHut()
        {
            InitializeComponent();
            //Museum FieldMuseum = new Museum();
            FieldMuseum.LocationName = "The Field Museum";
            FieldMuseum.City = "Chicago";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.displayTravelInfo.Text = FieldMuseum.listTravelInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          this.btnGetInfo.Click += new EventHandler(button1_Click);
        }

      
    }
}
