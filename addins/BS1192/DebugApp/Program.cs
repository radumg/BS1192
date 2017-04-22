using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS1192.Standard;

namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string bs = "15183-GAL-XX-00-DR-A-qwert-0000-S1-P2";
            Console.WriteLine(bs);
            string[] fields = bs.Split('-');

            var projcode = fields[0];
            var orig = fields[1];
            var vol = fields[2];
            var level = fields[3];
            var type = fields[4];
            var role = fields[5];
            var number = "";
            var clas = "";
            int index = 6;
            if (fields[index].All(char.IsNumber))
            {
                number = fields[index];
                index++;
            }
            else
            {
                clas = fields[6];
                number = fields[7];
                index += 2;
            }
            var suit = "";
            if (index < fields.Length)  suit = fields[index];
            index++;
            var rev = "";
            if (index < fields.Length) rev = fields[index];

            Enum.TryParse(role, out BS1192.Standard.Role parsebool);

            Console.WriteLine("projcode : " + projcode );
            Console.WriteLine("orig : " + orig);
            Console.WriteLine("vol : " + vol);
            Console.WriteLine("level : " + level);
            Console.WriteLine("type : " + type);
            Console.WriteLine("role : " + role + " / " + parsebool.ToString() );
            Console.WriteLine("number : " + number);
            Console.WriteLine("clas : " + clas);
            Console.WriteLine("suit : " + suit);
            Console.WriteLine("rev : " + rev);

            foreach (var item in fields)
            {
                Console.WriteLine(item);
            }

            List<string> levels = new List<string> { "01", "02", "GF", "007", "13", "68", "RF" };

            foreach (string l in levels)
            {
                if (l.All(char.IsDigit))
                {
                    // remove all preceding 0s and see if a valid number is left.
                    Console.WriteLine("original : " + l);
                    Console.Write("decomposing : ");
                    while (l.StartsWith("0")) { l.Remove(0, 1); Console.Write(l + ","); }
                    if (int.TryParse(l, out int val)) throw new Exception("Could not parse string into an int value for Level.");
                    Console.WriteLine("final : " + l);
                    Console.WriteLine("parsed : " + val.ToString());

                }
                //else if (!Enum.TryParse(l, out BS1192.Standard.Levels lev)) throw new Exception("Could not parse string into Level.");
            }
            Console.ReadKey();
        }
        /*
        static void ClassesTests()
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
            Console.Write("Set to Struct \t: "); BS1192.Role.SetRole(BS1192.Roles.S); Console.WriteLine(BS1192.Role.CurrentRole);
            Console.Write("Set to MEP  \t: "); BS1192.Role.SetRole(BS1192.Roles.M); Console.WriteLine(BS1192.Role.CurrentRole);

        }
        */
        static void hl()
        {
            Console.WriteLine(Environment.NewLine + "--------------------------------------------------------" + Environment.NewLine);
        }
    }
}
