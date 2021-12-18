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
    public partial class SecondForm : Form
    {
        public double total = 0;
        public double pizzaprice = 12;
        public double burgerprice = 6;
        public double shawarmaprice = 7;
        public double colaprice = 2;
        public double waterprice = 1;
        public int pizzaqte = 1;
        public int burgerqte = 1;
        public int shawarmaqte = 1;
        public int colaqte = 1;
        public int waterqte = 1;
        public static string order;
        public string msg = "";
        public string quantite;

        public int Pizza   // property
        {
            get { return pizzaqte; }
            set { pizzaqte = value; }
        }
        public int Shawarma  // property
        {
            get { return shawarmaqte; }
            set { shawarmaqte = value; }

        }
        public int Burger   // property
        {
            get { return burgerqte; }
            set { burgerqte = value; }
        }
        public int Cola   // property
        {
            get { return colaqte; }
            set { colaqte = value; }
        }
        public int Water   // property
        {
            get { return waterqte; }
            set { waterqte = value; }
        }
        public double Total   // property
        {
            get { return total; }
            set { total = value; }
        }
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
        public SecondForm()
        {
           
           InitializeComponent();
        }


        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {   
                this.Msg = this.msg + pizzaBox.Text+ " Pizza , ";
                this.Total = this.total + this.pizzaprice*this.pizzaqte;
            }
            else
            {
                this.Msg = this.msg ;//delete ,Pizza from this.Msg
                this.Total = this.total - this.pizzaprice*this.pizzaqte;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("the Total Price = $ " + this.Total.ToString(), "Price", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
               
                    order = this.Msg;
                    var newForm = new Summary();
                    newForm.Show();
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ? ", "Exit Menu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox2.Checked)
            {
                this.Msg = this.msg + burgerBox.Text+" Burger , ";
                this.Total = this.total + this.burgerprice*this.burgerqte;
            }
            else
            {
                this.Msg = this.msg;
                this.Total = this.total + this.burgerprice*this.burgerqte;
            }
        }

        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox3.Checked)
            {
                this.Msg = this.msg +shawarmaBox.Text+ " Shawarma , ";
                this.Total = this.total + this.shawarmaprice*this.shawarmaqte;
            }
            else
            {
                this.Msg = this.msg;
                this.Total = this.total - this.shawarmaprice*this.shawarmaqte;
            }
        }

        public void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
          

            if (checkBox5.Checked)
            {
                this.Msg = this.msg + colaBox.Text+" Cola , ";
                this.Total = this.total + this.colaprice*this.colaqte;
            }
            else
            {
                this.Msg = this.msg;
                this.Total = this.total - this.colaprice*this.colaqte;
            }
        }

        public void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox4.Checked)
            {
                this.Msg = this.msg + waterBox.Text+" Water";
                this.Total = this.total + this.waterprice*this.waterqte;
            }
            else
            {
                this.Msg = this.msg;
                this.Total = this.total - this.waterprice*this.waterqte;
            }
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {

        }

        private void pizzaBox_TextChanged(object sender, EventArgs e)
        {
            this.Pizza=pizzaBox.Text == "" ? 1 : int.Parse(pizzaBox.Text);

        }

        private void burgerBox_TextChanged(object sender, EventArgs e)
        {
            this.Burger = burgerBox.Text == "" ? 1 : int.Parse(burgerBox.Text);
        }

        private void shawarmaBox_TextChanged(object sender, EventArgs e)
        {
            this.Shawarma = shawarmaBox.Text == "" ? 1 : int.Parse(shawarmaBox.Text);
        }

        private void colaBox_TextChanged(object sender, EventArgs e)
        {
            this.Cola = colaBox.Text == "" ? 1 : int.Parse(colaBox.Text);
        }

        private void waterBox_TextChanged(object sender, EventArgs e)
        {
              this.Water = waterBox.Text == "" ? 1 : int.Parse(waterBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pizzaBox.Clear();
            burgerBox.Clear();
            shawarmaBox.Clear();
            colaBox.Clear();
            waterBox.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            
            var newForm = new SecondForm();
            newForm.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            var newForm = new PersonalInfo();
            newForm.Show();
             this.Close();
        }
    }
}