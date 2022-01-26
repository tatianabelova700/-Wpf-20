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
using Lab20___WpfApp.ViewModels;

namespace Lab20___WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ThemChange();
        }

        private void ThemChange()
        {
            string dir = "Views/StyleLight.xaml";
            if (darkTopic.IsChecked == true)
            {
                dir = "Views/StyleDark.xaml";
            }
            Uri uriStyle = new Uri(dir, UriKind.Relative);
            ResourceDictionary resource = Application.LoadComponent(uriStyle) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void TopDarkExecuted(object sender, ExecutedRoutedEventArgs e)
        {

            if (darkTopic.IsChecked == true)
            {
                lightTopic.IsChecked = false;
            }
            else
            {
                darkTopic.IsChecked = true;
                lightTopic.IsChecked = false;
            }
            ThemChange();
        }

        private void TopLightExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (lightTopic.IsChecked == true)
            {
                darkTopic.IsChecked = false;
            }
            else
            {
                lightTopic.IsChecked = true;
                darkTopic.IsChecked = false;
            }
            ThemChange();
        }
    }
}
