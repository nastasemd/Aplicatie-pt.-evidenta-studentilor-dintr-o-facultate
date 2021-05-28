
namespace NichiforVlad
{
    partial class AniUniversitari
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
            this.components = new System.ComponentModel.Container();
            this.lOp = new System.Windows.Forms.Label();
            this.bRenuntare = new System.Windows.Forms.Button();
            this.bConfirmare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.anuniversitarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarstudentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anUniversitarDS = new NichiforVlad.anUniversitarDS();
            this.bStergere = new System.Windows.Forms.Button();
            this.bModificare = new System.Windows.Forms.Button();
            this.bAdaugare = new System.Windows.Forms.Button();
            this.lIdSpec = new System.Windows.Forms.Label();
            this.lAnUniv = new System.Windows.Forms.Label();
            this.lSpec = new System.Windows.Forms.Label();
            this.lAnSpec = new System.Windows.Forms.Label();
            this.lNrStud = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializariDS = new NichiforVlad.specializariDS();
            this.txtAnSpec = new System.Windows.Forms.TextBox();
            this.txtNrStud = new System.Windows.Forms.TextBox();
            this.specializariTableAdapter = new NichiforVlad.specializariDSTableAdapters.SpecializariTableAdapter();
            this.dataTable1TableAdapter = new NichiforVlad.anUniversitarDSTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anUniversitarDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lOp
            // 
            this.lOp.AutoSize = true;
            this.lOp.Location = new System.Drawing.Point(814, 18);
            this.lOp.Name = "lOp";
            this.lOp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lOp.Size = new System.Drawing.Size(0, 13);
            this.lOp.TabIndex = 30;
            // 
            // bRenuntare
            // 
            this.bRenuntare.Location = new System.Drawing.Point(703, 17);
            this.bRenuntare.Name = "bRenuntare";
            this.bRenuntare.Size = new System.Drawing.Size(93, 33);
            this.bRenuntare.TabIndex = 29;
            this.bRenuntare.Text = "Renuntare";
            this.bRenuntare.UseVisualStyleBackColor = true;
            this.bRenuntare.Click += new System.EventHandler(this.bRenuntare_Click);
            // 
            // bConfirmare
            // 
            this.bConfirmare.Location = new System.Drawing.Point(584, 17);
            this.bConfirmare.Name = "bConfirmare";
            this.bConfirmare.Size = new System.Drawing.Size(95, 33);
            this.bConfirmare.TabIndex = 28;
            this.bConfirmare.Text = "Confirmare";
            this.bConfirmare.UseVisualStyleBackColor = true;
            this.bConfirmare.Click += new System.EventHandler(this.bConfirmare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anuniversitarDataGridViewTextBoxColumn,
            this.idspecializareDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.anspecializareDataGridViewTextBoxColumn,
            this.numarstudentiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 258);
            this.dataGridView1.TabIndex = 27;
            // 
            // anuniversitarDataGridViewTextBoxColumn
            // 
            this.anuniversitarDataGridViewTextBoxColumn.DataPropertyName = "an_universitar";
            this.anuniversitarDataGridViewTextBoxColumn.HeaderText = "an_universitar";
            this.anuniversitarDataGridViewTextBoxColumn.Name = "anuniversitarDataGridViewTextBoxColumn";
            this.anuniversitarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idspecializareDataGridViewTextBoxColumn
            // 
            this.idspecializareDataGridViewTextBoxColumn.DataPropertyName = "id_specializare";
            this.idspecializareDataGridViewTextBoxColumn.HeaderText = "id_specializare";
            this.idspecializareDataGridViewTextBoxColumn.Name = "idspecializareDataGridViewTextBoxColumn";
            this.idspecializareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idspecializareDataGridViewTextBoxColumn.Visible = false;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "denumire";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anspecializareDataGridViewTextBoxColumn
            // 
            this.anspecializareDataGridViewTextBoxColumn.DataPropertyName = "an_specializare";
            this.anspecializareDataGridViewTextBoxColumn.HeaderText = "an_specializare";
            this.anspecializareDataGridViewTextBoxColumn.Name = "anspecializareDataGridViewTextBoxColumn";
            this.anspecializareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numarstudentiDataGridViewTextBoxColumn
            // 
            this.numarstudentiDataGridViewTextBoxColumn.DataPropertyName = "numar_studenti";
            this.numarstudentiDataGridViewTextBoxColumn.HeaderText = "numar_studenti";
            this.numarstudentiDataGridViewTextBoxColumn.Name = "numarstudentiDataGridViewTextBoxColumn";
            this.numarstudentiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.anUniversitarDS;
            // 
            // anUniversitarDS
            // 
            this.anUniversitarDS.DataSetName = "anUniversitarDS";
            this.anUniversitarDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bStergere
            // 
            this.bStergere.Location = new System.Drawing.Point(226, 17);
            this.bStergere.Name = "bStergere";
            this.bStergere.Size = new System.Drawing.Size(91, 32);
            this.bStergere.TabIndex = 26;
            this.bStergere.Text = "Stergere";
            this.bStergere.UseVisualStyleBackColor = true;
            this.bStergere.Click += new System.EventHandler(this.bStergere_Click);
            // 
            // bModificare
            // 
            this.bModificare.Location = new System.Drawing.Point(120, 17);
            this.bModificare.Name = "bModificare";
            this.bModificare.Size = new System.Drawing.Size(85, 33);
            this.bModificare.TabIndex = 25;
            this.bModificare.Text = "Modificare";
            this.bModificare.UseVisualStyleBackColor = true;
            this.bModificare.Click += new System.EventHandler(this.bModificare_Click);
            // 
            // bAdaugare
            // 
            this.bAdaugare.Location = new System.Drawing.Point(12, 17);
            this.bAdaugare.Name = "bAdaugare";
            this.bAdaugare.Size = new System.Drawing.Size(87, 33);
            this.bAdaugare.TabIndex = 24;
            this.bAdaugare.Text = "Adaugare";
            this.bAdaugare.UseVisualStyleBackColor = true;
            this.bAdaugare.Click += new System.EventHandler(this.bAdaugare_Click);
            // 
            // lIdSpec
            // 
            this.lIdSpec.AutoSize = true;
            this.lIdSpec.Location = new System.Drawing.Point(703, 318);
            this.lIdSpec.Name = "lIdSpec";
            this.lIdSpec.Size = new System.Drawing.Size(0, 13);
            this.lIdSpec.TabIndex = 32;
            // 
            // lAnUniv
            // 
            this.lAnUniv.AutoSize = true;
            this.lAnUniv.Location = new System.Drawing.Point(545, 80);
            this.lAnUniv.Name = "lAnUniv";
            this.lAnUniv.Size = new System.Drawing.Size(134, 13);
            this.lAnUniv.TabIndex = 33;
            this.lAnUniv.Text = "Data inceput an universitar";
            // 
            // lSpec
            // 
            this.lSpec.AutoSize = true;
            this.lSpec.Location = new System.Drawing.Point(604, 118);
            this.lSpec.Name = "lSpec";
            this.lSpec.Size = new System.Drawing.Size(64, 13);
            this.lSpec.TabIndex = 34;
            this.lSpec.Text = "Specializare";
            // 
            // lAnSpec
            // 
            this.lAnSpec.AutoSize = true;
            this.lAnSpec.Location = new System.Drawing.Point(588, 151);
            this.lAnSpec.Name = "lAnSpec";
            this.lAnSpec.Size = new System.Drawing.Size(80, 13);
            this.lAnSpec.TabIndex = 35;
            this.lAnSpec.Text = "An Specializare";
            // 
            // lNrStud
            // 
            this.lNrStud.AutoSize = true;
            this.lNrStud.Location = new System.Drawing.Point(588, 187);
            this.lNrStud.Name = "lNrStud";
            this.lNrStud.Size = new System.Drawing.Size(80, 13);
            this.lNrStud.TabIndex = 36;
            this.lNrStud.Text = "Numar Studenti";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(688, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // cmbSpec
            // 
            this.cmbSpec.DataSource = this.specializariBindingSource;
            this.cmbSpec.DisplayMember = "denumire";
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Location = new System.Drawing.Point(688, 115);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(121, 21);
            this.cmbSpec.TabIndex = 38;
            this.cmbSpec.ValueMember = "id_specializare";
            // 
            // specializariBindingSource
            // 
            this.specializariBindingSource.DataMember = "Specializari";
            this.specializariBindingSource.DataSource = this.specializariDS;
            // 
            // specializariDS
            // 
            this.specializariDS.DataSetName = "specializariDS";
            this.specializariDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAnSpec
            // 
            this.txtAnSpec.Location = new System.Drawing.Point(688, 148);
            this.txtAnSpec.Name = "txtAnSpec";
            this.txtAnSpec.Size = new System.Drawing.Size(100, 20);
            this.txtAnSpec.TabIndex = 39;
            this.txtAnSpec.Leave += new System.EventHandler(this.txtAnSpec_Leave);
            // 
            // txtNrStud
            // 
            this.txtNrStud.Location = new System.Drawing.Point(688, 180);
            this.txtNrStud.Name = "txtNrStud";
            this.txtNrStud.Size = new System.Drawing.Size(100, 20);
            this.txtNrStud.TabIndex = 40;
            this.txtNrStud.Leave += new System.EventHandler(this.txtNrStud_Leave);
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // AniUniversitari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.txtNrStud);
            this.Controls.Add(this.txtAnSpec);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lNrStud);
            this.Controls.Add(this.lAnSpec);
            this.Controls.Add(this.lSpec);
            this.Controls.Add(this.lAnUniv);
            this.Controls.Add(this.lIdSpec);
            this.Controls.Add(this.lOp);
            this.Controls.Add(this.bRenuntare);
            this.Controls.Add(this.bConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bStergere);
            this.Controls.Add(this.bModificare);
            this.Controls.Add(this.bAdaugare);
            this.Name = "AniUniversitari";
            this.Text = "AniUniversitari";
            this.Load += new System.EventHandler(this.AniUniversitari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anUniversitarDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lOp;
        private System.Windows.Forms.Button bRenuntare;
        private System.Windows.Forms.Button bConfirmare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bStergere;
        private System.Windows.Forms.Button bModificare;
        private System.Windows.Forms.Button bAdaugare;
        private System.Windows.Forms.Label lIdSpec;
        private System.Windows.Forms.Label lAnUniv;
        private System.Windows.Forms.Label lSpec;
        private System.Windows.Forms.Label lAnSpec;
        private System.Windows.Forms.Label lNrStud;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.TextBox txtAnSpec;
        private System.Windows.Forms.TextBox txtNrStud;
        private specializariDS specializariDS;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private specializariDSTableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private anUniversitarDS anUniversitarDS;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private anUniversitarDSTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn anuniversitarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anspecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarstudentiDataGridViewTextBoxColumn;
    }
}