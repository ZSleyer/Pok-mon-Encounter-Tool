Imports MaterialSkin
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        Call ComboINIT()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub SwitchToPKMNVButton_Click(sender As Object, e As EventArgs) Handles SwitchToPKMNVButton.Click
        'Switch zur Pokémon Verwaltungs-Form
        Hide()
        Call PKMNV.ComboINIT()
        PKMNV.Show()
    End Sub
    Private Sub EncounterNummerTextFeld_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EncounterNummerTextFeld.KeyPress
        If e.KeyChar < Chr(48) Or e.KeyChar > Chr(57) Then 'Verbiete Nicht Zahlen
            If Asc(e.KeyChar) = 8 Then 'Erlaube Backspace
                'do nothing
            Else
                e.KeyChar = Nothing
                MsgBox("Hier dürfen nur Zahlen stehen, du Pleb!", 48, "Fehler - Pokémon Encounter-Tool v1.1")
            End If
        End If
    End Sub

    Private Sub Minus1Button_Click(sender As Object, e As EventArgs) Handles Minus1Button.Click
        Call EncounterMinus
    End Sub

    Private Sub Plus1Button_Click(sender As Object, e As EventArgs) Handles Plus1Button.Click
        Call EncounterPlus()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Call EncounterReset()
    End Sub
    Public Sub EncounterMinus()
        If PokémonListComboBox.Text = "" Then
            MsgBox("Bitte wähle erst ein Pokémon aus!", 48, "Fehler - Pokémon Encounter-Tool v1.1")
        Else
            Dim DoDaMathMinus As Single
            If String.IsNullOrEmpty(EncounterNummerTextFeld.Text) Then
                MsgBox("Du bist auch so n' Nullnummer, Mr. Pleb!", 48, "Fehler - Pokémon Encounter-Tool v1.1")
            Else
                DoDaMathMinus = Convert.ToSingle(EncounterNummerTextFeld.Text)
                DoDaMathMinus = Single.Parse(EncounterNummerTextFeld.Text)
                DoDaMathMinus = DoDaMathMinus - 1
                If Not DoDaMathMinus < 0 Then
                    EncounterNummerTextFeld.Text = DoDaMathMinus
                Else
                    MsgBox("Du bist auch so ein Minus Encounter, Mr. Pleb!", 48, "Fehler - Pokémon Encounter-Tool v1.1")
                End If
            End If
            Call EncounterWriter()
        End If
    End Sub
    Public Sub EncounterPlus()
        If PokémonListComboBox.Text = "" Then
            MsgBox("Bitte wähle erst ein Pokémon aus!", 48, "Fehler - Pokémon Encounter-Tool v1.1")
        Else
            Dim DoDaMathPlus As Single
            If String.IsNullOrEmpty(EncounterNummerTextFeld.Text) Then
                EncounterNummerTextFeld.Text = 1
            Else
                DoDaMathPlus = Convert.ToSingle(EncounterNummerTextFeld.Text)
                DoDaMathPlus = Single.Parse(EncounterNummerTextFeld.Text)
                DoDaMathPlus = DoDaMathPlus + 1
                If Not DoDaMathPlus < 0 Then
                    EncounterNummerTextFeld.Text = DoDaMathPlus
                Else
                    MsgBox("Du bist auch so ein Minus Encounter, Mr. Pleb!", 48, "Fehler - Pokémon Encounter-Tool v1.1")
                End If
            End If
            Call EncounterWriter()
        End If
    End Sub
    Public Sub EncounterReset()
        'Resete die Encounterzahl auf 0
        If PokémonListComboBox.Text = "" Then
            MsgBox("Bitte wähle erst ein Pokémon aus!", 48, "Fehler - Pokémon Encounter-Tool v1.1")
        Else
            Dim ReAns = MsgBox("Möchtest du die Encounter-Zahl wirklich Reseten?", 36, "Reset? - Pokémon Encounter-Tool v1.1")
            If ReAns = 6 Then
                EncounterNummerTextFeld.Text = 0
                Call EncounterWriter()
            End If
        End If
    End Sub
    Public Sub EncounterWriter()
        'Schreibe die derzeitige Encounterzahl in die Textdatei CurrentEncounter.txt
        IO.File.WriteAllText(Application.StartupPath & "\CurrentEncounter.txt", EncounterNummerTextFeld.Text)

        'Schreibe EncounterZahl in INI
        Dim ini As New INIDatei(Application.StartupPath + "\PKMNDB.ini")
        ini.WertSchreiben("PKMN", PokémonListComboBox.SelectedIndex + 1, PokémonListComboBox.Text & "_" & EncounterNummerTextFeld.Text)
    End Sub

    'HOTKEYS

    Public Const MOD_ALT As Integer = &H1 'Alt key
    Public Const WM_HOTKEY As Integer = &H312

    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RegisterHotKey(Handle, 100, MOD_ALT, Keys.R)
        RegisterHotKey(Handle, 200, 0, Keys.Subtract)
        RegisterHotKey(Handle, 300, 0, Keys.Add)
        RegisterHotKey(Handle, 200, 0, Keys.OemMinus)
        RegisterHotKey(Handle, 300, 0, Keys.Oemplus)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "100"
                    Call EncounterReset()
                Case "200"
                    Call EncounterMinus()
                Case "300"
                    Call EncounterPlus()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Handle, 100)
        UnregisterHotKey(Handle, 200)
        UnregisterHotKey(Handle, 300)
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
        EncounterNummerTextFeld.Text = Werte(1)
    End Sub
End Class