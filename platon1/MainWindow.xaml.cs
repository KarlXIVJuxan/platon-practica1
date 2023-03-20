using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using platon1.platon1DataSetTableAdapters;

namespace platon1
{

    public partial class MainWindow : Window
    {

        ColorTableAdapter color = new ColorTableAdapter();
        HumanTableAdapter human = new HumanTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

            ColourComboBox.ItemsSource = color.GetData();
            ColourComboBox.DisplayMemberPath = "name_color";

            HumanComboBox.ItemsSource = human.GetData();
            HumanComboBox.DisplayMemberPath = "ColorId";


        }
        private void ColourComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            object cell = (ColourComboBox.SelectedItem as DataRowView).Row[0];
            MessageBox.Show(cell.ToString());
        }

        private void HumanComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (HumanComboBox.SelectedItem as DataRowView).Row[1];
            MessageBox.Show(cell.ToString());
        }
    }
}

