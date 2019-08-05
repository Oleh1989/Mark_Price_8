using System;
using System.Reflection;
using System.Linq;
using static System.Console;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Assembly metadata");

            Assembly assembly = Assembly.GetEntryAssembly();
            WriteLine($" Full name: {assembly.FullName}");
            WriteLine($" Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();

            WriteLine(" Attributes:");
            foreach (Attribute attribute in attributes)
            {
                WriteLine($" {attribute.GetType()}");
            }

            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            WriteLine($" Version: {version.InformationalVersion}");

            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            WriteLine($" Company: {company.Company}");


            WriteLine(new string('#', 50));

            WriteLine($"Types:");
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                WriteLine($" Name: {type.FullName}");
                MemberInfo[] members = type.GetMembers();

                foreach (MemberInfo member in members)
                {
                    WriteLine($" {member.MemberType} : {member.Name} ({member.DeclaringType.Name})");

                    var coders = member.GetCustomAttributes<CoderAttribute>()
                        .OrderByDescending(c => c.LastModified);
                    foreach (CoderAttribute coder in coders)
                    {
                        WriteLine($" Modified by {coder.Coder} on {coder.LastModified.ToShortDateString()}");
                    }
                }
            }
        }
        [Coder("Mark Price", "22 August 2017")]
        [Coder("Johni Rasmussen", "13 September 2017")]
        public static void DoStaff()
        {

        }
    }
}
