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
using SmallWorld;
namespace WPFInterface
{
    /// <summary>
    /// Logique d'interaction pour GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        List<int> map;
        Game game;

        public GameWindow(Game game)
        {
            InitializeComponent();
            map = game.getMap();
            FondCarte.Map = map;
        }

        private void FinPartie(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void FondCarte_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            var grid = sender as Grid;
            var pos = e.GetPosition(grid);
            var x = pos.X; //coordonnée x du click
            var y = pos.Y; //coordonnée y du click
            int sizeMap = (int)Math.Sqrt(map.Count()); //nombre de cases par côté
            int numSlot = ((int)y / 50) * sizeMap + ((int)x / 50); //numéro du slot correspondant au click
            Console.WriteLine(numSlot);
            int newSelectRectX = ((int)x / 50) * 50;
            int newSelectRectY = ((int)y / 50) * 50;
            if ((newSelectRectX == SelectRect.Margin.Left && newSelectRectY == SelectRect.Margin.Top) && SelectRect.Visibility == Visibility.Visible)
            {
                SelectRect.Visibility = Visibility.Hidden; //déselection
            }
            else if (SelectRect.Visibility == Visibility.Hidden)
            {
                SelectRect.Visibility = Visibility.Visible;
                SelectRect.Margin = new Thickness(((int)x / 50) * 50, ((int)y / 50) * 50, SelectRect.Margin.Right, SelectRect.Margin.Bottom);
            }
        }

        private void EndTurn_Click(object sender, RoutedEventArgs e)
        {
            SelectRect.Visibility = Visibility.Hidden;
            Console.WriteLine(2);
        }
    }
}
