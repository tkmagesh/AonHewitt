Public Class ServerControls
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Reques
    End Sub

    Protected Sub BtnSubmitClick(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim name = TxtName.Text
        If (name.Equals("")) Then
            TxtName.BorderColor = Drawing.Color.Red
            TxtName.BackColor = Drawing.Color.LightPink

        Else
            Dim msg = "Hi " & name
            LblGreeting.Text = msg

        End If

    End Sub
End Class