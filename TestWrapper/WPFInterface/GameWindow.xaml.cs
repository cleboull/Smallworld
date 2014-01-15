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
        Game game = new Game();
        List<Unit> unitList;
        Unit curUnit;
        bool isUnitSelected;

        public GameWindow(Game game)
        {
            this.game = game;
            InitializeComponent();
            setUnitPos();
            setCurrentPlayer();
            setCurrentRound();
            setCiv();
            map = game.getMap();
            FondCarte.Map = map;
        }

        public void setCurrentPlayer()
        {
            labelJoueur.Content = "Tour du Joueur "+game.getCurrentPlayer();
        }

        public void setCiv()
        {
            civJ1.Content = "Civilisation du joueur 1 : " + game.getCiv("J1");
            civJ2.Content = "Civilisation du joueur 2 : " + game.getCiv("J2");
        }

        public void setUnitPos(){
            FondCarte.setPosUnitJ1(game.getUnitPos("J1"),game.getNbUnit());
            FondCarte.setPosUnitJ2(game.getUnitPos("J2"),game.getNbUnit());
            isUnitSelected = false;
        }

        public void setCurrentRound()
        {
            labelTour.Content = "Tour " + game.getRound() + "/" + game.getRoundMax();
        }

        public void setScore()
        {
            J1Score.Content = game.getP1Points().ToString();
            J2Score.Content = game.getP2Points().ToString();
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

            if ((newSelectRectX == SelectRect.Margin.Left && newSelectRectY == SelectRect.Margin.Top) && SelectRect.Visibility == Visibility.Visible)//une case selec et clique sur la même case
            {
                SelectRect.Visibility = Visibility.Hidden; //déselection
                isUnitSelected = false;
                unitList=null;
                listBoxUnit.Items.Clear();
                labelMsg.Content = "Case désélectionnée";
                majLabelUnit();
            }

            else if (SelectRect.Visibility == Visibility.Visible && isUnitSelected == true)//une case est selec et une unité aussi
            {
                if (game.moveUnit(curUnit, (int)(x / 50), (int)(y / 50)))
                {
                    listBoxUnit.Items.Remove(curUnit);
                    isUnitSelected = false;
                    majLabelUnit();
                    FondCarte.setPosUnitJ1(game.getUnitPos("J1"), game.getNbUnit());
                    FondCarte.setPosUnitJ2(game.getUnitPos("J2"), game.getNbUnit());
                    FondCarte.InvalidateVisual();//permet de rafraichir la carte
                    labelMsg.Content = "Déplacement effectué";
                }
            }

            else if (SelectRect.Visibility == Visibility.Hidden && isUnitSelected == false)//une case et pas de case selec
            {
                SelectRect.Visibility = Visibility.Visible;
                SelectRect.Margin = new Thickness(((int)x / 50) * 50, ((int)y / 50) * 50, SelectRect.Margin.Right, SelectRect.Margin.Bottom);

                if (game.selectSlot((int)x / 50, (int)y / 50))
                {
                    unitList = game.selectUnit((int)x / 50, (int)y / 50);
                    labelMsg.Content = "Sélectionnez une unité";
                }

                if (unitList != null)
                {
                    foreach (Unit unit in unitList)
                    {
                        listBoxUnit.Items.Add(unit);
                    }
                }
            }
        }

        private void EndTurn_Click(object sender, RoutedEventArgs e)
        {
            SelectRect.Visibility = Visibility.Hidden;
            game.resetMovPoints();
            game.changePlayer();
            setCurrentRound(); 
            setCurrentPlayer();
            setScore();
            listBoxUnit.Items.Clear();
            isUnitSelected = false;
            majLabelUnit();
            if (game.isGameOver())
            {
                finTourBouton.IsEnabled = false;
                FinalWindow fwin = new FinalWindow(game.getWinner());
                fwin.Show();
                this.Close();
            }
        }

        private void unitChange(object sender, SelectionChangedEventArgs e)
        {
            if ((Unit)listBoxUnit.SelectedItem != null)
            {
                curUnit = (Unit)listBoxUnit.SelectedItem;
                unitSelect.Content = curUnit;
                isUnitSelected = true;
                majLabelUnit();
            }
        }

        private void majLabelUnit()
        {
            if (isUnitSelected == true)
            {
                labelPDV.Content = curUnit.getPDV();
                labelATK.Content = curUnit.getATK();
                labelDEF.Content = curUnit.getDEF();
                labelMOV.Content = curUnit.getMOV();
            }
            else
            {
                labelPDV.Content = "-";
                labelATK.Content = "-";
                labelDEF.Content = "-";
                labelMOV.Content = "-";
            }
        }
    }
}
