namespace AutoberlesApp
{
    partial class frmwebshop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgtartozek = new System.Windows.Forms.DataGridView();
            this.txnev = new System.Windows.Forms.TextBox();
            this.txar = new System.Windows.Forms.TextBox();
            this.txleiras = new System.Windows.Forms.TextBox();
            this.txkeszlet = new System.Windows.Forms.TextBox();
            this.pladatok = new System.Windows.Forms.Panel();
            this.rbmod = new System.Windows.Forms.RadioButton();
            this.rbuj = new System.Windows.Forms.RadioButton();
            this.cbkategoria = new System.Windows.Forms.ComboBox();
            this.txkereses = new System.Windows.Forms.TextBox();
            this.btmentes = new System.Windows.Forms.Button();
            this.btelvet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btvisz = new System.Windows.Forms.Button();
            this.tartozek_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keszlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgtartozek)).BeginInit();
            this.pladatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgtartozek
            // 
            this.dgtartozek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtartozek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tartozek_id,
            this.nev,
            this.leiras,
            this.ar,
            this.keszlet});
            this.dgtartozek.Location = new System.Drawing.Point(2, 43);
            this.dgtartozek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgtartozek.Name = "dgtartozek";
            this.dgtartozek.RowHeadersWidth = 51;
            this.dgtartozek.Size = new System.Drawing.Size(647, 295);
            this.dgtartozek.TabIndex = 0;
            this.dgtartozek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtartozek_CellClick);
            // 
            // txnev
            // 
            this.txnev.Location = new System.Drawing.Point(771, 34);
            this.txnev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txnev.MaxLength = 50;
            this.txnev.Name = "txnev";
            this.txnev.Size = new System.Drawing.Size(116, 23);
            this.txnev.TabIndex = 1;
            // 
            // txar
            // 
            this.txar.Location = new System.Drawing.Point(771, 185);
            this.txar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txar.MaxLength = 50;
            this.txar.Name = "txar";
            this.txar.Size = new System.Drawing.Size(93, 23);
            this.txar.TabIndex = 2;
            // 
            // txleiras
            // 
            this.txleiras.Location = new System.Drawing.Point(771, 105);
            this.txleiras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txleiras.MaxLength = 50;
            this.txleiras.Name = "txleiras";
            this.txleiras.Size = new System.Drawing.Size(140, 23);
            this.txleiras.TabIndex = 3;
            // 
            // txkeszlet
            // 
            this.txkeszlet.Location = new System.Drawing.Point(771, 265);
            this.txkeszlet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txkeszlet.MaxLength = 50;
            this.txkeszlet.Name = "txkeszlet";
            this.txkeszlet.Size = new System.Drawing.Size(93, 23);
            this.txkeszlet.TabIndex = 4;
            // 
            // pladatok
            // 
            this.pladatok.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pladatok.Controls.Add(this.rbmod);
            this.pladatok.Controls.Add(this.rbuj);
            this.pladatok.Location = new System.Drawing.Point(698, 410);
            this.pladatok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pladatok.Name = "pladatok";
            this.pladatok.Size = new System.Drawing.Size(147, 80);
            this.pladatok.TabIndex = 5;
            // 
            // rbmod
            // 
            this.rbmod.AutoSize = true;
            this.rbmod.Location = new System.Drawing.Point(14, 48);
            this.rbmod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbmod.Name = "rbmod";
            this.rbmod.Size = new System.Drawing.Size(58, 20);
            this.rbmod.TabIndex = 1;
            this.rbmod.TabStop = true;
            this.rbmod.Text = "mod";
            this.rbmod.UseVisualStyleBackColor = true;
            this.rbmod.CheckedChanged += new System.EventHandler(this.rbmod_CheckedChanged);
            // 
            // rbuj
            // 
            this.rbuj.AutoSize = true;
            this.rbuj.Location = new System.Drawing.Point(14, 13);
            this.rbuj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbuj.Name = "rbuj";
            this.rbuj.Size = new System.Drawing.Size(41, 20);
            this.rbuj.TabIndex = 0;
            this.rbuj.TabStop = true;
            this.rbuj.Text = "uj";
            this.rbuj.UseVisualStyleBackColor = true;
            this.rbuj.CheckedChanged += new System.EventHandler(this.rbuj_CheckedChanged);
            // 
            // cbkategoria
            // 
            this.cbkategoria.FormattingEnabled = true;
            this.cbkategoria.Location = new System.Drawing.Point(771, 353);
            this.cbkategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbkategoria.Name = "cbkategoria";
            this.cbkategoria.Size = new System.Drawing.Size(140, 24);
            this.cbkategoria.TabIndex = 6;
            // 
            // txkereses
            // 
            this.txkereses.Location = new System.Drawing.Point(113, 13);
            this.txkereses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txkereses.Name = "txkereses";
            this.txkereses.Size = new System.Drawing.Size(116, 23);
            this.txkereses.TabIndex = 7;
            this.txkereses.TextChanged += new System.EventHandler(this.txkereses_TextChanged);
            // 
            // btmentes
            // 
            this.btmentes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btmentes.Location = new System.Drawing.Point(179, 385);
            this.btmentes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btmentes.Name = "btmentes";
            this.btmentes.Size = new System.Drawing.Size(128, 67);
            this.btmentes.TabIndex = 8;
            this.btmentes.Text = "ment";
            this.btmentes.UseVisualStyleBackColor = false;
            this.btmentes.Click += new System.EventHandler(this.btmentes_Click);
            // 
            // btelvet
            // 
            this.btelvet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btelvet.Location = new System.Drawing.Point(326, 385);
            this.btelvet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btelvet.Name = "btelvet";
            this.btelvet.Size = new System.Drawing.Size(126, 67);
            this.btelvet.TabIndex = 9;
            this.btelvet.Text = "elvet";
            this.btelvet.UseVisualStyleBackColor = false;
            this.btelvet.Click += new System.EventHandler(this.btelvet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(13, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 77;
            this.label13.Text = "Keresés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(668, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(668, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Leírás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(677, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "Ár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(668, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 81;
            this.label4.Text = "Kategória:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(677, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 81;
            this.label5.Text = "Készlet";
            // 
            // btvisz
            // 
            this.btvisz.BackColor = System.Drawing.Color.IndianRed;
            this.btvisz.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btvisz.Location = new System.Drawing.Point(16, 466);
            this.btvisz.Name = "btvisz";
            this.btvisz.Size = new System.Drawing.Size(78, 34);
            this.btvisz.TabIndex = 78;
            this.btvisz.Text = "Vissza";
            this.btvisz.UseVisualStyleBackColor = false;
            this.btvisz.Click += new System.EventHandler(this.btvisz_Click);
            // 
            // tartozek_id
            // 
            this.tartozek_id.HeaderText = "ID";
            this.tartozek_id.MinimumWidth = 6;
            this.tartozek_id.Name = "tartozek_id";
            this.tartozek_id.Width = 125;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.MinimumWidth = 6;
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 125;
            // 
            // leiras
            // 
            this.leiras.HeaderText = "Leírás";
            this.leiras.MinimumWidth = 6;
            this.leiras.Name = "leiras";
            this.leiras.ReadOnly = true;
            this.leiras.Width = 125;
            // 
            // ar
            // 
            this.ar.HeaderText = "Ár";
            this.ar.MinimumWidth = 6;
            this.ar.Name = "ar";
            this.ar.ReadOnly = true;
            this.ar.Width = 125;
            // 
            // keszlet
            // 
            this.keszlet.HeaderText = "Készlet";
            this.keszlet.MinimumWidth = 6;
            this.keszlet.Name = "keszlet";
            this.keszlet.ReadOnly = true;
            this.keszlet.Width = 125;
            // 
            // frmwebshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoberlesApp.Properties.Resources._6221798;
            this.ClientSize = new System.Drawing.Size(923, 512);
            this.Controls.Add(this.btvisz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btelvet);
            this.Controls.Add(this.btmentes);
            this.Controls.Add(this.txkereses);
            this.Controls.Add(this.cbkategoria);
            this.Controls.Add(this.pladatok);
            this.Controls.Add(this.txkeszlet);
            this.Controls.Add(this.txleiras);
            this.Controls.Add(this.txar);
            this.Controls.Add(this.txnev);
            this.Controls.Add(this.dgtartozek);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmwebshop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmwebshop";
            ((System.ComponentModel.ISupportInitialize)(this.dgtartozek)).EndInit();
            this.pladatok.ResumeLayout(false);
            this.pladatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtartozek;
        private System.Windows.Forms.TextBox txnev;
        private System.Windows.Forms.TextBox txar;
        private System.Windows.Forms.TextBox txleiras;
        private System.Windows.Forms.TextBox txkeszlet;
        private System.Windows.Forms.Panel pladatok;
        private System.Windows.Forms.RadioButton rbmod;
        private System.Windows.Forms.RadioButton rbuj;
        private System.Windows.Forms.ComboBox cbkategoria;
        private System.Windows.Forms.TextBox txkereses;
        private System.Windows.Forms.Button btmentes;
        private System.Windows.Forms.Button btelvet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btvisz;
        private System.Windows.Forms.DataGridViewTextBoxColumn tartozek_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn leiras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn keszlet;
    }
}