﻿Public Class MsgAccess
    Private Sub MsgAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.microsoft.com/de-de/download/details.aspx?id=10910")
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class