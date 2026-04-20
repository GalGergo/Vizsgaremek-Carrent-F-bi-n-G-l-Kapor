using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoberlesApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            UjAdminForm hozzaadas = new UjAdminForm();
            hozzaadas.ShowDialog();
        }

        private void btnuj_Click(object sender, EventArgs e)
        {
            frmuj frmuj = new frmuj();
            frmuj.ShowDialog();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            frmmeglevoadat modositas = new frmmeglevoadat();
            modositas.ShowDialog();
        }

        private void btbez_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmwebshop f = new frmwebshop();
            f.Show();
        }
    }
}
