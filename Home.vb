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

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
