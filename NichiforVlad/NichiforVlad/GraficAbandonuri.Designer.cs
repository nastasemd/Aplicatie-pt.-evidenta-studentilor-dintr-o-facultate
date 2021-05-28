
namespace NichiforVlad
{
    partial class GraficAbandonuri
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lAbandon = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statAbandonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficAbandonDS = new NichiforVlad.graficAbandonDS();
            this.statAbandonTableAdapter = new NichiforVlad.graficAbandonDSTableAdapters.statAbandonTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrAbandonuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statAbandonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficAbandonDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lAbandon
            // 
            this.lAbandon.AutoSize = true;
            this.lAbandon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lAbandon.Location = new System.Drawing.Point(62, 26);
            this.lAbandon.Name = "lAbandon";
            this.lAbandon.Size = new System.Drawing.Size(91, 20);
            this.lAbandon.TabIndex = 0;
            this.lAbandon.Text = "Abandonuri";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(96, 63);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(87, 13);
            this.lTotal.TabIndex = 1;
            this.lTotal.Text = "Total abandonuri";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(199, 63);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDataGridViewTextBoxColumn,
            this.nrAbandonuriDataGridViewTextBoxColumn,
            this.Procent});
            this.dataGridView1.DataSource = this.statAbandonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(355, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // statAbandonBindingSource
            // 
            this.statAbandonBindingSource.DataMember = "statAbandon";
            this.statAbandonBindingSource.DataSource = this.graficAbandonDS;
            // 
            // graficAbandonDS
            // 
            this.graficAbandonDS.DataSetName = "graficAbandonDS";
            this.graficAbandonDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statAbandonTableAdapter
            // 
            this.statAbandonTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.statAbandonBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(469, 63);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Numarul de abandonuri";
            series2.XValueMember = "denumire";
            series2.YValueMembers = "NrAbandonuri";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(447, 267);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Specializare";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrAbandonuriDataGridViewTextBoxColumn
            // 
            this.nrAbandonuriDataGridViewTextBoxColumn.DataPropertyName = "NrAbandonuri";
            this.nrAbandonuriDataGridViewTextBoxColumn.HeaderText = "NrAbandonuri";
            this.nrAbandonuriDataGridViewTextBoxColumn.Name = "nrAbandonuriDataGridViewTextBoxColumn";
            this.nrAbandonuriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Procent
            // 
            this.Procent.DataPropertyName = "Procent";
            this.Procent.HeaderText = "Procent";
            this.Procent.Name = "Procent";
            this.Procent.ReadOnly = true;
            // 
            // GraficAbandonuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lAbandon);
            this.Name = "GraficAbandonuri";
            this.Text = "GraficAbandonuri";
            this.Load += new System.EventHandler(this.GraficAbandonuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statAbandonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficAbandonDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAbandon;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private graficAbandonDS graficAbandonDS;
        private System.Windows.Forms.BindingSource statAbandonBindingSource;
        private graficAbandonDSTableAdapters.statAbandonTableAdapter statAbandonTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrAbandonuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procent;
    }
}