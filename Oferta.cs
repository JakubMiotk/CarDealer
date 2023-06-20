using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KomisAplikacja
{
    public partial class Oferta : Form
    {
        DBAccess db = new DBAccess();
        DataTable data = new DataTable();
        int newIndex = 0;
        int carIndex = 0;
        public Oferta(int carindex, string brandtext, string modeltext, string yeartext,
            string enginetext, string fueltext, string mileagetext, string pricetext, string usernametext, string teltext)
        {
            InitializeComponent();
            carIndex = carindex;
            brand.Text = brandtext;
            model.Text = modeltext;
            year.Text = yeartext;
            engine.Text = enginetext;
            fuel.Text = fueltext;   
            mileage.Text = mileagetext;
            price.Text = pricetext;
            username.Text = usernametext;
            tel.Text = teltext;
            string querry = "Select TOP 1 id_oferty From Oferty Order By id_oferty Desc";
            db.readDatathroughAdapter(querry, data);
            newIndex = int.Parse(data.Rows[0]["id_oferty"].ToString()) + 1;

        }

        private void brand_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            double provision = int.Parse(price.Text) * 0.05;
            SqlCommand insertcommand = new SqlCommand("insert into Sprzedane(id, sprzedajacy, kupujacy, marka, model, rocznik," +
                "silnik, paliwo, przebieg, cena, prowizja, naleznosc, data_sprzedazy ) values(@id, @sprzedajacy, @kupujacy, @marka, @model, @rocznik," +
                "@silnik, @paliwo, @przebieg, @cena, @prowizja, @naleznosc, @data_sprzedazy)");
            insertcommand.Parameters.AddWithValue("@id", newIndex);
            insertcommand.Parameters.AddWithValue("@sprzedajacy", Logowanie.username );
            insertcommand.Parameters.AddWithValue("@kupujacy", username.Text);
            insertcommand.Parameters.AddWithValue("@marka", brand.Text);
            insertcommand.Parameters.AddWithValue("@model", model.Text);
            insertcommand.Parameters.AddWithValue("@rocznik", year.Text);
            insertcommand.Parameters.AddWithValue("@silnik", engine.Text);
            insertcommand.Parameters.AddWithValue("@paliwo", fuel.Text);
            insertcommand.Parameters.AddWithValue("@przebieg", mileage.Text);
            insertcommand.Parameters.AddWithValue("@cena", price.Text);
            insertcommand.Parameters.AddWithValue("@prowizja", provision.ToString());
            insertcommand.Parameters.AddWithValue("@naleznosc", (int.Parse(price.Text) * 0.95).ToString());
            insertcommand.Parameters.AddWithValue("@data_sprzedazy", DateTime.Now.ToString());
            db.executeQuery(insertcommand);
            SqlCommand deletecar = new SqlCommand("Delete From Samochody where id = @id");
            deletecar.Parameters.AddWithValue("@id", carIndex);
            db.executeQuery(deletecar);
            SqlCommand deleteoffer = new SqlCommand("Delete From Oferty where id_samochodu ='" + carIndex + "'");
            db.executeQuery(deleteoffer);
            Hide();
        }
    }
}
