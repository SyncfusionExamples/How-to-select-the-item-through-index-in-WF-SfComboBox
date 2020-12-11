Imports Syncfusion.Windows.Forms
Imports Syncfusion.WinForms.ListView

Partial Public Class Form1
    Inherits MetroForm
    Public Sub New()
        InitializeComponent()
        Dim list As List(Of State) = GetData()
        Dim sfComboBox1 As New SfComboBox()
        sfComboBox1.Size = New Size(150, 28)
        sfComboBox1.Location = New Point(138, 56)
        sfComboBox1.DataSource = list

        'Bind the Display member and Value member to the data source
        sfComboBox1.DisplayMember = "DispValue"
        sfComboBox1.ValueMember = "SfValue"
        sfComboBox1.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.SingleSelection
        sfComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        sfComboBox1.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains
        sfComboBox1.MaxDropDownItems = 10

        'Select the item based on index
        sfComboBox1.SelectedIndex = list(1).SfValue

        'Select the item based on item
        sfComboBox1.SelectedItem = list(1)
        Me.Controls.Add(sfComboBox1)
    End Sub

    Private Function GetData() As List(Of State)
        Dim states As New List(Of State)()
        states.Add(New State("ASTM A 351 GR.CF3M", 2))
        states.Add(New State("ASTM A 351 GR.CF8M", 3))
        states.Add(New State("ASTM A 351 GR.CF8", 4))
        states.Add(New State("ASTM A 351 GR.CF3", 5))
        states.Add(New State("ASTM A 351 GR.CF3MN", 6))
        states.Add(New State("ASTM A 351 GR.CF8C", 7))
        states.Add(New State("ASTM A 351 GR.CN7M", 8))
        states.Add(New State("ASTM A 351 GR.CN3MN", 9))
        states.Add(New State("ASTM A 351 GR.CD4MCu", 10))
        Return states
    End Function

    Public Class State
        'INSTANT VB NOTE: The variable sfValue was renamed since Visual Basic does not allow class members with the same name:
        Private sfValue_Renamed As Integer
        'INSTANT VB NOTE: The variable dispValue was renamed since Visual Basic does not allow class members with the same name:
        Private dispValue_Renamed As Object

        Public Sub New(ByVal DispValue As Object, ByVal SfValue As Integer)
            Me.dispValue_Renamed = DispValue
            Me.sfValue_Renamed = SfValue
        End Sub

        Public ReadOnly Property SfValue() As Integer
            Get
                Return sfValue_Renamed
            End Get
        End Property

        Public ReadOnly Property DispValue() As Object
            Get
                Return dispValue_Renamed
            End Get
        End Property
    End Class
End Class