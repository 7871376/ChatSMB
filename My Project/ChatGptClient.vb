Imports System.Media
Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports ChatSMB.SessionManager

Public Class ChatGptClient
    Implements IChatGptClient
    Implements IDisposable

    Private ReadOnly _httpClient As HttpClient
    Private ReadOnly _apiKey As String
    Private ReadOnly _model As String
    Private ReadOnly _messages As New List(Of ChatMessage)

    Public Sub New(apiKey As String,
                    Optional model As String = "gpt-4.1-nano",
                    Optional systemPrompt As String = Nothing)

        _apiKey = apiKey
        _model = model

        _httpClient = New HttpClient()
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}")

        If Not String.IsNullOrWhiteSpace(systemPrompt) Then
            _messages.Add(New ChatMessage With {
                .role = "system",
                .content = systemPrompt
            })
        End If

        'set the model in session for display in the TSSL
        SessionManager.Instance.Version = _model

    End Sub

    ''' <summary>
    ''' Send the message to the LLM
    ''' </summary>
    ''' <param name="userMessage"></param>
    ''' <param name="temperature"></param>
    ''' <returns></returns>
    Public Async Function SendMessageAsync(userMessage As String,
                                            Optional temperature As Double = 0.7) As Task(Of String) _
        Implements IChatGptClient.SendMessageAsync

        Dim assistantReply

        _messages.Add(New ChatMessage With {
            .role = "user",
            .content = userMessage
        })

        Dim requestBody = New ChatRequest With {
            .model = _model,
            .temperature = temperature,
            .messages = _messages
        }

        Dim json = JsonSerializer.Serialize(requestBody)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Dim response = Await _httpClient.PostAsync(
            "https://api.openai.com/v1/chat/completions",
            content)

        Dim responseString = Await response.Content.ReadAsStringAsync()

        If Not response.IsSuccessStatusCode Then
            Call PlayErrorSound()
            Call ShowErrorInStatusBar()
            assistantReply = String.Format("OpenAI Error: {0}", response.ReasonPhrase)

        Else
            Dim result = JsonSerializer.Deserialize(Of ChatResponse)(responseString)

            'increment the send count
            Dim intSendCount As Integer = SessionManager.Instance.SendCount
            SessionManager.Instance.SendCount = (intSendCount + 1)

            assistantReply = result.choices(0).message.content

            _messages.Add(New ChatMessage With {
                .role = "assistant",
                .content = assistantReply
            })

        End If

        Return assistantReply

    End Function

    ''' <summary>
    ''' Clear all messages.
    ''' </summary>
    Public Sub ClearConversation() _
        Implements IChatGptClient.ClearConversation

        _messages.Clear()
    End Sub

    ''' <summary>
    ''' Plays a wav file when something goes amiss.
    ''' </summary>
    Private Sub PlayErrorSound()
        Dim player As New SoundPlayer(My.Resources.pause)
        player.Play()
    End Sub

    Private Sub ShowErrorInStatusBar()
        Dim frm As ChatSMB = TryCast(Application.OpenForms("ChatSMB"), ChatSMB)

        If frm IsNot Nothing Then
            frm.StatusText = "Error"
        End If

    End Sub


    ''' <summary>
    ''' tidy up.
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        _httpClient.Dispose()
    End Sub

End Class

' ===== Request / Response Models =====
' ===== Properties must be in lower case!

Public Class ChatRequest
    Public Property model As String
    Public Property temperature As Double
    Public Property messages As List(Of ChatMessage)
End Class

Public Class ChatResponse
    Public Property choices As List(Of Choice)
End Class

Public Class Choice
    Public Property message As ChatMessage
End Class

Public Class ChatMessage
    Public Property role As String
    Public Property content As String
End Class


