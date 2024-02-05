Imports System.IO
Imports System.Net

Public Class frmSplashScreen
    Dim x As Integer
    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Try
        '    Dim client As WebClient = New WebClient()
        '    Dim data As String = client.DownloadString("https://fakkerai.com/SmileToSmileDentalClinics.txt")

        '    If data.Contains("0") Then
        '        MessageBox.Show("Application license is terminated!")
        '        Application.[Exit]()
        '    End If

        'Catch exp As WebException
        '    MessageBox.Show(exp.Message, "Exception")
        '    MessageBox.Show("Unable to check license, Application is terminated!")
        '    Application.[Exit]()
        'End Try



        If InitializingDatabaseConnection() = True Then
                Timer1.Start()
                Timer1.Interval = 400
                ProgressBar1.Value = 0
            Else
                frmDatabaseConnectionSetting.ShowDialog()
                Me.Hide()
            End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x += 1
        If Not ProgressBar1.Value > 90 Then
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
        If x = 8 Then
            frmAuthentication.Show()
            Me.Hide()
        End If
    End Sub
End Class