﻿using System;
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

namespace WPFInterface
{
    /// <summary>
    /// Suivez les étapes 1a ou 1b puis 2 pour utiliser ce contrôle personnalisé dans un fichier XAML.
    ///
    /// Étape 1a) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans le projet actif.
    /// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
    /// être utilisé :
    ///
    ///     xmlns:MyNamespace="clr-namespace:WPFInterface"
    ///
    ///
    /// Étape 1b) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans un autre projet.
    /// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
    /// être utilisé :
    ///
    ///     xmlns:MyNamespace="clr-namespace:WPFInterface;assembly=WPFInterface"
    ///
    /// Vous devrez également ajouter une référence du projet contenant le fichier XAML
    /// à ce projet et régénérer pour éviter des erreurs de compilation :
    ///
    ///     Cliquez avec le bouton droit sur le projet cible dans l'Explorateur de solutions, puis sur
    ///     "Ajouter une référence"->"Projets"->[Recherchez et sélectionnez ce projet]
    ///
    ///
    /// Étape 2)
    /// Utilisez à présent votre contrôle dans le fichier XAML.
    ///
    ///     <MyNamespace:DessinerCarte/>
    ///
    /// </summary>
    public class DessinerCarte : Grid
    {
        //static DessinerCarte()
        //{
        //    DefaultStyleKeyProperty.OverrideMetadata(typeof(DessinerCarte), new FrameworkPropertyMetadata(typeof(DessinerCarte)));
        //}

        public List<int> Map { get; set; }
        int[] posUnitJ1 = new int[15];
        int nbUnitJ1;
        int[] posUnitJ2 = new int[15];
        int nbUnitJ2;
        

        Brush[] brushes = { Brushes.Blue, Brushes.Red, Brushes.Green, Brushes.Black, Brushes.Pink };
        ImageSource[] images = {
                    new BitmapImage(new Uri(@"..\..\Resources\desert.png",UriKind.Relative)),
                    new BitmapImage(new Uri(@"..\..\Resources\foret.png",UriKind.Relative)),
                    new BitmapImage(new Uri(@"..\..\Resources\montagne.png",UriKind.Relative)),
                    new BitmapImage(new Uri(@"..\..\Resources\plaine.png",UriKind.Relative)),
                    new BitmapImage(new Uri(@"..\..\Resources\sea.png",UriKind.Relative))
                    };

        ImageSource J1 = new BitmapImage(new Uri(@"..\..\Resources\coulJ1.png", UriKind.Relative));
        ImageSource J2 = new BitmapImage(new Uri(@"..\..\Resources\coulJ2.png", UriKind.Relative));

        protected override void OnRender(DrawingContext drawingContext)
        {
            if (Map != null)
            {
                int sizeMap = Map.Count();
                int size = (int)Math.Sqrt(sizeMap);
                for (int x = 0; x < size; x++)
                {
                    for (int y = 0; y < size; y++)
                        drawingContext.DrawImage(images[Map[x + size * y]], new Rect(x * 50, y * 50, 50, 50));
                }
                int margin;
                switch (size)
                {
                    case 5: margin = 250; break;
                    case 10: margin = 125; break;
                    default: margin = 0; break;                       
                }
                this.Margin = new Thickness(margin,margin, this.Margin.Right, this.Margin.Bottom);

                //Dessiner les unités
                int i;
                for(i = 0; i < nbUnitJ1; i++)
                    drawingContext.DrawImage(J1, new Rect((posUnitJ1[i] % size)*50 + 10, ((posUnitJ1[i]/size))*50 + 10, 30, 30));
                for(i = 0; i < nbUnitJ2; i++)
                    drawingContext.DrawImage(J2, new Rect((posUnitJ2[i] % size)*50 + 10, ((posUnitJ2[i]/size))*50 + 10, 30, 30));
            }           
            base.OnRender(drawingContext);
        }

        public void setPosUnitJ1(int[] unitPosList,int nbUnit)
        {
            posUnitJ1 = unitPosList;
            nbUnitJ1 = nbUnit;
        }

        public void setPosUnitJ2(int[] unitPosList, int nbUnit)
        {
            posUnitJ2 = unitPosList;
            nbUnitJ2 = nbUnit;
        }

        
        
    }
}
