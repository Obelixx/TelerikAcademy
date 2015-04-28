namespace TA_ICS_Extractor
{
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
    using Microsoft.Win32;
    using System.IO;
    using System.Collections.Specialized;

    using TA_ICS_Extractor.Models;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string HomeworkString = "Срок за домашно";

        private const string LoginPage = @"https://telerikacademy.com/Users/Auth/Login/";
        private const string LoginPageDocument = "index.html";
        private const string PageUserNameString = "UsernameOrEmail";
        private const string PagePasswordString = "Password";

        private string loadFile = string.Empty;
        private string saveFolder = string.Empty;
        private static DateTime now = DateTime.Now;

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Load
        private void Select_ICS_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            var dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".ics";
            dlg.Filter = "Calendar File (.ics)|*.ics" + "|All Files|*.*";


            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                loadFile = dlg.FileName;
                FileNameTextBox.Text = loadFile;
                From.Text = loadFile;
                SaveTab.IsEnabled = true;
            }
        }

        private void DonwloadFromSite_Checked(object sender, RoutedEventArgs e)
        {
            FileNameTextBox.IsEnabled = false;
            Select_ICS.IsEnabled = false;
            UsernameOrEmail.IsEnabled = true;
            Password.IsEnabled = true;
            Login.IsEnabled = true;
            //Logout.IsEnabled = true;

        }

        private void DonwloadFromSite_Unchecked(object sender, RoutedEventArgs e)
        {
            FileNameTextBox.IsEnabled = true;
            Select_ICS.IsEnabled = true;
            UsernameOrEmail.IsEnabled = false;
            Password.IsEnabled = false;
            Login.IsEnabled = false;
            //Logout.IsEnabled = false;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var client = new CookieAwareWebClient();
            client.BaseAddress = LoginPage;
            var loginData = new NameValueCollection();
            loginData.Add(PageUserNameString, UsernameOrEmail.Text);
            loginData.Add(PagePasswordString, Password.Password);
            client.UploadValues(LoginPageDocument, "POST", loginData);

            string htmlSource = client.DownloadString("https://telerikacademy.com/Users/Calendar/DownloadCalendarEvents");
            if (htmlSource.Contains("<!DOCTYPE html>"))
            {
                Status.Text = "Login Failed!";
            }
            else
            {
                Status.Text = "Login OK!";
                client.DownloadFile("https://telerikacademy.com/Users/Calendar/DownloadCalendarEvents",
                                    System.AppDomain.CurrentDomain.BaseDirectory + "\\original.ics");
                loadFile = System.AppDomain.CurrentDomain.BaseDirectory + "\\original.ics";
                FileNameTextBox.Text = loadFile;
                From.Text = loadFile;
                DonwloadFromSite.IsEnabled = false;
                UsernameOrEmail.IsEnabled = false;
                Password.IsEnabled = false;
                Login.IsEnabled = false;
                SaveTab.IsEnabled = true;
            }
        }
        #endregion

        #region Save
        private void SelectFolder_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new SaveFileDialog();

            dlg.DefaultExt = ".ics";
            dlg.Filter = "Calendar File (.ics)|*.ics" + "|All Files|*.*";
            dlg.OverwritePrompt = false;
            dlg.Title = "Select some file in output directory.";
            dlg.FileName = "JustClickSave";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                // It was hard fo find dialog to pick directory so i pick file, and take just the directory.
                TryToSetSaveFolder(dlg.FileName.Substring(0, dlg.FileName.LastIndexOf('\\') + 1));
            }
        }

        private void UseLoadDir_Click(object sender, RoutedEventArgs e)
        {
            string path = loadFile.Substring(0, loadFile.LastIndexOf('\\') + 1);
            TryToSetSaveFolder(path);
        }

        private void UseProgramDir_Click(object sender, RoutedEventArgs e)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            TryToSetSaveFolder(path);

        }

        private void UseDesktopDir_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + "\\";
            TryToSetSaveFolder(path);
        }


        private void TryToSetSaveFolder(string folder)
        {
            if (folder != null || folder != string.Empty)
            {
                saveFolder = folder;
                OutputFolderTextBox.Text = folder;
                To.Text = folder;
                ExtractICSTab.IsEnabled = true;
            }
        }
        #endregion

        #region Extract
        private void OneFileChackBox_Checked(object sender, RoutedEventArgs e)
        {
            HomeworksCheckBox.IsEnabled = false;
            LecturesCheckBox.IsEnabled = false;
        }

        private void OneFileChackBox_Unchecked(object sender, RoutedEventArgs e)
        {
            HomeworksCheckBox.IsEnabled = true;
            LecturesCheckBox.IsEnabled = true;
        }

        private void LecturesCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            HomeworksCheckBox.IsChecked = true;
            HomeworksCheckBox.IsEnabled = false;
        }

        private void LecturesCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            HomeworksCheckBox.IsEnabled = true;
        }

        private void ExtractButton_Click(object sender, RoutedEventArgs e)
        {
            Logic();
        }
        #endregion

        #region Logic
        private void Logic()
        {
            var TA_Calendar = new MyCalendar(loadFile, (bool)SourcePRODID.IsChecked);
            string ICSsaveLocation = saveFolder + now.Year + now.Month + now.Day + now.Hour + now.Minute + now.Second + now.Millisecond + ".ics";

            if ((bool)OneFileChackBox.IsChecked)
            {
                WriteCalendarTofile(ICSsaveLocation, TA_Calendar);
            }
            else
                if ((bool)HomeworksCheckBox.IsChecked && !(bool)LecturesCheckBox.IsChecked)
                {
                    var Homeworks_Calendar = new MyCalendar((bool)SourcePRODID.IsChecked);
                    ExtractHomeworksToNewCalendar(TA_Calendar, out Homeworks_Calendar);
                    string HomeworksSaveLocation = saveFolder + now.Year + now.Month + now.Day + now.Hour + now.Minute + now.Second + now.Millisecond + "_homeworks.ics";

                    WriteCalendarTofile(ICSsaveLocation, TA_Calendar);
                    WriteCalendarTofile(HomeworksSaveLocation, Homeworks_Calendar);
                }
                else if ((bool)LecturesCheckBox.IsChecked)
                {
                    var Homeworks_Calendar = new MyCalendar((bool)SourcePRODID.IsChecked, TA_Calendar.PRODID);
                    ExtractHomeworksToNewCalendar(TA_Calendar, out Homeworks_Calendar);
                    string HomeworksSaveLocation = saveFolder + now.Year + now.Month + now.Day + now.Hour + now.Minute + now.Second + now.Millisecond + "_homeworks.ics";
                    WriteCalendarTofile(HomeworksSaveLocation, Homeworks_Calendar);

                    var calendarList = new List<MyCalendar>();
                    ExtractEachNewSummery_ToNewCalendar(TA_Calendar, out calendarList);

                    foreach (var cal in calendarList)
                    {
                        string calFilename = cal.Events[0].SUMMARY.Substring(cal.Events[0].SUMMARY.IndexOf('"') + 1, cal.Events[0].SUMMARY.IndexOf(' ', cal.Events[0].SUMMARY.IndexOf('"') + 1) - (cal.Events[0].SUMMARY.IndexOf('"') + 1));
                        string calSaveLocation = saveFolder + now.Year + now.Month + now.Day + now.Hour + now.Minute + now.Second + now.Millisecond + "_" + calFilename + ".ics";
                        WriteCalendarTofile(calSaveLocation, cal);
                    }
                }

        }

        private void WriteCalendarTofile(string saveLocation, MyCalendar cal)
        {
            StreamWriter output = new StreamWriter(saveLocation);
            output.Write(cal.ToString());
            output.Close();
            MessageBox.Show("File: " + saveLocation + " written!");
        }

        private void ExtractHomeworksToNewCalendar(MyCalendar input, out MyCalendar Homeworks_Calendar)
        {
            var output = new MyCalendar((bool)SourcePRODID.IsChecked, input.PRODID);
            for (int i = 0; i < input.Events.Count; i++)
            {
                if (input.Events[i].SUMMARY.Contains(HomeworkString))
                {
                    output.Events.Add(input.Events[i]);
                    input.Events.RemoveAt(i);
                    i--;
                }
            }
            Homeworks_Calendar = output;
        }



        private void ExtractEachNewSummery_ToNewCalendar(MyCalendar input, out List<MyCalendar> output)
        {
            output = new List<MyCalendar>();
            foreach (var ev in input.Events)
            {
                bool EventNotAdded = true;
                foreach (var cal in output)
                {
                    if (cal.Events[0].SUMMARY == ev.SUMMARY)
                    {
                        cal.Events.Add(ev);
                        EventNotAdded = false;
                        break;
                    }
                }
                if (EventNotAdded)
                {
                    output.Add(new MyCalendar((bool)SourcePRODID.IsChecked, input.PRODID));
                    output[output.Count - 1].Events.Add(ev);
                }
            }
        }

        #endregion
    }
}
