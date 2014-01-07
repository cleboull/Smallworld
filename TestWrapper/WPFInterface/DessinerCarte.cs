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
        Brush[] brushes = { Brushes.Blue, Brushes.Red, Brushes.Green, Brushes.Black, Brushes.Pink };
        protected override void OnRender(DrawingContext drawingContext)
        {
            if (Map != null)
            {
                int sizeMap = Map.Count();
                int size = (int)Math.Sqrt(sizeMap);
                for (int x = 0; x < size; x++)
                {
                    for (int y = 0; y < size; y++)
                        drawingContext.DrawRectangle(brushes[Map[x + size * y]], null, new Rect(x * 50, y * 50, 50, 50));
                }
            }
            base.OnRender(drawingContext);
        }

        public List<int> Map { get; set; }
    }
}