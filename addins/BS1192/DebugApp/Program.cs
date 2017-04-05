using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS1192;

namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rev1 = new BS1192.Revision();
            Console.WriteLine("Fresh revision  :\t" + rev1.GetAsString());
            Console.WriteLine("Increment major :\t" + rev1.IncrementMajor().GetAsString());
            Console.WriteLine("Increment minor :\t" + rev1.IncrementMinor().GetAsString());
            Console.WriteLine("Reset revision :\t" + rev1.Reset().GetAsString());
            Console.WriteLine("Set to P03.07 :\t" + rev1.SetMajor(3).SetMinor(7).GetAsString());
            Console.WriteLine("Get major :\t" + rev1.Major);
            Console.WriteLine("Get minor :\t" + rev1.Minor);
            Console.WriteLine("Set to P99.05 :\t" + rev1.SetMajor(99).SetMinor(5).GetAsString());
            // the following should throw out
            try
            {
                Console.Write("Set to P-3.03 :\t");
                Console.WriteLine(rev1.SetMajor(-3).SetMinor(3).GetAsString());
            }
            catch (Exception e ){ Console.WriteLine(e.Message); }
            try
            {
                Console.Write("Set to P105.02 :\t");
                Console.WriteLine(rev1.SetMajor(105).SetMinor(2).GetAsString());
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            hl();

            var role = new Role();
            Console.WriteLine("Roles");
            Console.WriteLine("Default role :\t" + role.GetCurrentRole());
            Console.WriteLine("Set role to archi :\t" + role.SetRole(Role.BS1192Roles.Architect).GetCurrentRole());
            Console.WriteLine("Set role to MEP :\t" + role.SetRole(Role.BS1192Roles.MEP).GetCurrentRole());

            Console.ReadKey();
        }

        static void hl()
        {
            Console.WriteLine(Environment.NewLine + "--------------------------------------------------------" + Environment.NewLine);
        }
    }
}
