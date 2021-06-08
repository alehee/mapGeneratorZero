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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace mapGeneratorZero
{
    public partial class Generator : Window
    {
        const string VERSION = "0.1.0t";

        ZeroOptions zeroOptions;
        ZeroMap zeroMap = new ZeroMap();

        public Generator()
        {
            InitializeComponent();

            Title = "mapGeneratorZero " + VERSION;

            /// Initialize all objects
            zeroOptions = new ZeroOptions(this, zeroMap);
            /// ==========
        }

        /// F: Load options from JSON file
        private void B_LoadSettings_Click(object sender, RoutedEventArgs e)
        {
            zeroOptions.loadSaveFromFile();
        }
        /// ==========
    }
}
