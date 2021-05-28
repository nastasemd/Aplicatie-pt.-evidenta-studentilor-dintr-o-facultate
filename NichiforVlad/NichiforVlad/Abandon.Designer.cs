
namespace NichiforVlad
{
    partial class Abandon
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
            this.lIdAb = new System.Windows.Forms.Label();
            this.lOp = new System.Windows.Forms.Label();
            this.bRenuntare = new System.Windows.Forms.Button();
            this.bConfirmare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idabandonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abandonDS = new NichiforVlad.abandonDS();
            this.bStergere = new System.Windows.Forms.Button();
            this.bModificare = new System.Windows.Forms.Button();
            this.bAdaugare = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter = new NichiforVlad.abandonDSTableAdapters.DataTable1TableAdapter();
            this.lData = new System.Windows.Forms.Label();
            this.lSpecializare = new System.Windows.Forms.Label();
            this.lAnSpec = new System.Windows.Forms.Label();
            this.lNume = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializariDS = new NichiforVlad.specializariDS();
            this.txtAnSpec = new System.Windows.Forms.TextBox();
            this.cmbNume = new System.Windows.Forms.ComboBox();
            this.persoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentiDS = new NichiforVlad.studentiDS();
            this.specializariTableAdapter = new NichiforVlad.specializariDSTableAdapters.SpecializariTableAdapter();
            this.persoaneTableAdapter = new NichiforVlad.studentiDSTableAdapters.PersoaneTableAdapter();
            this.lIdSpec = new System.Windows.Forms.Label();
            this.lIdPers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abandonDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lIdAb
            // 
            this.lIdAb.AutoSize = true;
            this.lIdAb.Location = new System.Drawing.Point(598, 319);
            this.lIdAb.Name = "lIdAb";
            this.lIdAb.Size = new System.Drawing.Size(0, 13);
            this.lIdAb.TabIndex = 31;
            // 
            // lOp
            // 
            this.lOp.AutoSize = true;
            this.lOp.Location = new System.Drawing.Point(831, 30);
            this.lOp.Name = "lOp";
            this.lOp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lOp.Size = new System.Drawing.Size(0, 13);
            this.lOp.TabIndex = 30;
            // 
            // bRenuntare
            // 
            this.bRenuntare.Location = new System.Drawing.Point(720, 29);
            this.bRenuntare.Name = "bRenuntare";
            this.bRenuntare.Size = new System.Drawing.Size(93, 33);
            this.bRenuntare.TabIndex = 29;
            this.bRenuntare.Text = "Renuntare";
            this.bRenuntare.UseVisualStyleBackColor = true;
            this.bRenuntare.Click += new System.EventHandler(this.bRenuntare_Click);
            // 
            // bConfirmare
            // 
            this.bConfirmare.Location = new System.Drawing.Point(601, 29);
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
            this.idabandonDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idspecializareDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.anspecializareDataGridViewTextBoxColumn,
            this.idpersoanaDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 258);
            this.dataGridView1.TabIndex = 27;
            // 
            // idabandonDataGridViewTextBoxColumn
            // 
            this.idabandonDataGridViewTextBoxColumn.DataPropertyName = "id_abandon";
            this.idabandonDataGridViewTextBoxColumn.HeaderText = "id_abandon";
            this.idabandonDataGridViewTextBoxColumn.Name = "idabandonDataGridViewTextBoxColumn";
            this.idabandonDataGridViewTextBoxColumn.ReadOnly = true;
            this.idabandonDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.denumireDataGridViewTextBoxColumn.HeaderText = "denumire specializare";
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
            // idpersoanaDataGridViewTextBoxColumn
            // 
            this.idpersoanaDataGridViewTextBoxColumn.DataPropertyName = "id_persoana";
            this.idpersoanaDataGridViewTextBoxColumn.HeaderText = "id_persoana";
            this.idpersoanaDataGridViewTextBoxColumn.Name = "idpersoanaDataGridViewTextBoxColumn";
            this.idpersoanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersoanaDataGridViewTextBoxColumn.Visible = false;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.abandonDS;
            // 
            // abandonDS
            // 
            this.abandonDS.DataSetName = "abandonDS";
            this.abandonDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bStergere
            // 
            this.bStergere.Location = new System.Drawing.Point(243, 29);
            this.bStergere.Name = "bStergere";
            this.bStergere.Size = new System.Drawing.Size(91, 32);
            this.bStergere.TabIndex = 26;
            this.bStergere.Text = "Stergere";
            this.bStergere.UseVisualStyleBackColor = true;
            this.bStergere.Click += new System.EventHandler(this.bStergere_Click);
            // 
            // bModificare
            // 
            this.bModificare.Location = new System.Drawing.Point(137, 29);
            this.bModificare.Name = "bModificare";
            this.bModificare.Size = new System.Drawing.Size(85, 33);
            this.bModificare.TabIndex = 25;
            this.bModificare.Text = "Modificare";
            this.bModificare.UseVisualStyleBackColor = true;
            this.bModificare.Click += new System.EventHandler(this.bModificare_Click);
            // 
            // bAdaugare
            // 
            this.bAdaugare.Location = new System.Drawing.Point(29, 29);
            this.bAdaugare.Name = "bAdaugare";
            this.bAdaugare.Size = new System.Drawing.Size(87, 33);
            this.bAdaugare.TabIndex = 24;
            this.bAdaugare.Text = "Adaugare";
            this.bAdaugare.UseVisualStyleBackColor = true;
            this.bAdaugare.Click += new System.EventHandler(this.bAdaugare_Click);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(601, 86);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(30, 13);
            this.lData.TabIndex = 32;
            this.lData.Text = "Data";
            // 
            // lSpecializare
            // 
            this.lSpecializare.AutoSize = true;
            this.lSpecializare.Location = new System.Drawing.Point(604, 136);
            this.lSpecializare.Name = "lSpecializare";
            this.lSpecializare.Size = new System.Drawing.Size(64, 13);
            this.lSpecializare.TabIndex = 33;
            this.lSpecializare.Text = "Specializare";
            // 
            // lAnSpec
            // 
            this.lAnSpec.AutoSize = true;
            this.lAnSpec.Location = new System.Drawing.Point(604, 174);
            this.lAnSpec.Name = "lAnSpec";
            this.lAnSpec.Size = new System.Drawing.Size(78, 13);
            this.lAnSpec.TabIndex = 34;
            this.lAnSpec.Text = "An specializare";
            // 
            // lNume
            // 
            this.lNume.AutoSize = true;
            this.lNume.Location = new System.Drawing.Point(604, 211);
            this.lNume.Name = "lNume";
            this.lNume.Size = new System.Drawing.Size(75, 13);
            this.lNume.TabIndex = 35;
            this.lNume.Text = "Nume Student";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(689, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // cmbSpec
            // 
            this.cmbSpec.DataSource = this.specializariBindingSource;
            this.cmbSpec.DisplayMember = "denumire";
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Location = new System.Drawing.Point(706, 136);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(121, 21);
            this.cmbSpec.TabIndex = 37;
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
            this.txtAnSpec.Location = new System.Drawing.Point(706, 174);
            this.txtAnSpec.Name = "txtAnSpec";
            this.txtAnSpec.Size = new System.Drawing.Size(100, 20);
            this.txtAnSpec.TabIndex = 38;
            this.txtAnSpec.Leave += new System.EventHandler(this.txtAnSpec_Leave);
            // 
            // cmbNume
            // 
            this.cmbNume.DataSource = this.persoaneBindingSource;
            this.cmbNume.DisplayMember = "nume";
            this.cmbNume.FormattingEnabled = true;
            this.cmbNume.Location = new System.Drawing.Point(706, 211);
            this.cmbNume.Name = "cmbNume";
            this.cmbNume.Size = new System.Drawing.Size(121, 21);
            this.cmbNume.TabIndex = 39;
            this.cmbNume.ValueMember = "id_persoana";
            // 
            // persoaneBindingSource
            // 
            this.persoaneBindingSource.DataMember = "Persoane";
            this.persoaneBindingSource.DataSource = this.studentiDS;
            // 
            // studentiDS
            // 
            this.studentiDS.DataSetName = "studentiDS";
            this.studentiDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // persoaneTableAdapter
            // 
            this.persoaneTableAdapter.ClearBeforeFill = true;
            // 
            // lIdSpec
            // 
            this.lIdSpec.AutoSize = true;
            this.lIdSpec.Location = new System.Drawing.Point(639, 330);
            this.lIdSpec.Name = "lIdSpec";
            this.lIdSpec.Size = new System.Drawing.Size(0, 13);
            this.lIdSpec.TabIndex = 40;
            // 
            // lIdPers
            // 
            this.lIdPers.AutoSize = true;
            this.lIdPers.Location = new System.Drawing.Point(720, 330);
            this.lIdPers.Name = "lIdPers";
            this.lIdPers.Size = new System.Drawing.Size(0, 13);
            this.lIdPers.TabIndex = 41;
            // 
            // Abandon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 504);
            this.Controls.Add(this.lIdPers);
            this.Controls.Add(this.lIdSpec);
            this.Controls.Add(this.cmbNume);
            this.Controls.Add(this.txtAnSpec);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lNume);
            this.Controls.Add(this.lAnSpec);
            this.Controls.Add(this.lSpecializare);
            this.Controls.Add(this.lData);
            this.Controls.Add(this.lIdAb);
            this.Controls.Add(this.lOp);
            this.Controls.Add(this.bRenuntare);
            this.Controls.Add(this.bConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bStergere);
            this.Controls.Add(this.bModificare);
            this.Controls.Add(this.bAdaugare);
            this.Name = "Abandon";
            this.Text = "Abandon";
            this.Load += new System.EventHandler(this.Abandon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abandonDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lIdAb;
        private System.Windows.Forms.Label lOp;
        private System.Windows.Forms.Button bRenuntare;
        private System.Windows.Forms.Button bConfirmare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bStergere;
        private System.Windows.Forms.Button bModificare;
        private System.Windows.Forms.Button bAdaugare;
        private abandonDS abandonDS;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private abandonDSTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idabandonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anspecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersoanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.Label lSpecializare;
        private System.Windows.Forms.Label lAnSpec;
        private System.Windows.Forms.Label lNume;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.TextBox txtAnSpec;
        private System.Windows.Forms.ComboBox cmbNume;
        private specializariDS specializariDS;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private specializariDSTableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private studentiDS studentiDS;
        private System.Windows.Forms.BindingSource persoaneBindingSource;
        private studentiDSTableAdapters.PersoaneTableAdapter persoaneTableAdapter;
        private System.Windows.Forms.Label lIdSpec;
        private System.Windows.Forms.Label lIdPers;
    }
}