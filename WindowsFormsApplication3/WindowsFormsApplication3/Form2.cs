using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2(string set1,string set2, string set3 ,string set4 )
        {
            InitializeComponent();
            label1.Text = set1;
            label2.Text = set2;
            label3.Text = set3;
            label4.Text = set4;
            
        }

        public Form2()
        {
            // TODO: Complete member initialization
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
