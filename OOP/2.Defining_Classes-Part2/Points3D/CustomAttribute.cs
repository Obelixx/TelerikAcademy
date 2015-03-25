// Problem 11. Version attribute

//Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.

namespace CustomAttribute
{
    using System;

    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method)]
    public class Version : System.Attribute
    {
        private double version;

        public Version(double version)
        {
            this.version = version;
        }
        public override string ToString()
        {
            return ("Version: " + version.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
