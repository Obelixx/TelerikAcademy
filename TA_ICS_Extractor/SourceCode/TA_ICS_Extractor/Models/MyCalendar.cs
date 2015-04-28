namespace TA_ICS_Extractor.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;
    using System.IO;
    using System.Diagnostics;

    public class MyCalendar
    {
        private string prodidString = string.Empty;
        public string PRODID
        {
            get { return prodidString; }
        }

        public List<MyEvent> Events = new List<MyEvent>();

        public MyCalendar(bool prodid_fromFile = false, string prodid_string = null)
        {
            if (prodid_fromFile)
            {
                this.prodidString = prodid_string;
            }
            else
            {
                this.prodidString = MyPRODID;
            }
        }

        public MyCalendar(string filePath, bool prodid_fromFile = false)
        {
            if (!prodid_fromFile)
            {
                prodidString = MyPRODID;
            }
            string line;
            using (StreamReader file = new StreamReader(filePath))
            {
                bool inEvent = false;
                List<string> eventLines = new List<string>();
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("PRODID:") && prodid_fromFile)
                    {
                        this.prodidString = line.Substring("PRODID:".Length);
                    }
                    if (inEvent || line == "BEGIN:VEVENT")
                    {
                        inEvent = true;
                        eventLines.Add(line);
                        if (line == "END:VEVENT")
                        {
                            inEvent = false;
                            this.Events.Add(new MyEvent(eventLines.ToArray()));
                            eventLines.Clear();
                        }
                    }
                }
                file.Close();
            }
        }




        private static string MyPRODID
        {
            get
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                string ver = fvi.FileVersion;

                //string ver = ((AssemblyVersionAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyVersionAttribute), false)).Version;
                return "-//Home_Project//TA_ICS_Extractor " + ver + "//BG";
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("BEGIN:VCALENDAR");
            sb.AppendLine("PRODID:" + prodidString);
            foreach (var ev in Events)
            {
                sb.Append(ev.ToString());
            }
            sb.AppendLine("END:VCALENDAR");
            return sb.ToString();
        }

    }
}
