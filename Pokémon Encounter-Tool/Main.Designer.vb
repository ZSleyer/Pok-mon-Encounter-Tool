<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PokémonListComboBox = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.EncounterNummerTextFeld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Minus1Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ResetButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Plus1Button = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SwitchToPKMNVButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'PokémonListComboBox
        '
        Me.PokémonListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PokémonListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PokémonListComboBox.FormattingEnabled = True
        Me.PokémonListComboBox.Location = New System.Drawing.Point(95, 108)
        Me.PokémonListComboBox.Name = "PokémonListComboBox"
        Me.PokémonListComboBox.Size = New System.Drawing.Size(208, 21)
        Me.PokémonListComboBox.TabIndex = 3
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 79)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(77, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Encounter"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 110)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Pokémon"
        '
        'EncounterNummerTextFeld
        '
        Me.EncounterNummerTextFeld.Depth = 0
        Me.EncounterNummerTextFeld.Hint = ""
        Me.EncounterNummerTextFeld.Location = New System.Drawing.Point(95, 79)
        Me.EncounterNummerTextFeld.MouseState = MaterialSkin.MouseState.HOVER
        Me.EncounterNummerTextFeld.Name = "EncounterNummerTextFeld"
        Me.EncounterNummerTextFeld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EncounterNummerTextFeld.SelectedText = ""
        Me.EncounterNummerTextFeld.SelectionLength = 0
        Me.EncounterNummerTextFeld.SelectionStart = 0
        Me.EncounterNummerTextFeld.Size = New System.Drawing.Size(208, 23)
        Me.EncounterNummerTextFeld.TabIndex = 0
        Me.EncounterNummerTextFeld.UseSystemPasswordChar = False
        '
        'Minus1Button
        '
        Me.Minus1Button.AutoSize = True
        Me.Minus1Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Minus1Button.Depth = 0
        Me.Minus1Button.Location = New System.Drawing.Point(310, 71)
        Me.Minus1Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Minus1Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Minus1Button.Name = "Minus1Button"
        Me.Minus1Button.Primary = False
        Me.Minus1Button.Size = New System.Drawing.Size(24, 36)
        Me.Minus1Button.TabIndex = 4
        Me.Minus1Button.Text = "-1"
        Me.Minus1Button.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.AutoSize = True
        Me.ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ResetButton.Depth = 0
        Me.ResetButton.Location = New System.Drawing.Point(362, 71)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ResetButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Primary = False
        Me.ResetButton.Size = New System.Drawing.Size(53, 36)
        Me.ResetButton.TabIndex = 5
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Plus1Button
        '
        Me.Plus1Button.AutoSize = True
        Me.Plus1Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Plus1Button.Depth = 0
        Me.Plus1Button.Location = New System.Drawing.Point(444, 71)
        Me.Plus1Button.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Plus1Button.MouseState = MaterialSkin.MouseState.HOVER
        Me.Plus1Button.Name = "Plus1Button"
        Me.Plus1Button.Primary = False
        Me.Plus1Button.Size = New System.Drawing.Size(27, 36)
        Me.Plus1Button.TabIndex = 6
        Me.Plus1Button.Text = "+1"
        Me.Plus1Button.UseVisualStyleBackColor = True
        '
        'SwitchToPKMNVButton
        '
        Me.SwitchToPKMNVButton.AutoSize = True
        Me.SwitchToPKMNVButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SwitchToPKMNVButton.Depth = 0
        Me.SwitchToPKMNVButton.Location = New System.Drawing.Point(310, 102)
        Me.SwitchToPKMNVButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SwitchToPKMNVButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.SwitchToPKMNVButton.Name = "SwitchToPKMNVButton"
        Me.SwitchToPKMNVButton.Primary = False
        Me.SwitchToPKMNVButton.Size = New System.Drawing.Size(161, 36)
        Me.SwitchToPKMNVButton.TabIndex = 7
        Me.SwitchToPKMNVButton.Text = "Pokémon Verwalten"
        Me.SwitchToPKMNVButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 147)
        Me.Controls.Add(Me.EncounterNummerTextFeld)
        Me.Controls.Add(Me.SwitchToPKMNVButton)
        Me.Controls.Add(Me.Plus1Button)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Minus1Button)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.PokémonListComboBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hauptmenü - Pokémon Encounter-Tool v1.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PokémonListComboBox As ComboBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents EncounterNummerTextFeld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Minus1Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ResetButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Plus1Button As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents SwitchToPKMNVButton As MaterialSkin.Controls.MaterialFlatButton
End Class
