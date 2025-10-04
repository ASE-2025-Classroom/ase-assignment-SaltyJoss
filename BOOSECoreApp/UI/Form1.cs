
// External Libraries
using System;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

// BOOSE libraries
using BOOSE;
using BOOSECoreApp.Core;

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
