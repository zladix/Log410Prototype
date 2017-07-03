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
using System.Linq;

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

        public void ChangeStaticItemVisibility(bool isVisible)
        {
            var children = FindVisualChildren(this, x => x.Tag != null && x.Tag.Equals("static"));
            foreach (var child in children)
            {
                if (isVisible)
                    child.Visibility = Visibility.Visible;
                else
                    child.Visibility = Visibility.Hidden;
            }
        }

        public void ChangeDynamicItemVisibility(bool isVisible)
        {
            var children = FindVisualChildren(this, x => x != null && x.Tag != null && x.Tag.Equals("dynamic"));
            foreach (var child in children)
            {
                if (isVisible)
                    child.Visibility = Visibility.Visible;
                else
                    child.Visibility = Visibility.Hidden;
            }
        }

        public void ChangeWorldMapItemVisibility(bool isVisible)
        {

        }

        public static IEnumerable<FrameworkElement> FindVisualChildren(FrameworkElement obj, Func<FrameworkElement, bool> predicate)
        {
            if (obj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    var objChild = VisualTreeHelper.GetChild(obj, i);
                    if (objChild != null && predicate(objChild as FrameworkElement))
                    {
                        yield return objChild as FrameworkElement;
                    }

                    foreach (FrameworkElement childOfChild in FindVisualChildren(objChild as FrameworkElement, predicate))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}
