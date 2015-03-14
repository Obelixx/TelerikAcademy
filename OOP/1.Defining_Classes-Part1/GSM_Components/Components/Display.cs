namespace GSM_Namespace.Components
{
    using System;
    using System.Text;

    public class Display
    {
        private double? sizeInch;
        public double? SizeInch
        {
            get { return sizeInch; }
            set 
            { 
                if (value >= 0)
                {
                    this.sizeInch = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("sizeInch must be positive value!");
                }
            }
        }

        private int? colours;
        public int? Colours
        {
            get { return colours; }
            set 
            { 
                if (value >= 0)
                {
                    this.colours = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("sizeInch must be positive value!");
                }
            }
        }

        #region Constructors ...
        public Display()
        {
            this.sizeInch = null;
            this.colours = null;
        }

        public Display(double size)
        {
            this.sizeInch = size;
            this.colours = 16000000;
        }

        public Display(double size,int colours)
        {
            this.sizeInch = size;
            this.colours = colours;
        }
        #endregion


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Display info:");
            if (this.sizeInch != null) sb.AppendLine("\t Size: " + this.sizeInch + " inches");
            if (this.colours != null) sb.AppendLine("\t Colours count: " + this.colours);
            if (this.sizeInch == null && this.colours == null)
            {
                sb.AppendLine("\t <empty> ");
            }
            return sb.ToString();
        }

    }
}
