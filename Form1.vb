
Imports ChatSMB.My.MySettings
Imports ChatSMB.SessionManager
Imports System.Media
Public Class ChatSMB

#Region " Declarations "

    Private Client As IChatGptClient

#End Region

#Region " Properties "

    Public Property StatusText As String
        Get
            Return ToolStripStatusLabel1.Text
        End Get
        Set(value As String)
            ToolStripStatusLabel1.Text = value
        End Set
    End Property
#End Region


#Region " Event Handlers "

    Protected Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.star_regular
    End Sub

    ''' <summary>
    ''' Send button event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Dim intSendCount As Integer = SessionManager.Instance.SendCount

        ButtonSend.Enabled = False
        Call Send()
        ButtonSend.Enabled = True
        TxtSend.Text = ""

        'show the current model in the TSSL

        If intSendCount > 0 Then
            Me.StatusText = "Model: " & SessionManager.Instance.Version
        End If

    End Sub

    ''' <summary>
    ''' request text field focus event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtSend_GotFocus(sender As Object, e As EventArgs) Handles TxtSend.GotFocus
        Dim intSendCount As Integer = SessionManager.Instance.SendCount
        If SessionManager.Instance.APIKey.Trim() = String.Empty Then
            Using frm As New FormKeyPath()
                frm.ShowDialog()
            End Using
        Else
            If intSendCount = 1 Then
                Me.StatusText = "API Key selected."
            End If

        End If
    End Sub

#End Region

#Region " Methods "

    ''' <summary>
    ''' Send a message to the LLM
    ''' </summary>
    ''' <returns>Task</returns>
    Async Function Send() As Task

        'get the key from session
        Dim strApiKey As String = GetApiKey()
        Dim strSeparator As String = "------------------------------------------------------------------------"
        Dim strQuery As String = TxtSend.Text.Trim()

        Using Client As New ChatGptClient(strApiKey, systemPrompt:=TxtSend.Text.Trim())
            Dim strReply = Await Client.SendMessageAsync(strQuery)
            LabelReceived.Text &= strQuery & vbCrLf & vbCrLf & strReply & vbCrLf & vbCrLf & strSeparator & vbCrLf & vbCrLf
        End Using

    End Function

    ''' <summary>
    ''' Get the API Key from session
    ''' </summary>
    ''' <returns>String</returns>
    Function GetApiKey() As String
        Return SessionManager.Instance.APIKey
    End Function

    Private Sub PlayStartupSound()
        Dim player As New SoundPlayer(My.Resources.powerup)
        player.Play()
    End Sub
#End Region

End Class
