using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;
// ...

namespace SaveLoadDefinition {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // A temporary path to save a report to.
        string filePathCodeDom = @"C:\Temp\XtraReport1.repx";

        private void SaveRepx_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Save the report's layout to the configuration file.
            report.SaveLayout(filePathCodeDom);
        }

        private void LoadRepx_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Load the report's layout from the specified file.
            report.LoadLayout(filePathCodeDom);

            // Display the print preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        string filePathXml = @"C:\Temp\XtraReport1.xml";

        private void SaveXml_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Save the report's layout to the configuration file.
            report.SaveLayoutToXml(filePathXml);
        }

        private void LoadXml_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Load the report's layout from the specified file.
            report.LoadLayoutFromXml(filePathXml);

            // Display the print preview.
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

    }
}