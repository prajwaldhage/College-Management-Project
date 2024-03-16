<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Ttile = New Label()
        StudName = New Label()
        AdmissionNo = New Label()
        DOB = New Label()
        Father = New Label()
        Email = New Label()
        contact = New Label()
        Year = New Label()
        Branch = New Label()
        Image = New Label()
        Title2 = New Label()
        StudNameIn = New TextBox()
        AdmissionNoIn = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        BranchIn = New ComboBox()
        YearIn = New ComboBox()
        Submit = New Button()
        SuspendLayout()
        ' 
        ' Ttile
        ' 
        Ttile.AutoSize = True
        Ttile.Font = New Font("Papyrus", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ttile.Location = New Point(317, 9)
        Ttile.Name = "Ttile"
        Ttile.Size = New Size(165, 25)
        Ttile.TabIndex = 0
        Ttile.Text = "Add Student Form"
        ' 
        ' StudName
        ' 
        StudName.AutoSize = True
        StudName.Location = New Point(67, 139)
        StudName.Name = "StudName"
        StudName.Size = New Size(116, 15)
        StudName.TabIndex = 1
        StudName.Text = "Enter Student Name:"
        ' 
        ' AdmissionNo
        ' 
        AdmissionNo.AutoSize = True
        AdmissionNo.Location = New Point(67, 174)
        AdmissionNo.Name = "AdmissionNo"
        AdmissionNo.Size = New Size(85, 15)
        AdmissionNo.TabIndex = 2
        AdmissionNo.Text = "Admission No."
        ' 
        ' DOB
        ' 
        DOB.AutoSize = True
        DOB.Location = New Point(67, 214)
        DOB.Name = "DOB"
        DOB.Size = New Size(76, 15)
        DOB.TabIndex = 3
        DOB.Text = "Date of Birth:"
        ' 
        ' Father
        ' 
        Father.AutoSize = True
        Father.Location = New Point(67, 324)
        Father.Name = "Father"
        Father.Size = New Size(86, 15)
        Father.TabIndex = 6
        Father.Text = "Father's Name:"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(67, 284)
        Email.Name = "Email"
        Email.Size = New Size(84, 15)
        Email.TabIndex = 5
        Email.Text = "Email Address:"
        ' 
        ' contact
        ' 
        contact.AutoSize = True
        contact.Location = New Point(67, 249)
        contact.Name = "contact"
        contact.Size = New Size(71, 15)
        contact.TabIndex = 4
        contact.Text = "Contact No:"
        ' 
        ' Year
        ' 
        Year.AutoSize = True
        Year.Location = New Point(436, 179)
        Year.Name = "Year"
        Year.Size = New Size(66, 15)
        Year.TabIndex = 8
        Year.Text = "Select Year:"
        ' 
        ' Branch
        ' 
        Branch.AutoSize = True
        Branch.Location = New Point(436, 139)
        Branch.Name = "Branch"
        Branch.Size = New Size(81, 15)
        Branch.TabIndex = 7
        Branch.Text = "Select Branch:"
        ' 
        ' Image
        ' 
        Image.AutoSize = True
        Image.Location = New Point(523, 332)
        Image.Name = "Image"
        Image.Size = New Size(84, 15)
        Image.TabIndex = 9
        Image.Text = "Student Image"
        ' 
        ' Title2
        ' 
        Title2.AutoSize = True
        Title2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Title2.Location = New Point(67, 82)
        Title2.Name = "Title2"
        Title2.Size = New Size(180, 30)
        Title2.TabIndex = 10
        Title2.Text = "Basic Information:"
        ' 
        ' StudNameIn
        ' 
        StudNameIn.Location = New Point(189, 136)
        StudNameIn.Name = "StudNameIn"
        StudNameIn.PlaceholderText = "Full Name"
        StudNameIn.Size = New Size(166, 23)
        StudNameIn.TabIndex = 11
        ' 
        ' AdmissionNoIn
        ' 
        AdmissionNoIn.Location = New Point(189, 171)
        AdmissionNoIn.Name = "AdmissionNoIn"
        AdmissionNoIn.Size = New Size(166, 23)
        AdmissionNoIn.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(189, 246)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(166, 23)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(189, 284)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(166, 23)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(189, 324)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(166, 23)
        TextBox3.TabIndex = 15
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(189, 214)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(166, 23)
        DateTimePicker1.TabIndex = 16
        ' 
        ' BranchIn
        ' 
        BranchIn.FormattingEnabled = True
        BranchIn.Items.AddRange(New Object() {"Computer Engineering", "Civil Branch", "Mechanical Engineering", "Artificial Intelligence Branch"})
        BranchIn.Location = New Point(523, 136)
        BranchIn.Name = "BranchIn"
        BranchIn.Size = New Size(160, 23)
        BranchIn.TabIndex = 17
        BranchIn.Text = "Select Branch"
        ' 
        ' YearIn
        ' 
        YearIn.FormattingEnabled = True
        YearIn.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year"})
        YearIn.Location = New Point(523, 174)
        YearIn.Name = "YearIn"
        YearIn.Size = New Size(160, 23)
        YearIn.TabIndex = 18
        YearIn.Text = "Select Year"
        ' 
        ' Submit
        ' 
        Submit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Submit.Location = New Point(351, 394)
        Submit.Name = "Submit"
        Submit.Size = New Size(75, 28)
        Submit.TabIndex = 20
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = True
        ' 
        ' AddStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Submit)
        Controls.Add(YearIn)
        Controls.Add(BranchIn)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(AdmissionNoIn)
        Controls.Add(StudNameIn)
        Controls.Add(Title2)
        Controls.Add(Image)
        Controls.Add(Year)
        Controls.Add(Branch)
        Controls.Add(Father)
        Controls.Add(Email)
        Controls.Add(contact)
        Controls.Add(DOB)
        Controls.Add(AdmissionNo)
        Controls.Add(StudName)
        Controls.Add(Ttile)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "AddStudent"
        Text = "AddStudent"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ttile As Label
    Friend WithEvents StudName As Label
    Friend WithEvents AdmissionNo As Label
    Friend WithEvents DOB As Label
    Friend WithEvents Father As Label
    Friend WithEvents Email As Label
    Friend WithEvents contact As Label
    Friend WithEvents Year As Label
    Friend WithEvents Branch As Label
    Friend WithEvents Image As Label
    Friend WithEvents Title2 As Label
    Friend WithEvents StudNameIn As TextBox
    Friend WithEvents AdmissionNoIn As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BranchIn As ComboBox
    Friend WithEvents YearIn As ComboBox
    Friend WithEvents Submit As Button
End Class
