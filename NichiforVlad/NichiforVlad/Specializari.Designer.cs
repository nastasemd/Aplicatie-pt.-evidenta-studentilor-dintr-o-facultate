
namespace NichiforVlad
{
    partial class Specializari
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
            this.lId = new System.Windows.Forms.Label();
            this.lOp = new System.Windows.Forms.Label();
            this.bRenuntare = new System.Windows.Forms.Button();
            this.bConfirmare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numaraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idspecializareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializariDS = new NichiforVlad.specializariDS();
            this.bStergere = new System.Windows.Forms.Button();
            this.bModificare = new System.Windows.Forms.Button();
            this.bAdaugare = new System.Windows.Forms.Button();
            this.specializariTableAdapter = new NichiforVlad.specializariDSTableAdapters.SpecializariTableAdapter();
            this.lDenumire = new System.Windows.Forms.Label();
            this.lNrAni = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtNrAni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(596, 307);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(0, 13);
            this.lId.TabIndex = 31;
            // 
            // lOp
            // 
            this.lOp.AutoSize = true;
            this.lOp.Location = new System.Drawing.Point(829, 18);
            this.lOp.Name = "lOp";
            this.lOp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lOp.Size = new System.Drawing.Size(0, 13);
            this.lOp.TabIndex = 30;
            // 
            // bRenuntare
            // 
            this.bRenuntare.Location = new System.Drawing.Point(718, 17);
            this.bRenuntare.Name = "bRenuntare";
            this.bRenuntare.Size = new System.Drawing.Size(93, 33);
            this.bRenuntare.TabIndex = 29;
            this.bRenuntare.Text = "Renuntare";
            this.bRenuntare.UseVisualStyleBackColor = true;
            this.bRenuntare.Click += new System.EventHandler(this.bRenuntare_Click);
            // 
            // bConfirmare
            // 
            this.bConfirmare.Location = new System.Drawing.Point(599, 17);
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
            this.denumireDataGridViewTextBoxColumn,
            this.numaraniDataGridViewTextBoxColumn,
            this.idspecializareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.specializariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 258);
            this.dataGridView1.TabIndex = 27;
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
            // idspecializareDataGridViewTextBoxColumn
            // 
            this.idspecializareDataGridViewTextBoxColumn.DataPropertyName = "id_specializare";
            this.idspecializareDataGridViewTextBoxColumn.HeaderText = "id_specializare";
            this.idspecializareDataGridViewTextBoxColumn.Name = "idspecializareDataGridViewTextBoxColumn";
            this.idspecializareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idspecializareDataGridViewTextBoxColumn.Visible = false;
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
            // bStergere
            // 
            this.bStergere.Location = new System.Drawing.Point(241, 17);
            this.bStergere.Name = "bStergere";
            this.bStergere.Size = new System.Drawing.Size(91, 32);
            this.bStergere.TabIndex = 26;
            this.bStergere.Text = "Stergere";
            this.bStergere.UseVisualStyleBackColor = true;
            this.bStergere.Click += new System.EventHandler(this.bStergere_Click);
            // 
            // bModificare
            // 
            this.bModificare.Location = new System.Drawing.Point(135, 17);
            this.bModificare.Name = "bModificare";
            this.bModificare.Size = new System.Drawing.Size(85, 33);
            this.bModificare.TabIndex = 25;
            this.bModificare.Text = "Modificare";
            this.bModificare.UseVisualStyleBackColor = true;
            this.bModificare.Click += new System.EventHandler(this.bModificare_Click);
            // 
            // bAdaugare
            // 
            this.bAdaugare.Location = new System.Drawing.Point(27, 17);
            this.bAdaugare.Name = "bAdaugare";
            this.bAdaugare.Size = new System.Drawing.Size(87, 33);
            this.bAdaugare.TabIndex = 24;
            this.bAdaugare.Text = "Adaugare";
            this.bAdaugare.UseVisualStyleBackColor = true;
            this.bAdaugare.Click += new System.EventHandler(this.bAdaugare_Click);
            // 
            // specializariTableAdapter
            // 
            this.specializariTableAdapter.ClearBeforeFill = true;
            // 
            // lDenumire
            // 
            this.lDenumire.AutoSize = true;
            this.lDenumire.Location = new System.Drawing.Point(642, 78);
            this.lDenumire.Name = "lDenumire";
            this.lDenumire.Size = new System.Drawing.Size(52, 13);
            this.lDenumire.TabIndex = 32;
            this.lDenumire.Text = "Denumire";
            // 
            // lNrAni
            // 
            this.lNrAni.AutoSize = true;
            this.lNrAni.Location = new System.Drawing.Point(642, 124);
            this.lNrAni.Name = "lNrAni";
            this.lNrAni.Size = new System.Drawing.Size(55, 13);
            this.lNrAni.TabIndex = 33;
            this.lNrAni.Text = "Numar ani";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(707, 75);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtDenumire.TabIndex = 34;
            this.txtDenumire.Leave += new System.EventHandler(this.txtDenumire_Leave);
            // 
            // txtNrAni
            // 
            this.txtNrAni.Location = new System.Drawing.Point(704, 121);
            this.txtNrAni.Name = "txtNrAni";
            this.txtNrAni.Size = new System.Drawing.Size(100, 20);
            this.txtNrAni.TabIndex = 35;
            this.txtNrAni.Leave += new System.EventHandler(this.txtNrAni_Leave);
            // 
            // Specializari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.txtNrAni);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.lNrAni);
            this.Controls.Add(this.lDenumire);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lOp);
            this.Controls.Add(this.bRenuntare);
            this.Controls.Add(this.bConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bStergere);
            this.Controls.Add(this.bModificare);
            this.Controls.Add(this.bAdaugare);
            this.Name = "Specializari";
            this.Text = "Specializari";
            this.Load += new System.EventHandler(this.Specializari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializariDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lOp;
        private System.Windows.Forms.Button bRenuntare;
        private System.Windows.Forms.Button bConfirmare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bStergere;
        private System.Windows.Forms.Button bModificare;
        private System.Windows.Forms.Button bAdaugare;
        private specializariDS specializariDS;
        private System.Windows.Forms.BindingSource specializariBindingSource;
        private specializariDSTableAdapters.SpecializariTableAdapter specializariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecializareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lDenumire;
        private System.Windows.Forms.Label lNrAni;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtNrAni;
    }
}