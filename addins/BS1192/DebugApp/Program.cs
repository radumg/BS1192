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
            Console.WriteLine("Fresh revision  : " + rev1.GetAsString());
            Console.WriteLine("Increment major : " + rev1.IncrementMajor().GetAsString());
            Console.WriteLine("Increment minor : " + rev1.IncrementMinor().GetAsString());
            Console.WriteLine("Reset revision \t: " + rev1.Reset().GetAsString());
            Console.WriteLine("Set to P03.07 \t: " + rev1.SetMajor(3).SetMinor(7).GetAsString());
            Console.WriteLine("Get major \t: " + rev1.Major);
            Console.WriteLine("Get minor \t: " + rev1.Minor);
            Console.WriteLine("Set to P99.05 \t: " + rev1.SetMajor(99).SetMinor(5).GetAsString());
            // the following should throw out
            try
            {
                Console.Write("Set to P-03.03 \t: ");
                Console.WriteLine(rev1.SetMajor(-3).SetMinor(3).GetAsString());
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try
            {
                Console.Write("Set to P1.-05 \t: ");
                Console.WriteLine(rev1.SetMajor(1).SetMinor(-5).GetAsString());
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try
            {
                Console.Write("Set to P105.02 \t: ");
                Console.WriteLine(rev1.SetMajor(105).SetMinor(2).GetAsString());
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            hl();

            Console.WriteLine("Roles");
            Console.WriteLine("Default role \t: " + BS1192.Role.CurrentRole);
            Console.Write("Set to Struct \t: "); BS1192.Role.SetRole(BS1192.Roles.S); Console.WriteLine(BS1192.Role.CurrentRole);
            Console.Write("Set to MEP  \t: "); BS1192.Role.SetRole(BS1192.Roles.M); Console.WriteLine(BS1192.Role.CurrentRole);

            Console.ReadKey();
        }

        static void hl()
        {
            Console.WriteLine(Environment.NewLine + "--------------------------------------------------------" + Environment.NewLine);
        }
    }
}
