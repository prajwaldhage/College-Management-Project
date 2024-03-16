<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Development
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Papyrus", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(367, 30)
        Label1.TabIndex = 0
        Label1.Text = "This Application is under development!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(162, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 17)
        Label2.TabIndex = 1
        Label2.Text = "Kindly Check Back Later!"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(172, 127)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 39)
        Button1.TabIndex = 2
        Button1.Text = "Return to HomePage"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Development
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 194)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Development"
        StartPosition = FormStartPosition.CenterParent
        Text = "Development"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
