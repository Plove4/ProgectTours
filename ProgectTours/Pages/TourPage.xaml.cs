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
using ProgectTours.ModelDB;

namespace ProgectTours.Pages
{
    /// <summary>
    /// Логика взаимодействия для TourPage.xaml
    /// </summary>
    public partial class TourPage : Page
    {
        private ToursEntities _context = new ToursEntities();
        public TourPage()
        {
            InitializeComponent();
            ListTours.ItemsSource = _context.Tour.OrderBy(tour => tour.Name).ToList();
        }

        private void TxtFindedTourName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void CmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ChbActual_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ChbActual_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
