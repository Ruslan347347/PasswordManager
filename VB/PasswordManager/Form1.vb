
Imports System.IO

Public Class Form1
    Dim n As Integer
    Dim fr As StreamReader
    Dim fw As StreamWriter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            n = n + 1
            ComboBox1.Items.Add(TextBox4.Text)
            fw = New StreamWriter("F:\GitKraken\PasswordManager\PasswordManager\VB\PasswordManager\profiles\Index.txt", True)
            fw.WriteLine(TextBox4.Text)
            fw.Close()
            fw = New StreamWriter("F:\GitKraken\PasswordManager\PasswordManager\VB\PasswordManager\date\" + (TextBox4.Text) + ".txt", True)
            fw.WriteLine(TextBox1.Text)
            fw.WriteLine(TextBox2.Text)
        Finally
            'Очистить поле
            TextBox4.Text = ""
            'Очистить поле
            TextBox1.Text = ""
            'Очистить поле
            TextBox2.Text = ""
            'Закрыть файл.
            fw.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fr = New StreamReader("F:\GitKraken\PasswordManager\PasswordManager\VB\PasswordManager\date\" + ComboBox1.Text + ".txt")
        Dim ReadString As String
        ReadString = ""
        Dim FileString As String
        Do
            'Считываем строку из файла в переменную FileString.
            FileString = fr.ReadLine
            'добавляем к ReadString
            ReadString = ReadString & ControlChars.CrLf & FileString
        Loop Until (FileString = Nothing)
        fr.Close()
        TextBox3.Visible = True
        TextBox3.Text = ReadString
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        fr = New StreamReader("F:\GitKraken\PasswordManager\PasswordManager\VB\PasswordManager\profiles\Index.txt")
        While fr.Peek <> -1
            ComboBox1.Items.Add(fr.ReadLine)
        End While
        fr.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class


