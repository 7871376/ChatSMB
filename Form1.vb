Imports ChatSMB.My.MySettings
Imports ChatSMB.SessionManager
Public Class ChatSMB

    ''' <summary>
    ''' Send a message to the LLM
    ''' </summary>
    ''' <returns>Task</returns>
    Async Function Send() As Task

        'get the key from session
        Dim strApiKey As String = GetApiKey()
        Dim strSeparator As String = "------------------------------------------------------------------------"
        Dim strQuery As String = TxtSend.Text.Trim()

        Using client As New ChatGptClient(strApiKey, systemPrompt:=TxtSend.Text.Trim())

            Dim strReply = Await client.SendMessageAsync(strQuery)
            LabelReceived.Text &= strQuery & vbCrLf & vbCrLf & strReply & vbCrLf & vbCrLf & strSeparator & vbCrLf & vbCrLf

        End Using

    End Function

    ''' <summary>
    ''' Get the API Key from session
    ''' </summary>
    ''' <returns></returns>
    Function GetApiKey() As String
        Return SessionManager.Instance.APIKey
    End Function

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Dim intSendCount As Integer = SessionManager.Instance.SendCount

        ButtonSend.Enabled = False
        Call Send()
        ButtonSend.Enabled = True
        TxtSend.Text = ""

        'show the current model in the TSSL
        With ToolStripStatusLabel1
            If intSendCount > 0 Then
                .Text = "Model: " & SessionManager.Instance.Version
            End If

        End With


    End Sub

    Private Sub TxtSend_GotFocus(sender As Object, e As EventArgs) Handles TxtSend.GotFocus
        Dim intSendCount As Integer = SessionManager.Instance.SendCount
        If SessionManager.Instance.APIKey.Trim() = String.Empty Then
            Using frm As New FormKeyPath()
                frm.ShowDialog()
            End Using
        Else
            With ToolStripStatusLabel1
                If intSendCount = 1 Then
                    .Text = "API Key selected."
                End If
            End With
        End If
    End Sub

End Class
