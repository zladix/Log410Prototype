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
using System.Diagnostics;

namespace Log410Proto
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> _items;
        SolidColorBrush yellow = new SolidColorBrush(Colors.Yellow);
        SolidColorBrush red = new SolidColorBrush(Colors.Red);

        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;
            this.view2d.Visibility = Visibility.Visible;
            this.view2d.mainWindow = this;
            this.view3d.Visibility = Visibility.Hidden;
        }


        public void addObject(Boolean isStatic, String objName)
        {
            /*
            Rectangle r = new Rectangle();
            r.Height = 100;
            r.Width = 200;
            if (isStatic)
            {
                SolidColorBrush redBrush = new SolidColorBrush();
                redBrush.Color = Colors.Blue;
                r.Fill = redBrush;
            }
            else
            {
                SolidColorBrush yellowBrush = new SolidColorBrush();
                yellowBrush.Color = Colors.Yellow;
                r.Fill = yellowBrush;
            }
            Grid.SetColumn(r, 2);
            Trace.WriteLine(r.Height);
            */
            if (isStatic)
            {
                this.view2d.createRectangle.Visibility = Visibility.Visible;
                this.view2d.redCreate.Visibility = Visibility.Hidden;
                this.view2d.chairLabel.Visibility = Visibility.Visible;
                this.view2d.chairLabel.Content = objName;
            }
            else
            {
                this.view2d.redCreate.Visibility = Visibility.Visible;
                this.view2d.createRectangle.Visibility = Visibility.Hidden;
                this.view2d.chairLabel.Visibility = Visibility.Visible;
                this.view2d.chairLabel.Content = objName;
            }
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            if (this.view2d == null || this.view3d == null)
            {
                return;
            }
            this.view2d.Visibility = Visibility.Hidden;
            this.view3d.Visibility = Visibility.Visible;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (this.view2d == null || this.view3d == null)
            {
                return;
            }
            this.view2d.Visibility = Visibility.Visible;
            this.view3d.Visibility = Visibility.Hidden;
        }

        private void createObjButton_Click(object sender, RoutedEventArgs e)
        {
            Window createObjWindow = new ObjectCreation(this);
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
            //this.staticItemCan3.IsEnabled = activated;
        }

        private void ChangeDynamicElementState(bool activated)
        {

        }

        public void deleteRoundShit()
        {
            this.view2d.roundThing.Visibility = Visibility.Hidden;
            this.view2d.roundShitLabel.Visibility = Visibility.Hidden;

        }

        public void modifRoundshit(String newName, Boolean isStatic)
        {
            if (isStatic)
            {
                this.view2d.roundThing.Fill = this.yellow;
                //this.yellowRoundThing.Visibility = Visibility.Visible;
                //this.roundThing.Visibility = Visibility.Hidden;
            }
            else
            {
                this.view2d.roundThing.Fill = this.red;
            }
            this.view2d.roundShitLabel.Content = newName;
            this.view2d.roundShitLabel.Visibility = Visibility.Visible;
        }
    }
}
