namespace WinF_BestOil
{
    public partial class Form1 : Form
    {
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
        }

        private void rdb_PerLiter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_PerLiter.Checked)
            {
                txt_Per_Liter.ReadOnly = false;
                txt_Per_Cost.ReadOnly = true;
                txt_Per_Cost.Text = String.Empty;
            }
            else
            {
                txt_Per_Liter.ReadOnly = true;
                txt_Per_Cost.ReadOnly = false;
                txt_Per_Liter.Text = String.Empty;
            }
        }
    }
}