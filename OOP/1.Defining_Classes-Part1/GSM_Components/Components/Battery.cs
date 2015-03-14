namespace GSM_Namespace.Components
{
    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


    public class Battery
    {
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int? hoursIdle;
        public int? HoursIdle
        {
            get { return hoursIdle; }
            set 
            {
                if (value >= 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("HoursIdle must be positive value!");
                }
            }
        }

        private int? hoursTolk;
        public int? HoursTolk
        {
            get { return hoursTolk; }
            set 
            { 
                if (value >= 0)
                {
                    this.hoursTolk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("hoursTolk must be positive value!");
                }
            }
        }
        
        private BatteryType? type;

        public BatteryType? Type
        {
            get { return type; }
            set { type = value; }
        }
        //BatteryType (Li-Ion, NiMH, NiCd, …)
        public enum BatteryType
        {
            LiIon=0,
            NiMh=1,
            NiCd=2
        }
        public static Dictionary<int?, string> BatteryDicttionary = new Dictionary<int?, string>
        {
            {0,"Li-Ion"},
            {1,"NiMh"},
            {2,"NiCd"}
        };

        private string batteryType
        {
            get
            {
                string tempBatteryString;
                if (this.type==null)
                {
                    return (null);
                }
                BatteryDicttionary.TryGetValue((int)this.type, out tempBatteryString);
                return tempBatteryString;
            }
        }

        #region Constructors ...
        public Battery()
        {
            this.model = null;
            this.type = null;
            this.hoursIdle = null;
            this.hoursTolk = null;
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = null;
            this.hoursTolk = null;
            this.type = BatteryType.LiIon;
        }

        public Battery(BatteryType type)
        {

            this.type = type;
            this.model = "Default " + batteryType + " battery";
            this.hoursIdle = null;
            this.hoursTolk = null;
        }


        public Battery(string model, int idle, int tolk)
        {
            this.model = model;
            this.hoursIdle = idle;
            this.hoursTolk = tolk;
            this.type = BatteryType.LiIon;
        }
        public Battery(string model, int idle, int tolk, BatteryType? type)
        {
            this.model = model;
            this.hoursIdle = idle;
            this.hoursTolk = tolk;
            this.type = type;
        }
        #endregion

        

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Battery info:");
            if (this.model != null) sb.AppendLine("\t Model: " + this.model);
            if (this.hoursIdle != null) sb.AppendLine("\t Idle time: " + this.hoursIdle + " Hours");
            if (this.hoursTolk != null) sb.AppendLine("\t Tolk time: " + this.hoursTolk + " Hours");
            if (this.type != null) sb.AppendLine("\t Battery type: " + batteryType);

            if (this.model == null && this.hoursIdle == null && this.hoursTolk == null && this.type == null)
            {
                sb.AppendLine("\t <empty> ");
            }
            return sb.ToString();
        }

    }
}
