using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformapp
{
    public partial class Form1 : Form
    {
        static Random veletlen = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void resultListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void howMany_ValueChanged(object sender, EventArgs e)
        {

        }
        private void firstNumberradius_ValueChanged(object sender, EventArgs e)
        {

        }

        private void secondNumberradius_ValueChanged(object sender, EventArgs e)
        {

        }

        private void randomGenbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < howMany.Value; i++)
            {
                int szam = veletlen.Next((int)firstNumberradius.Value, ((int)secondNumberradius.Value));
                resultListbox.Items.Add("A random szám a kövektező: "+szam);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            resultListbox.Items.Clear();
        }
    }
}
