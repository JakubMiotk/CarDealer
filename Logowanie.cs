using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomisAplikacja
{
    public partial class Logowanie : Form
    {
        DBAccess db = new DBAccess();
        DataTable usersTable = new DataTable();
        public static string username;
        public Logowanie()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OpenRegister_Click(object sender, EventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(usernameTxt.Text == "")
            {
                MessageBox.Show("Wprowadź nazwę użytkownika!");
            }
            else if(passwordTxt.Text == "")
            {
                MessageBox.Show("Wprowadź hasło!");
            }
            else
            {
                username = usernameTxt.Text;
                string password = passwordTxt.Text;

                string query = "Select * from Uzytkownicy Where nazwa = '" + username + "' AND haslo = '" + password + "'";
                db.readDatathroughAdapter(query, usersTable);

                if(usersTable.Rows.Count == 1) 
                { 
                    MessageBox.Show("Zalogowanie powiodło się. Witaj ponownie!");
                    Motoshop motoshop = new Motoshop();
                    Hide();
                    motoshop.Show();
                }
                else { MessageBox.Show("Logowanie nie powiodło się. Wprowadź poprawne dane"); }
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
