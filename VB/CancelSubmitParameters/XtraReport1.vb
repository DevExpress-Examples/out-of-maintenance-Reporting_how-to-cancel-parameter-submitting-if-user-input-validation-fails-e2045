Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
' ...

Namespace CancelSubmitParameters
	Partial Public Class XtraReport1
		Inherits XtraReport
		Private parameter As Integer
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_ParametersRequestSubmit(ByVal sender As Object, ByVal e As ParametersRequestEventArgs) Handles MyBase.ParametersRequestSubmit
			If CInt(Fix(e.ParametersInformation(0).Parameter.Value)) > 10 OrElse CInt(Fix(e.ParametersInformation(0).Parameter.Value)) < 0 Then
				e.ParametersInformation(0).Parameter.Value = parameter
				e.ParametersInformation(0).Editor.Text = parameter.ToString()
			End If
		End Sub

		Private Sub XtraReport1_ParametersRequestValueChanged(ByVal sender As Object, ByVal e As ParametersRequestValueChangedEventArgs) Handles MyBase.ParametersRequestValueChanged
			parameter = CInt(Fix(e.ChangedParameterInfo.Parameter.Value))
		End Sub

	End Class
End Namespace