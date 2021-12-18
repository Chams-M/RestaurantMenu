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
    public partial class PersonalInfo : Form
    {
        public static string name;
        public static string lastname;
        public static string number;
        public  string msg;
        Summary s = new Summary();

        public PersonalInfo()
        {    
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ? ", "Exit Menu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               
                 
        Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            { 
                MessageBox.Show("Please Enter these informations",MessageBoxButtons.OK);
            }
            else { 
            var newForm = new SecondForm();
            name = textBox1.Text;
            lastname = textBox2.Text;
            number = textBox3.Text;
            newForm.Show();
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
