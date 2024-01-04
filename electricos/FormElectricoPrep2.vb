﻿Imports System.Data.SqlClient
Imports Rutinas_mantenimiento.consultas
Public Class FormElectricoPrep2
    Private Sub FormPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nuevaVentana As New FormPrincipal()
        nuevaVentana.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress, TextBox7.KeyPress, TextBox8.KeyPress, TextBox9.KeyPress, TextBox10.KeyPress, TextBox11.KeyPress, TextBox12.KeyPress, TextBox13.KeyPress, TextBox14.KeyPress, TextBox15.KeyPress, TextBox16.KeyPress, TextBox17.KeyPress, TextBox18.KeyPress, TextBox19.KeyPress, TextBox20.KeyPress, TextBox21.KeyPress, TextBox22.KeyPress, TextBox23.KeyPress, TextBox24.KeyPress, TextBox25.KeyPress, TextBox26.KeyPress, TextBox27.KeyPress, TextBox28.KeyPress, TextBox29.KeyPress, TextBox30.KeyPress, TextBox31.KeyPress, TextBox32.KeyPress, TextBox33.KeyPress, TextBox34.KeyPress, TextBox35.KeyPress, TextBox36.KeyPress, TextBox37.KeyPress, TextBox38.KeyPress, TextBox39.KeyPress, TextBox40.KeyPress, TextBox41.KeyPress, TextBox42.KeyPress, TextBox43.KeyPress, TextBox44.KeyPress, TextBox45.KeyPress, TextBox46.KeyPress, TextBox47.KeyPress, TextBox48.KeyPress, TextBox49.KeyPress, TextBox50.KeyPress, TextBox51.KeyPress, TextBox52.KeyPress, TextBox53.KeyPress, TextBox54.KeyPress, TextBox55.KeyPress, TextBox56.KeyPress, TextBox57.KeyPress, TextBox58.KeyPress, TextBox59.KeyPress
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
        TextBox60.Text = fechaActual.ToString("yyyy-MM-dd")
        TextBox61.Text = horaActual.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conexion As New SqlConnection(conn)
            Try
                conexion.Open()
                Dim consulta As String = "INSERT INTO dbo.Electrico_Prep2 VALUES (@FECHA,@HORA,@VAR1,@VAR2,@VAR3,@VAR4,@VAR5,@VAR6,@VAR7,@VAR8,@VAR9,@VAR10,@VAR11,@VAR12,@VAR13,@VAR14,@VAR15,@VAR16,@VAR17,@VAR18,@VAR19,@VAR20,@VAR21,@VAR22,@VAR23,@VAR24,@VAR25,@VAR26,@VAR27,@VAR28,@VAR29,@VAR30,@VAR31,@VAR32,@VAR33,@VAR34,@VAR35,@VAR36,@VAR37,@VAR38,@VAR39,@VAR40,@VAR41,@VAR42,@VAR43,@VAR44,@VAR45,@VAR46,@VAR47,@VAR48,@VAR49,@VAR50,@VAR51,@VAR52,@VAR53,@VAR54,@VAR55,@VAR56,@VAR57,@VAR58,@VAR59)"
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
                    comando.Parameters.AddWithValue("@VAR12", Convert.ToSingle(TextBox12.Text))
                    comando.Parameters.AddWithValue("@VAR13", Convert.ToSingle(TextBox13.Text))
                    comando.Parameters.AddWithValue("@VAR14", Convert.ToSingle(TextBox14.Text))
                    comando.Parameters.AddWithValue("@VAR15", Convert.ToSingle(TextBox15.Text))
                    comando.Parameters.AddWithValue("@VAR16", Convert.ToSingle(TextBox16.Text))
                    comando.Parameters.AddWithValue("@VAR17", Convert.ToSingle(TextBox17.Text))
                    comando.Parameters.AddWithValue("@VAR18", Convert.ToSingle(TextBox18.Text))
                    comando.Parameters.AddWithValue("@VAR19", Convert.ToSingle(TextBox19.Text))
                    comando.Parameters.AddWithValue("@VAR20", Convert.ToSingle(TextBox20.Text))
                    comando.Parameters.AddWithValue("@VAR21", Convert.ToSingle(TextBox21.Text))
                    comando.Parameters.AddWithValue("@VAR22", Convert.ToSingle(TextBox22.Text))
                    comando.Parameters.AddWithValue("@VAR23", Convert.ToSingle(TextBox23.Text))
                    comando.Parameters.AddWithValue("@VAR24", Convert.ToSingle(TextBox24.Text))
                    comando.Parameters.AddWithValue("@VAR25", Convert.ToSingle(TextBox25.Text))
                    comando.Parameters.AddWithValue("@VAR26", Convert.ToSingle(TextBox26.Text))
                    comando.Parameters.AddWithValue("@VAR27", Convert.ToSingle(TextBox27.Text))
                    comando.Parameters.AddWithValue("@VAR28", Convert.ToSingle(TextBox28.Text))
                    comando.Parameters.AddWithValue("@VAR29", Convert.ToSingle(TextBox29.Text))
                    comando.Parameters.AddWithValue("@VAR30", Convert.ToSingle(TextBox30.Text))
                    comando.Parameters.AddWithValue("@VAR31", Convert.ToSingle(TextBox31.Text))
                    comando.Parameters.AddWithValue("@VAR32", Convert.ToSingle(TextBox32.Text))
                    comando.Parameters.AddWithValue("@VAR33", Convert.ToSingle(TextBox33.Text))
                    comando.Parameters.AddWithValue("@VAR34", Convert.ToSingle(TextBox34.Text))
                    comando.Parameters.AddWithValue("@VAR35", Convert.ToSingle(TextBox35.Text))
                    comando.Parameters.AddWithValue("@VAR36", Convert.ToSingle(TextBox36.Text))
                    comando.Parameters.AddWithValue("@VAR37", Convert.ToSingle(TextBox37.Text))
                    comando.Parameters.AddWithValue("@VAR38", Convert.ToSingle(TextBox38.Text))
                    comando.Parameters.AddWithValue("@VAR39", Convert.ToSingle(TextBox39.Text))
                    comando.Parameters.AddWithValue("@VAR40", Convert.ToSingle(TextBox40.Text))
                    comando.Parameters.AddWithValue("@VAR41", Convert.ToSingle(TextBox41.Text))
                    comando.Parameters.AddWithValue("@VAR42", Convert.ToSingle(TextBox42.Text))
                    comando.Parameters.AddWithValue("@VAR43", Convert.ToSingle(TextBox43.Text))
                    comando.Parameters.AddWithValue("@VAR44", Convert.ToSingle(TextBox44.Text))
                    comando.Parameters.AddWithValue("@VAR45", Convert.ToSingle(TextBox45.Text))
                    comando.Parameters.AddWithValue("@VAR46", Convert.ToSingle(TextBox46.Text))
                    comando.Parameters.AddWithValue("@VAR47", Convert.ToSingle(TextBox47.Text))
                    comando.Parameters.AddWithValue("@VAR48", Convert.ToSingle(TextBox48.Text))
                    comando.Parameters.AddWithValue("@VAR49", Convert.ToSingle(TextBox49.Text))
                    comando.Parameters.AddWithValue("@VAR50", Convert.ToSingle(TextBox50.Text))
                    comando.Parameters.AddWithValue("@VAR51", Convert.ToSingle(TextBox51.Text))
                    comando.Parameters.AddWithValue("@VAR52", Convert.ToSingle(TextBox52.Text))
                    comando.Parameters.AddWithValue("@VAR53", Convert.ToSingle(TextBox53.Text))
                    comando.Parameters.AddWithValue("@VAR54", Convert.ToSingle(TextBox54.Text))
                    comando.Parameters.AddWithValue("@VAR55", Convert.ToSingle(TextBox55.Text))
                    comando.Parameters.AddWithValue("@VAR56", Convert.ToSingle(TextBox56.Text))
                    comando.Parameters.AddWithValue("@VAR57", Convert.ToSingle(TextBox57.Text))
                    comando.Parameters.AddWithValue("@VAR58", Convert.ToSingle(TextBox58.Text))
                    comando.Parameters.AddWithValue("@VAR59", Convert.ToSingle(TextBox59.Text))
                    ' Ejecutar la consulta
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
            Panel3.Enabled = False
        ElseIf Panel3.Visible = False Then
            Panel3.Visible = True
            Panel3.Enabled = True
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If Panel4.Visible = True Then
            Panel4.Visible = False
            Panel4.Enabled = False
        ElseIf Panel4.Visible = False Then
            Panel4.Visible = True
            Panel4.Enabled = True
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If Panel5.Visible = True Then
            Panel5.Visible = False
            Panel5.Enabled = False
        ElseIf Panel5.Visible = False Then
            Panel5.Visible = True
            Panel5.Enabled = True
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If Panel6.Visible = True Then
            Panel6.Visible = False
            Panel6.Enabled = False
        ElseIf Panel6.Visible = False Then
            Panel6.Visible = True
            Panel6.Enabled = True
        End If
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        If Panel7.Visible = True Then
            Panel7.Visible = False
            Panel7.Enabled = False
        ElseIf Panel7.Visible = False Then
            Panel7.Visible = True
            Panel7.Enabled = True
        End If
    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click
        If Panel8.Visible = True Then
            Panel8.Visible = False
            Panel8.Enabled = False
        ElseIf Panel8.Visible = False Then
            Panel8.Visible = True
            Panel8.Enabled = True
        End If
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs) Handles Label41.Click
        If Panel9.Visible = True Then
            Panel9.Visible = False
            Panel9.Enabled = False
        ElseIf Panel9.Visible = False Then
            Panel9.Visible = True
            Panel9.Enabled = True
        End If
    End Sub

    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click
        If Panel10.Visible = True Then
            Panel10.Visible = False
            Panel10.Enabled = False
        ElseIf Panel10.Visible = False Then
            Panel10.Visible = True
            Panel10.Enabled = True
        End If
    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click
        If Panel11.Visible = True Then
            Panel11.Visible = False
            Panel11.Enabled = False
        ElseIf Panel11.Visible = False Then
            Panel11.Visible = True
            Panel11.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus, TextBox2.GotFocus, TextBox3.GotFocus, TextBox4.GotFocus, TextBox5.GotFocus, TextBox6.GotFocus, TextBox7.GotFocus, TextBox8.GotFocus, TextBox9.GotFocus, TextBox10.GotFocus, TextBox11.GotFocus, TextBox12.GotFocus, TextBox13.GotFocus, TextBox14.GotFocus, TextBox15.GotFocus, TextBox16.GotFocus, TextBox17.GotFocus, TextBox18.GotFocus, TextBox19.GotFocus, TextBox20.GotFocus, TextBox21.GotFocus, TextBox22.GotFocus, TextBox23.GotFocus, TextBox24.GotFocus, TextBox25.GotFocus, TextBox26.GotFocus, TextBox27.GotFocus, TextBox28.GotFocus, TextBox29.GotFocus, TextBox30.GotFocus, TextBox31.GotFocus, TextBox32.GotFocus, TextBox32.GotFocus, TextBox33.GotFocus, TextBox34.GotFocus, TextBox35.GotFocus, TextBox36.GotFocus, TextBox37.GotFocus, TextBox38.GotFocus, TextBox39.GotFocus, TextBox40.GotFocus, TextBox41.GotFocus, TextBox42.GotFocus, TextBox43.GotFocus, TextBox44.GotFocus, TextBox45.GotFocus, TextBox46.GotFocus, TextBox47.GotFocus, TextBox48.GotFocus, TextBox49.GotFocus, TextBox50.GotFocus, TextBox51.GotFocus, TextBox52.GotFocus, TextBox53.GotFocus, TextBox54.GotFocus, TextBox55.GotFocus, TextBox56.GotFocus, TextBox57.GotFocus, TextBox58.GotFocus, TextBox59.GotFocus
        ' Obtén el TextBox que ha recibido el foco
        Dim textBoxSeleccionado As TextBox = DirectCast(sender, TextBox)
        textBoxSeleccionado.Text = ""
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus, TextBox2.LostFocus, TextBox3.LostFocus, TextBox4.LostFocus, TextBox5.LostFocus, TextBox6.LostFocus, TextBox7.LostFocus, TextBox8.LostFocus, TextBox9.LostFocus, TextBox10.LostFocus, TextBox11.LostFocus, TextBox12.LostFocus, TextBox13.LostFocus, TextBox14.LostFocus, TextBox15.LostFocus, TextBox16.LostFocus, TextBox17.LostFocus, TextBox18.LostFocus, TextBox19.LostFocus, TextBox20.LostFocus, TextBox21.LostFocus, TextBox22.LostFocus, TextBox23.LostFocus, TextBox24.LostFocus, TextBox25.LostFocus, TextBox26.LostFocus, TextBox27.LostFocus, TextBox28.LostFocus, TextBox29.LostFocus, TextBox30.LostFocus, TextBox31.LostFocus, TextBox32.LostFocus, TextBox33.LostFocus, TextBox34.LostFocus, TextBox35.LostFocus, TextBox36.LostFocus, TextBox37.LostFocus, TextBox38.LostFocus, TextBox39.LostFocus, TextBox40.LostFocus, TextBox41.LostFocus, TextBox42.LostFocus, TextBox43.LostFocus, TextBox44.LostFocus, TextBox45.LostFocus, TextBox46.LostFocus, TextBox47.LostFocus, TextBox48.LostFocus, TextBox49.LostFocus, TextBox50.LostFocus, TextBox51.LostFocus, TextBox52.LostFocus, TextBox53.LostFocus, TextBox54.LostFocus, TextBox55.LostFocus, TextBox56.LostFocus, TextBox57.LostFocus, TextBox58.LostFocus, TextBox59.LostFocus
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
        If TextBox12.Text = "" Then
            TextBox12.Text = "0,01"
        End If
        If TextBox13.Text = "" Then
            TextBox13.Text = "0,01"
        End If
        If TextBox14.Text = "" Then
            TextBox14.Text = "0,01"
        End If
        If TextBox15.Text = "" Then
            TextBox15.Text = "0,01"
        End If
        If TextBox16.Text = "" Then
            TextBox16.Text = "0,01"
        End If
        If TextBox17.Text = "" Then
            TextBox17.Text = "0,01"
        End If
        If TextBox18.Text = "" Then
            TextBox18.Text = "0,01"
        End If
        If TextBox19.Text = "" Then
            TextBox19.Text = "0,01"
        End If
        If TextBox20.Text = "" Then
            TextBox20.Text = "0,01"
        End If
        If TextBox21.Text = "" Then
            TextBox21.Text = "0,01"
        End If
        If TextBox22.Text = "" Then
            TextBox22.Text = "0,01"
        End If
        If TextBox23.Text = "" Then
            TextBox23.Text = "0,01"
        End If
        If TextBox24.Text = "" Then
            TextBox24.Text = "0,01"
        End If
        If TextBox25.Text = "" Then
            TextBox25.Text = "0,01"
        End If
        If TextBox26.Text = "" Then
            TextBox26.Text = "0,01"
        End If
        If TextBox27.Text = "" Then
            TextBox27.Text = "0,01"
        End If
        If TextBox28.Text = "" Then
            TextBox28.Text = "0,01"
        End If
        If TextBox29.Text = "" Then
            TextBox29.Text = "0,01"
        End If
        If TextBox30.Text = "" Then
            TextBox30.Text = "0,01"
        End If
        If TextBox31.Text = "" Then
            TextBox31.Text = "0,01"
        End If
        If TextBox32.Text = "" Then
            TextBox32.Text = "0,01"
        End If
        If TextBox33.Text = "" Then
            TextBox33.Text = "0,01"
        End If
        If TextBox34.Text = "" Then
            TextBox34.Text = "0,01"
        End If
        If TextBox35.Text = "" Then
            TextBox35.Text = "0,01"
        End If
        If TextBox36.Text = "" Then
            TextBox36.Text = "0,01"
        End If
        If TextBox37.Text = "" Then
            TextBox37.Text = "0,01"
        End If
        If TextBox38.Text = "" Then
            TextBox38.Text = "0,01"
        End If
        If TextBox39.Text = "" Then
            TextBox39.Text = "0,01"
        End If
        If TextBox40.Text = "" Then
            TextBox40.Text = "0,01"
        End If
        If TextBox41.Text = "" Then
            TextBox41.Text = "0,01"
        End If
        If TextBox42.Text = "" Then
            TextBox42.Text = "0,01"
        End If
        If TextBox43.Text = "" Then
            TextBox43.Text = "0,01"
        End If
        If TextBox44.Text = "" Then
            TextBox44.Text = "0,01"
        End If
        If TextBox45.Text = "" Then
            TextBox45.Text = "0,01"
        End If
        If TextBox46.Text = "" Then
            TextBox46.Text = "0,01"
        End If
        If TextBox47.Text = "" Then
            TextBox47.Text = "0,01"
        End If
        If TextBox48.Text = "" Then
            TextBox48.Text = "0,01"
        End If
        If TextBox49.Text = "" Then
            TextBox49.Text = "0,01"
        End If
        If TextBox50.Text = "" Then
            TextBox50.Text = "0,01"
        End If
        If TextBox51.Text = "" Then
            TextBox51.Text = "0,01"
        End If
        If TextBox52.Text = "" Then
            TextBox52.Text = "0,01"
        End If
        If TextBox53.Text = "" Then
            TextBox53.Text = "0,01"
        End If
        If TextBox54.Text = "" Then
            TextBox54.Text = "0,01"
        End If
        If TextBox55.Text = "" Then
            TextBox55.Text = "0,01"
        End If
        If TextBox56.Text = "" Then
            TextBox56.Text = "0,01"
        End If
        If TextBox57.Text = "" Then
            TextBox57.Text = "0,01"
        End If
        If TextBox58.Text = "" Then
            TextBox58.Text = "0,01"
        End If
        If TextBox59.Text = "" Then
            TextBox59.Text = "0,01"
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
        TextBox12.Enabled = True
        TextBox13.Enabled = True
        TextBox14.Enabled = True
        TextBox15.Enabled = True
        TextBox16.Enabled = True
        TextBox17.Enabled = True
        TextBox18.Enabled = True
        TextBox19.Enabled = True
        TextBox20.Enabled = True
        TextBox21.Enabled = True
        TextBox22.Enabled = True
        TextBox23.Enabled = True
        TextBox24.Enabled = True
        TextBox25.Enabled = True
        TextBox26.Enabled = True
        TextBox27.Enabled = True
        TextBox28.Enabled = True
        TextBox29.Enabled = True
        TextBox30.Enabled = True
        TextBox31.Enabled = True
        TextBox32.Enabled = True
        TextBox33.Enabled = True
        TextBox34.Enabled = True
        TextBox35.Enabled = True
        TextBox36.Enabled = True
        TextBox37.Enabled = True
        TextBox38.Enabled = True
        TextBox39.Enabled = True
        TextBox40.Enabled = True
        TextBox41.Enabled = True
        TextBox42.Enabled = True
        TextBox43.Enabled = True
        TextBox44.Enabled = True
        TextBox45.Enabled = True
        TextBox46.Enabled = True
        TextBox47.Enabled = True
        TextBox48.Enabled = True
        TextBox49.Enabled = True
        TextBox50.Enabled = True
        TextBox51.Enabled = True
        TextBox52.Enabled = True
        TextBox53.Enabled = True
        TextBox54.Enabled = True
        TextBox55.Enabled = True
        TextBox56.Enabled = True
        TextBox57.Enabled = True
        TextBox58.Enabled = True
        TextBox59.Enabled = True
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
        If TextBox12.Text <> "" Then
            TextBox12.Enabled = False
        End If
        If TextBox13.Text <> "" Then
            TextBox13.Enabled = False
        End If
        If TextBox14.Text <> "" Then
            TextBox14.Enabled = False
        End If
        If TextBox15.Text <> "" Then
            TextBox15.Enabled = False
        End If
        If TextBox16.Text <> "" Then
            TextBox16.Enabled = False
        End If
        If TextBox17.Text <> "" Then
            TextBox17.Enabled = False
        End If
        If TextBox18.Text <> "" Then
            TextBox18.Enabled = False
        End If
        If TextBox19.Text <> "" Then
            TextBox19.Enabled = False
        End If
        If TextBox20.Text <> "" Then
            TextBox20.Enabled = False
        End If
        If TextBox21.Text <> "" Then
            TextBox21.Enabled = False
        End If
        If TextBox22.Text <> "" Then
            TextBox22.Enabled = False
        End If
        If TextBox23.Text <> "" Then
            TextBox23.Enabled = False
        End If
        If TextBox24.Text <> "" Then
            TextBox24.Enabled = False
        End If
        If TextBox25.Text <> "" Then
            TextBox25.Enabled = False
        End If
        If TextBox26.Text <> "" Then
            TextBox26.Enabled = False
        End If
        If TextBox27.Text <> "" Then
            TextBox27.Enabled = False
        End If
        If TextBox28.Text <> "" Then
            TextBox28.Enabled = False
        End If
        If TextBox29.Text <> "" Then
            TextBox29.Enabled = False
        End If
        If TextBox30.Text <> "" Then
            TextBox30.Enabled = False
        End If
        If TextBox31.Text <> "" Then
            TextBox31.Enabled = False
        End If
        If TextBox32.Text <> "" Then
            TextBox32.Enabled = False
        End If
        If TextBox33.Text <> "" Then
            TextBox33.Enabled = False
        End If
        If TextBox34.Text <> "" Then
            TextBox34.Enabled = False
        End If
        If TextBox35.Text <> "" Then
            TextBox35.Enabled = False
        End If
        If TextBox36.Text <> "" Then
            TextBox36.Enabled = False
        End If
        If TextBox37.Text <> "" Then
            TextBox37.Enabled = False
        End If
        If TextBox38.Text <> "" Then
            TextBox38.Enabled = False
        End If
        If TextBox39.Text <> "" Then
            TextBox39.Enabled = False
        End If
        If TextBox40.Text <> "" Then
            TextBox40.Enabled = False
        End If
        If TextBox41.Text <> "" Then
            TextBox41.Enabled = False
        End If
        If TextBox42.Text <> "" Then
            TextBox42.Enabled = False
        End If
        If TextBox43.Text <> "" Then
            TextBox43.Enabled = False
        End If
        If TextBox44.Text <> "" Then
            TextBox44.Enabled = False
        End If
        If TextBox45.Text <> "" Then
            TextBox45.Enabled = False
        End If
        If TextBox46.Text <> "" Then
            TextBox46.Enabled = False
        End If
        If TextBox47.Text <> "" Then
            TextBox47.Enabled = False
        End If
        If TextBox48.Text <> "" Then
            TextBox48.Enabled = False
        End If
        If TextBox49.Text <> "" Then
            TextBox49.Enabled = False
        End If
        If TextBox50.Text <> "" Then
            TextBox50.Enabled = False
        End If
        If TextBox51.Text <> "" Then
            TextBox51.Enabled = False
        End If
        If TextBox52.Text <> "" Then
            TextBox52.Enabled = False
        End If
        If TextBox53.Text <> "" Then
            TextBox53.Enabled = False
        End If
        If TextBox54.Text <> "" Then
            TextBox54.Enabled = False
        End If
        If TextBox55.Text <> "" Then
            TextBox55.Enabled = False
        End If
        If TextBox56.Text <> "" Then
            TextBox56.Enabled = False
        End If
        If TextBox57.Text <> "" Then
            TextBox57.Enabled = False
        End If
        If TextBox58.Text <> "" Then
            TextBox58.Enabled = False
        End If
        If TextBox59.Text <> "" Then
            TextBox59.Enabled = False
        End If
    End Sub


End Class