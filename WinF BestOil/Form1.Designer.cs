namespace WinF_BestOil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_Per_Cost = new System.Windows.Forms.NumericUpDown();
            this.num_Per_Liter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_FuelType = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_PerCost = new System.Windows.Forms.RadioButton();
            this.rdb_PerLiter = new System.Windows.Forms.RadioButton();
            this.txt_Fuel_Price = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gb_Fuel_Total = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Fuel_Total = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_Cola = new System.Windows.Forms.CheckBox();
            this.ColaPrice = new System.Windows.Forms.TextBox();
            this.num_Cola = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chk_Pizza = new System.Windows.Forms.CheckBox();
            this.PizzaPrice = new System.Windows.Forms.TextBox();
            this.num_Pizza = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chk_Hamburger = new System.Windows.Forms.CheckBox();
            this.HamPrice = new System.Windows.Forms.TextBox();
            this.num_hamburger = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HotDogPrice = new System.Windows.Forms.TextBox();
            this.chk_Hot_Dog = new System.Windows.Forms.CheckBox();
            this.num_hotdog = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_Cafe_Total = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Cafe_Total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Per_Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Per_Liter)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb_Fuel_Total.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Cola)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Pizza)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_hamburger)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_hotdog)).BeginInit();
            this.gb_Cafe_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_Per_Cost);
            this.groupBox1.Controls.Add(this.num_Per_Liter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_FuelType);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_Fuel_Price);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.gb_Fuel_Total);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel Station";
            // 
            // num_Per_Cost
            // 
            this.num_Per_Cost.DecimalPlaces = 2;
            this.num_Per_Cost.Enabled = false;
            this.num_Per_Cost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.num_Per_Cost.InterceptArrowKeys = false;
            this.num_Per_Cost.Location = new System.Drawing.Point(155, 223);
            this.num_Per_Cost.Name = "num_Per_Cost";
            this.num_Per_Cost.Size = new System.Drawing.Size(82, 23);
            this.num_Per_Cost.TabIndex = 16;
            this.num_Per_Cost.ValueChanged += new System.EventHandler(this.num_Per_Cost_ValueChanged);
            // 
            // num_Per_Liter
            // 
            this.num_Per_Liter.DecimalPlaces = 2;
            this.num_Per_Liter.Enabled = false;
            this.num_Per_Liter.InterceptArrowKeys = false;
            this.num_Per_Liter.Location = new System.Drawing.Point(155, 182);
            this.num_Per_Liter.Name = "num_Per_Liter";
            this.num_Per_Liter.Size = new System.Drawing.Size(82, 23);
            this.num_Per_Liter.TabIndex = 15;
            this.num_Per_Liter.ValueChanged += new System.EventHandler(this.num_Per_Liter_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Liter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "₼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "₼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // lbl_FuelType
            // 
            this.lbl_FuelType.AutoSize = true;
            this.lbl_FuelType.Location = new System.Drawing.Point(27, 37);
            this.lbl_FuelType.Name = "lbl_FuelType";
            this.lbl_FuelType.Size = new System.Drawing.Size(56, 15);
            this.lbl_FuelType.TabIndex = 10;
            this.lbl_FuelType.Text = "Fuel Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_PerCost);
            this.panel1.Controls.Add(this.rdb_PerLiter);
            this.panel1.Location = new System.Drawing.Point(18, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 73);
            this.panel1.TabIndex = 9;
            // 
            // rdb_PerCost
            // 
            this.rdb_PerCost.AutoSize = true;
            this.rdb_PerCost.Location = new System.Drawing.Point(19, 42);
            this.rdb_PerCost.Name = "rdb_PerCost";
            this.rdb_PerCost.Size = new System.Drawing.Size(69, 19);
            this.rdb_PerCost.TabIndex = 1;
            this.rdb_PerCost.TabStop = true;
            this.rdb_PerCost.Tag = "cost";
            this.rdb_PerCost.Text = "Per Cost";
            this.rdb_PerCost.UseVisualStyleBackColor = true;
            // 
            // rdb_PerLiter
            // 
            this.rdb_PerLiter.AutoSize = true;
            this.rdb_PerLiter.Location = new System.Drawing.Point(19, 11);
            this.rdb_PerLiter.Name = "rdb_PerLiter";
            this.rdb_PerLiter.Size = new System.Drawing.Size(68, 19);
            this.rdb_PerLiter.TabIndex = 0;
            this.rdb_PerLiter.TabStop = true;
            this.rdb_PerLiter.Tag = "liter";
            this.rdb_PerLiter.Text = "Per Liter";
            this.rdb_PerLiter.UseVisualStyleBackColor = true;
            this.rdb_PerLiter.CheckedChanged += new System.EventHandler(this.rdb_PerLiter_CheckedChanged);
            // 
            // txt_Fuel_Price
            // 
            this.txt_Fuel_Price.Location = new System.Drawing.Point(114, 92);
            this.txt_Fuel_Price.Name = "txt_Fuel_Price";
            this.txt_Fuel_Price.ReadOnly = true;
            this.txt_Fuel_Price.Size = new System.Drawing.Size(121, 23);
            this.txt_Fuel_Price.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gb_Fuel_Total
            // 
            this.gb_Fuel_Total.Controls.Add(this.label7);
            this.gb_Fuel_Total.Controls.Add(this.lbl_Fuel_Total);
            this.gb_Fuel_Total.Location = new System.Drawing.Point(18, 279);
            this.gb_Fuel_Total.Name = "gb_Fuel_Total";
            this.gb_Fuel_Total.Size = new System.Drawing.Size(242, 92);
            this.gb_Fuel_Total.TabIndex = 4;
            this.gb_Fuel_Total.TabStop = false;
            this.gb_Fuel_Total.Text = "Fuel Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(184, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "₼";
            // 
            // lbl_Fuel_Total
            // 
            this.lbl_Fuel_Total.AutoSize = true;
            this.lbl_Fuel_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Fuel_Total.Location = new System.Drawing.Point(116, 46);
            this.lbl_Fuel_Total.Name = "lbl_Fuel_Total";
            this.lbl_Fuel_Total.Size = new System.Drawing.Size(67, 31);
            this.lbl_Fuel_Total.TabIndex = 13;
            this.lbl_Fuel_Total.Text = "0.00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 116);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Cost";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(197, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 78);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(510, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 31);
            this.label10.TabIndex = 16;
            this.label10.Text = "₼";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(442, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 31);
            this.label11.TabIndex = 15;
            this.label11.Text = "0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinF_BestOil.Properties.Resources.icons8_cash_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.gb_Cafe_Total);
            this.groupBox2.Location = new System.Drawing.Point(361, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 388);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mini - Cafe";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chk_Cola);
            this.panel3.Controls.Add(this.ColaPrice);
            this.panel3.Controls.Add(this.num_Cola);
            this.panel3.Location = new System.Drawing.Point(28, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 27);
            this.panel3.TabIndex = 28;
            // 
            // chk_Cola
            // 
            this.chk_Cola.AutoSize = true;
            this.chk_Cola.Location = new System.Drawing.Point(4, 4);
            this.chk_Cola.Name = "chk_Cola";
            this.chk_Cola.Size = new System.Drawing.Size(88, 19);
            this.chk_Cola.TabIndex = 20;
            this.chk_Cola.Text = "Coca - Cola";
            this.chk_Cola.UseVisualStyleBackColor = true;
            this.chk_Cola.CheckedChanged += new System.EventHandler(this.chk_Hot_Dog_CheckedChanged);
            // 
            // ColaPrice
            // 
            this.ColaPrice.Location = new System.Drawing.Point(109, 2);
            this.ColaPrice.Name = "ColaPrice";
            this.ColaPrice.ReadOnly = true;
            this.ColaPrice.Size = new System.Drawing.Size(54, 23);
            this.ColaPrice.TabIndex = 16;
            this.ColaPrice.Text = "2.00";
            // 
            // num_Cola
            // 
            this.num_Cola.Enabled = false;
            this.num_Cola.InterceptArrowKeys = false;
            this.num_Cola.Location = new System.Drawing.Point(193, 0);
            this.num_Cola.Name = "num_Cola";
            this.num_Cola.Size = new System.Drawing.Size(53, 23);
            this.num_Cola.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chk_Pizza);
            this.panel4.Controls.Add(this.PizzaPrice);
            this.panel4.Controls.Add(this.num_Pizza);
            this.panel4.Location = new System.Drawing.Point(28, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 27);
            this.panel4.TabIndex = 29;
            // 
            // chk_Pizza
            // 
            this.chk_Pizza.AutoSize = true;
            this.chk_Pizza.Location = new System.Drawing.Point(4, 4);
            this.chk_Pizza.Name = "chk_Pizza";
            this.chk_Pizza.Size = new System.Drawing.Size(52, 19);
            this.chk_Pizza.TabIndex = 19;
            this.chk_Pizza.Text = "Pizza";
            this.chk_Pizza.UseVisualStyleBackColor = true;
            this.chk_Pizza.CheckedChanged += new System.EventHandler(this.chk_Hot_Dog_CheckedChanged);
            // 
            // PizzaPrice
            // 
            this.PizzaPrice.Location = new System.Drawing.Point(109, 1);
            this.PizzaPrice.Name = "PizzaPrice";
            this.PizzaPrice.ReadOnly = true;
            this.PizzaPrice.Size = new System.Drawing.Size(54, 23);
            this.PizzaPrice.TabIndex = 14;
            this.PizzaPrice.Text = "11.50";
            // 
            // num_Pizza
            // 
            this.num_Pizza.Enabled = false;
            this.num_Pizza.InterceptArrowKeys = false;
            this.num_Pizza.Location = new System.Drawing.Point(193, 2);
            this.num_Pizza.Name = "num_Pizza";
            this.num_Pizza.Size = new System.Drawing.Size(53, 23);
            this.num_Pizza.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chk_Hamburger);
            this.panel5.Controls.Add(this.HamPrice);
            this.panel5.Controls.Add(this.num_hamburger);
            this.panel5.Location = new System.Drawing.Point(28, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 27);
            this.panel5.TabIndex = 29;
            // 
            // chk_Hamburger
            // 
            this.chk_Hamburger.AutoSize = true;
            this.chk_Hamburger.Location = new System.Drawing.Point(3, 5);
            this.chk_Hamburger.Name = "chk_Hamburger";
            this.chk_Hamburger.Size = new System.Drawing.Size(87, 19);
            this.chk_Hamburger.TabIndex = 18;
            this.chk_Hamburger.Text = "Hamburger";
            this.chk_Hamburger.UseVisualStyleBackColor = true;
            this.chk_Hamburger.CheckedChanged += new System.EventHandler(this.chk_Hot_Dog_CheckedChanged);
            // 
            // HamPrice
            // 
            this.HamPrice.Location = new System.Drawing.Point(108, 2);
            this.HamPrice.Name = "HamPrice";
            this.HamPrice.ReadOnly = true;
            this.HamPrice.Size = new System.Drawing.Size(54, 23);
            this.HamPrice.TabIndex = 13;
            this.HamPrice.Text = "4.00";
            // 
            // num_hamburger
            // 
            this.num_hamburger.Enabled = false;
            this.num_hamburger.InterceptArrowKeys = false;
            this.num_hamburger.Location = new System.Drawing.Point(191, 1);
            this.num_hamburger.Name = "num_hamburger";
            this.num_hamburger.Size = new System.Drawing.Size(53, 23);
            this.num_hamburger.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HotDogPrice);
            this.panel2.Controls.Add(this.chk_Hot_Dog);
            this.panel2.Controls.Add(this.num_hotdog);
            this.panel2.Location = new System.Drawing.Point(28, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 27);
            this.panel2.TabIndex = 27;
            // 
            // HotDogPrice
            // 
            this.HotDogPrice.Location = new System.Drawing.Point(109, 3);
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.ReadOnly = true;
            this.HotDogPrice.Size = new System.Drawing.Size(54, 23);
            this.HotDogPrice.TabIndex = 12;
            this.HotDogPrice.Text = "3.70";
            // 
            // chk_Hot_Dog
            // 
            this.chk_Hot_Dog.AutoSize = true;
            this.chk_Hot_Dog.Location = new System.Drawing.Point(4, 7);
            this.chk_Hot_Dog.Name = "chk_Hot_Dog";
            this.chk_Hot_Dog.Size = new System.Drawing.Size(79, 19);
            this.chk_Hot_Dog.TabIndex = 17;
            this.chk_Hot_Dog.Tag = "";
            this.chk_Hot_Dog.Text = "Hot - Dog";
            this.chk_Hot_Dog.UseVisualStyleBackColor = true;
            this.chk_Hot_Dog.CheckedChanged += new System.EventHandler(this.chk_Hot_Dog_CheckedChanged);
            // 
            // num_hotdog
            // 
            this.num_hotdog.Enabled = false;
            this.num_hotdog.InterceptArrowKeys = false;
            this.num_hotdog.Location = new System.Drawing.Point(193, 3);
            this.num_hotdog.Name = "num_hotdog";
            this.num_hotdog.Size = new System.Drawing.Size(53, 23);
            this.num_hotdog.TabIndex = 23;
            this.num_hotdog.ValueChanged += new System.EventHandler(this.num_hotdog_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(220, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Price";
            // 
            // gb_Cafe_Total
            // 
            this.gb_Cafe_Total.Controls.Add(this.label8);
            this.gb_Cafe_Total.Controls.Add(this.lbl_Cafe_Total);
            this.gb_Cafe_Total.Location = new System.Drawing.Point(15, 279);
            this.gb_Cafe_Total.Name = "gb_Cafe_Total";
            this.gb_Cafe_Total.Size = new System.Drawing.Size(266, 92);
            this.gb_Cafe_Total.TabIndex = 5;
            this.gb_Cafe_Total.TabStop = false;
            this.gb_Cafe_Total.Text = "Cafe Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(202, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "₼";
            // 
            // lbl_Cafe_Total
            // 
            this.lbl_Cafe_Total.AutoSize = true;
            this.lbl_Cafe_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cafe_Total.Location = new System.Drawing.Point(134, 46);
            this.lbl_Cafe_Total.Name = "lbl_Cafe_Total";
            this.lbl_Cafe_Total.Size = new System.Drawing.Size(67, 31);
            this.lbl_Cafe_Total.TabIndex = 15;
            this.lbl_Cafe_Total.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Best Oil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Per_Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Per_Liter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Fuel_Total.ResumeLayout(false);
            this.gb_Fuel_Total.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Cola)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Pizza)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_hamburger)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_hotdog)).EndInit();
            this.gb_Cafe_Total.ResumeLayout(false);
            this.gb_Cafe_Total.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_FuelType;
        private Panel panel1;
        private RadioButton rdb_PerCost;
        private RadioButton rdb_PerLiter;
        private TextBox txt_Fuel_Price;
        private ComboBox comboBox1;
        private GroupBox gb_Fuel_Total;
        private Label label7;
        private Label lbl_Fuel_Total;
        private GroupBox groupBox3;
        private Button button1;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Label label13;
        private Label label12;
        private CheckBox chk_Cola;
        private CheckBox chk_Pizza;
        private CheckBox chk_Hamburger;
        private CheckBox chk_Hot_Dog;
        private TextBox ColaPrice;
        private TextBox PizzaPrice;
        private TextBox HamPrice;
        private TextBox HotDogPrice;
        private GroupBox gb_Cafe_Total;
        private Label label8;
        private Label lbl_Cafe_Total;
        private NumericUpDown num_Per_Liter;
        private NumericUpDown num_Per_Cost;
        private NumericUpDown num_Cola;
        private NumericUpDown num_Pizza;
        private NumericUpDown num_hamburger;
        private NumericUpDown num_hotdog;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}