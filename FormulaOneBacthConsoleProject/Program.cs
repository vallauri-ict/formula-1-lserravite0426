using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaOneDll;

namespace FormulaOneBacthConsoleProject
{
    class Program
    {
        static DbTools db = new DbTools();
        static string[] tables = new string[] {
            "Countries",
            "Drivers",
            "Teams",
            "Circuits",
            "Races",
            "Scores",
            "RacesScores"
        };

        static void Main(string[] args)
        {
            char scelta = '\0';
            do
            {
                #region Menu
                Console.WriteLine("*** FORMULA ONE - BATCH SCRIPTS ***");
                Console.WriteLine("1 - CREATE DATABASE");
                Console.WriteLine("2 - DROP DATABASE");
                Console.WriteLine("3 - EXPORT TO JSON");
                Console.WriteLine("X - EXIT");
                #endregion
                scelta = Char.ToUpper(Console.ReadKey(true).KeyChar);
                Console.Clear();
                switch (scelta)
                {
                    case '1': SetDB("Create"); break;
                    case '2': SetDB("Drop"); break;
                    case '3':
                        string path = @"D:\Dati\db.json";
                        if (db.SerializeToJSON<Team>(path))
                            Console.WriteLine("OK.");
                        else
                            Console.WriteLine("Error...");
                        break;
                    default:
                        Console.WriteLine("Uncorrect Choice - Try Again");
                        break;
                    case 'X': return;
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            while (scelta != 'X');
        }

        private static void SetDB(string operation)
        {
            if (operation == "Drop")
            {
                foreach (string table in tables.Reverse())
                {
                    CallExecuteSqlScript($"{operation}{table}.sql");
                }
            }
            else
            {
                foreach (string table in tables)
                {
                    CallExecuteSqlScript($"{operation}{table}.sql");
                }
            }
        }
        private static void SetContraints()
        {
            CallExecuteSqlScript("SetConstraints.sql");
        }

        private static bool CallExecuteSqlScript(string scriptName)
        {
            try
            {
                db.ExecuteSqlScript($"{scriptName}");
                Console.WriteLine($"{scriptName} - SUCCESS.\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{scriptName} - {ex.Message}\n");
                return false;
            }
        }
    }
}
