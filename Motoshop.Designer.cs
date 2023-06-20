namespace KomisAplikacja
{
    partial class Motoshop
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
            this.components = new System.ComponentModel.Container();
            this.Offers = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.samochodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearMinBox = new System.Windows.Forms.ComboBox();
            this.yearMaxBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mileageMinBox = new System.Windows.Forms.ComboBox();
            this.mileageMaxBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.priceMinBox = new System.Windows.Forms.ComboBox();
            this.priceMaxBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.fuelBox = new System.Windows.Forms.ComboBox();
            this.engineBox = new System.Windows.Forms.ComboBox();
            this.modelBox = new System.Windows.Forms.ComboBox();
            this.brandBox = new System.Windows.Forms.ComboBox();
            this.samochodyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.samochodySet = new KomisAplikacja.SamochodySet();
            this.samochodyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.samochodyTableAdapter2 = new KomisAplikacja.SamochodySetTableAdapters.SamochodyTableAdapter();
            this.Offers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodySet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // Offers
            // 
            this.Offers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Offers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Offers.Controls.Add(this.dataGridView1);
            this.Offers.Location = new System.Drawing.Point(180, 62);
            this.Offers.Name = "Offers";
            this.Offers.Size = new System.Drawing.Size(517, 345);
            this.Offers.TabIndex = 0;
            this.Offers.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayout_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 332);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // samochodyBindingSource
            // 
            this.samochodyBindingSource.DataMember = "Samochody";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rocznik";
            // 
            // yearMinBox
            // 
            this.yearMinBox.FormattingEnabled = true;
            this.yearMinBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.yearMinBox.Location = new System.Drawing.Point(12, 158);
            this.yearMinBox.Name = "yearMinBox";
            this.yearMinBox.Size = new System.Drawing.Size(56, 21);
            this.yearMinBox.TabIndex = 6;
            // 
            // yearMaxBox
            // 
            this.yearMaxBox.FormattingEnabled = true;
            this.yearMaxBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.yearMaxBox.Location = new System.Drawing.Point(99, 158);
            this.yearMaxBox.Name = "yearMaxBox";
            this.yearMaxBox.Size = new System.Drawing.Size(56, 21);
            this.yearMaxBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pojemność silnika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rodzaj paliwa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Przebieg";
            // 
            // mileageMinBox
            // 
            this.mileageMinBox.FormattingEnabled = true;
            this.mileageMinBox.Items.AddRange(new object[] {
            "1000",
            "50000",
            "100000",
            "200000",
            "300000",
            "400000",
            "500000"});
            this.mileageMinBox.Location = new System.Drawing.Point(12, 278);
            this.mileageMinBox.Name = "mileageMinBox";
            this.mileageMinBox.Size = new System.Drawing.Size(56, 21);
            this.mileageMinBox.TabIndex = 14;
            // 
            // mileageMaxBox
            // 
            this.mileageMaxBox.FormattingEnabled = true;
            this.mileageMaxBox.Items.AddRange(new object[] {
            "1000",
            "50000",
            "100000",
            "200000",
            "300000",
            "400000",
            "500000"});
            this.mileageMaxBox.Location = new System.Drawing.Point(99, 278);
            this.mileageMaxBox.Name = "mileageMaxBox";
            this.mileageMaxBox.Size = new System.Drawing.Size(56, 21);
            this.mileageMaxBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "do";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cena";
            // 
            // priceMinBox
            // 
            this.priceMinBox.FormattingEnabled = true;
            this.priceMinBox.Items.AddRange(new object[] {
            "1000",
            "3000",
            "5000",
            "7500",
            "10000",
            "30000",
            "50000",
            "100000",
            "200000",
            "300000",
            "500000",
            "1000000"});
            this.priceMinBox.Location = new System.Drawing.Point(12, 318);
            this.priceMinBox.Name = "priceMinBox";
            this.priceMinBox.Size = new System.Drawing.Size(56, 21);
            this.priceMinBox.TabIndex = 18;
            // 
            // priceMaxBox
            // 
            this.priceMaxBox.FormattingEnabled = true;
            this.priceMaxBox.Items.AddRange(new object[] {
            "1000",
            "3000",
            "5000",
            "7500",
            "10000",
            "30000",
            "50000",
            "100000",
            "200000",
            "300000",
            "500000",
            "1000000"});
            this.priceMaxBox.Location = new System.Drawing.Point(99, 318);
            this.priceMaxBox.Name = "priceMaxBox";
            this.priceMaxBox.Size = new System.Drawing.Size(56, 21);
            this.priceMaxBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "do";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(212, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(462, 42);
            this.Title.TabIndex = 21;
            this.Title.Text = "Znajdź swój wymarzony samochód";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(50, 376);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fuelBox
            // 
            this.fuelBox.FormattingEnabled = true;
            this.fuelBox.Location = new System.Drawing.Point(12, 238);
            this.fuelBox.Name = "fuelBox";
            this.fuelBox.Size = new System.Drawing.Size(132, 21);
            this.fuelBox.TabIndex = 12;
            // 
            // engineBox
            // 
            this.engineBox.FormattingEnabled = true;
            this.engineBox.Location = new System.Drawing.Point(12, 198);
            this.engineBox.Name = "engineBox";
            this.engineBox.Size = new System.Drawing.Size(132, 21);
            this.engineBox.TabIndex = 10;
            // 
            // modelBox
            // 
            this.modelBox.FormattingEnabled = true;
            this.modelBox.Location = new System.Drawing.Point(12, 118);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(132, 21);
            this.modelBox.TabIndex = 4;
            // 
            // brandBox
            // 
            this.brandBox.FormattingEnabled = true;
            this.brandBox.Location = new System.Drawing.Point(12, 78);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(132, 21);
            this.brandBox.TabIndex = 1;
            // 
            // samochodyBindingSource1
            // 
            this.samochodyBindingSource1.DataMember = "Samochody";
            // 
            // samochodySet
            // 
            this.samochodySet.DataSetName = "SamochodySet";
            this.samochodySet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // samochodyBindingSource2
            // 
            this.samochodyBindingSource2.DataMember = "Samochody";
            this.samochodyBindingSource2.DataSource = this.samochodySet;
            // 
            // samochodyTableAdapter2
            // 
            this.samochodyTableAdapter2.ClearBeforeFill = true;
            // 
            // Motoshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.priceMaxBox);
            this.Controls.Add(this.priceMinBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mileageMaxBox);
            this.Controls.Add(this.mileageMinBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fuelBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.engineBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearMaxBox);
            this.Controls.Add(this.yearMinBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.Offers);
            this.Name = "Motoshop";
            this.Text = "Motoshop";
            this.Offers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodySet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodyBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Offers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearMinBox;
        private System.Windows.Forms.ComboBox yearMaxBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox mileageMinBox;
        private System.Windows.Forms.ComboBox mileageMaxBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox priceMinBox;
        private System.Windows.Forms.ComboBox priceMaxBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource samochodyBindingSource;
        private System.Windows.Forms.ComboBox fuelBox;
        private System.Windows.Forms.ComboBox engineBox;
        private System.Windows.Forms.ComboBox modelBox;
        private System.Windows.Forms.ComboBox brandBox;
        private System.Windows.Forms.BindingSource samochodyBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SamochodySet samochodySet;
        private System.Windows.Forms.BindingSource samochodyBindingSource2;
        private SamochodySetTableAdapters.SamochodyTableAdapter samochodyTableAdapter2;
    }
}