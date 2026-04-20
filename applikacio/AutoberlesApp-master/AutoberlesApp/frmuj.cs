using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoberlesApp
{
    public partial class frmuj : Form
    {

        void combobetoltes()
        {
            //Váltó típusok manuális betöltése
            cbvalto.Items.Clear();
            cbvalto.Items.Add("Manuális");
            cbvalto.Items.Add("Automata");
            cbvalto.Items.Add("Félautomata");

            //Autó fajták betöltése az adatbázisból
            cbfajta.Items.Clear();
            string lekerdezes = "select fajta from auto_fajta order by fajta";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                cbfajta.Items.Add(ab.Dr["fajta"].ToString());
            }
            ab.lezaras(); 

            //Helyszínek betöltése az adatbázisból
            cbhelyszin.Items.Clear();
            lekerdezes = "select varos, kerulet from helyszin order by varos";
            ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                string varos = ab.Dr["varos"].ToString();
                string kerulet = ab.Dr["kerulet"].ToString();

                // Ha van kerület megadva, akkor "Város - Kerület" formátumban adjuk hozzá, különben csak a várost.
                if (kerulet.Length > 0)
                {
                    cbhelyszin.Items.Add(varos + " - " + kerulet);
                }
                else
                {
                    cbhelyszin.Items.Add(varos);
                }
            }
            ab.lezaras();
        }

        
        void mezoktorlese()
        {
            txrendszam.Clear();
            txmarka.Clear();
            txtipus.Clear();
            txar.Clear();
            dtevjarat.Value = DateTime.Now; // Az évjáratot a mai napra állítja vissza
            cbvalto.SelectedIndex = -1;     // A legördülőkben megszünteti a kiválasztást
            cbfajta.SelectedIndex = -1;
            txkapacitas.Clear();
            txteljesitmeny.Clear();
            txkilometer.Clear();
            cbhelyszin.SelectedIndex = -1;
            txrendszam.Focus();             
        }

        public frmuj()
        {
            InitializeComponent(); 
            combobetoltes();       
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            // --- VALIDÁCIÓ: Ellenőrizzük, hogy minden kötelező mező ki van-e töltve ---
            if (txrendszam.TextLength == 0)
            {
                MessageBox.Show("Adja meg a rendszámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txmarka.TextLength == 0)
            {
                MessageBox.Show("Adja meg a márkát!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtipus.TextLength == 0)
            {
                MessageBox.Show("Adja meg a típust!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txar.TextLength == 0)
            {
                MessageBox.Show("Adja meg az árat!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txkilometer.TextLength == 0)
            {
                MessageBox.Show("Adja meg a kilométer állást!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbvalto.SelectedIndex == -1)
            {
                MessageBox.Show("Válassza ki a sebességváltó fajtáját!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbfajta.SelectedIndex == -1)
            {
                MessageBox.Show("Válassza ki az autó fajtáját!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbhelyszin.SelectedIndex == -1)
            {
                MessageBox.Show("Válassza ki a helyszínt!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  
            else
            {
                // Auto fajta ID (idegen kulcs) lekérdezése a kiválasztott szöveg alapján
                string lekerdezes = "select auto_fajta_id from auto_fajta where fajta = '" + cbfajta.Text + "'";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                int fajtaid = Convert.ToInt32(ab.Dr["auto_fajta_id"]);
                ab.lezaras();

                // Helyszín ID (idegen kulcs) lekérdezése
                string helyszinszoveg = cbhelyszin.Text;
                string varoskereso = helyszinszoveg.Split('-')[0].Trim(); // Kinyerjük a várost a "Város - Kerület" formátumból
                lekerdezes = "select helyszin_id from helyszin where varos = '" + varoskereso + "'";
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                int helyszinid = Convert.ToInt32(ab.Dr["helyszin_id"]);
                ab.lezaras();

                // Ellenőrizzük, hogy létezik-e már ilyen rendszámú autó az adatbázisban
                lekerdezes = "select count(*) as darab from autok where rendszam = '" + txrendszam.Text + "'";
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                int db = Convert.ToInt32(ab.Dr["darab"]);
                ab.lezaras();

                // Ha 'db' értéke 0, azaz nincs még ilyen rendszám
                if (db == 0)
                {
                    // Ha a kapacitás vagy teljesítmény üres, akkor "NULL" értéket adunk át az adatbázisnak
                    string kapacitas = txkapacitas.TextLength > 0 ? txkapacitas.Text : "NULL";
                    string teljesitmeny = txteljesitmeny.TextLength > 0 ? txteljesitmeny.Text : "NULL";

                    // Új autó beszúrása (INSERT) az 'autok' táblába
                    lekerdezes = "insert into autok (rendszam, marka, tipus, ar, evjarat, valto, kapacitas, teljesitmeny, kilometerallas, auto_fajta_id, helyszin_id) " +
                                 "values ('" + txrendszam.Text + "','" + txmarka.Text + "','" + txtipus.Text + "'," + txar.Text + ",'" + dtevjarat.Value.Year + "','" + cbvalto.Text + "'," + kapacitas + "," + teljesitmeny + "," + txkilometer.Text + "," + fajtaid + "," + helyszinid + ")";
                    ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read(); 

                    MessageBox.Show("Sikeres feltöltés!", "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mezoktorlese();
                }
                // Ha már van ilyen rendszám
                else
                {
                    MessageBox.Show("Ilyen rendszám már létezik!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txrendszam.Clear(); 
                    txrendszam.Focus();
                }
            }
        }

      
        private void btelvet_Click(object sender, EventArgs e)
        {
            // Megerősítő ablak megjelenítése, nehogy véletlenül töröljön mindent a felhasználó
            DialogResult valasz = MessageBox.Show("Biztosan törölni szeretné az adatokat?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                mezoktorlese(); 
            }
        }

    
        private void UjAdatForm_Load(object sender, EventArgs e)
        {

        }

        private void btvissza_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}