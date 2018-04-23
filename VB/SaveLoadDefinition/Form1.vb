Imports DevExpress.XtraReports.UI
Imports System
Imports System.Windows.Forms
' ...

Namespace SaveLoadDefinition
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        ' A temporary path to save a report to.
        Private filePathCodeDom As String = "C:\Temp\XtraReport1.repx"

        Private Sub SaveRepx_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveRepx.Click
            ' Create a report.
            Dim report As New XtraReport1()

            ' Save the report's layout to the configuration file.
            report.SaveLayout(filePathCodeDom)
        End Sub

        Private Sub LoadRepx_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoadRepx.Click
            ' Create a report.
            Dim report As New XtraReport1()

            ' Load the report's layout from the specified file.
            report.LoadLayout(filePathCodeDom)

            ' Display the print preview.
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub

        Private filePathXml As String = "C:\Temp\XtraReport1.xml"

        Private Sub SaveXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveXml.Click
            ' Create a report.
            Dim report As New XtraReport1()

            ' Save the report's layout to the configuration file.
            report.SaveLayoutToXml(filePathXml)
        End Sub

        Private Sub LoadXml_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoadXml.Click
            ' Create a report.
            Dim report As New XtraReport1()

            ' Load the report's layout from the specified file.
            report.LoadLayoutFromXml(filePathXml)

            ' Display the print preview.
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub

    End Class
End Namespace