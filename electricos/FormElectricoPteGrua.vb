Imports System.Data.SqlClient
Imports Rutinas_mantenimiento.consultas
Public Class FormElectricoPteGrua
    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nuevaVentana As New FormPrincipal()
        nuevaVentana.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress, TextBox10.KeyPress, TextBox10.KeyPress, TextBox11.KeyPress
        ' Verificar que el primer carácter sea un número
        If (sender Is TextBox1 OrElse sender Is TextBox2) AndAlso Char.IsDigit(e.KeyChar) AndAlso (TryCast(sender, TextBox).Text.Length = 0) Then
            ' Primer carácter y es un número
        ElseIf Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "," Then
            e.Handled = True ' Ignorar la tecla presionada
        End If

        ' Permitir solo un punto decimal
        If e.KeyChar = "," AndAlso (TryCast(sender, TextBox).Text.Contains(",") OrElse TryCast(sender, TextBox).SelectionLength > 0) Then
            e.Handled = True ' Ignorar si ya hay un punto decimal o si se seleccionó un rango
        End If
    End Sub

    Private Sub FormElectricoNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized ' Maximizar ventana
        Dim fechaActual As DateTime = DateTime.Now.Date
        Dim horaActual As TimeSpan = DateTime.Now.TimeOfDay
        TextBox12.Text = fechaActual.ToString("yyyy-MM-dd")
        TextBox13.Text = horaActual.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conexion As New SqlConnection(conn)
            Try
                conexion.Open()
                Dim consulta As String = "INSERT INTO dbo.Electrico_Pte_Grua VALUES (@FECHA,@HORA,@VAR1,@VAR2,@VAR3,@VAR4,@VAR5,@VAR6,@VAR7,@VAR8,@VAR9,@VAR10,@VAR11)"
                Using comando As New SqlCommand(consulta, conexion)
                    ' Agregar parámetros
                    comando.Parameters.AddWithValue("@FECHA", DateTime.Now.Date)
                    comando.Parameters.AddWithValue("@HORA", DateTime.Now.TimeOfDay)
                    comando.Parameters.AddWithValue("@VAR1", Convert.ToSingle(TextBox1.Text))
                    comando.Parameters.AddWithValue("@VAR2", Convert.ToSingle(TextBox2.Text))
                    comando.Parameters.AddWithValue("@VAR3", Convert.ToSingle(TextBox3.Text))
                    comando.Parameters.AddWithValue("@VAR4", Convert.ToSingle(TextBox4.Text))
                    comando.Parameters.AddWithValue("@VAR5", Convert.ToSingle(TextBox5.Text))
                    comando.Parameters.AddWithValue("@VAR6", Convert.ToSingle(TextBox6.Text))
                    comando.Parameters.AddWithValue("@VAR7", Convert.ToSingle(TextBox7.Text))
                    comando.Parameters.AddWithValue("@VAR8", Convert.ToSingle(TextBox8.Text))
                    comando.Parameters.AddWithValue("@VAR9", Convert.ToSingle(TextBox9.Text))
                    comando.Parameters.AddWithValue("@VAR10", Convert.ToSingle(TextBox10.Text))
                    comando.Parameters.AddWithValue("@VAR11", Convert.ToSingle(TextBox11.Text))
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Datos insertados correctamente.")
                End Using
                Dim nuevaVentana As New FormPrincipal()
                nuevaVentana.Show()
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Error al insertar datos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            Panel1.Enabled = False
        ElseIf Panel1.Visible = False Then
            Panel1.Visible = True
            Panel1.Enabled = True
        End If
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
            Panel2.Enabled = False
        ElseIf Panel2.Visible = False Then
            Panel2.Visible = True
            Panel2.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus, TextBox2.GotFocus, TextBox3.GotFocus, TextBox4.GotFocus, TextBox5.GotFocus, TextBox6.GotFocus, TextBox7.GotFocus, TextBox8.GotFocus, TextBox9.GotFocus, TextBox10.GotFocus, TextBox11.GotFocus
        ' Obtén el TextBox que ha recibido el foco
        Dim textBoxSeleccionado As TextBox = DirectCast(sender, TextBox)
        textBoxSeleccionado.Text = ""
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus, TextBox2.LostFocus, TextBox3.LostFocus, TextBox4.LostFocus, TextBox5.LostFocus, TextBox6.LostFocus, TextBox7.LostFocus, TextBox8.LostFocus, TextBox9.LostFocus, TextBox10.LostFocus, TextBox11.LostFocus
        ' Obtén el TextBox que ha recibido el foco
        Dim textBoxSeleccionado As TextBox = DirectCast(sender, TextBox)
        If textBoxSeleccionado.Text = "" Then
            textBoxSeleccionado.Text = "0,01"
        ElseIf textBoxSeleccionado.Text <> "0,01" Then
            textBoxSeleccionado.Enabled = False
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            TextBox1.Text = "0,01"
        End If
        If TextBox2.Text = "" Then
            TextBox2.Text = "0,01"
        End If
        If TextBox3.Text = "" Then
            TextBox3.Text = "0,01"
        End If
        If TextBox4.Text = "" Then
            TextBox4.Text = "0,01"
        End If
        If TextBox5.Text = "" Then
            TextBox5.Text = "0,01"
        End If
        If TextBox6.Text = "" Then
            TextBox6.Text = "0,01"
        End If
        If TextBox7.Text = "" Then
            TextBox7.Text = "0,01"
        End If
        If TextBox8.Text = "" Then
            TextBox8.Text = "0,01"
        End If
        If TextBox9.Text = "" Then
            TextBox9.Text = "0,01"
        End If
        If TextBox10.Text = "" Then
            TextBox10.Text = "0,01"
        End If
        If TextBox11.Text = "" Then
            TextBox11.Text = "0,01"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        TextBox11.Enabled = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "" Then
            TextBox1.Enabled = False
        End If
        If TextBox2.Text <> "" Then
            TextBox2.Enabled = False
        End If
        If TextBox3.Text <> "" Then
            TextBox3.Enabled = False
        End If
        If TextBox4.Text <> "" Then
            TextBox4.Enabled = False
        End If
        If TextBox5.Text <> "" Then
            TextBox5.Enabled = False
        End If
        If TextBox6.Text <> "" Then
            TextBox6.Enabled = False
        End If
        If TextBox7.Text <> "" Then
            TextBox7.Enabled = False
        End If
        If TextBox8.Text <> "" Then
            TextBox8.Enabled = False
        End If
        If TextBox9.Text <> "" Then
            TextBox9.Enabled = False
        End If
        If TextBox10.Text <> "" Then
            TextBox10.Enabled = False
        End If
        If TextBox11.Text <> "" Then
            TextBox11.Enabled = False
        End If

    End Sub


End Class