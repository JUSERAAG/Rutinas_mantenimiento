Imports System.Data.SqlClient
Imports Rutinas_mantenimiento.consultas
Public Class FormMecanicoPintura
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
                Dim consulta As String = "INSERT INTO dbo.Mecanico_Pintura VALUES (@FECHA,@HORA,@VAR1,@VAR2,@VAR3,@VAR4,@VAR5,@VAR6,@VAR7,@VAR8,@VAR9,@VAR10,@VAR11,@VAR12,@VAR13,@VAR14,@VAR15,@VAR16,@VAR17,@VAR18,@VAR19,@VAR20,@VAR21,@VAR22,@VAR23,@VAR24,@VAR25,@VAR26,@VAR27,@VAR28,@VAR29,@VAR30,@VAR31,@VAR32,@VAR33,@VAR34,@VAR35,@VAR36,@VAR37,@VAR38,@VAR39,@VAR40,@VAR41,@VAR42,@VAR43,@VAR44,@VAR45,@VAR46,@VAR47,@VAR48,@VAR49,@VAR50,@VAR51,@VAR52,@VAR53,@VAR54,@VAR55,@VAR56,@VAR57,@VAR58,@VAR59,@VAR60,@VAR61,@VAR62,@VAR63,@VAR64,@VAR65,@VAR66,@VAR67,@VAR68,@VAR69,@VAR70,@VAR71,@VAR72,@VAR73,@VAR74,@VAR75,@VAR76,@VAR77,@VAR78,@VAR79,@VAR80,@VAR81,@VAR82,@VAR83,@VAR84,@VAR85,@VAR86,@VAR87,@VAR88,@VAR89,@VAR90,@VAR91,@VAR92,@VAR93,@VAR94,@VAR95,@VAR96,@VAR97,@VAR98,@VAR99,@VAR100,@VAR101,@VAR102,@VAR103,@VAR104,@VAR105,@VAR106,@VAR107,@VAR108,@VAR109,@VAR110,@VAR111,@VAR112,@VAR113,@VAR114,@VAR115,@VAR116,@VAR117,@VAR118,@VAR119,@VAR120,@VAR121,@VAR122,@VAR123,@VAR124,@VAR125,@VAR126,@VAR127,@VAR128,@VAR129,@VAR130,@VAR131,@VAR132,@VAR133,@VAR134,@VAR135,@VAR136,@VAR137,@VAR138)"
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
                    comando.Parameters.AddWithValue("@VAR57", If(CheckBox57.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR58", If(CheckBox58.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR59", If(CheckBox59.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR60", If(CheckBox60.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR61", If(CheckBox61.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR62", If(CheckBox62.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR63", If(CheckBox63.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR64", If(CheckBox64.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR65", If(CheckBox65.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR66", If(CheckBox66.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR67", If(CheckBox67.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR68", If(CheckBox68.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR69", If(CheckBox69.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR70", If(CheckBox70.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR71", If(CheckBox71.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR72", If(CheckBox72.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR73", If(CheckBox73.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR74", If(CheckBox74.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR75", If(CheckBox75.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR76", If(CheckBox76.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR77", If(CheckBox77.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR78", If(CheckBox78.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR79", If(CheckBox79.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR80", If(CheckBox80.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR81", If(CheckBox81.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR82", If(CheckBox82.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR83", If(CheckBox83.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR84", If(CheckBox84.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR85", If(CheckBox85.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR86", If(CheckBox86.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR87", If(CheckBox87.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR88", If(CheckBox88.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR89", If(CheckBox89.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR90", If(CheckBox90.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR91", If(CheckBox91.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR92", If(CheckBox92.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR93", If(CheckBox93.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR94", If(CheckBox94.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR95", If(CheckBox95.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR96", If(CheckBox96.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR97", If(CheckBox97.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR98", If(CheckBox98.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR99", If(CheckBox99.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR100", If(CheckBox100.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR101", If(CheckBox101.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR102", If(CheckBox102.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR103", If(CheckBox103.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR104", If(CheckBox104.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR105", If(CheckBox105.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR106", If(CheckBox106.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR107", If(CheckBox107.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR108", If(CheckBox108.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR109", If(CheckBox109.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR110", If(CheckBox110.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR111", If(CheckBox111.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR112", If(CheckBox112.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR113", If(CheckBox113.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR114", If(CheckBox114.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR115", If(CheckBox115.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR116", If(CheckBox116.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR117", If(CheckBox117.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR118", If(CheckBox118.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR119", If(CheckBox119.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR120", If(CheckBox120.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR121", If(CheckBox121.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR122", If(CheckBox122.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR123", If(CheckBox123.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR124", If(CheckBox124.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR125", If(CheckBox125.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR126", If(CheckBox126.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR127", If(CheckBox127.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR128", If(CheckBox128.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR129", If(CheckBox129.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR130", If(CheckBox130.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR131", If(CheckBox131.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR132", If(CheckBox132.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR133", If(CheckBox133.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR134", If(CheckBox134.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR135", If(CheckBox135.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR136", If(CheckBox136.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR137", If(CheckBox137.Checked, 1, 0))
                    comando.Parameters.AddWithValue("@VAR138", TextBox1.Text)
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
        CheckBox57.Checked = False
        CheckBox58.Checked = False
        CheckBox59.Checked = False
        CheckBox60.Checked = False
        CheckBox61.Checked = False
        CheckBox62.Checked = False
        CheckBox63.Checked = False
        CheckBox64.Checked = False
        CheckBox65.Checked = False
        CheckBox66.Checked = False
        CheckBox67.Checked = False
        CheckBox68.Checked = False
        CheckBox69.Checked = False
        CheckBox70.Checked = False
        CheckBox71.Checked = False
        CheckBox72.Checked = False
        CheckBox73.Checked = False
        CheckBox74.Checked = False
        CheckBox75.Checked = False
        CheckBox76.Checked = False
        CheckBox77.Checked = False
        CheckBox78.Checked = False
        CheckBox79.Checked = False
        CheckBox80.Checked = False
        CheckBox81.Checked = False
        CheckBox82.Checked = False
        CheckBox83.Checked = False
        CheckBox84.Checked = False
        CheckBox85.Checked = False
        CheckBox86.Checked = False
        CheckBox87.Checked = False
        CheckBox88.Checked = False
        CheckBox89.Checked = False
        CheckBox90.Checked = False
        CheckBox91.Checked = False
        CheckBox92.Checked = False
        CheckBox93.Checked = False
        CheckBox94.Checked = False
        CheckBox95.Checked = False
        CheckBox96.Checked = False
        CheckBox97.Checked = False
        CheckBox98.Checked = False
        CheckBox99.Checked = False
        CheckBox100.Checked = False
        CheckBox101.Checked = False
        CheckBox102.Checked = False
        CheckBox103.Checked = False
        CheckBox104.Checked = False
        CheckBox105.Checked = False
        CheckBox106.Checked = False
        CheckBox107.Checked = False
        CheckBox108.Checked = False
        CheckBox109.Checked = False
        CheckBox110.Checked = False
        CheckBox111.Checked = False
        CheckBox112.Checked = False
        CheckBox113.Checked = False
        CheckBox114.Checked = False
        CheckBox115.Checked = False
        CheckBox116.Checked = False
        CheckBox117.Checked = False
        CheckBox118.Checked = False
        CheckBox119.Checked = False
        CheckBox120.Checked = False
        CheckBox121.Checked = False
        CheckBox122.Checked = False
        CheckBox123.Checked = False
        CheckBox124.Checked = False
        CheckBox125.Checked = False
        CheckBox126.Checked = False
        CheckBox127.Checked = False
        CheckBox128.Checked = False
        CheckBox129.Checked = False
        CheckBox130.Checked = False
        CheckBox131.Checked = False
        CheckBox132.Checked = False
        CheckBox133.Checked = False
        CheckBox134.Checked = False
        CheckBox135.Checked = False
        CheckBox136.Checked = False
        CheckBox137.Checked = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox100.SelectedIndexChanged
        Select Case ComboBox100.SelectedItem()
            Case "BANDA ALIMENTACIÓN #1"
                Panel1.Visible = True
                Panel1.Enabled = True
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel5.Visible = False
                Panel5.Enabled = False
                Panel6.Visible = False
                Panel6.Enabled = False
                Panel7.Visible = False
                Panel7.Enabled = False
                Panel8.Visible = False
                Panel8.Enabled = False
                Panel9.Visible = False
                Panel9.Enabled = False
                Panel10.Visible = False
                Panel10.Enabled = False
                Panel11.Visible = False
                Panel11.Enabled = False
                Panel12.Visible = False
                Panel12.Enabled = False
                Panel13.Visible = False
                Panel13.Enabled = False
                Panel14.Visible = False
                Panel14.Enabled = False
                Panel15.Visible = False
                Panel15.Enabled = False
                Panel16.Visible = False
                Panel16.Enabled = False
                Panel17.Visible = False
                Panel17.Enabled = False
                Panel18.Visible = False
                Panel18.Enabled = False
                Panel19.Visible = False
                Panel19.Enabled = False
                Panel20.Visible = False
                Panel20.Enabled = False
                Panel21.Visible = False
                Panel21.Enabled = False
                Panel22.Visible = False
                Panel22.Enabled = False
            Case "CABINA PINTURA #1"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = True
                Panel2.Enabled = True
                Panel3.Visible = True
                Panel3.Enabled = True
                Panel4.Visible = True
                Panel4.Enabled = True
                Panel5.Visible = True
                Panel5.Enabled = True
                Panel6.Visible = False
                Panel6.Enabled = False
                Panel7.Visible = False
                Panel7.Enabled = False
                Panel8.Visible = False
                Panel8.Enabled = False
                Panel9.Visible = False
                Panel9.Enabled = False
                Panel10.Visible = False
                Panel10.Enabled = False
                Panel11.Visible = False
                Panel11.Enabled = False
                Panel12.Visible = False
                Panel12.Enabled = False
                Panel13.Visible = False
                Panel13.Enabled = False
                Panel14.Visible = False
                Panel14.Enabled = False
                Panel15.Visible = False
                Panel15.Enabled = False
                Panel16.Visible = False
                Panel16.Enabled = False
                Panel17.Visible = False
                Panel17.Enabled = False
                Panel18.Visible = False
                Panel18.Enabled = False
                Panel19.Visible = False
                Panel19.Enabled = False
                Panel20.Visible = False
                Panel20.Enabled = False
                Panel21.Visible = False
                Panel21.Enabled = False
                Panel22.Visible = False
                Panel22.Enabled = False
            Case "BANDA DE TRANSICIÓN ENTRE CABINA DE PINTURA Y HORNO"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel5.Visible = False
                Panel5.Enabled = False
                Panel6.Visible = True
                Panel6.Enabled = True
                Panel7.Visible = False
                Panel7.Enabled = False
                Panel8.Visible = False
                Panel8.Enabled = False
                Panel9.Visible = False
                Panel9.Enabled = False
                Panel10.Visible = False
                Panel10.Enabled = False
                Panel11.Visible = False
                Panel11.Enabled = False
                Panel12.Visible = False
                Panel12.Enabled = False
                Panel13.Visible = False
                Panel13.Enabled = False
                Panel14.Visible = False
                Panel14.Enabled = False
                Panel15.Visible = False
                Panel15.Enabled = False
                Panel16.Visible = False
                Panel16.Enabled = False
                Panel17.Visible = False
                Panel17.Enabled = False
                Panel18.Visible = False
                Panel18.Enabled = False
                Panel19.Visible = False
                Panel19.Enabled = False
                Panel20.Visible = False
                Panel20.Enabled = False
                Panel21.Visible = False
                Panel21.Enabled = False
                Panel22.Visible = False
                Panel22.Enabled = False
            Case "TUNEL DE CALENTAMIENTO #1"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel5.Visible = False
                Panel5.Enabled = False
                Panel6.Visible = False
                Panel6.Enabled = False
                Panel7.Visible = True
                Panel7.Enabled = True
                Panel8.Visible = True
                Panel8.Enabled = True
                Panel9.Visible = True
                Panel9.Enabled = True
                Panel10.Visible = True
                Panel10.Enabled = True
                Panel11.Visible = False
                Panel11.Enabled = False
                Panel12.Visible = False
                Panel12.Enabled = False
                Panel13.Visible = False
                Panel13.Enabled = False
                Panel14.Visible = False
                Panel14.Enabled = False
                Panel15.Visible = False
                Panel15.Enabled = False
                Panel16.Visible = False
                Panel16.Enabled = False
                Panel17.Visible = False
                Panel17.Enabled = False
                Panel18.Visible = False
                Panel18.Enabled = False
                Panel19.Visible = False
                Panel19.Enabled = False
                Panel20.Visible = False
                Panel20.Enabled = False
                Panel21.Visible = False
                Panel21.Enabled = False
                Panel22.Visible = False
                Panel22.Enabled = False
            Case "CABINA PINTURA #2"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel5.Visible = False
                Panel5.Enabled = False
                Panel6.Visible = False
                Panel6.Enabled = False
                Panel7.Visible = False
                Panel7.Enabled = False
                Panel8.Visible = False
                Panel8.Enabled = False
                Panel9.Visible = False
                Panel9.Enabled = False
                Panel10.Visible = False
                Panel10.Enabled = False
                Panel11.Visible = True
                Panel11.Enabled = True
                Panel12.Visible = True
                Panel12.Enabled = True
                Panel13.Visible = True
                Panel13.Enabled = True
                Panel14.Visible = True
                Panel14.Enabled = True
                Panel15.Visible = False
                Panel15.Enabled = False
                Panel16.Visible = False
                Panel16.Enabled = False
                Panel17.Visible = False
                Panel17.Enabled = False
                Panel18.Visible = False
                Panel18.Enabled = False
                Panel19.Visible = False
                Panel19.Enabled = False
                Panel20.Visible = False
                Panel20.Enabled = False
                Panel21.Visible = False
                Panel21.Enabled = False
                Panel22.Visible = False
                Panel22.Enabled = False
            Case "TUNEL DE CALENTAMIENTO #2"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel5.Visible = False
                Panel5.Enabled = False
                Panel6.Visible = False
                Panel6.Enabled = False
                Panel7.Visible = False
                Panel7.Enabled = False
                Panel8.Visible = False
                Panel8.Enabled = False
                Panel9.Visible = False
                Panel9.Enabled = False
                Panel10.Visible = False
                Panel10.Enabled = False
                Panel11.Visible = False
                Panel11.Enabled = False
                Panel12.Visible = False
                Panel12.Enabled = False
                Panel13.Visible = False
                Panel13.Enabled = False
                Panel14.Visible = False
                Panel14.Enabled = False
                Panel15.Visible = True
                Panel15.Enabled = True
                Panel16.Visible = True
                Panel16.Enabled = True
                Panel17.Visible = True
                Panel17.Enabled = True
                Panel18.Visible = True
                Panel18.Enabled = True
                Panel19.Visible = False
                Panel19.Enabled = False
                Panel20.Visible = False
                Panel20.Enabled = False
                Panel21.Visible = False
                Panel21.Enabled = False
                Panel22.Visible = False
                Panel22.Enabled = False
            Case "TUNEL DE SECADO"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel5.Visible = False
                Panel5.Enabled = False
                Panel6.Visible = False
                Panel6.Enabled = False
                Panel7.Visible = False
                Panel7.Enabled = False
                Panel8.Visible = False
                Panel8.Enabled = False
                Panel9.Visible = False
                Panel9.Enabled = False
                Panel10.Visible = False
                Panel10.Enabled = False
                Panel11.Visible = False
                Panel11.Enabled = False
                Panel12.Visible = False
                Panel12.Enabled = False
                Panel13.Visible = False
                Panel13.Enabled = False
                Panel14.Visible = False
                Panel14.Enabled = False
                Panel15.Visible = False
                Panel15.Enabled = False
                Panel16.Visible = False
                Panel16.Enabled = False
                Panel17.Visible = False
                Panel17.Enabled = False
                Panel18.Visible = False
                Panel18.Enabled = False
                Panel19.Visible = True
                Panel19.Enabled = True
                Panel20.Visible = True
                Panel20.Enabled = True
                Panel21.Visible = True
                Panel21.Enabled = True
                Panel22.Visible = False
                Panel22.Enabled = False
            Case "BANDA SALIDA"
                Panel1.Visible = False
                Panel1.Enabled = False
                Panel2.Visible = False
                Panel2.Enabled = False
                Panel3.Visible = False
                Panel3.Enabled = False
                Panel4.Visible = False
                Panel4.Enabled = False
                Panel5.Visible = False
                Panel5.Enabled = False
                Panel6.Visible = False
                Panel6.Enabled = False
                Panel7.Visible = False
                Panel7.Enabled = False
                Panel8.Visible = False
                Panel8.Enabled = False
                Panel9.Visible = False
                Panel9.Enabled = False
                Panel10.Visible = False
                Panel10.Enabled = False
                Panel11.Visible = False
                Panel11.Enabled = False
                Panel12.Visible = False
                Panel12.Enabled = False
                Panel13.Visible = False
                Panel13.Enabled = False
                Panel14.Visible = False
                Panel14.Enabled = False
                Panel15.Visible = False
                Panel15.Enabled = False
                Panel16.Visible = False
                Panel16.Enabled = False
                Panel17.Visible = False
                Panel17.Enabled = False
                Panel18.Visible = False
                Panel18.Enabled = False
                Panel19.Visible = False
                Panel19.Enabled = False
                Panel20.Visible = False
                Panel20.Enabled = False
                Panel21.Visible = False
                Panel21.Enabled = False
                Panel22.Visible = True
                Panel22.Enabled = True
        End Select
    End Sub

End Class