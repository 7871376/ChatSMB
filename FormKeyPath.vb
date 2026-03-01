Imports ChatSMB.SessionManager

Public Class FormKeyPath
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Using ofd As New OpenFileDialog()

            ' Set dialog properties
            ofd.Title = "Select a File"
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            ofd.Multiselect = False

            ' Show dialog and check result
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim selectedFilePath As String = ofd.FileName

                ' Example: Show selected file path
                'MessageBox.Show("Selected File: " & selectedFilePath)

                ' Example: Read file content
                Dim content As String = IO.File.ReadAllText(selectedFilePath)

                If content <> String.Empty Then
                    SessionManager.Instance.APIKey = content

                    Me.Close()
                End If
            End If

        End Using

    End Sub
End Class