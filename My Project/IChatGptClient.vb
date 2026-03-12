Public Interface IChatGptClient
    Inherits IDisposable

    Function SendMessageAsync(userMessage As String,
                              Optional temperature As Double = 0.7) As Task(Of String)

    Sub ClearConversation()

End Interface
