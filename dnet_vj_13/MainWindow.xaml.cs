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

namespace dnet_vj_13
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

        

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {

            Window1 prozor = new Window1();
            
            TextRange tekst = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            prozor.textBlock.Text = tekst.Text;
            prozor.ShowDialog();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TextRange tekst = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            tekst.Text = " ";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TextRange tekst = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            tekst.Text += tekst.Text;
        }
    }
}
