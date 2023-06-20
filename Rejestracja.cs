using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KomisAplikacja
{
    public partial class Rejestracja : Form
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public string name;
        public string password;
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string querry = "Select TOP 1 id From Uzytkownicy Order By id Desc";
            db.readDatathroughAdapter(querry, dt);
            int newIndex = int.Parse(dt.Rows[0]["id"].ToString()) +1;

            SqlCommand countUsers = new SqlCommand();
            
            if(nameTxt.Text == "")
            {
                MessageBox.Show("Prosze podać nazwę użytkownika");
            }
            else if (passTxt.Text == "")
            {
                MessageBox.Show("Prosze podać hasło");
            }
            else if (emailTxt.Text == "")
            {
                MessageBox.Show("Prosze podać email");
            }
            else if (telTxt.Text == "")
            {
                MessageBox.Show("Prosze podać numer telefonu");
            }
            else
            {
                string regName = nameTxt.Text;
                string regPass = passTxt.Text;
                string regEmail = emailTxt.Text;
                string regTel = telTxt.Text;
                SqlCommand insertCommand = new SqlCommand("insert into Uzytkownicy(id, nazwa, haslo, telefon, email) values(@id, @regName, @regPass, @regTel, @regEmail)");
                insertCommand.Parameters.AddWithValue("@id", newIndex);
                insertCommand.Parameters.AddWithValue("@regName", regName);
                insertCommand.Parameters.AddWithValue("@regPass", regPass);
                insertCommand.Parameters.AddWithValue("@regTel", regTel);
                insertCommand.Parameters.AddWithValue("@regEmail", regEmail);

                int row = db.executeQuery(insertCommand);
                if(row == 1) 
                { 
                    MessageBox.Show("Twoje konto zostało stworzone!");
                    Hide();
                }
                else { MessageBox.Show("Napotkano błąd. Spróbuj ponownie"); }
            }
        }
    }
}
