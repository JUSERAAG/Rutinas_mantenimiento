Imports System.Windows
Imports System.Data.SqlClient
Public Class FormPrincipal

    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized ' Maximizar ventana
        CmbMantenimiento.DropDownStyle = ComboBoxStyle.DropDownList
        CmbArea.DropDownStyle = ComboBoxStyle.DropDownList
        CmbEquipo.DropDownStyle = ComboBoxStyle.DropDownList
        CmbMantenimiento.Items.Add("Eléctrico")
        CmbMantenimiento.Items.Add("Mecánico")
    End Sub

    Private Sub CmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMantenimiento.SelectedIndexChanged
        CmbArea.Items.Clear()
        CmbEquipo.Items.Clear()
        Select Case CmbMantenimiento.SelectedItem.ToString()
            Case "Eléctrico"
                CmbArea.Items.Add("Refinación")
                CmbArea.Items.Add("Preparación")
                CmbArea.Items.Add("Control espesores")
                CmbArea.Items.Add("Formadora")
                CmbArea.Items.Add("Onduladora")
                CmbArea.Items.Add("Desmoldeadora")
                CmbArea.Items.Add("Puente grúa")
                CmbArea.Items.Add("Caldera - Autoclave")
            Case "Mecánico"
                CmbArea.Items.Add("NT y periféricos")
                CmbArea.Items.Add("Máquina 1")
                CmbArea.Items.Add("Máquina 2")
                CmbArea.Items.Add("Puente grúa")
                CmbArea.Items.Add("Pintura")
                CmbArea.Items.Add("Cambio de equipos")
                CmbArea.Items.Add("Puntos de verificación")

        End Select
    End Sub

    Private Sub CmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbArea.SelectedIndexChanged
        CmbEquipo.Items.Clear()
        Select Case CmbMantenimiento.SelectedItem.ToString()
            Case "Eléctrico"
                Select Case CmbArea.SelectedItem.ToString()
                    Case "Preparación", "Control espesores", "Formadora", "Onduladora", "Desmoldeadora"
                        CmbEquipo.Items.Add("1")
                        CmbEquipo.Items.Add("2")
                    Case "Refinación"
                        Dim nuevaVentana As New FormElectricoNT()
                        nuevaVentana.Show()
                        Me.Hide()
                    Case "Puente grúa"
                        Dim nuevaVentana As New FormElectricoPteGrua()
                        nuevaVentana.Show()
                        Me.Hide()
                    Case "Caldera - Autoclave"
                        Dim nuevaVentana As New FormElectricoCaldAut()
                        nuevaVentana.Show()
                        Me.Hide()
                End Select
            Case "Mecánico"
                Select Case CmbArea.SelectedItem.ToString()
                    Case "NT y periféricos"
                        Dim nuevaVentana As New FormMecanicoNT()
                        nuevaVentana.Show()
                        Me.Hide()
                    Case "Máquina 1"
                        Dim nuevaVentana As New FormMecanicoMQ1()
                        nuevaVentana.Show()
                        Me.Hide()
                    Case "Máquina 2"
                        Dim nuevaVentana As New FormMecanicoMQ2()
                        nuevaVentana.Show()
                        Me.Hide()
                    Case "Puente grúa"
                        Dim nuevaVentana As New FormMecanicoPteGrua()
                        nuevaVentana.Show()
                        Me.Hide()
                    Case "Pintura"
                        Dim nuevaVentana As New FormMecanicoPintura()
                        nuevaVentana.Show()
                        Me.Hide()
                    Case "Cambio de equipos"
                        Dim nuevaVentana As New FormMecanicoCambioEquipo()
                        nuevaVentana.Show()
                        Me.Hide()
                    Case "Puntos de verificación"
                        Dim nuevaVentana As New FormMecanicoPuntosVerificacion()
                        nuevaVentana.Show()
                        Me.Hide()
                End Select

        End Select

    End Sub

    Private Sub CmbEquipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEquipo.SelectedIndexChanged
        Select Case CmbMantenimiento.SelectedItem.ToString()
            Case "Eléctrico"
                Select Case CmbArea.SelectedItem.ToString()
                    Case "Preparación"
                        Select Case CmbEquipo.SelectedItem.ToString()
                            Case "1"
                                Dim nuevaVentana As New FormElectricoPrep1()
                                nuevaVentana.Show()

                            Case "2"
                                Dim nuevaVentana As New FormElectricoPrep2()
                                nuevaVentana.Show()
                        End Select
                        Me.Hide()
                    Case "Control espesores"
                        Select Case CmbEquipo.SelectedItem.ToString()
                            Case "1"
                                Dim nuevaVentana As New FormElectricoCE1()
                                nuevaVentana.Show()
                            Case "2"
                                Dim nuevaVentana As New FormElectricoCE2()
                                nuevaVentana.Show()
                        End Select
                        Me.Hide()
                    Case "Formadora"
                        Select Case CmbEquipo.SelectedItem.ToString()
                            Case "1"
                                Dim nuevaVentana As New FormElectricoForm1()
                                nuevaVentana.Show()
                            Case "2"
                                Dim nuevaVentana As New FormElectricoForm2()
                                nuevaVentana.Show()
                        End Select
                        Me.Hide()
                    Case "Onduladora"
                        Select Case CmbEquipo.SelectedItem.ToString()
                            Case "1"
                                Dim nuevaVentana As New FormElectricoOnd1()
                                nuevaVentana.Show()
                            Case "2"
                                Dim nuevaVentana As New FormElectricoOnd2()
                                nuevaVentana.Show()
                        End Select
                        Me.Hide()
                    Case "Desmoldeadora"
                        Select Case CmbEquipo.SelectedItem.ToString()
                            Case "1"
                                Dim nuevaVentana As New FormElectricoDesm1()
                                nuevaVentana.Show()
                            Case "2"
                                Dim nuevaVentana As New FormElectricoDesm2()
                                nuevaVentana.Show()
                        End Select
                        Me.Hide()
                End Select

        End Select

    End Sub


End Class