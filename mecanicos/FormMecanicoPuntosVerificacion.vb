Imports System.Data.SqlClient
Imports Rutinas_mantenimiento.consultas
Public Class FormMecanicoPuntosVerificacion
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
                Dim consulta As String = "INSERT INTO dbo.Mecanico_Puntos_Verificacion VALUES (@FECHA,@HORA,@VAR1,@VAR2,@VAR3,@VAR4,@VAR5,@VAR6,@VAR7,@VAR8,@VAR9,@VAR10,@VAR11,@VAR12,@VAR13,@VAR14,@VAR15,@VAR16,@VAR17,@VAR18,@VAR19,@VAR20,@VAR21,@VAR22,@VAR23,@VAR24,@VAR25)"
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
                    comando.Parameters.AddWithValue("@VAR25", TextBox1.Text)
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
    End Sub

End Class