Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32
Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Net.WebClient
Imports System.Net

Public Class Form1
    Private Shared Picture As Object
    Dim directory As String = False
    Private this As Object
    Dim ip As String = "149.202.41.210"
    Dim port As String = "30210"
    Public Property UpdateButton As Object
    Public Property FinalButon As Object
    Public Property PlayDirectory As String

    Private Sub Unrar(ByVal filepath As String, ByVal WorkingDir As String)
        Dim ObjRegKey As RegistryKey
        ObjRegKey = Registry.ClassesRoot.OpenSubKey("Winrar\Shell\Open\Command")

        Dim obj As Object = ObjRegKey.GetValue("")

        Dim objRarPath As String = obj.ToString()
        objRarPath = objRarPath.Substring(1, objRarPath.Length - 7)

        ObjRegKey.Close()

        Dim objArgs As String
        objArgs = " x " & " " & filepath & " " + " " + WorkingDir

        Dim objStartInfo As New ProcessStartInfo()
        objStartInfo.UseShellExecute = False
        objStartInfo.FileName = objRarPath
        objStartInfo.Arguments = objArgs
        objStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        objStartInfo.WorkingDirectory = WorkingDir & ""

        Dim objPro As New Process()
        objPro.StartInfo = objStartInfo
        objPro.Start()

    End Sub

    Private Sub SetA3Directory()
        FolderBrowserDialog1.ShowDialog()
        directory = FolderBrowserDialog1.SelectedPath

        If directory.Equals("") Then
            SetA3Directory()
            Exit Sub
        End If

        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora")
        My.Computer.FileSystem.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\directory.a3", directory, False)
    End Sub

    Private Sub UpdateChecker()
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\version.txt") Then
            My.Computer.Network.DownloadFile("https://www.dropbox.com/s/wf3hlxo5xm7a2vb/version-serv.txt?dl=0", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\version-serv.txt")
            If My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\version.txt") = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\version-serv.txt") Then
                'Il n'y a pas de mise à jour
            Else
                UpdateClient()
                My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\version-serv.txt")
            End If
        Else
            UpdateClient()
        End If
    End Sub

    Private Sub UpdateClient()
        Timer1.Start()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\directory.a3") Then
            directory = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\directory.a3")
        Else
            MsgBox("Vous devez spécifier le chemin d'accès de FiveM", MsgBoxStyle.Exclamation, "Erreur")
            SetA3Directory()
        End If
        UpdateChecker()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\directory.a3") Then
            Dim url As String = "Lien de download de votre dlc perso"
            Dim client As New WebClient()

            If Not String.IsNullOrEmpty(url) Then
                UpdateButton.Visible = False
                FinalButon.Visible = True
                If File.Exists((PlayDirectory + ("/update/x64/dlcpacks/patchday15ng/" + "dlc.rpf"))) Then
                    System.IO.File.Move((PlayDirectory + ("/update/x64/dlcpacks/patchday15ng/" + "dlc.rpf")), (PlayDirectory + ("/update/x64/dlcpacks/patchday15ng/" + "backup_dlc.rpf")))
                    Dim uri As Uri = New Uri(url)
                    Dim filename As String = System.IO.Path.GetFileName(uri.AbsolutePath)
                    client.DownloadFileAsync(uri, (PlayDirectory + ("/update/x64/dlcpacks/patchday15ng/" + filename)))
                    'Warning!!! Lambda constructs are not supported
                    UpdateClient()
                Else
                    Dim uri As Uri = New Uri(url)
                    Dim filename As String = System.IO.Path.GetFileName(uri.AbsolutePath)
                    client.DownloadFileAsync(uri, (PlayDirectory + ("/update/x64/dlcpacks/patchday15ng/" + filename)))
                    'Warning!!! Lambda constructs are not supported
                    UpdateClient()
                End If
            End If
        Else
            MsgBox("Vous devez spécifier le chemin d'accès de Fivem", MsgBoxStyle.Exclamation, "Erreur")
            SetA3Directory()
        End If
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click

        If UBound(Diagnostics.Process.GetProcessesByName("Steam")) < 0 Then
            MsgBox("Vous n'avez pas démarré Steam !!", MsgBoxStyle.Exclamation, "Erreur")
        Else

            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\directory.a3") Then
                UpdateChecker()
                Process.Start(My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\directory.a3") & "\fivem.exe", "+connect 54.38.240.116:30120")
            Else
                MsgBox("Vous devez spécifier le chemin d'accès de FiveM", MsgBoxStyle.Exclamation, "Erreur")
                SetA3Directory()
            End If
        End If
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        If (My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\directory.a3")) Then
            directory = My.Computer.FileSystem.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LauncherEndora\directory.a3")

            If (My.Computer.FileSystem.DirectoryExists("C:\Users\admin\AppData\Local\FiveM\FiveM.app\cache\")) Then
                My.Computer.FileSystem.DeleteDirectory("C:\Users\admin\AppData\Local\FiveM\FiveM.app\cache\servers\", DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory("C:\Users\admin\AppData\Local\FiveM\FiveM.app\cache\browser\", DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory("C:\Users\admin\AppData\Local\FiveM\FiveM.app\cache\db\", DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory("C:\Users\admin\AppData\Local\FiveM\FiveM.app\cache\dunno\", DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory("C:\Users\admin\AppData\Local\FiveM\FiveM.app\cache\priv\", DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteDirectory("C:\Users\admin\AppData\Local\FiveM\FiveM.app\cache\subprocess\", DeleteDirectoryOption.DeleteAllContents)
            End If
            MsgBox("Cache vidé !")
        End If
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click

        If My.Computer.FileSystem.FileExists("C:\Users\admin\AppData\Local\FiveM\FiveM.app\citizen\platform\data\control\default.meta") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\admin\AppData\Local\FiveM\FiveM.app\citizen\platform\data\control\default.meta")
        Else
            MsgBox("Le fichier n'éxiste pas !", MsgBoxStyle.Exclamation, "Erreur")
        End If

        My.Computer.Network.DownloadFile("https://www.dropbox.com/s/vnoeia18gitcbgv/default.meta?dl=0", "C:\Users\admin\AppData\Local\FiveM\FiveM.app\citizen\platform\data\control\default.meta")
        MsgBox("Clavier passer en azerty !", vbOK, "Clavier")
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Process.Start("https://endorarp.wixsite.com/endorarp")
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        Process.Start("https://gta.top-serveurs.net/endora")
    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        Process.Start("https://twitter.com/EndoraRP")
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click
        Process.Start("https://discord.gg/7RXm2Tz")
    End Sub
End Class


