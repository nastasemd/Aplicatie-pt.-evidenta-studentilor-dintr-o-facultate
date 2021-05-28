namespace NichiforVlad
{
    partial class BalantaStudenti
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculStudenti2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new NichiforVlad.DataSet3();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.datainceputanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasfarsitanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numaraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anspecializareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrstudentiinitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrtransferuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrabandonuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrstudentifinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnInitial = new System.Windows.Forms.Button();
            this.btnTransferuri = new System.Windows.Forms.Button();
            this.btnAbandonuri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculStudenti2TableAdapter = new NichiforVlad.DataSet3TableAdapters.CalculStudenti2TableAdapter();
            this.balantaTableAdapter = new NichiforVlad.DataSet3TableAdapters.BalantaTableAdapter();
            this.operatii_denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainceputanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasfarsitanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataevenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializari_denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarstudentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStudenti2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operatii_denumire,
            this.datainceputanDataGridViewTextBoxColumn,
            this.datasfarsitanDataGridViewTextBoxColumn,
            this.dataevenimentDataGridViewTextBoxColumn,
            this.specializari_denumire,
            this.anspecializareDataGridViewTextBoxColumn,
            this.numarstudentiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculStudenti2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(557, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // calculStudenti2BindingSource
            // 
            this.calculStudenti2BindingSource.DataMember = "CalculStudenti2";
            this.calculStudenti2BindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datainceputanDataGridViewTextBoxColumn1,
            this.datasfarsitanDataGridViewTextBoxColumn1,
            this.denumireDataGridViewTextBoxColumn,
            this.numaraniDataGridViewTextBoxColumn,
            this.anspecializareDataGridViewTextBoxColumn1,
            this.nrstudentiinitialDataGridViewTextBoxColumn,
            this.nrtransferuriDataGridViewTextBoxColumn,
            this.nrabandonuriDataGridViewTextBoxColumn,
            this.nrstudentifinalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.balantaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(575, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(558, 240);
            this.dataGridView2.TabIndex = 1;
            // 
            // datainceputanDataGridViewTextBoxColumn1
            // 
            this.datainceputanDataGridViewTextBoxColumn1.DataPropertyName = "data_inceput_an";
            this.datainceputanDataGridViewTextBoxColumn1.HeaderText = "data_inceput_an";
            this.datainceputanDataGridViewTextBoxColumn1.Name = "datainceputanDataGridViewTextBoxColumn1";
            this.datainceputanDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // datasfarsitanDataGridViewTextBoxColumn1
            // 
            this.datasfarsitanDataGridViewTextBoxColumn1.DataPropertyName = "data_sfarsit_an";
            this.datasfarsitanDataGridViewTextBoxColumn1.HeaderText = "data_sfarsit_an";
            this.datasfarsitanDataGridViewTextBoxColumn1.Name = "datasfarsitanDataGridViewTextBoxColumn1";
            this.datasfarsitanDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "denumire";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numaraniDataGridViewTextBoxColumn
            // 
            this.numaraniDataGridViewTextBoxColumn.DataPropertyName = "numar_ani";
            this.numaraniDataGridViewTextBoxColumn.HeaderText = "numar_ani";
            this.numaraniDataGridViewTextBoxColumn.Name = "numaraniDataGridViewTextBoxColumn";
            this.numaraniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anspecializareDataGridViewTextBoxColumn1
            // 
            this.anspecializareDataGridViewTextBoxColumn1.DataPropertyName = "an_specializare";
            this.anspecializareDataGridViewTextBoxColumn1.HeaderText = "an_specializare";
            this.anspecializareDataGridViewTextBoxColumn1.Name = "anspecializareDataGridViewTextBoxColumn1";
            this.anspecializareDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nrstudentiinitialDataGridViewTextBoxColumn
            // 
            this.nrstudentiinitialDataGridViewTextBoxColumn.DataPropertyName = "nr_studenti_initial";
            this.nrstudentiinitialDataGridViewTextBoxColumn.HeaderText = "nr_studenti_initial";
            this.nrstudentiinitialDataGridViewTextBoxColumn.Name = "nrstudentiinitialDataGridViewTextBoxColumn";
            this.nrstudentiinitialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrtransferuriDataGridViewTextBoxColumn
            // 
            this.nrtransferuriDataGridViewTextBoxColumn.DataPropertyName = "nr_transferuri";
            this.nrtransferuriDataGridViewTextBoxColumn.HeaderText = "nr_transferuri";
            this.nrtransferuriDataGridViewTextBoxColumn.Name = "nrtransferuriDataGridViewTextBoxColumn";
            this.nrtransferuriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrabandonuriDataGridViewTextBoxColumn
            // 
            this.nrabandonuriDataGridViewTextBoxColumn.DataPropertyName = "nr_abandonuri";
            this.nrabandonuriDataGridViewTextBoxColumn.HeaderText = "nr_abandonuri";
            this.nrabandonuriDataGridViewTextBoxColumn.Name = "nrabandonuriDataGridViewTextBoxColumn";
            this.nrabandonuriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrstudentifinalDataGridViewTextBoxColumn
            // 
            this.nrstudentifinalDataGridViewTextBoxColumn.DataPropertyName = "nr_studenti_final";
            this.nrstudentifinalDataGridViewTextBoxColumn.HeaderText = "nr_studenti_final";
            this.nrstudentifinalDataGridViewTextBoxColumn.Name = "nrstudentifinalDataGridViewTextBoxColumn";
            this.nrstudentifinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balantaBindingSource
            // 
            this.balantaBindingSource.DataMember = "Balanta";
            this.balantaBindingSource.DataSource = this.dataSet3;
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(575, 362);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(75, 23);
            this.btnFinal.TabIndex = 2;
            this.btnFinal.Text = "Final";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(656, 362);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(75, 23);
            this.btnInitial.TabIndex = 3;
            this.btnInitial.Text = "Initial";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // btnTransferuri
            // 
            this.btnTransferuri.Location = new System.Drawing.Point(737, 362);
            this.btnTransferuri.Name = "btnTransferuri";
            this.btnTransferuri.Size = new System.Drawing.Size(75, 23);
            this.btnTransferuri.TabIndex = 4;
            this.btnTransferuri.Text = "Transferuri";
            this.btnTransferuri.UseVisualStyleBackColor = true;
            this.btnTransferuri.Click += new System.EventHandler(this.btnTransferuri_Click);
            // 
            // btnAbandonuri
            // 
            this.btnAbandonuri.Location = new System.Drawing.Point(818, 362);
            this.btnAbandonuri.Name = "btnAbandonuri";
            this.btnAbandonuri.Size = new System.Drawing.Size(75, 23);
            this.btnAbandonuri.TabIndex = 5;
            this.btnAbandonuri.Text = "Abandonuri";
            this.btnAbandonuri.UseVisualStyleBackColor = true;
            this.btnAbandonuri.Click += new System.EventHandler(this.btnAbandonuri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calcul studenti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Balanta studenti";
            // 
            // calculStudenti2TableAdapter
            // 
            this.calculStudenti2TableAdapter.ClearBeforeFill = true;
            // 
            // balantaTableAdapter
            // 
            this.balantaTableAdapter.ClearBeforeFill = true;
            // 
            // operatii_denumire
            // 
            this.operatii_denumire.DataPropertyName = "operatii_denumire";
            this.operatii_denumire.HeaderText = "operatii_denumire";
            this.operatii_denumire.Name = "operatii_denumire";
            this.operatii_denumire.ReadOnly = true;
            // 
            // datainceputanDataGridViewTextBoxColumn
            // 
            this.datainceputanDataGridViewTextBoxColumn.DataPropertyName = "data_inceput_an";
            this.datainceputanDataGridViewTextBoxColumn.HeaderText = "data_inceput_an";
            this.datainceputanDataGridViewTextBoxColumn.Name = "datainceputanDataGridViewTextBoxColumn";
            this.datainceputanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datasfarsitanDataGridViewTextBoxColumn
            // 
            this.datasfarsitanDataGridViewTextBoxColumn.DataPropertyName = "data_sfarsit_an";
            this.datasfarsitanDataGridViewTextBoxColumn.HeaderText = "data_sfarsit_an";
            this.datasfarsitanDataGridViewTextBoxColumn.Name = "datasfarsitanDataGridViewTextBoxColumn";
            this.datasfarsitanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataevenimentDataGridViewTextBoxColumn
            // 
            this.dataevenimentDataGridViewTextBoxColumn.DataPropertyName = "data_eveniment";
            this.dataevenimentDataGridViewTextBoxColumn.HeaderText = "data_eveniment";
            this.dataevenimentDataGridViewTextBoxColumn.Name = "dataevenimentDataGridViewTextBoxColumn";
            this.dataevenimentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specializari_denumire
            // 
            this.specializari_denumire.DataPropertyName = "specializari_denumire";
            this.specializari_denumire.HeaderText = "specializari_denumire";
            this.specializari_denumire.Name = "specializari_denumire";
            this.specializari_denumire.ReadOnly = true;
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
            // BalantaStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbandonuri);
            this.Controls.Add(this.btnTransferuri);
            this.Controls.Add(this.btnInitial);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BalantaStudenti";
            this.Text = "Balanta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStudenti2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnInitial;
        private System.Windows.Forms.Button btnTransferuri;
        private System.Windows.Forms.Button btnAbandonuri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource calculStudenti2BindingSource;
        private DataSet3TableAdapters.CalculStudenti2TableAdapter calculStudenti2TableAdapter;
        private System.Windows.Forms.BindingSource balantaBindingSource;
        private DataSet3TableAdapters.BalantaTableAdapter balantaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainceputanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasfarsitanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anspecializareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrstudentiinitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrtransferuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrabandonuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrstudentifinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatii_denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainceputanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasfarsitanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataevenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializari_denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn anspecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarstudentiDataGridViewTextBoxColumn;
    }
}