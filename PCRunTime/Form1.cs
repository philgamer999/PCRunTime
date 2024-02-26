using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCRunTime
{
    public partial class MainWindow : Form
    {
        public string dataPath = string.Empty;
        public string totalFilePath = string.Empty;
        public string dailyFilePath = string.Empty;
        public string date = DateTime.Now.ToString("yyyy_MM_dd");

        public MainWindow()
        {
            InitializeComponent();
            LabelCompany.Text = Application.CompanyName + "©";
            LabelVersion.Text = "v." + Application.ProductVersion;
            LabelTitle.Text = "PC Run Time";

            SetPaths();
            CreateFiles();
        }



        public void SetPaths()
        {
            dataPath = Application.StartupPath + "/data";
            totalFilePath = dataPath + "/total.txt";
            dailyFilePath = dataPath + "/daily_" + date + ".txt";
            MessageBox.Show(dailyFilePath);
        }

        public void CreateFiles()
        {
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            if (!File.Exists(totalFilePath))
            {
                File.Create(totalFilePath);
            }

            if (!File.Exists(dailyFilePath))
            {
                File.Create(dailyFilePath);
            }
        }
    }
}
