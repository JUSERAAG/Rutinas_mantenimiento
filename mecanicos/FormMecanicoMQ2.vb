Imports System.Data.SqlClient
Imports Rutinas_mantenimiento.consultas
Public Class FormMecanicoMQ2
    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nuevaVentana As New FormPrincipal()
        nuevaVentana.Show()
        Me.Hide()
    End Sub


    Private Sub FormElectricoNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized ' Maximizar ventana
        Dim fechaActual As DateTime = DateTime.Now.Date
        Dim horaActual As TimeSpan = DateTime.Now.TimeOfDay
        TextBox2.Text = fechaActual.ToString("yyyy-MM-dd")
        TextBox3.Text = horaActual.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conexion As New SqlConnection(conn)
            Try
                conexion.Open()
                Dim consulta As String = "INSERT INTO dbo.Mecanico_NT VALUES (@FECHA,@HORA,@VAR1,@VAR2,@VAR3,@VAR4,@VAR5,@VAR6,@VAR7,@VAR8,@VAR9,@VAR10,@VAR11,@VAR12,@VAR13,@VAR14,@VAR15,@VAR16,@VAR17,@VAR18,@VAR19,@VAR20,@VAR21,@VAR22,@VAR23,@VAR24,@VAR25,@VAR26,@VAR27,@VAR28,@VAR29,@VAR30,@VAR31,@VAR32,@VAR33,@VAR34,@VAR35,@VAR36,@VAR37,@VAR38,@VAR39,@VAR40,@VAR41,@VAR42,@VAR43,@VAR44,@VAR45,@VAR46,@VAR47,@VAR48,@VAR49,@VAR50,@VAR51,@VAR52)"
                Using comando As New SqlCommand(consulta, conexion)
                    ' agregar parámetros
                    comando.Parameters.AddWithValue("@FECHA", DateTime.Now.Date)
                    comando.Parameters.AddWithValue("@HORA", DateTime.Now.TimeOfDay)
                    comando.Parameters.AddWithValue("@VAR1", If(CheckBox1.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR2", If(CheckBox2.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR3", If(CheckBox3.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR4", If(CheckBox4.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR5", If(CheckBox5.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR6", If(CheckBox6.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR7", If(CheckBox7.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR8", If(CheckBox8.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR9", If(CheckBox9.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR10", If(CheckBox10.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR11", If(CheckBox11.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR12", If(CheckBox12.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR13", If(CheckBox13.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR14", If(CheckBox14.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR15", If(CheckBox15.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR16", If(CheckBox16.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR17", If(CheckBox17.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR18", If(CheckBox18.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR19", If(CheckBox19.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR20", If(CheckBox20.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR21", If(CheckBox21.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR22", If(CheckBox22.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR23", If(CheckBox23.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR24", If(CheckBox24.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR25", If(CheckBox25.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR26", If(CheckBox26.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR27", If(CheckBox27.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR28", If(CheckBox28.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR29", If(CheckBox29.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR30", If(CheckBox30.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR31", If(CheckBox31.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR32", If(CheckBox32.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR33", If(CheckBox33.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR34", If(CheckBox34.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR35", If(CheckBox35.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR36", If(CheckBox36.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR37", If(CheckBox37.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR38", If(CheckBox38.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR39", If(CheckBox39.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR40", If(CheckBox40.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR41", If(CheckBox41.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR42", If(CheckBox42.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR43", If(CheckBox43.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR44", If(CheckBox44.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR45", If(CheckBox45.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR46", If(CheckBox46.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR47", If(CheckBox47.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR48", If(CheckBox48.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR49", If(CheckBox49.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR50", If(CheckBox50.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR51", If(CheckBox51.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR52", If(CheckBox52.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR53", If(CheckBox53.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR54", If(CheckBox54.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR55", If(CheckBox55.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR56", If(CheckBox56.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR57", TextBox1.Text)
                    ' ejecutar la consulta
                    comando.ExecuteNonQuery()
                    MessageBox.Show("datos insertados correctamente.")
                End Using
                Dim nuevaventana As New FormPrincipal()
                nuevaventana.Show()
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("error al insertar datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        CheckBox29.Checked = False
        CheckBox30.Checked = False
        CheckBox31.Checked = False
        CheckBox32.Checked = False
        CheckBox33.Checked = False
        CheckBox34.Checked = False
        CheckBox35.Checked = False
        CheckBox36.Checked = False
        CheckBox37.Checked = False
        CheckBox38.Checked = False
        CheckBox39.Checked = False
        CheckBox40.Checked = False
        CheckBox41.Checked = False
        CheckBox42.Checked = False
        CheckBox43.Checked = False
        CheckBox44.Checked = False
        CheckBox45.Checked = False
        CheckBox46.Checked = False
        CheckBox47.Checked = False
        CheckBox48.Checked = False
        CheckBox49.Checked = False
        CheckBox50.Checked = False
        CheckBox51.Checked = False
        CheckBox52.Checked = False
        CheckBox53.Checked = False
        CheckBox54.Checked = False
        CheckBox55.Checked = False
        CheckBox56.Checked = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox100.SelectedIndexChanged
        Select Case ComboBox100.SelectedItem()
            Case "Sistema o equipos 1"
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel1.Visible = True
                Panel1.Enabled = True
                Panel2.Visible = True
                Panel2.Enabled = True
            Case "Sistema o equipos 2"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel3.Visible = True
                Panel3.Enabled = True
            Case "Desmoldeadora 1"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = True
                Panel4.Enabled = True
        End Select
    End Sub


End Class