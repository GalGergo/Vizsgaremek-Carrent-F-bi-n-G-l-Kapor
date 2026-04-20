namespace AutoberlesApp
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btbez = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnadmin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnadmin.Location = new System.Drawing.Point(179, 366);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(187, 52);
            this.btnadmin.TabIndex = 0;
            this.btnadmin.Text = "Admin fiók hozzáadása";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnmod.Location = new System.Drawing.Point(498, 203);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(256, 80);
            this.btnmod.TabIndex = 1;
            this.btnmod.Text = "Meglévő adat módosítása";
            this.btnmod.UseVisualStyleBackColor = false;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnuj
            // 
            this.btnuj.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnuj.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnuj.Location = new System.Drawing.Point(38, 203);
            this.btnuj.Name = "btnuj";
            this.btnuj.Size = new System.Drawing.Size(256, 80);
            this.btnuj.TabIndex = 2;
            this.btnuj.Text = "Új adat felvitele";
            this.btnuj.UseVisualStyleBackColor = false;
            this.btnuj.Click += new System.EventHandler(this.btnuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(252, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mit szeretne tenni?";
            // 
            // btbez
            // 
            this.btbez.BackColor = System.Drawing.Color.IndianRed;
            this.btbez.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btbez.Location = new System.Drawing.Point(717, 448);
            this.btbez.Name = "btbez";
            this.btbez.Size = new System.Drawing.Size(80, 30);
            this.btbez.TabIndex = 4;
            this.btbez.Text = "Bezárás";
            this.btbez.UseVisualStyleBackColor = false;
            this.btbez.Click += new System.EventHandler(this.btbez_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(424, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Webshop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoberlesApp.Properties.Resources._6221798;
            this.ClientSize = new System.Drawing.Size(809, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btbez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnuj);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnadmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbez;
        private System.Windows.Forms.Button button1;
    }
}
