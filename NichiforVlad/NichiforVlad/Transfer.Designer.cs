
namespace NichiforVlad
{
    partial class Transfer
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
            this.lIdSpec = new System.Windows.Forms.Label();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializariDS = new NichiforVlad.specializariDS();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lNume = new System.Windows.Forms.Label();
            this.lAnSpec = new System.Windows.Forms.Label();
            this.lSpecializare = new System.Windows.Forms.Label();
            this.lData = new System.Windows.Forms.Label();
            this.cmbNume = new System.Windows.Forms.ComboBox();
            this.persoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentiDS = new NichiforVlad.studentiDS();
            this.txtAnSpec = new System.Windows.Forms.TextBox();
            this.specializariTableAdapter = new NichiforVlad.specializariDSTableAdapters.SpecializariTableAdapter();
            this.persoaneTableAdapter = new NichiforVlad.studentiDSTableAdapters.PersoaneTableAdapter();
            this.lIdPers = new System.Windows.Forms.Label();
            this.lIdTr = new System.Windows.Forms.Label();
            this.bStergere = new System.Windows.Forms.Button();
            this.lOp = new System.Windows.Forms.Label();
            this.bRenuntare = new System.Windows.Forms.Button();
            this.bConfirmare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpersoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transferDS = new NichiforVlad.transferDS();
            this.bModificare = new System.Windows.Forms.Button();
            this.bAdaugare = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter = new NichiforVlad.transferDSTableAdapters.DataTable1TableAdapter();
            this.anspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtransferDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lIdSpec
            // 
            this.lIdSpec.AutoSize = true;
            this.lIdSpec.Location = new System.Drawing.Point(622, 324);
            this.lIdSpec.Name = "lIdSpec";
            this.lIdSpec.Size = new System.Drawing.Size(0, 13);
            this.lIdSpec.TabIndex = 58;
            // 
            // cmbSpec
            // 
            this.cmbSpec.DataSource = this.specializariBindingSource;
            this.cmbSpec.DisplayMember = "denumire";
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Location = new System.Drawing.Point(689, 130);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(121, 21);
            this.cmbSpec.TabIndex = 55;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(672, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // lNume
            // 
            this.lNume.AutoSize = true;
            this.lNume.Location = new System.Drawing.Point(587, 205);
            this.lNume.Name = "lNume";
            this.lNume.Size = new System.Drawing.Size(75, 13);
            this.lNume.TabIndex = 53;
            this.lNume.Text = "Nume Student";
            // 
            // lAnSpec
            // 
            this.lAnSpec.AutoSize = true;
            this.lAnSpec.Location = new System.Drawing.Point(587, 168);
            this.lAnSpec.Name = "lAnSpec";
            this.lAnSpec.Size = new System.Drawing.Size(78, 13);
            this.lAnSpec.TabIndex = 52;
            this.lAnSpec.Text = "An specializare";
            // 
            // lSpecializare
            // 
            this.lSpecializare.AutoSize = true;
            this.lSpecializare.Location = new System.Drawing.Point(587, 130);
            this.lSpecializare.Name = "lSpecializare";
            this.lSpecializare.Size = new System.Drawing.Size(64, 13);
            this.lSpecializare.TabIndex = 51;
            this.lSpecializare.Text = "Specializare";
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(584, 80);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(30, 13);
            this.lData.TabIndex = 50;
            this.lData.Text = "Data";
            // 
            // cmbNume
            // 
            this.cmbNume.DataSource = this.persoaneBindingSource;
            this.cmbNume.DisplayMember = "nume";
            this.cmbNume.FormattingEnabled = true;
            this.cmbNume.Location = new System.Drawing.Point(689, 205);
            this.cmbNume.Name = "cmbNume";
            this.cmbNume.Size = new System.Drawing.Size(121, 21);
            this.cmbNume.TabIndex = 57;
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
            // txtAnSpec
            // 
            this.txtAnSpec.Location = new System.Drawing.Point(689, 168);
            this.txtAnSpec.Name = "txtAnSpec";
            this.txtAnSpec.Size = new System.Drawing.Size(100, 20);
            this.txtAnSpec.TabIndex = 56;
            this.txtAnSpec.Leave += new System.EventHandler(this.txtAnSpec_Leave);
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // persoaneTableAdapter
            // 
            this.persoaneTableAdapter.ClearBeforeFill = true;
            // 
            // lIdPers
            // 
            this.lIdPers.AutoSize = true;
            this.lIdPers.Location = new System.Drawing.Point(703, 324);
            this.lIdPers.Name = "lIdPers";
            this.lIdPers.Size = new System.Drawing.Size(0, 13);
            this.lIdPers.TabIndex = 59;
            // 
            // lIdTr
            // 
            this.lIdTr.AutoSize = true;
            this.lIdTr.Location = new System.Drawing.Point(581, 313);
            this.lIdTr.Name = "lIdTr";
            this.lIdTr.Size = new System.Drawing.Size(0, 13);
            this.lIdTr.TabIndex = 49;
            // 
            // bStergere
            // 
            this.bStergere.Location = new System.Drawing.Point(226, 23);
            this.bStergere.Name = "bStergere";
            this.bStergere.Size = new System.Drawing.Size(91, 32);
            this.bStergere.TabIndex = 44;
            this.bStergere.Text = "Stergere";
            this.bStergere.UseVisualStyleBackColor = true;
            this.bStergere.Click += new System.EventHandler(this.bStergere_Click);
            // 
            // lOp
            // 
            this.lOp.AutoSize = true;
            this.lOp.Location = new System.Drawing.Point(814, 24);
            this.lOp.Name = "lOp";
            this.lOp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lOp.Size = new System.Drawing.Size(0, 13);
            this.lOp.TabIndex = 48;
            // 
            // bRenuntare
            // 
            this.bRenuntare.Location = new System.Drawing.Point(703, 23);
            this.bRenuntare.Name = "bRenuntare";
            this.bRenuntare.Size = new System.Drawing.Size(93, 33);
            this.bRenuntare.TabIndex = 47;
            this.bRenuntare.Text = "Renuntare";
            this.bRenuntare.UseVisualStyleBackColor = true;
            this.bRenuntare.Click += new System.EventHandler(this.bRenuntare_Click);
            // 
            // bConfirmare
            // 
            this.bConfirmare.Location = new System.Drawing.Point(584, 23);
            this.bConfirmare.Name = "bConfirmare";
            this.bConfirmare.Size = new System.Drawing.Size(95, 33);
            this.bConfirmare.TabIndex = 46;
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
            this.idpersoanaDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.idtransferDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idspecializareDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.anspecializareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 258);
            this.dataGridView1.TabIndex = 45;
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
            this.dataTable1BindingSource.DataSource = this.transferDS;
            // 
            // transferDS
            // 
            this.transferDS.DataSetName = "transferDS";
            this.transferDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bModificare
            // 
            this.bModificare.Location = new System.Drawing.Point(120, 23);
            this.bModificare.Name = "bModificare";
            this.bModificare.Size = new System.Drawing.Size(85, 33);
            this.bModificare.TabIndex = 43;
            this.bModificare.Text = "Modificare";
            this.bModificare.UseVisualStyleBackColor = true;
            this.bModificare.Click += new System.EventHandler(this.bModificare_Click);
            // 
            // bAdaugare
            // 
            this.bAdaugare.Location = new System.Drawing.Point(12, 23);
            this.bAdaugare.Name = "bAdaugare";
            this.bAdaugare.Size = new System.Drawing.Size(87, 33);
            this.bAdaugare.TabIndex = 42;
            this.bAdaugare.Text = "Adaugare";
            this.bAdaugare.UseVisualStyleBackColor = true;
            this.bAdaugare.Click += new System.EventHandler(this.bAdaugare_Click);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // anspecializareDataGridViewTextBoxColumn
            // 
            this.anspecializareDataGridViewTextBoxColumn.DataPropertyName = "an_specializare";
            this.anspecializareDataGridViewTextBoxColumn.HeaderText = "an_specializare";
            this.anspecializareDataGridViewTextBoxColumn.Name = "anspecializareDataGridViewTextBoxColumn";
            this.anspecializareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "denumire";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idspecializareDataGridViewTextBoxColumn
            // 
            this.idspecializareDataGridViewTextBoxColumn.DataPropertyName = "id_specializare";
            this.idspecializareDataGridViewTextBoxColumn.HeaderText = "id_specializare";
            this.idspecializareDataGridViewTextBoxColumn.Name = "idspecializareDataGridViewTextBoxColumn";
            this.idspecializareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idspecializareDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtransferDataGridViewTextBoxColumn
            // 
            this.idtransferDataGridViewTextBoxColumn.DataPropertyName = "id_transfer";
            this.idtransferDataGridViewTextBoxColumn.HeaderText = "id_transfer";
            this.idtransferDataGridViewTextBoxColumn.Name = "idtransferDataGridViewTextBoxColumn";
            this.idtransferDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtransferDataGridViewTextBoxColumn.Visible = false;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.lIdSpec);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lNume);
            this.Controls.Add(this.lAnSpec);
            this.Controls.Add(this.lSpecializare);
            this.Controls.Add(this.lData);
            this.Controls.Add(this.cmbNume);
            this.Controls.Add(this.txtAnSpec);
            this.Controls.Add(this.lIdPers);
            this.Controls.Add(this.lIdTr);
            this.Controls.Add(this.bStergere);
            this.Controls.Add(this.lOp);
            this.Controls.Add(this.bRenuntare);
            this.Controls.Add(this.bConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bModificare);
            this.Controls.Add(this.bAdaugare);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lIdSpec;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private specializariDS specializariDS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lNume;
        private System.Windows.Forms.Label lAnSpec;
        private System.Windows.Forms.Label lSpecializare;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.ComboBox cmbNume;
        private System.Windows.Forms.BindingSource persoaneBindingSource;
        private studentiDS studentiDS;
        private System.Windows.Forms.TextBox txtAnSpec;
        private specializariDSTableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private studentiDSTableAdapters.PersoaneTableAdapter persoaneTableAdapter;
        private System.Windows.Forms.Label lIdPers;
        private System.Windows.Forms.Label lIdTr;
        private System.Windows.Forms.Button bStergere;
        private System.Windows.Forms.Label lOp;
        private System.Windows.Forms.Button bRenuntare;
        private System.Windows.Forms.Button bConfirmare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bModificare;
        private System.Windows.Forms.Button bAdaugare;
        private transferDS transferDS;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private transferDSTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersoanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransferDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anspecializareDataGridViewTextBoxColumn;
    }
}