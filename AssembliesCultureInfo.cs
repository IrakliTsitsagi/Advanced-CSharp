using System;
using System.Reflection;
using System.Globalization;
namespace AssembliesCultureInfo
{
    internal class AssembliesCultureInfo
    {
        static void Main(string[] args)
        {
            Assembly assemObject = Assembly.GetEntryAssembly();
            AssemblyName assemName = assemObject.GetName();

            Console.WriteLine(assemName.FullName);

            Console.WriteLine(assemName.CultureName);
            CultureInfo cultureInfo = new CultureInfo("en-US");
            assemName.CultureInfo = cultureInfo;
            Console.WriteLine(assemName.CultureInfo.DisplayName);
            Console.WriteLine(assemName.CultureInfo.NativeName);
            Console.WriteLine(assemName.CultureInfo.NumberFormat.CurrencySymbol);
            Console.WriteLine(assemName.CultureInfo.Calendar);
        }
    }
}