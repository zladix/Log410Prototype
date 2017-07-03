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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Log410Proto
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : UserControl
    {
        public MainWindow mainWindow { get; set; }

        public View()
        {
            InitializeComponent();
        }

        private void roundThing_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window modifDelObjWindow = new ModifDelete(this.mainWindow);
            modifDelObjWindow.Show();
        }
    }
}
