using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace AutoberlesApp
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            // Megkeressük a felületen a felhasználónév és jelszó beviteli mezőket név alapján
            TextBox txtUsername = this.Controls["txtUsername"] as TextBox;
            TextBox txtPassword = this.Controls["txtPassword"] as TextBox;

            // --- Üres mezők ellenőrzése ---
            if (txtUsername.TextLength == 0 || txtPassword.TextLength == 0)
            {
                MessageBox.Show("Adja meg a felhasználónevet és a jelszót!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SQL lekérdezés: keressük a felhasználót az adatbázisban a megadott név alapján
                string lekerdezes = "select user_id, password, rang from user where username = '" + txtUsername.Text + "'";
                Adatbazis ab = new Adatbazis(lekerdezes);

                // Ha találtunk ilyen nevű felhasználót
                if (ab.Dr.Read())
                {
                    // Kiolvassuk az adatbázisban tárolt titkosított (hash-elt) jelszót és a rangot
                    string hashjelszo = ab.Dr["password"].ToString();
                    int rang = Convert.ToInt32(ab.Dr["rang"]);

                    // A BCrypt.Verify összehasonlítja a sima szöveges jelszót a titkosítottal
                    if (BCrypt.Net.BCrypt.Verify(txtPassword.Text, hashjelszo))
                    {
                        // Csak akkor engedjük be, ha a rangja eléri a 2-es szintet (pl. admin/moderátor)
                        if (rang >= 2)
                        {
                            MessageBox.Show("Sikeres bejelentkezés!", "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            MainMenuForm mainmenu = new MainMenuForm();
                            mainmenu.Show();
                        }
                        else
                        {
                            // Ha a jelszó jó, de nincs elég joga az app használatához
                            MessageBox.Show("Nincs admin jogosultságod!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Ha a felhasználó létezik, de a jelszó nem egyezik
                        MessageBox.Show("Hibás jelszó!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
                // Ha egyáltalán nem találunk ilyen felhasználónevet az adatbázisban
                else
                {
                    MessageBox.Show("Hibás felhasználónév!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtUsername.Focus();
                }

                ab.lezaras();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}