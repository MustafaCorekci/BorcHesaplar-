namespace Odev
{
    partial class frmRaporGoruntule
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilgilerDataSet = new Odev.bilgilerDataSet();
            this.OdemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilgilerDataSet1 = new Odev.bilgilerDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MusterilerTableAdapter = new Odev.bilgilerDataSetTableAdapters.MusterilerTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OdemelerTableAdapter = new Odev.bilgilerDataSet1TableAdapters.OdemelerTableAdapter();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bilgilerDataSet2 = new Odev.bilgilerDataSet2();
            this.OdemesiBitenlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OdemesiBitenlerTableAdapter = new Odev.bilgilerDataSet2TableAdapters.OdemesiBitenlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemesiBitenlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MusterilerBindingSource
            // 
            this.MusterilerBindingSource.DataMember = "Musteriler";
            this.MusterilerBindingSource.DataSource = this.bilgilerDataSet;
            // 
            // bilgilerDataSet
            // 
            this.bilgilerDataSet.DataSetName = "bilgilerDataSet";
            this.bilgilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OdemelerBindingSource
            // 
            this.OdemelerBindingSource.DataMember = "Odemeler";
            this.OdemelerBindingSource.DataSource = this.bilgilerDataSet1;
            // 
            // bilgilerDataSet1
            // 
            this.bilgilerDataSet1.DataSetName = "bilgilerDataSet1";
            this.bilgilerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MusterilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Odev.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1137, 595);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.MusterilerBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Odev.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1137, 595);
            this.reportViewer2.TabIndex = 1;
            // 
            // MusterilerTableAdapter
            // 
            this.MusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.OdemelerBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Odev.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1137, 595);
            this.reportViewer3.TabIndex = 2;
            // 
            // OdemelerTableAdapter
            // 
            this.OdemelerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.OdemesiBitenlerBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Odev.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1137, 595);
            this.reportViewer4.TabIndex = 3;
            // 
            // bilgilerDataSet2
            // 
            this.bilgilerDataSet2.DataSetName = "bilgilerDataSet2";
            this.bilgilerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OdemesiBitenlerBindingSource
            // 
            this.OdemesiBitenlerBindingSource.DataMember = "OdemesiBitenler";
            this.OdemesiBitenlerBindingSource.DataSource = this.bilgilerDataSet2;
            // 
            // OdemesiBitenlerTableAdapter
            // 
            this.OdemesiBitenlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 595);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRaporGoruntule";
            this.Text = "frmRaporGoruntule";
            this.Load += new System.EventHandler(this.frmRaporGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgilerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemesiBitenlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MusterilerBindingSource;
        private bilgilerDataSet bilgilerDataSet;
        private bilgilerDataSetTableAdapters.MusterilerTableAdapter MusterilerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource OdemelerBindingSource;
        private bilgilerDataSet1 bilgilerDataSet1;
        private bilgilerDataSet1TableAdapters.OdemelerTableAdapter OdemelerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource OdemesiBitenlerBindingSource;
        private bilgilerDataSet2 bilgilerDataSet2;
        private bilgilerDataSet2TableAdapters.OdemesiBitenlerTableAdapter OdemesiBitenlerTableAdapter;
    }
}