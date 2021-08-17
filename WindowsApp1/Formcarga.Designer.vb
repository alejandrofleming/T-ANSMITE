<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formcarga
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formcarga))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboPais = New System.Windows.Forms.ComboBox()
        Me.ComboCiudad = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Mistral", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(267, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "---"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Mistral", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(74, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(478, 106)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "A CONTINUACION SELECCIONA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EL PAIS Y PROVINCIA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Mistral", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(101, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(428, 53)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "¡GRACIAS POR ESTAR AQUI!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 45.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-7, -20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(633, 75)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "T  Я  A  N  S  M  I  T  E"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 45.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(-7, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(633, 75)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "T  Я  A  N  S  M  I  T  E"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 45.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-7, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(633, 75)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "T  Я  A  N  S  M  I  T  E"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 45.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(-7, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(633, 75)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "T  Я  A  N  S  M  I  T  E"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 45.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-7, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(633, 75)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "T  Я  A  N  S  M  I  T  E"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 45.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(-7, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(633, 75)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "T  Я  A  N  S  M  I  T  E"
        '
        'ComboPais
        '
        Me.ComboPais.FormattingEnabled = True
        Me.ComboPais.Items.AddRange(New Object() {"Argentina", "Venezuela"})
        Me.ComboPais.Location = New System.Drawing.Point(33, 267)
        Me.ComboPais.Name = "ComboPais"
        Me.ComboPais.Size = New System.Drawing.Size(190, 21)
        Me.ComboPais.TabIndex = 150
        Me.ComboPais.Text = "Selección País"
        '
        'ComboCiudad
        '
        Me.ComboCiudad.FormattingEnabled = True
        Me.ComboCiudad.Location = New System.Drawing.Point(406, 267)
        Me.ComboCiudad.Name = "ComboCiudad"
        Me.ComboCiudad.Size = New System.Drawing.Size(190, 21)
        Me.ComboCiudad.TabIndex = 151
        Me.ComboCiudad.Text = "Selección Ciudad/Provincia"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 49)
        Me.Button1.TabIndex = 152
        Me.Button1.Text = "Continuar"
        Me.ToolTip1.SetToolTip(Me.Button1, "Pulsa para continuar")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Formcarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboCiudad)
        Me.Controls.Add(Me.ComboPais)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formcarga"
        Me.Text = "TЯANSMITE - SELECCION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboPais As ComboBox
    Friend WithEvents ComboCiudad As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
