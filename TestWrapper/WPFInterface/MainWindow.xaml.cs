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
            String civ1 = CivJ1Selected.Text;
            String civ2 = CivJ2Selected.Text;
            String taille = ((Button)sender).Tag.ToString();

            GameCreator gc = new GameCreator(civ1, civ2, taille);
            Game game = gc.getGame();
            GameWindow gameWindow = new GameWindow(game);
            
            gameWindow.Show();
            this.Close();
        }
    }
}
