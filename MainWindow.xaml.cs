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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.NombreTextBox.Tag = (object)this.NombreAyudaTextBlock;
            this.ApellidoTextBox.Tag = (object)this.ApellidoAyudaTextBlock;
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBlock tag = (sender as TextBox).Tag as TextBlock;
            if (e.Key != Key.F1)
                return;
            tag.Visibility = tag.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
        }

        private void Edad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.F2)
                return;
            if (int.TryParse(this.EdadTextBox.Text, out int _))
                this.EdadAyudaTextBlock.Visibility = Visibility.Hidden;
            else
                this.EdadAyudaTextBlock.Visibility = Visibility.Visible;
        }
    }
}
