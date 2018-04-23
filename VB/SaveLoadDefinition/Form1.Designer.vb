Namespace SaveLoadDefinition
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.SaveRepx = New System.Windows.Forms.Button()
            Me.LoadRepx = New System.Windows.Forms.Button()
            Me.SaveXml = New System.Windows.Forms.Button()
            Me.LoadXml = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' SaveRepx
            ' 
            Me.SaveRepx.Location = New System.Drawing.Point(12, 12)
            Me.SaveRepx.Name = "SaveRepx"
            Me.SaveRepx.Size = New System.Drawing.Size(135, 53)
            Me.SaveRepx.TabIndex = 0
            Me.SaveRepx.Text = "Save Report to REPX"
            Me.SaveRepx.UseVisualStyleBackColor = True
            ' 
            ' LoadRepx
            ' 
            Me.LoadRepx.Location = New System.Drawing.Point(12, 86)
            Me.LoadRepx.Name = "LoadRepx"
            Me.LoadRepx.Size = New System.Drawing.Size(135, 53)
            Me.LoadRepx.TabIndex = 1
            Me.LoadRepx.Text = "Load Report from REPX"
            Me.LoadRepx.UseVisualStyleBackColor = True
            ' 
            ' SaveXml
            ' 
            Me.SaveXml.Location = New System.Drawing.Point(250, 13)
            Me.SaveXml.Name = "SaveXml"
            Me.SaveXml.Size = New System.Drawing.Size(135, 52)
            Me.SaveXml.TabIndex = 2
            Me.SaveXml.Text = "Save Report to XML"
            Me.SaveXml.UseVisualStyleBackColor = True
            ' 
            ' LoadXml
            ' 
            Me.LoadXml.Location = New System.Drawing.Point(250, 86)
            Me.LoadXml.Name = "LoadXml"
            Me.LoadXml.Size = New System.Drawing.Size(135, 53)
            Me.LoadXml.TabIndex = 3
            Me.LoadXml.Text = "Load Report from XML"
            Me.LoadXml.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(397, 348)
            Me.Controls.Add(Me.LoadXml)
            Me.Controls.Add(Me.SaveXml)
            Me.Controls.Add(Me.LoadRepx)
            Me.Controls.Add(Me.SaveRepx)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents SaveRepx As System.Windows.Forms.Button
        Private WithEvents LoadRepx As System.Windows.Forms.Button
        Private WithEvents SaveXml As System.Windows.Forms.Button
        Private WithEvents LoadXml As System.Windows.Forms.Button
    End Class
End Namespace

