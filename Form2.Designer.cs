namespace Pizza
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rdbThick = new System.Windows.Forms.RadioButton();
            this.rdbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chbxTomatoes = new System.Windows.Forms.CheckBox();
            this.chbxOlives = new System.Windows.Forms.CheckBox();
            this.chbxMushrooms = new System.Windows.Forms.CheckBox();
            this.chbxOnion = new System.Windows.Forms.CheckBox();
            this.chbxExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbWhere = new System.Windows.Forms.GroupBox();
            this.rdbTakeOut = new System.Windows.Forms.RadioButton();
            this.rdbEatIn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWhere = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhere.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rdbLarge);
            this.gbSize.Controls.Add(this.rdbMedium);
            this.gbSize.Controls.Add(this.rdbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("El Messiri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(53, 87);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(187, 159);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "*Size";
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.BackColor = System.Drawing.Color.Transparent;
            this.rdbLarge.Location = new System.Drawing.Point(24, 106);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(79, 33);
            this.rdbLarge.TabIndex = 3;
            this.rdbLarge.Tag = "40";
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = false;
            this.rdbLarge.CheckedChanged += new System.EventHandler(this.rdbLarge_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.BackColor = System.Drawing.Color.Transparent;
            this.rdbMedium.Location = new System.Drawing.Point(24, 74);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(99, 33);
            this.rdbMedium.TabIndex = 2;
            this.rdbMedium.Tag = "30";
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = false;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.BackColor = System.Drawing.Color.Transparent;
            this.rdbSmall.Checked = true;
            this.rdbSmall.Location = new System.Drawing.Point(24, 40);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(77, 33);
            this.rdbSmall.TabIndex = 1;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Tag = "20";
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = false;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MODERNIZ", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "➥ Personalize Your Perfect Slice : ";
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gbCrustType.Controls.Add(this.rdbThick);
            this.gbCrustType.Controls.Add(this.rdbThin);
            this.gbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCrustType.Font = new System.Drawing.Font("El Messiri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(287, 87);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(187, 159);
            this.gbCrustType.TabIndex = 4;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "*Crust Type";
            // 
            // rdbThick
            // 
            this.rdbThick.AutoSize = true;
            this.rdbThick.BackColor = System.Drawing.Color.Transparent;
            this.rdbThick.Location = new System.Drawing.Point(24, 74);
            this.rdbThick.Name = "rdbThick";
            this.rdbThick.Size = new System.Drawing.Size(129, 33);
            this.rdbThick.TabIndex = 2;
            this.rdbThick.TabStop = true;
            this.rdbThick.Tag = "10";
            this.rdbThick.Text = "Thick Crust";
            this.rdbThick.UseVisualStyleBackColor = false;
            this.rdbThick.CheckedChanged += new System.EventHandler(this.rdbThick_CheckedChanged);
            // 
            // rdbThin
            // 
            this.rdbThin.AutoSize = true;
            this.rdbThin.BackColor = System.Drawing.Color.Transparent;
            this.rdbThin.Location = new System.Drawing.Point(24, 40);
            this.rdbThin.Name = "rdbThin";
            this.rdbThin.Size = new System.Drawing.Size(121, 33);
            this.rdbThin.TabIndex = 1;
            this.rdbThin.TabStop = true;
            this.rdbThin.Tag = "0";
            this.rdbThin.Text = "Thin Crust";
            this.rdbThin.UseVisualStyleBackColor = false;
            this.rdbThin.CheckedChanged += new System.EventHandler(this.rdbThin_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chbxGreenPeppers);
            this.gbToppings.Controls.Add(this.chbxTomatoes);
            this.gbToppings.Controls.Add(this.chbxOlives);
            this.gbToppings.Controls.Add(this.chbxMushrooms);
            this.gbToppings.Controls.Add(this.chbxOnion);
            this.gbToppings.Controls.Add(this.chbxExtraCheese);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.Font = new System.Drawing.Font("El Messiri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(53, 252);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(400, 159);
            this.gbToppings.TabIndex = 5;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chbxGreenPeppers
            // 
            this.chbxGreenPeppers.AutoSize = true;
            this.chbxGreenPeppers.BackColor = System.Drawing.Color.Transparent;
            this.chbxGreenPeppers.Location = new System.Drawing.Point(234, 75);
            this.chbxGreenPeppers.Name = "chbxGreenPeppers";
            this.chbxGreenPeppers.Size = new System.Drawing.Size(160, 33);
            this.chbxGreenPeppers.TabIndex = 11;
            this.chbxGreenPeppers.Tag = "3";
            this.chbxGreenPeppers.Text = "Green Peppers";
            this.chbxGreenPeppers.UseVisualStyleBackColor = false;
            this.chbxGreenPeppers.CheckedChanged += new System.EventHandler(this.chbxGreenPeppers_CheckedChanged);
            // 
            // chbxTomatoes
            // 
            this.chbxTomatoes.AutoSize = true;
            this.chbxTomatoes.BackColor = System.Drawing.Color.Transparent;
            this.chbxTomatoes.Location = new System.Drawing.Point(114, 75);
            this.chbxTomatoes.Name = "chbxTomatoes";
            this.chbxTomatoes.Size = new System.Drawing.Size(114, 33);
            this.chbxTomatoes.TabIndex = 10;
            this.chbxTomatoes.Tag = "3";
            this.chbxTomatoes.Text = "Tomatoes";
            this.chbxTomatoes.UseVisualStyleBackColor = false;
            this.chbxTomatoes.CheckedChanged += new System.EventHandler(this.chbxTomatoes_CheckedChanged);
            // 
            // chbxOlives
            // 
            this.chbxOlives.AutoSize = true;
            this.chbxOlives.BackColor = System.Drawing.Color.Transparent;
            this.chbxOlives.Location = new System.Drawing.Point(24, 75);
            this.chbxOlives.Name = "chbxOlives";
            this.chbxOlives.Size = new System.Drawing.Size(84, 33);
            this.chbxOlives.TabIndex = 9;
            this.chbxOlives.Tag = "3";
            this.chbxOlives.Text = "Olives";
            this.chbxOlives.UseVisualStyleBackColor = false;
            this.chbxOlives.CheckedChanged += new System.EventHandler(this.chbxOlives_CheckedChanged);
            // 
            // chbxMushrooms
            // 
            this.chbxMushrooms.AutoSize = true;
            this.chbxMushrooms.BackColor = System.Drawing.Color.Transparent;
            this.chbxMushrooms.Location = new System.Drawing.Point(252, 36);
            this.chbxMushrooms.Name = "chbxMushrooms";
            this.chbxMushrooms.Size = new System.Drawing.Size(131, 33);
            this.chbxMushrooms.TabIndex = 8;
            this.chbxMushrooms.Tag = "3";
            this.chbxMushrooms.Text = "Mushrooms";
            this.chbxMushrooms.UseVisualStyleBackColor = false;
            this.chbxMushrooms.CheckedChanged += new System.EventHandler(this.chbxMushrooms_CheckedChanged);
            // 
            // chbxOnion
            // 
            this.chbxOnion.AutoSize = true;
            this.chbxOnion.BackColor = System.Drawing.Color.Transparent;
            this.chbxOnion.Location = new System.Drawing.Point(163, 36);
            this.chbxOnion.Name = "chbxOnion";
            this.chbxOnion.Size = new System.Drawing.Size(83, 33);
            this.chbxOnion.TabIndex = 7;
            this.chbxOnion.Tag = "3";
            this.chbxOnion.Text = "Onion";
            this.chbxOnion.UseVisualStyleBackColor = false;
            this.chbxOnion.CheckedChanged += new System.EventHandler(this.chbxOnion_CheckedChanged);
            // 
            // chbxExtraCheese
            // 
            this.chbxExtraCheese.AutoSize = true;
            this.chbxExtraCheese.BackColor = System.Drawing.Color.Transparent;
            this.chbxExtraCheese.Location = new System.Drawing.Point(24, 36);
            this.chbxExtraCheese.Name = "chbxExtraCheese";
            this.chbxExtraCheese.Size = new System.Drawing.Size(143, 33);
            this.chbxExtraCheese.TabIndex = 6;
            this.chbxExtraCheese.Tag = "3";
            this.chbxExtraCheese.Text = "Extra Cheese";
            this.chbxExtraCheese.UseVisualStyleBackColor = false;
            this.chbxExtraCheese.CheckedChanged += new System.EventHandler(this.chbxExtraCheese_CheckedChanged);
            // 
            // gbWhere
            // 
            this.gbWhere.BackColor = System.Drawing.Color.Transparent;
            this.gbWhere.Controls.Add(this.rdbTakeOut);
            this.gbWhere.Controls.Add(this.rdbEatIn);
            this.gbWhere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWhere.Font = new System.Drawing.Font("El Messiri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhere.Location = new System.Drawing.Point(479, 271);
            this.gbWhere.Name = "gbWhere";
            this.gbWhere.Size = new System.Drawing.Size(187, 140);
            this.gbWhere.TabIndex = 5;
            this.gbWhere.TabStop = false;
            this.gbWhere.Text = "*Where To Eat";
            // 
            // rdbTakeOut
            // 
            this.rdbTakeOut.AutoSize = true;
            this.rdbTakeOut.BackColor = System.Drawing.Color.Transparent;
            this.rdbTakeOut.Location = new System.Drawing.Point(24, 74);
            this.rdbTakeOut.Name = "rdbTakeOut";
            this.rdbTakeOut.Size = new System.Drawing.Size(108, 33);
            this.rdbTakeOut.TabIndex = 2;
            this.rdbTakeOut.TabStop = true;
            this.rdbTakeOut.Text = "Take Out";
            this.rdbTakeOut.UseVisualStyleBackColor = false;
            this.rdbTakeOut.CheckedChanged += new System.EventHandler(this.rdbTakeOut_CheckedChanged);
            // 
            // rdbEatIn
            // 
            this.rdbEatIn.AutoSize = true;
            this.rdbEatIn.BackColor = System.Drawing.Color.Transparent;
            this.rdbEatIn.Location = new System.Drawing.Point(24, 40);
            this.rdbEatIn.Name = "rdbEatIn";
            this.rdbEatIn.Size = new System.Drawing.Size(80, 33);
            this.rdbEatIn.TabIndex = 1;
            this.rdbEatIn.TabStop = true;
            this.rdbEatIn.Text = "Eat In";
            this.rdbEatIn.UseVisualStyleBackColor = false;
            this.rdbEatIn.CheckedChanged += new System.EventHandler(this.rdbEatIn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MODERNIZ", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "‣ Total :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(860, 363);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(70, 48);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "$ 0";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblWhere);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblToppings);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCrustType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("El Messiri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "⁃ Order Summary";
            // 
            // lblWhere
            // 
            this.lblWhere.AutoSize = true;
            this.lblWhere.BackColor = System.Drawing.Color.Transparent;
            this.lblWhere.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhere.Location = new System.Drawing.Point(493, 34);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(0, 25);
            this.lblWhere.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "‣ Where To Eat:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblToppings.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(144, 108);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(115, 25);
            this.lblToppings.TabIndex = 18;
            this.lblToppings.Text = "no toppings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "‣ Toppings:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.BackColor = System.Drawing.Color.Transparent;
            this.lblCrustType.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(156, 68);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(0, 25);
            this.lblCrustType.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "‣ Crust Type:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(91, 34);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 25);
            this.lblSize.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "‣ Size:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("MODERNIZ", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(731, 447);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(189, 66);
            this.btnPlaceOrder.TabIndex = 13;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.Font = new System.Drawing.Font("MODERNIZ", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(731, 537);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(189, 66);
            this.btnResetForm.TabIndex = 14;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza.Properties.Resources.wooden_plate_pita_bread_with_sliced_tomato_onion__Custom_;
            this.ClientSize = new System.Drawing.Size(977, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.gbWhere);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Order Now!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhere.ResumeLayout(false);
            this.gbWhere.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rdbThick;
        private System.Windows.Forms.RadioButton rdbThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbxExtraCheese;
        private System.Windows.Forms.CheckBox chbxTomatoes;
        private System.Windows.Forms.CheckBox chbxOlives;
        private System.Windows.Forms.CheckBox chbxMushrooms;
        private System.Windows.Forms.CheckBox chbxOnion;
        private System.Windows.Forms.CheckBox chbxGreenPeppers;
        private System.Windows.Forms.GroupBox gbWhere;
        private System.Windows.Forms.RadioButton rdbTakeOut;
        private System.Windows.Forms.RadioButton rdbEatIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnResetForm;
    }
}