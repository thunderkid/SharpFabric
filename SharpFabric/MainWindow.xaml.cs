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

namespace SharpFabric
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string pus = GetResourceString("SharpFabric.JavaScript.JavaScript1.js");
        }


        string GetResourceString(string id)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            string result; 

            string[] names = assembly.GetManifestResourceNames();

            using (System.IO.Stream stream = assembly.GetManifestResourceStream(id))
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                result = reader.ReadToEnd();

            return result;
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            // dog.
        }
    }
}
