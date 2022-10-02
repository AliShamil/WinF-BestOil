using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace WinF_BestOil
{
    public partial class Form1 : Form
    {
        public decimal TotalCafe { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Fuel> FuelType = new List<Fuel>()
            {
                new("AI-92",1),
                new("AI-95",2),
                new("AI-98",2.3),
                new("Diesel",0.8),
                new("LPG",0.65),
                new("CNG",0.45)
            };

            comboBox1.Items.AddRange(FuelType.ToArray());

            comboBox1.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Fuel_Price.Text = (comboBox1.SelectedItem as Fuel).Price.ToString();
            foreach (Control control in panel1.Controls)
            {
                if (control.Tag.ToString() == "liter")
                    num_Per_Liter_ValueChanged(sender, e);
            }
        }

        private void rdb_PerLiter_CheckedChanged(object sender, EventArgs e)
        {



            if (rdb_PerLiter.Checked)
            {
                num_Per_Liter.Enabled = true;
                num_Per_Cost.Enabled = false;
                num_Per_Cost.Value = 0;
            }
            else
            {

                num_Per_Cost.Enabled = true;
                num_Per_Liter.Enabled = false;
                num_Per_Liter.Value = 0;
            }









        }




        private void num_Per_Liter_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is null)
                return;

            Fuel currentFuel = (Fuel)comboBox1.SelectedItem;
            double price = (double)num_Per_Liter.Value;
            lbl_Fuel_Total.Text = Math.Round(currentFuel.Price * price).ToString();
        }

        private void num_Per_Cost_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is null)
                return;
            Fuel currentFuel = (Fuel)comboBox1.SelectedItem;

            lbl_Fuel_Total.Text = Math.Round(num_Per_Cost.Value).ToString();

        }

          
        private void chk_Hot_Dog_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                foreach (Control control in (sender as CheckBox).Parent.Controls)
                {
                    if (control is NumericUpDown num)
                    {
                        num.Enabled = true;
                    }


                }

            }
            else
            {
                foreach (Control control in (sender as CheckBox).Parent.Controls)
                {
                    if (control is NumericUpDown num)
                    {
                        num.Enabled = false;
                      
                    }
                }

            }
            lbl_Cafe_Total.Text = TotalCafe.ToString(); 

        }
        private void num_Cafe_ValueChanged(object sender, EventArgs e)
        {
           

            

        }

        private void num_hotdog_ValueChanged(object sender, EventArgs e)
        {
            

            lbl_Cafe_Total.Text =((double)((decimal.Parse(HamPrice.Text) * num_hamburger.Value) + (decimal.Parse(HotDogPrice.Text) * num_hotdog.Value) + (decimal.Parse(PizzaPrice.Text) * num_Pizza.Value) + (decimal.Parse(ColaPrice.Text) * num_Cola.Value))).ToString();
        }
    }
}