//Logan Ellis
//May 27th
//Imput the amount of each coin and it will tell you your change
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

namespace U5_Challange_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddingButton_Click(object sender, RoutedEventArgs e)
        {
            int loonies = 100;
            int twoonies = 200;
            int quarters = 25;
            int nickles =  5;
            int dimes =  10;
            int numberOfLoonies;
            int numberOfQuarters;
            int numberOfNickles;
            int numberOfDimes;
            int numberOfTwoonies;
            double Sum;

            int.TryParse(Loonies.Text, out numberOfLoonies);
            int.TryParse(Twoonies.Text, out numberOfTwoonies);
            int.TryParse(Nickles.Text, out numberOfNickles);
            int.TryParse(Dimes.Text, out numberOfDimes);
            int.TryParse(Quarters.Text, out numberOfQuarters);



           Sum = (loonies*numberOfLoonies + twoonies*numberOfTwoonies + nickles*numberOfNickles + dimes*numberOfDimes + quarters*numberOfQuarters) /100.0;
           Equal.Content = "Your Total is: $" + (double) Sum + "  Thank you for using Logans Legit Money Calculator!!!";



        }
    }
}
