namespace GSM_Namespace
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using GSM_Namespace.Components;
    using CallNamespace;


    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery = new Battery();
        private Display display = new Display();
        private List<Call> callHistory = new List<Call>();


        //static field and a property IPhone4S
        private static GSM iPhone4s = new GSM("IPhone 4s", "Apple", 600, new Battery("Non-removable Li-Po 1432 mAh battery (5.3 Wh)", 200, 8, Battery.BatteryType.LiIon), new Display(3.5, 16000000));
        public static GSM IPhone4s
        {
            get { return GSM.iPhone4s; }
        }

        #region Constructors ...
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;

            this.price = null;
            this.battery = new Battery();
            this.display = new Display();
            this.owner = null;
        }

        public GSM(string model, string manufacturer, decimal price, Battery batt, Display disp)
        {
            this.model = model;
            this.manufacturer = manufacturer;

            this.price = price;
            this.battery = batt;
            this.display = disp;
            this.owner = null;
        }

        public GSM(string model, string manufacturer, decimal price, string BatteryModel, int batteryIdleTime, int batteryTolkTime, double displaySize, int displayColoursCount)
        {
            this.model = model;
            this.manufacturer = manufacturer;

            this.price = price;
            this.battery = new Battery(BatteryModel, batteryIdleTime, batteryTolkTime);
            this.display = new Display(displaySize, displayColoursCount);
            this.owner = null;
        }
        #endregion


        #region prop
        public string Model
        {
            get { return model; }
            set
            {
                if (value != null && value != string.Empty)
                {
                    this.model = value;
                }
                else
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Model cant be null!");
                    }
                    else
                    {
                        throw new ArgumentException("Model cant be empty string!");
                    }
                }
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value != null && value != string.Empty)
                {
                    this.manufacturer = value;
                }
                else
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Manufacturer cant be null!");
                    }
                    else
                    {
                        throw new ArgumentException("Manufacturer cant be empty string!");
                    }
                }
            }
        }
        public decimal? Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price must be positive value!");
                }
            }
        }
        private static string currency = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
        public string Owner
        {
            get { return owner; }
            set
            {
                #region != null and empty
                if (value != null && value != string.Empty)
                {
                    #region is name
                    if (char.IsLetter(value[0]) && value.Contains(" "))
                    {
                        this.owner = value;
                    }
                    else
                    {
                        throw new ArgumentException("Owner name must contain at least two names!");
                    }
                    #endregion
                }
                else
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Owner cant be null!");
                    }
                    else
                    {
                        throw new ArgumentException("Owner cant be empty string!");
                    }
                }
                #endregion
            }
        }
        public string CallHistory
        {
            get 
            {
                var sb = new StringBuilder();
                
                if (callHistory.Count == 0)
                {
                    sb.AppendLine("<empty call history>");
                }
                else
                {
                    sb.AppendLine(new string('-', 20));
                    foreach (var call in callHistory)
                    {
                        sb.AppendLine(call.ToString());
                    }
                    sb.AppendLine(new string('-', 20));
                }
                
                return sb.ToString(); 
            }
        }
        #endregion


        public void AddCallToCallhistoryNow(string number, int durationInSeconds)
        {
            callHistory.Add(new Call(number, durationInSeconds));
        }
        public void AddCallToCallhistory(DateTime time, string number, int durationInSeconds)
        {
            callHistory.Add(new Call(time, number, durationInSeconds));
        }

        public void CallHistoryDeleteCall(DateTime time, string number)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].DateAndTime == time && callHistory[i].Number == number)
                {
                    callHistory.RemoveAt(i);
                    break;
                }
            }
        }
        public void CallHistoryDeleteLongestCall()
        {
            int bestI = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[bestI].DurationSeconds < callHistory[i].DurationSeconds)
                {
                    bestI = i;
                }
            }
            callHistory.RemoveAt(bestI);
        }


        public void CallHistoryClear()
        {
            callHistory.Clear();
        }

        public double CallPrice(double PricePerMinute)
        {
            double price = 0d;
            foreach (var call in callHistory)
            {
                if (call.Duration.TotalMinutes > (double)(int)call.Duration.TotalMinutes) // calculateing every starting minute (or if totalmintes has seconds -> add 1 min to price)
                {                                                                         //this makes calls with seconds to be like 1 min. calls (a.k.a. 60/60)
                    price+=PricePerMinute;
                }
                price += (int)call.Duration.TotalMinutes * PricePerMinute;
            }
            return price;
        }


        public override string ToString()
        {
            const int lineLen = 20;
            var sb = new StringBuilder();

            sb.AppendLine((new String('-', lineLen)));
            if (this.model != null) sb.AppendLine("GSM: " + this.model.ToString());
            if (this.manufacturer != null) sb.AppendLine("Made by: " + this.manufacturer.ToString());
            if (this.price != null) sb.AppendLine("Price: " + price.ToString() + " " + currency);
            if (this.owner != null) sb.AppendLine("Owner: " + owner);
            sb.AppendLine(this.battery.ToString());
            sb.AppendLine(this.display.ToString());
            sb.AppendLine((new String('-', lineLen)));

            return sb.ToString();
        }
    }
}
