using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PCRunTime
{
    public partial class MainWindow : Form
    {
        public string dataPath = string.Empty;
        public string totalFilePath = string.Empty;
        public string dailyFilePath = string.Empty;
        public string date = DateTime.Now.ToString("yyyy_MM_dd");

        public int cHour, cMinute, cSecond;
        public int dHour, dMinute, dSecond;
        public int tHour, tMinute, tSecond;

        public Timer timer = new Timer();

        public MainWindow()
        {
            InitializeComponent();
            LabelCompany.Text = Application.CompanyName + "©";
            LabelVersion.Text = "v." + Application.ProductVersion;
            LabelTitle.Text = "PC Run Time";

            SetPaths();
            CreateFiles();
            GetData();
            SetDisplay();

            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(TimerTick);
        }


        public void TimerTick(object sender, EventArgs e)
        {
            if (cSecond == 59)
            {
                cSecond = 0;
                cMinute++;
                SaveData();
            }
            else
            {
                cSecond++;
            }

            if (cMinute == 59)
            {
                cMinute = 0;
                cHour++;
            }

            if (dSecond == 59)
            {
                dSecond = 0;
                dMinute++;
                SaveData();
            }
            else
            {
                dSecond++;
            }

            if (dMinute == 59)
            {
                dMinute = 0;
                dHour++;
            }


            if (tSecond == 59)
            {
                tSecond = 0;
                tMinute++;
                SaveData();
            }
            else
            {
                tSecond++;
            }

            if (tMinute == 59)
            {
                tMinute = 0;
                tHour++;
            }

            SetDisplay();
        }

        public void SetPaths()
        {
            dataPath = Application.StartupPath + "/data";
            totalFilePath = dataPath + "/total.txt";
            dailyFilePath = dataPath + "/daily_" + date + ".txt";
        }

        public void CreateFiles()
        {
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            if (!File.Exists(totalFilePath))
            {
                File.WriteAllText(totalFilePath, "00:00:00");
            }

            if (!File.Exists(dailyFilePath))
            {
                File.WriteAllText(dailyFilePath, "00:00:00");
            }
        }

        public void SetDisplay()
        {
            LabelTimeCurrent.Text = $"{cHour.ToString("D2")} : {cMinute.ToString("D2")} : {cSecond.ToString("D2")}";
            LabelTimeToday.Text = $"{dHour.ToString("D2")} : {dMinute.ToString("D2")} : {dSecond.ToString("D2")}";
            LabelTimeTotal.Text = $"{tHour.ToString("D2")} : {tMinute.ToString("D2")} : {tSecond.ToString("D2")}";
        }

        public void GetData()
        {
            char[] dailyChars = File.ReadAllText(dailyFilePath).ToCharArray();
            char[] totalChars = File.ReadAllText(dailyFilePath).ToCharArray();

            dSecond = int.Parse(string.Join("", dailyChars.Skip(0).Take(2)));
            dMinute = int.Parse(string.Join("", dailyChars.Skip(3).Take(2)));
            dHour = int.Parse(string.Join("", dailyChars.Skip(6)));

            tSecond = int.Parse(string.Join("", totalChars.Skip(0).Take(2)));
            tMinute = int.Parse(string.Join("", totalChars.Skip(3).Take(2)));
            tHour = int.Parse(string.Join("", totalChars.Skip(6)));
        }

        public void SaveData()
        {
            File.WriteAllText(totalFilePath, $"{tSecond.ToString("D2")}:{tMinute.ToString("D2")}:{tHour.ToString("D2")}");
            File.WriteAllText(dailyFilePath, $"{dSecond.ToString("D2")}:{dMinute.ToString("D2")}:{dHour.ToString("D2")}");

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveData();
        }

        private void ButtonSaveQuit_Click(object sender, EventArgs e)
        {
            SaveData();
            Application.Exit();
        }
    }
}
