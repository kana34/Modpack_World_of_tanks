Imports System.Net
Imports System.IO.Compression

Public Class mods
    Dim ctrl As Control
    Dim chkbx As CheckBox
    Dim client As WebClient
    Dim adresse As String
    Dim chaine As String
    Dim bytesIn As Double
    Dim totalBytes As Double
    Dim percentage As Double
    Dim zipPath As String
    Dim extractPath As String
    Dim msg As MessageBox
    Dim DirDesktop As String
    Dim procID As Integer
    Dim MapsInstall As Integer = 0

    Private Sub Mods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim CheckBox As New CheckBox()
        'CheckBox.Location = New Point(15, 15)
        'CheckBox.Text = "test"
        'GroupBox.Controls.Add(CheckBox)
    End Sub

    '--- Onglet ---
    '--------------
    Private Sub Menu_home_Click(sender As Object, e As EventArgs) Handles Menu_home.Click
        Close()
        Modpack.Show()
    End Sub
    Private Sub Menu_news_Click(sender As Object, e As EventArgs) Handles Menu_news.Click
        Close()
        news.Show()
    End Sub

    '--- Bouton ---
    '--------------
    Private Sub Bouton_install_mods_Click(sender As Object, e As EventArgs) Handles Bouton_install_mods.Click

        '--- Téléchargement des mods sélectionnés ---
        '--------------------------------------------
        For Each ctrl In GroupBox.Controls
            If (ctrl.GetType() Is GetType(CheckBox)) Then
                chkbx = CType(ctrl, CheckBox)
                If chkbx.Checked Then
                    Try
                        download_mods_client(My.Settings.lien_mods & ctrl.Name & ".zip", ctrl.Name)
                    Catch
                        MessageBox.Show("Une erreur est survenue !")
                    End Try
                End If
            End If
        Next

        '--- Mise à jour de la version des mods ---
        '------------------------------------------
        Try
            client = New WebClient
            client.DownloadFileAsync(New Uri("http://team-acdc-34.ovh/modpack/version_mods.txt"), My.Settings.path_install & "\mods\configs\version_mods.txt")
        Catch
            MessageBox.Show("Une erreur est survenue !")
        End Try
    End Sub
    Private Sub Bouton_desinstall_mods_Click(sender As Object, e As EventArgs) Handles Bouton_desinstall_mods.Click
        Try
            supp_mods_client()
        Catch
            MessageBox.Show("Une erreur est survenue !")
        End Try

        MessageBox.Show("Suppression de tous les mods Terminé !")
        Close()
        Modpack.Show()
    End Sub
    Private Sub Bouton_close_Click(sender As Object, e As EventArgs) Handles Bouton_close.Click
        Modpack.Close()
    End Sub

    '--- Affichage de la progressbar et extraction des mods ---
    '----------------------------------------------------------
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        bytesIn = Double.Parse(e.BytesReceived.ToString())
        totalBytes = Double.Parse(e.TotalBytesToReceive.ToString())
        percentage = bytesIn / totalBytes * 100

        download.ProgressBar.Value = Integer.Parse(Math.Truncate(percentage).ToString())
        download.pourcentage.Text = download.ProgressBar.Value & "%"
    End Sub
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        zipPath = My.Settings.path_install & "\" & ctrl.Name

        extractPath = My.Settings.path_install

        ZipFile.ExtractToDirectory(zipPath, extractPath)

        download.Close()
        My.Computer.FileSystem.DeleteFile(zipPath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)

    End Sub

    '--- Fonction ---
    '----------------
    Private Sub supp_mods_client()
        If My.Computer.FileSystem.DirectoryExists(My.Settings.path_install & "\mods\" & My.Settings.version_jeu) Then
            My.Computer.FileSystem.DeleteDirectory(My.Settings.path_install & "\mods\" & My.Settings.version_jeu, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
            My.Computer.FileSystem.DeleteDirectory(My.Settings.path_install & "\mods\configs", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)

            My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\mods\" & My.Settings.version_jeu)
        Else
            My.Computer.FileSystem.CreateDirectory(My.Settings.path_install & "\mods\" & My.Settings.version_jeu)
        End If
    End Sub
    Private Sub download_mods_client(url_mods As String, name_mods As String)
        client = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf client_DownloadCompleted
        client.DownloadFileAsync(New Uri(url_mods), My.Settings.path_install & "\res_mods.zip")

        download.info_install.Text = "Installation de: " & name_mods
        download.info.Text = "Téléchargement de: " & name_mods
        download.ShowDialog()
    End Sub
End Class