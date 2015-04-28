using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_ICS_Extractor.Models
{
    public class MyEvent
    {
        string[] EventContent;
        public string SUMMARY = string.Empty;

        public MyEvent (string[] eventContent)
        {
            this.EventContent = eventContent;
            foreach (var line in this.EventContent)
            {
                if (line.Substring(0,"SUMMARY:".Length) == "SUMMARY:")
                {
                    this.SUMMARY = line;
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var line in this.EventContent)
            {
                    sb.AppendLine(line);
                
            }
            return sb.ToString();
        }

    }
}
