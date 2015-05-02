namespace Application
{
    using System;

    /*
        Problem 11. Version attribute• Create a  [Version]  attribute that can be applied to structures, 
        classes, interfaces, enumerations and methods and holds a version in the format  major.minor  (e.g.  2.11 ).
        • Apply the version attribute to a sample class and display its version at runtime.
    */
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method |
                    AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        private uint major;
        private uint minor;

        public VersionAttribute(uint major, uint minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public string Version 
        {
            get
            {
                return this.ToString();
            }
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.major, this.minor);
        }
    }
}

