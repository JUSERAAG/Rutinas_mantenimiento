<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.CmbMantenimiento = New System.Windows.Forms.ComboBox()
        Me.CmbArea = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbEquipo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CmbMantenimiento
        '
        Me.CmbMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbMantenimiento.Font = New System.Drawing.Font("Franklin Gothic Medium", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.CmbMantenimiento.FormattingEnabled = True
        Me.CmbMantenimiento.Location = New System.Drawing.Point(50, 331)
        Me.CmbMantenimiento.Name = "CmbMantenimiento"
        Me.CmbMantenimiento.Size = New System.Drawing.Size(355, 51)
        Me.CmbMantenimiento.TabIndex = 0
        '
        'CmbArea
        '
        Me.CmbArea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbArea.Font = New System.Drawing.Font("Franklin Gothic Medium", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.CmbArea.FormattingEnabled = True
        Me.CmbArea.Location = New System.Drawing.Point(459, 331)
        Me.CmbArea.Name = "CmbArea"
        Me.CmbArea.Size = New System.Drawing.Size(355, 51)
        Me.CmbArea.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 63)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mantenimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ImageKey = "(ninguna)"
        Me.Label2.Location = New System.Drawing.Point(456, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 63)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Área"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(497, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 63)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "FORMULARIOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(869, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 63)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo"
        '
        'CmbEquipo
        '
        Me.CmbEquipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbEquipo.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CmbEquipo.FormattingEnabled = True
        Me.CmbEquipo.Location = New System.Drawing.Point(869, 331)
        Me.CmbEquipo.Name = "CmbEquipo"
        Me.CmbEquipo.Size = New System.Drawing.Size(355, 51)
        Me.CmbEquipo.TabIndex = 6
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 749)
        Me.Controls.Add(Me.CmbEquipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbArea)
        Me.Controls.Add(Me.CmbMantenimiento)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrincipal"
        Me.Text = "FORMULARIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbMantenimiento As ComboBox
    Friend WithEvents CmbArea As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbEquipo As ComboBox
End Class
