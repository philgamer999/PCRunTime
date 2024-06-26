﻿using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCRunTime
{
    public partial class MainWindow : Form
    {
        public string dataPath = string.Empty;
        public string totalFilePath = string.Empty;
        public string dailyFilePath = string.Empty;
        public string startFilePath = string.Empty;
        public string dataFilePath = string.Empty;
        public string date = DateTime.Now.ToString("yyyy_MM_dd");
        public string dateDisplay = DateTime.Now.ToString("dd.MM.yyyy");
        public string startDate = string.Empty;
        public string totalDays = string.Empty;

        public int cHour, cMinute, cSecond;
        public int dHour, dMinute, dSecond;
        public int tHour, tMinute, tSecond;

        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

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
            startFilePath = dataPath + "/start.txt";
            dataFilePath = dataPath + "/dat.txt";
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

            if (!File.Exists(startFilePath))
            {
                File.WriteAllText(startFilePath, dateDisplay);
                MessageBox.Show("This application tracks your pc time.\r\nTimes will be automatically saved after one minute (Current Time).\r\nThe button \"Save and Quit\" saves the times before shutting down.\r\nGeneral statistics are shown at the bottom right.");
            }
        }

        public void SetDisplay()
        {
            LabelTimeCurrent.Text = $"{cHour.ToString("D2")} : {cMinute.ToString("D2")} : {cSecond.ToString("D2")}";
            LabelTimeToday.Text = $"{dHour.ToString("D2")} : {dMinute.ToString("D2")} : {dSecond.ToString("D2")}";
            LabelTimeTotal.Text = $"{tHour.ToString("D2")} : {tMinute.ToString("D2")} : {tSecond.ToString("D2")}";

            totalDays = (DateTime.ParseExact(dateDisplay, "dd.MM.yyyy", null) - DateTime.ParseExact(startDate, "dd.MM.yyyy", null)).TotalDays.ToString();
            LabelTotalDays.Text = totalDays + " Days";
            LabelTimePerDay.Text = Math.Round((tHour / float.Parse(totalDays)), 2).ToString() + " h/D";
            if (float.Parse(totalDays) >= 7)
            {
                LabelTimePerWeek.Text = Math.Round((tHour / (float.Parse(totalDays) / 7)), 2).ToString() + " h/W";
            }
            else
            {
                LabelTimePerWeek.Text = tHour.ToString() + " h/W";
            }

            if (float.Parse(totalDays) >= 31)
            {
                LabelTimePerMonth.Text = Math.Round((tHour / (float.Parse(totalDays) / 31)), 2).ToString() + " h/M";
            }
            else
            {
                LabelTimePerMonth.Text = tHour.ToString() + " h/M";
            }

            if (float.Parse(totalDays) >= 365)
            {
                LabelTimePerYear.Text = Math.Round((tHour / (float.Parse(totalDays) / 365)), 2).ToString() + " h/Y";
            }
            else
            {
                LabelTimePerYear.Text = tHour.ToString() + " h/Y";
            }
        }

        public async void GetData()
        {
            char[] dailyChars = File.ReadAllText(dailyFilePath).ToCharArray();
            char[] totalChars = File.ReadAllText(totalFilePath).ToCharArray();
            startDate = File.ReadAllText(startFilePath).Trim();

            dSecond = int.Parse(string.Join("", dailyChars.Skip(0).Take(2)));
            dMinute = int.Parse(string.Join("", dailyChars.Skip(3).Take(2)));
            dHour = int.Parse(string.Join("", dailyChars.Skip(6)));

            tSecond = int.Parse(string.Join("", totalChars.Skip(0).Take(2)));
            tMinute = int.Parse(string.Join("", totalChars.Skip(3).Take(2)));
            tHour = int.Parse(string.Join("", totalChars.Skip(6)));

            LabelDate.Text = "Start: " + startDate;
            LabelDateToday.Text = dateDisplay;

            await TaskPositionForm();
        }

        private async Task TaskPositionForm()
        {
            await Task.Run(() => { SetFormPosition(); });
        }

        private void SetFormPosition()
        {
            if (File.Exists(dataFilePath))
            {
                string[] dat = File.ReadAllLines(dataFilePath);
                Console.WriteLine($"{dat[0]}:{dat[1]}");
                Thread.Sleep(50);
                if (InvokeRequired)
                {
                    Invoke((Action)delegate { SetFormPosition(); });
                }
                else
                {
                    this.Location = new Point(int.Parse(dat[0]), int.Parse(dat[1]));
                }
            }
        }

        public void SaveData()
        {
            File.WriteAllText(totalFilePath, $"{tSecond.ToString("D2")}:{tMinute.ToString("D2")}:{tHour.ToString("D2")}");
            File.WriteAllText(dailyFilePath, $"{dSecond.ToString("D2")}:{dMinute.ToString("D2")}:{dHour.ToString("D2")}");
            File.WriteAllText(dataFilePath, $"{this.Location.X}\n{this.Location.Y}");
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
