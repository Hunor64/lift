using System;
using System.Collections.Generic;
using System.IO;
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

namespace LiftWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Lift> adatok = new List<Lift>();
        public MainWindow()
        {
            InitializeComponent();
            readFile("lift.txt");
        }
        public void readFile(string fileName)
        {
            var readFile = File.ReadLines(fileName);
            foreach (var line in readFile)
            {
                if (adatok.Count()!=1000)
                {
                    adatok.Add(new Lift(line));
                }
            }
        }
    }
}
