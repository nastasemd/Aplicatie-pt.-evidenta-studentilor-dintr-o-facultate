namespace NichiforVlad
{
    partial class Start
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.f1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abandonuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.transferuriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abandonuriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficTransferuriToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.graficAbandonuriToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.anUniversitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specializariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.f1ToolStripMenuItem,
            this.f2ToolStripMenuItem,
            this.graficeToolStripMenuItem,
            this.studentiToolStripMenuItem,
            this.specializariToolStripMenuItem,
            this.anUniversitarToolStripMenuItem,
            this.transferuriToolStripMenuItem1,
            this.abandonuriToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // f1ToolStripMenuItem
            // 
            this.f1ToolStripMenuItem.Name = "f1ToolStripMenuItem";
            this.f1ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.f1ToolStripMenuItem.Text = "Balanta";
            this.f1ToolStripMenuItem.Click += new System.EventHandler(this.f1ToolStripMenuItem_Click);
            // 
            // f2ToolStripMenuItem
            // 
            this.f2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferuriToolStripMenuItem,
            this.abandonuriToolStripMenuItem});
            this.f2ToolStripMenuItem.Name = "f2ToolStripMenuItem";
            this.f2ToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.f2ToolStripMenuItem.Text = "Rapoarte";
            this.f2ToolStripMenuItem.Click += new System.EventHandler(this.f2ToolStripMenuItem_Click);
            // 
            // transferuriToolStripMenuItem
            // 
            this.transferuriToolStripMenuItem.Name = "transferuriToolStripMenuItem";
            this.transferuriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transferuriToolStripMenuItem.Text = "Transferuri";
            this.transferuriToolStripMenuItem.Click += new System.EventHandler(this.transferuriToolStripMenuItem_Click);
            // 
            // abandonuriToolStripMenuItem
            // 
            this.abandonuriToolStripMenuItem.Name = "abandonuriToolStripMenuItem";
            this.abandonuriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abandonuriToolStripMenuItem.Text = "Abandonuri";
            this.abandonuriToolStripMenuItem.Click += new System.EventHandler(this.abandonuriToolStripMenuItem_Click);
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(375, 193);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(179, 20);
            this.txtUtilizator.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(375, 232);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(179, 20);
            this.txtParola.TabIndex = 2;
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(295, 193);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(45, 13);
            this.lblUtilizator.TabIndex = 3;
            this.lblUtilizator.Text = "utilizator";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(295, 232);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(36, 13);
            this.lblParola.TabIndex = 4;
            this.lblParola.Text = "parola";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(188, 85);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(525, 25);
            this.lblTitlu.TabIndex = 5;
            this.lblTitlu.Text = "Aplicatie pt. evidenta studentilor dintr-o facultate";
            this.lblTitlu.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(405, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Login";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // transferuriToolStripMenuItem1
            // 
            this.transferuriToolStripMenuItem1.Name = "transferuriToolStripMenuItem1";
            this.transferuriToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.transferuriToolStripMenuItem1.Text = "Transferuri";
            this.transferuriToolStripMenuItem1.Click += new System.EventHandler(this.transferuriToolStripMenuItem1_Click);
            // 
            // abandonuriToolStripMenuItem1
            // 
            this.abandonuriToolStripMenuItem1.Name = "abandonuriToolStripMenuItem1";
            this.abandonuriToolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.abandonuriToolStripMenuItem1.Text = "Abandonuri";
            this.abandonuriToolStripMenuItem1.Click += new System.EventHandler(this.abandonuriToolStripMenuItem1_Click);
            // 
            // graficeToolStripMenuItem
            // 
            this.graficeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficTransferuriToolStripMenuItem2,
            this.graficAbandonuriToolStripMenuItem2});
            this.graficeToolStripMenuItem.Name = "graficeToolStripMenuItem";
            this.graficeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.graficeToolStripMenuItem.Text = "Grafice";
            this.graficeToolStripMenuItem.Click += new System.EventHandler(this.graficeToolStripMenuItem_Click);
            // 
            // graficTransferuriToolStripMenuItem2
            // 
            this.graficTransferuriToolStripMenuItem2.Name = "graficTransferuriToolStripMenuItem2";
            this.graficTransferuriToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.graficTransferuriToolStripMenuItem2.Text = "Transferuri";
            this.graficTransferuriToolStripMenuItem2.Click += new System.EventHandler(this.graficTransferuriToolStripMenuItem2_Click);
            // 
            // graficAbandonuriToolStripMenuItem2
            // 
            this.graficAbandonuriToolStripMenuItem2.Name = "graficAbandonuriToolStripMenuItem2";
            this.graficAbandonuriToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.graficAbandonuriToolStripMenuItem2.Text = "Abandonuri";
            this.graficAbandonuriToolStripMenuItem2.Click += new System.EventHandler(this.graficAbandonuriToolStripMenuItem2_Click);
            // 
            // anUniversitarToolStripMenuItem
            // 
            this.anUniversitarToolStripMenuItem.Name = "anUniversitarToolStripMenuItem";
            this.anUniversitarToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.anUniversitarToolStripMenuItem.Text = "Ani universitari";
            this.anUniversitarToolStripMenuItem.Click += new System.EventHandler(this.anUniversitarToolStripMenuItem_Click);
            // 
            // specializariToolStripMenuItem
            // 
            this.specializariToolStripMenuItem.Name = "specializariToolStripMenuItem";
            this.specializariToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.specializariToolStripMenuItem.Text = "Specializari";
            this.specializariToolStripMenuItem.Click += new System.EventHandler(this.specializariToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem f1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem f2ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem transferuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abandonuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferuriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abandonuriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem graficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficTransferuriToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem graficAbandonuriToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem anUniversitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specializariToolStripMenuItem;
    }
}