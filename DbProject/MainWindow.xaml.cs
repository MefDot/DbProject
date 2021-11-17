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


namespace DbProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {

            Global global = new Global();

           if (!String.IsNullOrEmpty(global.CheckConnection()))
           {
                MessageBox.Show("Подключение прошло успешно! ");
            }
           else
            {
                MessageBox.Show("Подключение не удалось!");
            }

        }
    }
}
