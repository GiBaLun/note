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

namespace note
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string GiBaLunNote = "";
       public MainWindow()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                GiBaLunNote = dig.FileName;

                book.Text = System.IO.File.ReadAllText(GiBaLunNote);
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                GiBaLunNote = dig.FileName;

                System.IO.File.WriteAllText(GiBaLunNote, book.Text);
            }
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            book.Clear();
        }

        private void big_MouseDown(object sender, MouseButtonEventArgs e)
        {
            book.FontSize += 5;

            if (book.FontSize > 5)
                sma.IsEnabled = true;
        }

        private void sma_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (book.FontSize > 5)
                book.FontSize -= 5;
            else
                sma.IsEnabled = false;
        }

        private void line_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (book.TextDecorations == TextDecorations.Underline)
                book.TextDecorations = null;
            else if (book.TextDecorations == null)
                book.TextDecorations = TextDecorations.Underline;
        }

        private void slide_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (book.FontStyle == FontStyles.Italic)
                book.FontStyle = FontStyles.Normal;
            else if (book.FontStyle == FontStyles.Normal)
                book.FontStyle = FontStyles.Italic;
        }

        private void bold_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (book.FontWeight == FontWeights.Bold)
                book.FontWeight = FontWeights.Normal;
            else if (book.FontWeight == FontWeights.Normal)
                book.FontWeight = FontWeights.Bold;
        }
    }
}
