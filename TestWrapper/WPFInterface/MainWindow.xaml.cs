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
using SmallWorld;

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
            String civ1 = ;
            String civ2;
            String taille = ((Button)sender).Tag.ToString();
            List<int> map;

            GameCreator gc = new GameCreator(civ1, civ2, taille);

            GameWindow gameWindow = new GameWindow(map);
            
            gameWindow.Show();
            this.Close();
        }
    }
}
