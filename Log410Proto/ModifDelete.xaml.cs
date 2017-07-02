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
    /// Interaction logic for ModifDelete.xaml
    /// </summary>
    public partial class ModifDelete : Window
    {
        MainWindow parent;
        Boolean isStatic = true;
        public ModifDelete(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.objNameInput.Text = (String)this.parent.roundShitLabel.Content;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            this.parent.deleteRoundShit();
            this.Close();
        }

        private void staticRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            isStatic = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            isStatic = false;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            this.parent.modifRoundshit(this.objNameInput.Text, isStatic);
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to cancel object modification?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }


    }
}
