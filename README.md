# How-to-select-the-item-through-index-in-WF-SfComboBox
Index of the selected item can be retrieved by using the SelectedIndex property. For more details please refer [How to select the item thorugh index index in SfComboBox](https://www.syncfusion.com/kb/12171/how-to-select-the-item-through-index-in-winforms-sfcombobox).

# C#
         public Form1()
            {
                InitializeComponent();
                List<State> list = GetData();
                SfComboBox sfComboBox1 = new SfComboBox();
                sfComboBox1.Size = new Size(150, 28);
                sfComboBox1.Location = new Point(138, 56);
                sfComboBox1.DataSource = list;

                //Bind the Display member and Value member to the data source
                sfComboBox1.DisplayMember = "DispValue";
                sfComboBox1.ValueMember = "SfValue";
                sfComboBox1.ComboBoxMode = Syncfusion.WinForms.ListView.Enums.ComboBoxMode.SingleSelection;
                sfComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                sfComboBox1.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
                sfComboBox1.MaxDropDownItems = 10;

                //Select the item based on index
                sfComboBox1.SelectedIndex = list[1].SfValue;

                //Select the item based on item
                sfComboBox1.SelectedItem = list[1];
                this.Controls.Add(sfComboBox1);
            }


![Select Item through Index](SfComboBox_Selection_C#/Image/Select%20item%20through%20index.png)
