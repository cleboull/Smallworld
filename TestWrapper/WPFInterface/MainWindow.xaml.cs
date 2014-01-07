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
using mWrapper;

namespace WPFInterface
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Create_Map(object sender, RoutedEventArgs e)
        {
            
            WrapperMap wm = new WrapperMap();
            List<int> map;
            String taille = ((Button)sender).Tag.ToString();
            switch (taille)
            {
                case "Demo": map = wm.CreateMapWrapper(5); break;
                case "Petite": map = wm.CreateMapWrapper(10); break;
                case "Normale": map = wm.CreateMapWrapper(15); break;
                default: map = null; break;
            }
            GameWindow gameWindow = new GameWindow(map);
            gameWindow.Show();
            
            this.Close();
        }

        private void NbTourBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            CheckIsNumeric(e);
        }

        private void CheckIsNumeric(TextCompositionEventArgs e)
        {
            int resultat;

            if (!(int.TryParse(e.Text, out resultat)))
            {
                e.Handled = true;
            }
        }

        private void NbTourBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (NbTourBox.Text != "" && !NbTourBox.Text.Contains(" "))
            {
                DemoButton.IsEnabled = true;
                PetiteButton.IsEnabled = true;
                NormaleButton.IsEnabled = true;
            }
            else
            {
                DemoButton.IsEnabled = false;
                PetiteButton.IsEnabled = false;
                NormaleButton.IsEnabled = false;
            }
        }
    }
}
