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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int lives  = 10;
        private int randomNumber = 0;

        public MainWindow()
        {
            InitializeComponent();

            Random random = new Random();
            randomNumber = random.Next() % 100;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(lives == 0)
            {
                labelFrom.Content = "You";
                labelTo.Content = "Lose";
                return;
            }

            if(e.Key == Key.Enter)
            {
                lives--;

                int userGuesed = Int32.Parse(textBox.Text);
                if (userGuesed == randomNumber)
                {
                    labelFrom.Content = "You";
                    labelTo.Content = "Win";
                    labelRemaining.Content = "Remaining Live =" + lives;
                    return;
                }

                if(userGuesed < randomNumber)
                {
                    labelFrom.Content = userGuesed;
                }
                else
                {
                    labelTo.Content = userGuesed;
                }

                if(lives <= 3)
                {
                    labelRemaining.Foreground = new SolidColorBrush(Color.FromRgb(250, 0, 0));
                }
                labelRemaining.Content = "Remaining Live = " + lives; 
            }
        }
    }
}
