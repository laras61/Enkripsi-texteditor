Public Class Form1

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = System.IO.File.ReadAllText(openFileDialog.FileName)
        End If
    End Sub

    Private Function Encrypt(ByVal text As String) As String
        Dim result As New System.Text.StringBuilder()

        For Each c As Char In text
            Dim offset As Integer = AscW(c) + 3 ' Geser 3 posisi
            result.Append(ChrW(offset)) ' Tambahkan karakter yang sudah digeser
        Next

        Return result.ToString()
    End Function



    Private Sub SaveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim encryptedText As String = Encrypt(TextBox1.Text)
            System.IO.File.WriteAllText(saveFileDialog.FileName, encryptedText)
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub
End Class
