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
    public partial class frmmeglevoadat : Form
    {

        public string eredetirendszam = "";

        // Sebességváltó típusok listájának feltöltése
        void combobetoltes()
        {
            cbvalto.Items.Clear();
            cbvalto.Items.Add("Manuális");
            cbvalto.Items.Add("Automata");
            cbvalto.Items.Add("Félautomata");
        }

        void tablazatbetoltes()
        {
            dgautok.Rows.Clear();
            string keresszoveg = "";

            // Keresés szűrése: rendszámra, márkára vagy kategóriára (fajtára)
            if (txkereses.TextLength > 0)
            {
                keresszoveg = " where rendszam like '" + txkereses.Text + "%' or marka like '" + txkereses.Text + "%' or auto_fajta.fajta like '" + txkereses.Text + "%'";
            }

            // JOIN-t használunk, hogy az auto_fajta_id helyett a kategória nevét (fajta) lássuk
            string lekerdezes = "select autok.rendszam, autok.marka, auto_fajta.fajta from autok " +
                               "join auto_fajta on autok.auto_fajta_id = auto_fajta.auto_fajta_id" +
                               keresszoveg + " order by autok.rendszam";

            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                dgautok.Rows.Add(ab.Dr["rendszam"], ab.Dr["marka"], ab.Dr["fajta"]);
            }
            ab.lezaras();
        }

        // Az összes adatbeviteli mező alaphelyzetbe állítása
        void mezoktorlese()
        {
            txrendszam.Clear();
            txmarka.Clear();
            txtipus.Clear();
            txar.Clear();
            dtevjarat.Value = DateTime.Now;
            cbvalto.SelectedIndex = -1;
            txkapacitas.Clear();
            txteljesitmeny.Clear();
            txkilometer.Clear();
            txhelyszin.Clear();
            txleiras.Clear();
            eredetirendszam = "";
            txrendszam.Enabled = true;
        }

        public frmmeglevoadat()
        {
            InitializeComponent();
            combobetoltes();
            tablazatbetoltes();
            dgautok.ReadOnly = false; // Engedélyezzük a táblázatban való szerkesztést

            // Bekötjük az eseményt, ami akkor fut le, ha a felhasználó közvetlenül a táblázat celláját írja át
            dgautok.CellEndEdit += new DataGridViewCellEventHandler(dgautok_CellEndEdit);
        }

        private void txkereses_TextChanged(object sender, EventArgs e)
        {
            tablazatbetoltes();
        }

        private void dgautok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow sor = dgautok.Rows[e.RowIndex];
                string rendszam = sor.Cells["rendszam"].Value.ToString();
                eredetirendszam = rendszam;

                // Összetett lekérdezés: az autó minden adata + a kapcsolódó táblák (fajta, helyszín) nevei
                string lekerdezes = "select autok.*, auto_fajta.fajta, auto_fajta.leiras, helyszin.varos " +
                                   "from autok " +
                                   "join auto_fajta on autok.auto_fajta_id = auto_fajta.auto_fajta_id " +
                                   "join helyszin on autok.helyszin_id = helyszin.helyszin_id " +
                                   "where autok.rendszam = '" + rendszam + "'";

                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();

                txrendszam.Text = ab.Dr["rendszam"].ToString();
                txmarka.Text = ab.Dr["marka"].ToString();
                txtipus.Text = ab.Dr["fajta"].ToString();
                txar.Text = ab.Dr["ar"].ToString();

                // Évszám kezelése: mivel az adatbázisban csak egy év van, egy fiktív dátumot (Január 1) adunk neki a vezérlőhöz
                int ev = Convert.ToInt32(ab.Dr["evjarat"]);
                dtevjarat.Value = new DateTime(ev, 1, 1);

                cbvalto.Text = ab.Dr["valto"].ToString();
                txkapacitas.Text = ab.Dr["kapacitas"].ToString();
                txteljesitmeny.Text = ab.Dr["teljesitmeny"].ToString();
                txkilometer.Text = ab.Dr["kilometerallas"].ToString();
                txhelyszin.Text = ab.Dr["varos"].ToString();
                txleiras.Text = ab.Dr["leiras"].ToString();

                ab.lezaras();
            }
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            // --- Kötelező mezők ellenőrzése ---
            if (txrendszam.TextLength == 0 || txmarka.TextLength == 0 || txtipus.TextLength == 0 ||
                txar.TextLength == 0 || txkilometer.TextLength == 0 || cbvalto.SelectedIndex == -1 ||
                txhelyszin.TextLength == 0)
            {
                MessageBox.Show("Minden kötelező mezőt töltsön ki!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (eredetirendszam == "")
            {
                MessageBox.Show("Válasszon ki egy autót a módosításhoz!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Autó fajta kezelése (Ha új típust írt be, létrehozzuk)
            string lekerdezes = "select auto_fajta_id from auto_fajta where fajta = '" + txtipus.Text + "'";
            Adatbazis ab = new Adatbazis(lekerdezes);
            int fajtaid = 0;

            if (ab.Dr.Read())
            {
                fajtaid = Convert.ToInt32(ab.Dr["auto_fajta_id"]);
                ab.lezaras();
            }
            else
            {
                ab.lezaras();
                string leirastext = txleiras.TextLength > 0 ? "'" + txleiras.Text + "'" : "NULL";
                lekerdezes = "insert into auto_fajta (fajta, leiras) values ('" + txtipus.Text + "'," + leirastext + ")";
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                ab.lezaras();

                // Újra lekérjük az ID-t a friss beszúrás után
                lekerdezes = "select auto_fajta_id from auto_fajta where fajta = '" + txtipus.Text + "'";
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                fajtaid = Convert.ToInt32(ab.Dr["auto_fajta_id"]);
                ab.lezaras();
            }

            //Helyszín kezelése (Város keresése vagy felvétele)
            lekerdezes = "select helyszin_id from helyszin where varos = '" + txhelyszin.Text + "'";
            ab = new Adatbazis(lekerdezes);
            int helyszinid = 0;

            if (ab.Dr.Read())
            {
                helyszinid = Convert.ToInt32(ab.Dr["helyszin_id"]);
                ab.lezaras();
            }
            else
            {
                ab.lezaras();
                lekerdezes = "insert into helyszin (varos, helyszin_tel, helyszin_email) values ('" + txhelyszin.Text + "','06-1-234-5678','info@autoberles.hu')";
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                ab.lezaras();

                lekerdezes = "select helyszin_id from helyszin where varos = '" + txhelyszin.Text + "'";
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                helyszinid = Convert.ToInt32(ab.Dr["helyszin_id"]);
                ab.lezaras();
            }

            //Rendszám ütközés vizsgálata (ha átírta a rendszámot)
            if (eredetirendszam != txrendszam.Text)
            {
                lekerdezes = "select count(*) as darab from autok where rendszam = '" + txrendszam.Text + "'";
                ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                if (Convert.ToInt32(ab.Dr["darab"]) > 0)
                {
                    MessageBox.Show("Ez az új rendszám már foglalt!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ab.lezaras();
                    return;
                }
                ab.lezaras();
            }

            //Végleges módosítás (UPDATE)
            string kapacitas = txkapacitas.TextLength > 0 ? txkapacitas.Text : "NULL";
            string teljesitmeny = txteljesitmeny.TextLength > 0 ? txteljesitmeny.Text : "NULL";

            lekerdezes = "update autok set rendszam='" + txrendszam.Text + "', marka='" + txmarka.Text + "', ar=" + txar.Text +
                        ", evjarat='" + dtevjarat.Value.Year + "', valto='" + cbvalto.Text + "', kapacitas=" + kapacitas + ", teljesitmeny=" + teljesitmeny +
                        ", kilometerallas=" + txkilometer.Text + ", auto_fajta_id=" + fajtaid + ", helyszin_id=" + helyszinid +
                        " where rendszam='" + eredetirendszam + "'";

            ab = new Adatbazis(lekerdezes);
            ab.Dr.Read();
            ab.lezaras();

            MessageBox.Show("Az autó adatai sikeresen frissültek!", "SIKER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tablazatbetoltes();
            mezoktorlese();
        }

        private void btelvet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni szeretné a beírt adatokat?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mezoktorlese();
            }
        }

        // Közvetlen szerkesztés a táblázatban (ha csak a márkát vagy a típust írja át a rácsban)
        private void dgautok_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sor = dgautok.Rows[e.RowIndex];
            string rendszam = sor.Cells["rendszam"].Value.ToString();
            string ujmarka = sor.Cells["marka"].Value.ToString();
            string ujtipus = sor.Cells["fajta"].Value.ToString();

            // Típus ID ellenőrzése/felvétele
            string lekerdezes = "select auto_fajta_id from auto_fajta where fajta = '" + ujtipus + "'";
            Adatbazis ab = new Adatbazis(lekerdezes);
            int fajtaid = 0;

            if (ab.Dr.Read())
            {
                fajtaid = Convert.ToInt32(ab.Dr["auto_fajta_id"]);
                ab.lezaras();
            }
            else
            {
                ab.lezaras();
                ab = new Adatbazis("insert into auto_fajta (fajta) values ('" + ujtipus + "')");
                ab.Dr.Read(); ab.lezaras();

                ab = new Adatbazis("select auto_fajta_id from auto_fajta where fajta = '" + ujtipus + "'");
                ab.Dr.Read(); fajtaid = Convert.ToInt32(ab.Dr["auto_fajta_id"]);
                ab.lezaras();
            }

            // Csak a márka és a kategória módosítása rendszám alapján
            lekerdezes = "update autok set marka='" + ujmarka + "', auto_fajta_id=" + fajtaid + " where rendszam='" + rendszam + "'";
            ab = new Adatbazis(lekerdezes);
            ab.Dr.Read();
            ab.lezaras();
        }

        private void btvisz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}