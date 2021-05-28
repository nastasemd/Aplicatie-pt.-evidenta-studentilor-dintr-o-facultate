
namespace NichiforVlad
{
    partial class Studenti
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
            this.bRenuntare = new System.Windows.Forms.Button();
            this.bConfirmare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bStergere = new System.Windows.Forms.Button();
            this.bModificare = new System.Windows.Forms.Button();
            this.bAdaugare = new System.Windows.Forms.Button();
            this.lOp = new System.Windows.Forms.Label();
            this.lNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lCNP = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.studentiDS = new NichiforVlad.studentiDS();
            this.persoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persoaneTableAdapter = new NichiforVlad.studentiDSTableAdapters.PersoaneTableAdapter();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bRenuntare
            // 
            this.bRenuntare.Location = new System.Drawing.Point(696, 12);
            this.bRenuntare.Name = "bRenuntare";
            this.bRenuntare.Size = new System.Drawing.Size(93, 33);
            this.bRenuntare.TabIndex = 17;
            this.bRenuntare.Text = "Renuntare";
            this.bRenuntare.UseVisualStyleBackColor = true;
            this.bRenuntare.Click += new System.EventHandler(this.bRenuntare_Click);
            // 
            // bConfirmare
            // 
            this.bConfirmare.Location = new System.Drawing.Point(577, 12);
            this.bConfirmare.Name = "bConfirmare";
            this.bConfirmare.Size = new System.Drawing.Size(95, 33);
            this.bConfirmare.TabIndex = 16;
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
            this.numeDataGridViewTextBoxColumn,
            this.cnpDataGridViewTextBoxColumn,
            this.idpersoanaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.persoaneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(506, 258);
            this.dataGridView1.TabIndex = 15;
            // 
            // bStergere
            // 
            this.bStergere.Location = new System.Drawing.Point(219, 12);
            this.bStergere.Name = "bStergere";
            this.bStergere.Size = new System.Drawing.Size(91, 32);
            this.bStergere.TabIndex = 14;
            this.bStergere.Text = "Stergere";
            this.bStergere.UseVisualStyleBackColor = true;
            this.bStergere.Click += new System.EventHandler(this.bStergere_Click);
            // 
            // bModificare
            // 
            this.bModificare.Location = new System.Drawing.Point(113, 12);
            this.bModificare.Name = "bModificare";
            this.bModificare.Size = new System.Drawing.Size(85, 33);
            this.bModificare.TabIndex = 13;
            this.bModificare.Text = "Modificare";
            this.bModificare.UseVisualStyleBackColor = true;
            this.bModificare.Click += new System.EventHandler(this.bModificare_Click);
            // 
            // bAdaugare
            // 
            this.bAdaugare.Location = new System.Drawing.Point(5, 12);
            this.bAdaugare.Name = "bAdaugare";
            this.bAdaugare.Size = new System.Drawing.Size(87, 33);
            this.bAdaugare.TabIndex = 12;
            this.bAdaugare.Text = "Adaugare";
            this.bAdaugare.UseVisualStyleBackColor = true;
            this.bAdaugare.Click += new System.EventHandler(this.bAdaugare_Click);
            // 
            // lOp
            // 
            this.lOp.AutoSize = true;
            this.lOp.Location = new System.Drawing.Point(807, 13);
            this.lOp.Name = "lOp";
            this.lOp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lOp.Size = new System.Drawing.Size(0, 13);
            this.lOp.TabIndex = 18;
            // 
            // lNume
            // 
            this.lNume.AutoSize = true;
            this.lNume.Location = new System.Drawing.Point(610, 69);
            this.lNume.Name = "lNume";
            this.lNume.Size = new System.Drawing.Size(35, 13);
            this.lNume.TabIndex = 19;
            this.lNume.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(651, 69);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 20;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(651, 110);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(100, 20);
            this.txtCNP.TabIndex = 21;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // lCNP
            // 
            this.lCNP.AutoSize = true;
            this.lCNP.Location = new System.Drawing.Point(610, 113);
            this.lCNP.Name = "lCNP";
            this.lCNP.Size = new System.Drawing.Size(29, 13);
            this.lCNP.TabIndex = 22;
            this.lCNP.Text = "CNP";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(574, 302);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(0, 13);
            this.lId.TabIndex = 23;
            // 
            // studentiDS
            // 
            this.studentiDS.DataSetName = "studentiDS";
            this.studentiDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // persoaneBindingSource
            // 
            this.persoaneBindingSource.DataMember = "Persoane";
            this.persoaneBindingSource.DataSource = this.studentiDS;
            // 
            // persoaneTableAdapter
            // 
            this.persoaneTableAdapter.ClearBeforeFill = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpDataGridViewTextBoxColumn
            // 
            this.cnpDataGridViewTextBoxColumn.DataPropertyName = "cnp";
            this.cnpDataGridViewTextBoxColumn.HeaderText = "cnp";
            this.cnpDataGridViewTextBoxColumn.Name = "cnpDataGridViewTextBoxColumn";
            this.cnpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpersoanaDataGridViewTextBoxColumn
            // 
            this.idpersoanaDataGridViewTextBoxColumn.DataPropertyName = "id_persoana";
            this.idpersoanaDataGridViewTextBoxColumn.HeaderText = "id_persoana";
            this.idpersoanaDataGridViewTextBoxColumn.Name = "idpersoanaDataGridViewTextBoxColumn";
            this.idpersoanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpersoanaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lCNP);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lNume);
            this.Controls.Add(this.lOp);
            this.Controls.Add(this.bRenuntare);
            this.Controls.Add(this.bConfirmare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bStergere);
            this.Controls.Add(this.bModificare);
            this.Controls.Add(this.bAdaugare);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentiDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRenuntare;
        private System.Windows.Forms.Button bConfirmare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bStergere;
        private System.Windows.Forms.Button bModificare;
        private System.Windows.Forms.Button bAdaugare;
        private System.Windows.Forms.Label lOp;
        private System.Windows.Forms.Label lNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lCNP;
        private System.Windows.Forms.Label lId;
        private studentiDS studentiDS;
        private System.Windows.Forms.BindingSource persoaneBindingSource;
        private studentiDSTableAdapters.PersoaneTableAdapter persoaneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersoanaDataGridViewTextBoxColumn;
    }
}