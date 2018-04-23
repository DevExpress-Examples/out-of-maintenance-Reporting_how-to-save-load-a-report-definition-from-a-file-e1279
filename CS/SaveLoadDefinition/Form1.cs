using System;
using System.Windows.Forms;
// ...

namespace SaveLoadDefinition {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // A temporary path to save a report to.
        string filePath = @"C:\Temp\XtraReport1.repx";

        private void button1_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Save the report's layout to the configuration file.
            report.SaveLayout(filePath);
        }

        private void button2_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport1 report = new XtraReport1();

            // Load the report's layout from the specified file.
            report.LoadLayout(filePath);

            // Display the print preview.
            report.ShowPreview();
        }

    }
}