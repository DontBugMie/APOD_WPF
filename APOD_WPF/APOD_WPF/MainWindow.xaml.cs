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

namespace APOD_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //endpoint url
        const string EndpointURL = "https://api.nasa.gov/planetary/apod";

        //APOD launch date
        DateTime launchDate = new DateTime(1995,6,16);

        //A count of images downloaded today
        int imageCountToday;

        //Flag to ignore a strange double-event in WPF
        bool ignoreDoubleEvent = false;


        public MainWindow()
        {
            InitializeComponent();

            //Set the maximum date to today, and the minimum date to the date APOD was launched
            MonthCalendar.DisplayDateEnd = DateTime.Today;
            MonthCalendar.DisplayDateStart = launchDate;
        }

        private void LaunchButton_Click(object sender, RoutedEventArgs e)
        {
            LimitRangeCheckBox.IsChecked = false;

            //set the calender APOD launch date
            //will fire double event, the first will be ignored
            ignoreDoubleEvent = true;
            MonthCalendar.SelectedDate = launchDate;
        }

        private void MonthCalendar_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
