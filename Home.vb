Imports System.Windows

Public Class Home
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        PanelOn.Height = HomeBtn.Height
        PanelOn.Top = HomeBtn.Top
        HomePanel.Visible = True
        StudentPanel.Visible = False
        StaffPanel.Visible = False
        LibraryPanel.Visible = False
        AboutPanel.Visible = False

    End Sub
    Private Sub StudentBtn_Click(sender As Object, e As EventArgs) Handles StudentBtn.Click
        PanelOn.Height = StudentBtn.Height
        PanelOn.Top = StudentBtn.Top
        HomePanel.Visible = False
        StudentPanel.Visible = True
        StaffPanel.Visible = False
        LibraryPanel.Visible = False
        AboutPanel.Visible = False
    End Sub
    Private Sub StaffBtn_Click(sender As Object, e As EventArgs) Handles FacultyBtn.Click
        PanelOn.Height = FacultyBtn.Height
        PanelOn.Top = FacultyBtn.Top
        HomePanel.Visible = False
        StudentPanel.Visible = False
        StaffPanel.Visible = True
        LibraryPanel.Visible = False
        AboutPanel.Visible = False
    End Sub
    Private Sub LibraryBtn_Click(sender As Object, e As EventArgs) Handles LibraryBtn.Click
        PanelOn.Height = LibraryBtn.Height
        PanelOn.Top = LibraryBtn.Top
        HomePanel.Visible = False
        StudentPanel.Visible = False
        StaffPanel.Visible = False
        LibraryPanel.Visible = True
        AboutPanel.Visible = False
    End Sub
    Private Sub AboutBtn_Click(sender As Object, e As EventArgs) Handles AboutBtn.Click
        PanelOn.Height = AboutBtn.Height
        PanelOn.Top = AboutBtn.Top
        HomePanel.Visible = False
        StudentPanel.Visible = False
        StaffPanel.Visible = False
        LibraryPanel.Visible = False
        AboutPanel.Visible = True
    End Sub
    Private Sub StudentBtnHome_Click(sender As Object, e As EventArgs) Handles StudentBtnHome.Click
        PanelOn.Height = StudentBtn.Height
        PanelOn.Top = StudentBtn.Top
        HomePanel.Visible = False
        StudentPanel.Visible = True
        StaffPanel.Visible = False
        LibraryPanel.Visible = False
        AboutPanel.Visible = False
    End Sub
    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        AddStudent.Show()
    End Sub
    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        Development.Show()
    End Sub
    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        Development.Show()
    End Sub
    Private Sub AddClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddClassToolStripMenuItem.Click
        Development.Show()
    End Sub
    Private Sub ViewClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewClassToolStripMenuItem.Click
        Development.Show()
    End Sub
    Private Sub AddFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFeesToolStripMenuItem.Click
        Development.Show()
    End Sub
    Private Sub ViewFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFeesToolStripMenuItem.Click
        Development.Show()
    End Sub
    Private Sub CollectFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectFeesToolStripMenuItem.Click
        Development.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub FacultyBtnHome_Click(sender As Object, e As EventArgs) Handles FacultyBtnHome.Click
        PanelOn.Height = FacultyBtn.Height
        PanelOn.Top = FacultyBtn.Top
        HomePanel.Visible = False
        StudentPanel.Visible = False
        StaffPanel.Visible = True
        LibraryPanel.Visible = False
        AboutPanel.Visible = False
    End Sub

    Private Sub LibraryBtnHome_Click(sender As Object, e As EventArgs) Handles LibraryBtnHome.Click
        PanelOn.Height = LibraryBtn.Height
        PanelOn.Top = LibraryBtn.Top
        HomePanel.Visible = False
        StudentPanel.Visible = False
        StaffPanel.Visible = False
        LibraryPanel.Visible = True
        AboutPanel.Visible = False
    End Sub

    Private Sub AboutBtnHome_Click(sender As Object, e As EventArgs) Handles AboutBtnHome.Click
        PanelOn.Height = AboutBtn.Height
        PanelOn.Top = AboutBtn.Top
        HomePanel.Visible = False
        StudentPanel.Visible = False
        StaffPanel.Visible = False
        LibraryPanel.Visible = False
        AboutPanel.Visible = True
    End Sub
End Class
