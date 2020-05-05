namespace Odev5
{
    partial class FormRapor
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SOHATSDataSet = new Odev5.SOHATSDataSet();
            this.sevkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sevkTableAdapter = new Odev5.SOHATSDataSetTableAdapters.sevkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SOHATSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sevkBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Odev5.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(877, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // SOHATSDataSet
            // 
            this.SOHATSDataSet.DataSetName = "SOHATSDataSet";
            this.SOHATSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sevkBindingSource
            // 
            this.sevkBindingSource.DataMember = "sevk";
            this.sevkBindingSource.DataSource = this.SOHATSDataSet;
            // 
            // sevkTableAdapter
            // 
            this.sevkTableAdapter.ClearBeforeFill = true;
            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 564);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.FormRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SOHATSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sevkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sevkBindingSource;
        private SOHATSDataSet SOHATSDataSet;
        private SOHATSDataSetTableAdapters.sevkTableAdapter sevkTableAdapter;
    }
}