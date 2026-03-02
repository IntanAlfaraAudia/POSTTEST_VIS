Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class Form1

    Dim listIPS As New List(Of Double)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        txtIPK.Text = "0.00"
        txtIPK.ReadOnly = True
        lblPredikat.Text = "-"
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Dim ips As Double = Convert.ToDouble(txtIPS.Text)

            If ips < 0 Or ips > 4 Then
                MessageBox.Show("IP harus antara 0 - 4")
                Exit Sub
            End If

            listIPS.Add(ips)

            Dim ipk As Double = listIPS.Average()

            txtIPK.Text = ipk.ToString("0.00")

            If ipk >= 2.0 And ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

            txtIPS.Clear()
            txtIPS.Focus()

        Catch
            MessageBox.Show("Masukkan angka yang valid!")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        listIPS.Clear()
        txtIPK.Text = "0.00"
        lblPredikat.Text = "-"
        txtIPS.Clear()
        txtIPS.Focus()
    End Sub

End Class