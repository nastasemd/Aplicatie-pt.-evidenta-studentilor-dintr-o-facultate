
namespace NichiforVlad
{
    partial class GraficTransferuri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lTotal = new System.Windows.Forms.Label();
            this.lTransfer = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statTransferuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graficTransferDS = new NichiforVlad.graficTransferDS();
            this.statTransferuriTableAdapter = new NichiforVlad.graficTransferDSTableAdapters.statTransferuriTableAdapter();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTransferuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statTransferuriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficTransferDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireDataGridViewTextBoxColumn,
            this.nrTransferuriDataGridViewTextBoxColumn,
            this.procentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statTransferuriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(416, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(164, 53);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(61, 53);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(80, 13);
            this.lTotal.TabIndex = 6;
            this.lTotal.Text = "Total transferuri";
            // 
            // lTransfer
            // 
            this.lTransfer.AutoSize = true;
            this.lTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lTransfer.Location = new System.Drawing.Point(27, 16);
            this.lTransfer.Name = "lTransfer";
            this.lTransfer.Size = new System.Drawing.Size(85, 20);
            this.lTransfer.TabIndex = 5;
            this.lTransfer.Text = "Transferuri";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.statTransferuriBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(502, 43);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Numarul de transferuri";
            series2.XValueMember = "denumire";
            series2.YValueMembers = "NrTransferuri";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(402, 273);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // statTransferuriBindingSource
            // 
            this.statTransferuriBindingSource.DataMember = "statTransferuri";
            this.statTransferuriBindingSource.DataSource = this.graficTransferDS;
            // 
            // graficTransferDS
            // 
            this.graficTransferDS.DataSetName = "graficTransferDS";
            this.graficTransferDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statTransferuriTableAdapter
            // 
            this.statTransferuriTableAdapter.ClearBeforeFill = true;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "Specializare";
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrTransferuriDataGridViewTextBoxColumn
            // 
            this.nrTransferuriDataGridViewTextBoxColumn.DataPropertyName = "NrTransferuri";
            this.nrTransferuriDataGridViewTextBoxColumn.HeaderText = "NrTransferuri";
            this.nrTransferuriDataGridViewTextBoxColumn.Name = "nrTransferuriDataGridViewTextBoxColumn";
            this.nrTransferuriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procentDataGridViewTextBoxColumn
            // 
            this.procentDataGridViewTextBoxColumn.DataPropertyName = "Procent";
            this.procentDataGridViewTextBoxColumn.HeaderText = "Procent";
            this.procentDataGridViewTextBoxColumn.Name = "procentDataGridViewTextBoxColumn";
            this.procentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GraficTransferuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lTransfer);
            this.Name = "GraficTransferuri";
            this.Text = "GraficTransferuri";
            this.Load += new System.EventHandler(this.GraficTransferuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statTransferuriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficTransferDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lTransfer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private graficTransferDS graficTransferDS;
        private System.Windows.Forms.BindingSource statTransferuriBindingSource;
        private graficTransferDSTableAdapters.statTransferuriTableAdapter statTransferuriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTransferuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentDataGridViewTextBoxColumn;
    }
}