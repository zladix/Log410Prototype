using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Log410Proto
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> _items;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void createObjButton_Click(object sender, RoutedEventArgs e)
        {
            Window createObjWindow = new ObjectCreation();
            createObjWindow.Show();
        }

        private void checkBox_Static_Checked(object sender, RoutedEventArgs e)
        {
            ChangeStaticElementState(true);
        }

        private void checkBox_Static_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeStaticElementState(false);
        }

        private void checkBox_Dynamic_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void checkBox_Dynamic_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox_WorldMap_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void checkBox_WorldMap_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeStaticElementState(bool activated)
        {
            this.staticItemCan3.IsEnabled = activated;
        }

        private void ChangeDynamicElementState(bool activated)
        {

        }

       
    }
}
