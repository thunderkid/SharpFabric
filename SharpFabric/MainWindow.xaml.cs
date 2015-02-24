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

            myBrowser.LoadHtml(GetResourceString("SharpFabric.JavaScript.CanvBody.html"), "http://junky/");

            // Initialize fabric.js after the DOM is fully loaded. Not sure whether this is the recommended way to ensure this.
            myBrowser.FrameLoadEnd += delegate 
            { 
                myBrowser.ExecuteScriptAsync(GetResourceString("SharpFabric.JavaScript.fabric.js")); 
                myBrowser.ExecuteScriptAsync(GetResourceString("SharpFabric.JavaScript.qFunctions.js")); 
            };
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

        int times = 1;
        private void test_Click(object sender, RoutedEventArgs e)
        {
            QCircle(10, 10 + 10 * times);

            times++;
        }


        void QCircle(int x, int y)
        {
            myBrowser.ExecuteScriptAsync(string.Format("qJsCircle({0},{1})",x,y));
        }



    }
}
