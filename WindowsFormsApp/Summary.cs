using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Summary : Form
    {
        private string msg;
        private string name;
        private string lastname;
        private string number;
        
        public Summary()
        {
            
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
           
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            nameL.Text=PersonalInfo.name;
            lastL.Text=PersonalInfo.lastname;
            numL.Text=PersonalInfo.number;
            order.Text = SecondForm.order;
            

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nameL_Click(object sender, EventArgs e)
        {

        }

        private void numL_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var newForm = new SecondForm();
            newForm.Show();
        }
    }
}
