Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports MaterialSkin
<BrowsableAttribute(False)>
Public Event Closing As CancelEventHandler

Public Class PKMNV
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Call ComboINIT()
    End Sub
    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Programm beenden
        Application.Exit()
    End Sub 'Form1_Closing
    Private Sub SwitchToMainButton_Click(sender As Object, e As EventArgs) Handles SwitchToMainButton.Click
        'Switch zur Main-Form
        Hide()
        Call Main.ComboINIT()
        Main.Show()
    End Sub
    Private Sub PKMNEncounterTextFeld_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PKMNEncounterTextFeld.KeyPress
        If e.KeyChar < Chr(48) Or e.KeyChar > Chr(57) Then 'Verbiete Nicht Zahlen
            If Asc(e.KeyChar) = 8 Then 'Erlaube Backspace
                'do nothing
            Else
                e.KeyChar = Nothing
                MsgBox("Hier dürfen nur Zahlen stehen, du Pleb!", 48, "Fehler - Pokémon Encounter-Tool v1.1")
            End If
        End If
    End Sub
    Public Sub PKMNDBWriter()
        Dim ini As New INIDatei(Application.StartupPath + "\PKMNDB.ini")
        'WertSchreiben(ByVal Sektion As String, ByVal Schlüssel As String, ByVal Wert As String)
        If File.Exists(Application.StartupPath + "\PKMNDB.ini") Then
            ini.WertSchreiben("PKMN", "Count", Convert.ToInt32(ini.WertLesen("PKMN", "Count")) + 1)
        Else
            ini.WertSchreiben("PKMN", "Count", "1")
        End If
        If String.IsNullOrEmpty(PKMNEncounterTextFeld.Text.ToString()) Then
            ini.WertSchreiben("PKMN", Convert.ToInt32(ini.WertLesen("PKMN", "Count")), PKMNNameTextFeld.Text & "_0")
        Else
            ini.WertSchreiben("PKMN", Convert.ToInt32(ini.WertLesen("PKMN", "Count")), PKMNNameTextFeld.Text & "_" & PKMNEncounterTextFeld.Text)
        End If
        Call ComboINIT()
    End Sub
    Public Sub PKMNDBDeleter()
        If Not (PokémonListComboBox.SelectedIndex.ToString().Equals("-1")) Then
            Dim ini As New INIDatei(Application.StartupPath + "\PKMNDB.ini")
            ini.SchlüsselLöschen("PKMN", PokémonListComboBox.SelectedIndex + 1)
            ini.WertSchreiben("PKMN", "Count", CInt(ini.WertLesen("PKMN", "Count")) - 1)
            PKMNNameTextFeld.Text = ""
            PKMNEncounterTextFeld.Text = ""
            Call ComboINIT()
        Else
            MsgBox("Kein Pokémon Ausgewählt!", 64, "Informartion - Pokémon Encounter-Tool v1.1")
        End If

    End Sub
    Private Sub PKMNAddButton_Click(sender As Object, e As EventArgs) Handles PKMNAddButton.Click
        If PKMNNameTextFeld.Text IsNot "" Then
            Call PKMNDBWriter()
        Else
            MsgBox("Du musst deinem Pokémon schon einen Namen geben! :I", 64, "Informartion - Pokémon Encounter-Tool v1.1")
        End If
    End Sub

    Private Sub PKMNRemoveButton_Click(sender As Object, e As EventArgs) Handles PKMNRemoveButton.Click
        Call PKMNDBDeleter()
    End Sub
    Public Sub ComboINIT()
        If File.Exists(Application.StartupPath + "\PKMNDB.ini") Then
            Dim ini As New INIDatei(Application.StartupPath + "\PKMNDB.ini"), count As Integer, i As Integer
            count = CInt(ini.WertLesen("PKMN", "Count"))
            PokémonListComboBox.Items.Clear()
            For i = 1 To count
                Dim Wert As String
                Dim Werte() As String
                Wert = ini.WertLesen("PKMN", CStr(i))
                Werte = Wert.Split("_")
                PokémonListComboBox.Items.Add(Werte(0))
            Next i
        End If
    End Sub

    Private Sub PokémonListComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PokémonListComboBox.SelectedIndexChanged
        Dim ini As New INIDatei(Application.StartupPath + "\PKMNDB.ini"), count As Integer, i As Integer
        Dim Wert As String
        Dim Werte() As String
        Wert = ini.WertLesen("PKMN", PokémonListComboBox.SelectedIndex + 1)
        Werte = Wert.Split("_")
        PKMNNameTextFeld.Text = Werte(0)
        PKMNEncounterTextFeld.Text = Werte(1)
    End Sub
End Class