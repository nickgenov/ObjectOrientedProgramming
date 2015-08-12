using System;

namespace GenericListVersion
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]
    public class Version : System.Attribute
    {
        public Version(int majorVersion, int minorVersion)
        {
            MajorVersion = majorVersion;
            MinorVersion = minorVersion;
        }

        public int MajorVersion { get; private set; }
        public int MinorVersion { get; private set; }
        public string FullVersion
        {
            get
            {
                string output = string.Format("{0}.{1}", this.MajorVersion, this.MinorVersion);

                return output;
            }
        }
    }
}