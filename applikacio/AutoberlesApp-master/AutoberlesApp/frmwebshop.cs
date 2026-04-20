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
    public partial class frmwebshop : Form
    {
        // Ebben a változóban tároljuk el a módosításra kiválasztott tartozék azonosítóját (ID-ját). 
        public int eredetitartozekid = 0;

        void tablazatbetoltes()
        {
            dgtartozek.Rows.Clear(); 
            string keresszoveg = "";

            // Ha a keresőmezőbe írtunk valamit, akkor beállítjuk a szűrést névre vagy kategóriára
            if (txkereses.TextLength > 0)
            {
                keresszoveg = " where tartozek.nev like '" + txkereses.Text + "%' or kategoria.nev like '" + txkereses.Text + "%'";
            }

            // Lekérdezzük a tartozékokat, hozzákapcsolva a kategória táblát, hogy lássuk a kategória nevét is.
            string lekerdezes = "select tartozek.tartozek_id, tartozek.nev, kategoria.nev as kategorianev, tartozek.ar, tartozek.keszlet " +
                               "from tartozek " +
                               "left join kategoria on tartozek.kategoria_id = kategoria.kategoria_id" +
                               keresszoveg + " order by tartozek.nev";
            Adatbazis ab = new Adatbazis(lekerdezes);

            while (ab.Dr.Read())
            {
                string kategorianev = ab.Dr["kategorianev"].ToString();
                // Ha egy tartozéknak nincs kategóriája, adunk neki egy alapértelmezett szöveget
                if (kategorianev.Length == 0)
                    kategorianev = "Nincs kategória";
                dgtartozek.Rows.Add(ab.Dr["tartozek_id"], ab.Dr["nev"], kategorianev, ab.Dr["ar"], ab.Dr["keszlet"]);
            }
            ab.lezaras();
        }

        // Kategóriák betöltése a legördülő menübe
        void combobetoltes()
        {
            cbkategoria.Items.Clear();
            string lekerdezes = "select nev from kategoria order by nev";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                cbkategoria.Items.Add(ab.Dr["nev"].ToString());
            }
            ab.lezaras();
        }


        void mezoktorlese()
        {
            txnev.Clear();
            txleiras.Clear();
            txar.Clear();
            txkeszlet.Clear();
            cbkategoria.SelectedIndex = -1; // Kategória választó alaphelyzetbe tétele
            txnev.Focus();                  
            eredetitartozekid = 0;          // Nullázzuk a kiválasztott ID-t, hiszen üresek a mezők
        }


        public frmwebshop()
        {
            InitializeComponent();
            tablazatbetoltes(); 
            combobetoltes();    
            rbuj.Checked = true; // Alapértelmezetten az "Új felvitele" rádiógomb legyen kiválasztva
            txkereses.TextChanged += txkereses_TextChanged; // Eseménykezelő hozzákötése a keresőmezőhöz
        }

 
        private void txkereses_TextChanged(object sender, EventArgs e)
        {
            tablazatbetoltes();
        }

        private void rbuj_CheckedChanged(object sender, EventArgs e)
        {
            if (rbuj.Checked)
            {
                dgtartozek.Enabled = false; // Kikapcsoljuk a táblázatot (nem kell belőle választani új felvitelnél)
                mezoktorlese();             
            }
        }

        private void rbmod_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmod.Checked)
            {
                dgtartozek.Enabled = true;  // Bekapcsoljuk a táblázatot, hogy lehessen belőle elemet választani
                mezoktorlese();             
            }
        }

        private void dgtartozek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Csak akkor csinálunk valamit, ha érvényes sorra kattintott, "Módosít" módban vagyunk és a tábla aktív
            if (e.RowIndex >= 0 && rbmod.Checked && dgtartozek.Enabled)
            {
                DataGridViewRow sor = dgtartozek.Rows[e.RowIndex];
                int tartozekid = Convert.ToInt32(sor.Cells["tartozek_id"].Value);
                eredetitartozekid = tartozekid; // Eltároljuk a módosítandó elem azonosítóját

                // Lekérdezzük az adatbázisból a kiválasztott tartozék összes adatát
                string lekerdezes = "select tartozek.*, kategoria.nev as kategorianev " +
                                   "from tartozek " +
                                   "left join kategoria on tartozek.kategoria_id = kategoria.kategoria_id " +
                                   "where tartozek.tartozek_id = " + tartozekid;
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();

                txnev.Text = ab.Dr["nev"].ToString();
                txleiras.Text = ab.Dr["leiras"].ToString();
                txar.Text = ab.Dr["ar"].ToString();
                txkeszlet.Text = ab.Dr["keszlet"].ToString();
                cbkategoria.Text = ab.Dr["kategorianev"].ToString();

                ab.lezaras();
                pladatok.Visible = true; 
            }
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            // --- Kötelező mezők ellenőrzése ---
            if (txnev.TextLength == 0)
            {
                MessageBox.Show("Adja meg a tartozék nevét!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txar.TextLength == 0)
            {
                MessageBox.Show("Adja meg az árat!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txkeszlet.TextLength == 0)
            {
                MessageBox.Show("Adja meg a készletet!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Kategória ID kikeresése a kiválasztott kategória név alapján
                int kategoriaid = 0;
                if (cbkategoria.SelectedIndex != -1) // Ha van kiválasztva kategória
                {
                    string lekerdezes = "select kategoria_id from kategoria where nev = '" + cbkategoria.Text + "'";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    if (ab.Dr.Read())
                    {
                        kategoriaid = Convert.ToInt32(ab.Dr["kategoria_id"]);
                    }
                    ab.lezaras();
                }

                // Előkészítjük az SQL értékeket (ha üres, akkor "NULL" szövegként kerül be a parancsba)
                string leirastext = txleiras.TextLength > 0 ? "'" + txleiras.Text + "'" : "NULL";
                string kategoriaidtext = kategoriaid > 0 ? kategoriaid.ToString() : "NULL";

                if (rbuj.Checked)
                {
                    // Ellenőrizzük, hogy létezik-e már ilyen nevű tartozék az adatbázisban
                    string ellenorzes = "select count(*) as darab from tartozek where nev = '" + txnev.Text + "'";
                    Adatbazis abellenorzes = new Adatbazis(ellenorzes);
                    abellenorzes.Dr.Read();
                    int db = Convert.ToInt32(abellenorzes.Dr["darab"]);
                    abellenorzes.lezaras();

                    
                    if (db > 0)
                    {
                        MessageBox.Show("Ilyen nevű tartozék már létezik!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txnev.Clear();
                        txnev.Focus();
                        return; 
                    }

                    // Új tartozék beszúrása az adatbázisba
                    string lekerdezes = "insert into tartozek (nev, leiras, ar, keszlet, kategoria_id, aktiv) " +
                                       "values ('" + txnev.Text + "'," + leirastext + "," + txar.Text + "," + txkeszlet.Text + "," + kategoriaidtext + ", TRUE)";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    ab.lezaras();
                    MessageBox.Show("Sikeres feltöltés!", "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mezoktorlese(); 
                }
        
                else if (rbmod.Checked)
                {
                    // Ha a felhasználó úgy nyomott mentést, hogy nem jelölt ki semmit a táblázatban
                    if (eredetitartozekid == 0)
                    {
                        MessageBox.Show("Válasszon ki egy tartozékot a módosításhoz!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Meglévő tartozék adatainak frissítése 
                        string lekerdezes = "update tartozek set nev='" + txnev.Text + "', leiras=" + leirastext + ", ar=" + txar.Text +
                                           ", keszlet=" + txkeszlet.Text + ", kategoria_id=" + kategoriaidtext + " where tartozek_id=" + eredetitartozekid;
                        Adatbazis ab = new Adatbazis(lekerdezes);
                        ab.Dr.Read();
                        ab.lezaras();
                        MessageBox.Show("Sikeres módosítás!", "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mezoktorlese();
                    }
                }

                tablazatbetoltes();
            }
        }

        
        private void btelvet_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan törölni szeretné az adatokat?", "Biztos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                mezoktorlese();
            }
        }

        
        private void btvisz_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}