Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class AddStudent
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=PRAJWAL-PC\SQLEXPRESS;Initial Catalog=college;Integrated Security=True;Encrypt=False")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[studentdata]
           ([AdmissionNo]
           ,[Name]
           ,[Dob]
           ,[ContactNo]
           ,[Email]
           ,[FName]
           ,[CBranch]
           ,[CYear])
     VALUES
           ('" + AdmissionNoIn.Text + "','" + StudNameIn.Text + "','" + DOBIn.Text + "','" + ContactIn.Text + "','" + EmailIn.Text + "','" + FNameIn.Text + "','" + BranchIn.SelectedItem.ToString() + "','" + YearIn.SelectedItem.ToString() + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Added!")
        Me.Close()
    End Sub
End Class