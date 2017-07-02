using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Log410Proto
{
    /// <summary>
    /// Interaction logic for ObjectCreation.xaml
    /// </summary>
    public partial class ObjectCreation : Window
    {
        MainWindow parent;
        Boolean isStatic = false;
        public ObjectCreation(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            // add a alert message saying object was saved and added to the map
            // this.close() ?

            this.parent.addObject(isStatic, this.objNameInput.Text);
            this.Close();

        }

        private void staticRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            isStatic = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to cancel object creation?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            isStatic = false;
        }
    }
}
