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

namespace WpfAppTest
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

        private void AddContent(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("Nom : " + textBoxNom.Text);
            listBox.Items.Add("Prénom : "+textBoxPrenom.Text);
            listBox.Items.Add("Date de naissance : " + dateDeNaissance.Text);
        }
    }
}
