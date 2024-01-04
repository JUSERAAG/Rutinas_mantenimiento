Imports System.Threading
Imports System.Windows.Forms

Public Class FormBienvenida
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FormBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized ' Maximizar ventana
        ' Establece el intervalo del temporizador en milisegundos (por ejemplo, 3000 para 3 segundos)
        Timer1.Interval = 3000
        ' Inicia el temporizador cuando se carga el formulario
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Cuando el temporizador alcanza su intervalo, detén el temporizador y muestra el formulario principal
        Timer1.Stop()

        ' Crea e muestra el formulario principal
        Dim formularioPrincipal As New FormPrincipal()
        formularioPrincipal.Show()

        ' Cierra el formulario actual (de bienvenida)
        Me.Hide()
    End Sub
End Class
