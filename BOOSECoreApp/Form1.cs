using BOOSE;
using System.Diagnostics;

namespace BOOSECoreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine(AboutBOOSE.about());
        }
    }
}
