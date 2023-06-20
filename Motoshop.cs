using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KomisAplikacja
{
    public partial class Motoshop : Form
    {
        DBAccess db = new DBAccess();
        DataTable carsSearched = new DataTable();
        DataTable offersTable = new DataTable();
        DataTable carsTable = new DataTable();
        DataTable modelsTable = new DataTable();
        DataTable brandsTable = new DataTable();
        DataTable engineTable = new DataTable();
        DataTable fuelTable = new DataTable();

        public Motoshop()
        {
            InitializeComponent();
            string queryCars = "Select * from Samochody";
            string queryOffers = "Select * from Oferty";
            string queryBrand = "Select Distinct marka from Samochody";
            string querryModel = "Select Distinct model from Samochody";
            string querryEngine = "Select Distinct silnik from Samochody";
            string querryFuel = "Select Distinct paliwo from Samochody";

            db.readDatathroughAdapter(queryOffers, offersTable);
            db.readDatathroughAdapter(queryCars, carsTable);
            db.readDatathroughAdapter(queryBrand, brandsTable);
            db.readDatathroughAdapter(querryModel, modelsTable);
            db.readDatathroughAdapter(querryEngine, engineTable);
            db.readDatathroughAdapter(querryFuel, fuelTable);

            dataGridView1.DataSource = carsTable;

            foreach (DataRow row in brandsTable.Rows)
            {
                brandBox.Items.Add(row[0].ToString());
            }
            foreach (DataRow row in modelsTable.Rows)
            {
                modelBox.Items.Add(row[0].ToString());
            }

            foreach (DataRow row in engineTable.Rows)
            {
                engineBox.Items.Add(row[0].ToString());
            }
            foreach (DataRow row in fuelTable.Rows)
            {
                fuelBox.Items.Add(row[0].ToString());
            }

        }

        private void FlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }
        private Label newlabel(string attribute, Point point, string text)
        {
            return new Label
            {
                Text = attribute + ": " + text,
                Location = point,
                Size = new Size(300, 20),
                Font = new Font("arial", 7, FontStyle.Bold)
            };
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            carsSearched = new DataTable();
            string queryCars = "Select * from Samochody";
            db.readDatathroughAdapter(queryCars, carsSearched);
            if (brandBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (row["marka"].ToString() != brandBox.Text) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (modelBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (row["model"].ToString() != modelBox.Text) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (yearMinBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (Int16.Parse(row["rocznik"].ToString()) < Int16.Parse(yearMinBox.Text)) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (yearMaxBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (Int16.Parse(row["rocznik"].ToString()) > Int16.Parse(yearMaxBox.Text)) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (engineBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (row["silnik"].ToString() != engineBox.Text) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (fuelBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (row["paliwo"].ToString() != fuelBox.Text) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (mileageMinBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (Int32.Parse(row["przebieg"].ToString()) < Int32.Parse(mileageMinBox.Text)) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (mileageMaxBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (Int32.Parse(row["przebieg"].ToString()) > Int32.Parse(mileageMaxBox.Text)) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (priceMinBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (Int32.Parse(row["cena"].ToString()) < Int32.Parse(priceMinBox.Text)) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            if (priceMaxBox.Text != "")
            {
                foreach (DataRow row in carsSearched.Rows)
                {
                    if (Int32.Parse(row["cena"].ToString()) > Int32.Parse(priceMaxBox.Text)) { row.Delete(); }
                }
                carsSearched.AcceptChanges();
            }
            dataGridView1.DataSource = carsSearched;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            if(e.RowIndex >= 0)
            {
               string indexText= dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                int index = int.Parse(indexText);
                DataTable carTable1 = new DataTable();
                DataTable sellerTable = new DataTable();
                string querry1 = "Select * from Samochody ORDER BY id ASC" ;
                db.readDatathroughAdapter(querry1, carTable1);
                DataRow car = carTable1.Rows[index-1] ;
               string querry2 = "Select * from Oferty Inner join Uzytkownicy ON Oferty.sprzedajacy = Uzytkownicy.nazwa WHERE Oferty.id_samochodu = '" + index  + "'";
                db.readDatathroughAdapter(querry2, sellerTable);
               Oferta offer = new Oferta(index, car["marka"].ToString(), car["model"].ToString(),
                    car["rocznik"].ToString(), car["silnik"].ToString(), car["paliwo"].ToString(),
                    car["przebieg"].ToString(), car["cena"].ToString(), sellerTable.Rows[0]["sprzedajacy"].ToString(),
                    sellerTable.Rows[0]["telefon"].ToString());
                offer.ShowDialog();
            }
        }
    }
}
