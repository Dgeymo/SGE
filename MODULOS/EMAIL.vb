Imports System.Net.Mail
Module EMAIL
    Public MENSAJE As String
    Public Sub ENVIAR_EMAIL(ByVal PRIORIDAD As String, ByVal DESTINATARIO As String, ASUNTO As String, ByVal MENSAJE As String, ByVal REMITE As String, Optional ByVal CCOPIA As String = Nothing) ', ByVal Optional CON_COPIA As Object = Nothing


        Dim SMTP_SERVER As SmtpClient
        Dim E_MAIL As MailMessage
        SMTP_SERVER = New SmtpClient()
        SMTP_SERVER.UseDefaultCredentials = True
        SMTP_SERVER.Port = 25
        SMTP_SERVER.Host = "srv-mail"

        E_MAIL = New MailMessage
        E_MAIL.From = New MailAddress(REMITE, "SGE - MENSAJE AUTOMATICO", Text.Encoding.UTF8)
        E_MAIL.Subject = ASUNTO

        Select Case PRIORIDAD
            Case "URGENTE", "ALTA"
                E_MAIL.Priority = MailPriority.High
                E_MAIL.Subject = "EMAIL CON CARACTER " & PRIORIDAD & "!!   " & ASUNTO
            Case "MEDIA"
                E_MAIL.Priority = MailPriority.Normal
            Case "BAJA"
                E_MAIL.Priority = MailPriority.Low
        End Select

        E_MAIL.To.Add(DESTINATARIO)
        If CCOPIA IsNot Nothing Then
            E_MAIL.CC.Add(CCOPIA)
        End If


        E_MAIL.IsBodyHtml = False
        E_MAIL.BodyEncoding = Text.Encoding.UTF8
        E_MAIL.Body = MENSAJE
        Try
            SMTP_SERVER.Send(E_MAIL)
            NOTIFICACION("SYS", "Email enviado de manera correcta")
        Catch ex As Exception
            NOTIFICACION("SYS", "OOOOPS!! No se ha podido enviar el mail")
        End Try
    End Sub


End Module
