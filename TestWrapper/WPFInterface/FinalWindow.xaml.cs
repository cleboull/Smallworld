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

namespace WPFInterface
{
    /// <summary>
    /// Logique d'interaction pour FinalWindow.xaml
    /// </summary>
    public partial class FinalWindow : Window
    {
        public FinalWindow(string winner)
        {
            InitializeComponent();
            if(winner == "draw")
                winnerLabel.Content = "Match nul !";
            else
                winnerLabel.Content = "Victoire du " + winner + " !";
        }
    }
}
