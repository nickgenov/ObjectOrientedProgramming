using System;

namespace GenericListVersion
{
    class VersionMain
    {
        static void Main()
        {
            //TODO Find out why activating the indexer method in GenericList<T> causes exception when casting to Version

            Type type = typeof (GenericList<>);
            Object[] versions = type.GetCustomAttributes(false);

            foreach (Version version in versions)
            {
                Console.WriteLine("Full version: {0}", version.FullVersion);
            }
        }
    }
}