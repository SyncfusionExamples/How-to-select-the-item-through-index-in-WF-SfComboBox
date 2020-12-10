using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfComboBox_Selection
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            List<State> list = GetData();
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
        }

        List<State> GetData()
        {
            List<State> states = new List<State>();
            states.Add(new State("ASTM A 351 GR.CF3M", 2));
            states.Add(new State("ASTM A 351 GR.CF8M", 3));
            states.Add(new State("ASTM A 351 GR.CF8", 4));
            states.Add(new State("ASTM A 351 GR.CF3", 5));
            states.Add(new State("ASTM A 351 GR.CF3MN", 6));
            states.Add(new State("ASTM A 351 GR.CF8C", 7));
            states.Add(new State("ASTM A 351 GR.CN7M", 8));
            states.Add(new State("ASTM A 351 GR.CN3MN", 9));
            states.Add(new State("ASTM A 351 GR.CD4MCu", 10));
            return states;
        }

        public class State
        {
            private int sfValue;
            private object dispValue;

            public State(object DispValue, int SfValue)
            {
                this.dispValue = DispValue;
                this.sfValue = SfValue;
            }

            public int SfValue
            {
                get { return sfValue; }
            }

            public object DispValue
            {
                get { return dispValue; }
            }
        }
    }
}
