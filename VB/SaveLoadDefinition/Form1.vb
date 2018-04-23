Imports Microsoft.VisualBasic
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
		Private filePath As String = "C:\Temp\XtraReport1.repx"

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create a report.
			Dim report As New XtraReport1()

			' Save the report's layout to the configuration file.
			report.SaveLayout(filePath)
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			' Create a report.
			Dim report As New XtraReport1()

			' Load the report's layout from the specified file.
			report.LoadLayout(filePath)

			' Display the print preview.
			report.ShowPreview()
		End Sub

	End Class
End Namespace