using BCrypt.Net;
using Mysqlx.Crud;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AutoberlesApp
{
    public partial class UjAdminForm : Form
    {
        public UjAdminForm()
        {
            InitializeComponent();
        }

        private void UjAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btvissza_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            // A beviteli mezők (TextBox-ok) példányosítása a nevük alapján a Controls gyűjteményből
            TextBox txtUsername = this.Controls["txtUsername"] as TextBox;
            TextBox txtPassword = this.Controls["txtPassword"] as TextBox;
            TextBox txtemail = this.Controls["txtemail"] as TextBox;

            // Üres mezők ellenőrzése (minden adat kötelező)
            if (txtUsername.TextLength == 0 || txtPassword.TextLength == 0 || txtemail.TextLength == 0)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Jelszó hosszának ellenőrzése (biztonsági minimum: 6 karakter)
                if (txtPassword.TextLength < 6)
                {
                    MessageBox.Show("A jelszónak legalább 6 karakter hosszúnak kell lennie!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
                else
                {
                    // Ellenőrizzük, hogy a választott felhasználónév foglalt-e már
                    string lekerdezes = "select count(*) as darab from user where username = '" + txtUsername.Text + "'";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    int db = Convert.ToInt32(ab.Dr["darab"]);
                    ab.lezaras();

                    if (db == 0)
                    {
                        // --- JELSZÓ TITKOSÍTÁSA (Hashing) ---
                     
                        string hashjelszo = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

                        // Az új felhasználó beszúrása az adatbázisba
                        // A 'rang' értékét fixen 2-re állítjuk
                        lekerdezes = "INSERT INTO `user` (username, password, rang, email) VALUES " +
                                      "('" + txtUsername.Text + "', '" + hashjelszo + "', 2, '" + txtemail.Text + "')";
                        ab = new Adatbazis(lekerdezes);
                        ab.Dr.Read();

                        MessageBox.Show("Sikeres admin regisztráció!", "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        // Ha a felhasználónév már létezik az adatbázisban
                        MessageBox.Show("Ilyen felhasználónév már létezik!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtUsername.Focus();
                    }
                }
            }
        }
    }
}