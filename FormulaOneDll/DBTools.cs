using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.IO;

// Cercare questi pacchetti su nuget
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.ComponentModel;

using Newtonsoft.Json;

namespace FormulaOneDll
{
    public class DbTools
    {
        private const string WORKINGPATH = @"D:\Dati\";
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Dati\FormulaOne.mdf;Integrated Security=True";

        private Dictionary<int, Driver> drivers;
        private Dictionary<string, Country> countries;
        private List<Team> teams;
        private Dictionary<int, Circuit> circuits;
        private Dictionary<int, Race> races;

        #region Tables
        public Dictionary<int, Driver> Drivers
        {
            get
            {
                if (this.drivers == null || this.drivers.Count == 0)
                    this.GetDrivers();
                return this.drivers;
            }
            set => drivers = value;
        }
        public Dictionary<string, Country> Countries
        {
            get
            {
                if (this.countries == null || this.countries.Count == 0)
                    this.GetCountries();
                return this.countries;
            }
            set => countries = value;
        }
        public List<Team> Teams
        {
            get
            {
                if (teams == null || teams.Count == 0)
                    this.LoadTeams();
                return teams;
            }
            set => teams = value;
        }
        public Dictionary<int, Circuit> Circuits
        {
            get
            {
                if (circuits == null || circuits.Count == 0)
                    this.GetCircuits();
                return circuits;
            }
            set => circuits = value;
        }
        public Dictionary<int, Race> Races
        {
            get
            {
                if (races == null || races.Count == 0)
                    this.GetRaces();
                return races;
            }
            set => races = value;
        }
        #endregion

        public void ExecuteSqlScript(string sqlScriptPath)
        {
            var fileContent = File.ReadAllText($"{WORKINGPATH}{sqlScriptPath}");
            fileContent = fileContent
                .Replace("\r\n", "")
                .Replace("\r", "")
                .Replace("\n", "")
                .Replace("\t", "");
            var sqlQueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOne.mdf;Integrated Security=True");
            var cmd = new SqlCommand("query", con);
            con.Open();
            foreach (var query in sqlQueries)
            {
                cmd.CommandText = query;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"Errore in esecuzione della query numero: {ex.LineNumber}");
                    Console.WriteLine($"Errore: {ex.Number} {ex.Message}");
                }
            }
            con.Close();
            con.Dispose();
            SqlConnection.ClearAllPools();
        }

        private void GetCountries()
        {
            this.countries = new Dictionary<string, Country>();
            var con = new SqlConnection(CONNECTION_STRING);
            using (con)
            {
                con.Open();
                var command = new SqlCommand("SELECT * FROM Countries;", con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string countryIsoCode = reader.GetString(0);
                    Country c = new Country()
                    {
                        CountryCode = countryIsoCode,
                        CountryName = reader.GetString(1)
                    };
                    this.countries.Add(countryIsoCode, c);
                }
                con.Close();
                con.Dispose();
            }
            SqlConnection.ClearAllPools();
        }

        private void GetDrivers(bool forceReload = false)
        {
            this.drivers = new Dictionary<int, Driver>();
            var con = new SqlConnection(CONNECTION_STRING);
            using (con)
            {
                con.Open();
                var command = new SqlCommand("SELECT * FROM Drivers;", con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Driver d = new Driver(reader.GetInt32(0))
                    {
                        Firstname = reader.GetString(1),
                        Lastname = reader.GetString(2),
                        Dob = reader.GetDateTime(3),
                        PlaceOfBirth = reader.GetString(4),
                        Country = this.Countries[reader.GetString(5)],
                        Img = reader.GetString(6),
                        Description = reader.GetString(7)
                    };
                    this.drivers.Add(d.ID, d);
                }
                con.Close();
                con.Dispose();
            }
            SqlConnection.ClearAllPools();
        }

        private void LoadTeams()
        {
            this.teams = new List<Team>();
            var con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={WORKINGPATH}FormulaOne.mdf;Integrated Security=True");
            using (con)
            {
                con.Open();
                var command = new SqlCommand("SELECT * FROM Teams;", con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Team t = new Team(reader.GetInt32(0))
                    {
                        Name = reader.GetString(1),
                        FullTeamName = reader.GetString(2),
                        Country = this.Countries[reader.GetString(3)],
                        PowerUnit = reader.GetString(4),
                        TechnicalChief = reader.GetString(5),
                        Chassis = reader.GetString(6),
                        FirstDriver = this.Drivers[reader.GetInt32(7)],
                        SecondDriver = this.Drivers[reader.GetInt32(8)],
                        Img = reader.GetString(9)
                    };
                    this.teams.Add(t);
                }
                con.Close();
                con.Dispose();
            }
            SqlConnection.ClearAllPools();
        }

        private void GetCircuits(bool forceReload = false)
        {
            this.circuits = new Dictionary<int, Circuit>();
            var con = new SqlConnection(CONNECTION_STRING);
            using (con)
            {
                con.Open();
                var command = new SqlCommand("SELECT * FROM Circuits;", con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Circuit c = new Circuit(reader.GetInt32(0))
                    {
                        Name = reader.GetString(1),
                        Length = reader.GetInt32(2),
                        Laps = reader.GetInt32(3),
                        Country = this.Countries[reader.GetString(4)],
                        RecordLap = reader.GetString(5),
                        Img = reader.GetString(6)
                    };
                    this.circuits.Add(c.ID, c);
                }
                con.Close();
                con.Dispose();
            }
            SqlConnection.ClearAllPools();
        }

        private void GetRaces()
        {
            this.races = new Dictionary<int, Race>();
            var con = new SqlConnection(CONNECTION_STRING);
            using (con)
            {
                con.Open();
                var command = new SqlCommand("SELECT * FROM Races;", con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Race r = new Race(reader.GetInt32(0))
                    {
                        Name = reader.GetString(1),
                        Circuit = this.Circuits[reader.GetInt32(2)],
                        Date = reader.GetDateTime(3)
                    };
                    this.races.Add(r.ID, r);
                }
                con.Close();
                con.Dispose();
            }
            SqlConnection.ClearAllPools();
        }

        public bool SerializeToJSON<T>(string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false);
                sw.AutoFlush = true;
                sw.WriteLine("{");
                sw.WriteLine($"\t\"teams\": {JsonConvert.SerializeObject(Teams, Formatting.Indented)},");
                sw.WriteLine($"\t\"drivers\": {JsonConvert.SerializeObject(Drivers.Values, Formatting.Indented)},");
                sw.WriteLine($"\t\"races\": {JsonConvert.SerializeObject(Races.Values, Formatting.Indented)},");
                sw.WriteLine($"\t\"circuits\": {JsonConvert.SerializeObject(Circuits.Values, Formatting.Indented)},");
                sw.WriteLine($"\t\"countries\": {JsonConvert.SerializeObject(Countries.Values, Formatting.Indented)}");
                sw.Write("}");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
