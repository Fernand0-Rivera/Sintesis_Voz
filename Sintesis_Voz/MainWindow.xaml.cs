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
using System.Speech.Synthesis;
namespace Sintesis_Voz{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window{
        string cad1;
        public MainWindow(){
            InitializeComponent();
        }

        private void btLeer_Click(object sender, RoutedEventArgs e){
            cad1 = tb1.Text;
            SpeechSynthesizer voz1 = new SpeechSynthesizer();
            if (cad1 != " "){
                voz1.Speak(cad1);
            }
            else {
                tb1.Text = "Escribir algo...";
            }
        }
    }
}
