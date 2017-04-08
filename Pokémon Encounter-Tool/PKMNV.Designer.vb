<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PKMNV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PKMNV))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.PokémonListComboBox = New System.Windows.Forms.ComboBox()
        Me.PKMNAddButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.PKMNRemoveButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SwitchToMainButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.PKMNNameTextFeld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PKMNEncounterTextFeld = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 73)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Pokémon"
        '
        'PokémonListComboBox
        '
        Me.PokémonListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PokémonListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PokémonListComboBox.FormattingEnabled = True
        Me.PokémonListComboBox.Location = New System.Drawing.Point(91, 74)
        Me.PokémonListComboBox.Name = "PokémonListComboBox"
        Me.PokémonListComboBox.Size = New System.Drawing.Size(335, 21)
        Me.PokémonListComboBox.TabIndex = 1
        '
        'PKMNAddButton
        '
        Me.PKMNAddButton.AutoSize = True
        Me.PKMNAddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PKMNAddButton.Depth = 0
        Me.PKMNAddButton.Location = New System.Drawing.Point(91, 168)
        Me.PKMNAddButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PKMNAddButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.PKMNAddButton.Name = "PKMNAddButton"
        Me.PKMNAddButton.Primary = False
        Me.PKMNAddButton.Size = New System.Drawing.Size(96, 36)
        Me.PKMNAddButton.TabIndex = 2
        Me.PKMNAddButton.Text = "Hinzufügen"
        Me.PKMNAddButton.UseVisualStyleBackColor = True
        '
        'PKMNRemoveButton
        '
        Me.PKMNRemoveButton.AutoSize = True
        Me.PKMNRemoveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PKMNRemoveButton.Depth = 0
        Me.PKMNRemoveButton.Location = New System.Drawing.Point(195, 168)
        Me.PKMNRemoveButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.PKMNRemoveButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.PKMNRemoveButton.Name = "PKMNRemoveButton"
        Me.PKMNRemoveButton.Primary = False
        Me.PKMNRemoveButton.Size = New System.Drawing.Size(89, 36)
        Me.PKMNRemoveButton.TabIndex = 3
        Me.PKMNRemoveButton.Text = "Entfernen"
        Me.PKMNRemoveButton.UseVisualStyleBackColor = True
        '
        'SwitchToMainButton
        '
        Me.SwitchToMainButton.AutoSize = True
        Me.SwitchToMainButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SwitchToMainButton.Depth = 0
        Me.SwitchToMainButton.Location = New System.Drawing.Point(361, 168)
        Me.SwitchToMainButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.SwitchToMainButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.SwitchToMainButton.Name = "SwitchToMainButton"
        Me.SwitchToMainButton.Primary = False
        Me.SwitchToMainButton.Size = New System.Drawing.Size(64, 36)
        Me.SwitchToMainButton.TabIndex = 4
        Me.SwitchToMainButton.Text = "Zurück"
        Me.SwitchToMainButton.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 107)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(49, 19)
        Me.MaterialLabel2.TabIndex = 5
        Me.MaterialLabel2.Text = "Name"
        '
        'PKMNNameTextFeld
        '
        Me.PKMNNameTextFeld.Depth = 0
        Me.PKMNNameTextFeld.Hint = ""
        Me.PKMNNameTextFeld.Location = New System.Drawing.Point(91, 107)
        Me.PKMNNameTextFeld.MouseState = MaterialSkin.MouseState.HOVER
        Me.PKMNNameTextFeld.Name = "PKMNNameTextFeld"
        Me.PKMNNameTextFeld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PKMNNameTextFeld.SelectedText = ""
        Me.PKMNNameTextFeld.SelectionLength = 0
        Me.PKMNNameTextFeld.SelectionStart = 0
        Me.PKMNNameTextFeld.Size = New System.Drawing.Size(335, 23)
        Me.PKMNNameTextFeld.TabIndex = 6
        Me.PKMNNameTextFeld.UseSystemPasswordChar = False
        '
        'PKMNEncounterTextFeld
        '
        Me.PKMNEncounterTextFeld.Depth = 0
        Me.PKMNEncounterTextFeld.Hint = ""
        Me.PKMNEncounterTextFeld.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PKMNEncounterTextFeld.Location = New System.Drawing.Point(91, 136)
        Me.PKMNEncounterTextFeld.MouseState = MaterialSkin.MouseState.HOVER
        Me.PKMNEncounterTextFeld.Name = "PKMNEncounterTextFeld"
        Me.PKMNEncounterTextFeld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PKMNEncounterTextFeld.SelectedText = ""
        Me.PKMNEncounterTextFeld.SelectionLength = 0
        Me.PKMNEncounterTextFeld.SelectionStart = 0
        Me.PKMNEncounterTextFeld.Size = New System.Drawing.Size(335, 23)
        Me.PKMNEncounterTextFeld.TabIndex = 7
        Me.PKMNEncounterTextFeld.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 140)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(77, 19)
        Me.MaterialLabel3.TabIndex = 8
        Me.MaterialLabel3.Text = "Encounter"
        '
        'PKMNV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 216)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.PKMNEncounterTextFeld)
        Me.Controls.Add(Me.PKMNNameTextFeld)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.SwitchToMainButton)
        Me.Controls.Add(Me.PKMNRemoveButton)
        Me.Controls.Add(Me.PKMNAddButton)
        Me.Controls.Add(Me.PokémonListComboBox)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PKMNV"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verwaltung - Pokémon Encounter-Tool v1.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PokémonListComboBox As ComboBox
    Friend WithEvents PKMNAddButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PKMNRemoveButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents SwitchToMainButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PKMNNameTextFeld As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PKMNEncounterTextFeld As MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialLabel
End Class
