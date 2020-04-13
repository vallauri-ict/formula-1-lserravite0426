using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    [DataContract(Name = "team")]
    public class Team
    {
        #region Attributes
        [DataMember(Name = "id")]
        private readonly int id;
        [DataMember(Name = "name")]
        private string name;
        [DataMember(Name = "fullTeamName")]
        private string fullTeamName;
        [DataMember(Name = "country")]
        private Country country;
        [DataMember(Name = "powerUnit")]
        private string powerUnit;
        [DataMember(Name = "technicalChief")]
        private string technicalChief;
        [DataMember(Name = "chassis")]
        private string chassis;
        [DataMember(Name = "firstDriver")]
        private Driver firstDriver;
        [DataMember(Name = "secondDriver")]
        private Driver secondDriver;
        [DataMember(Name = "img")]
        private string img;
        #endregion

        #region Constructors
        public Team() { }

        public Team(int id)
        {
            this.id = id;
        }

        public Team(int id, string nome, string fullTeamName, Country country, string powerUnit, string technicalChief, string chassis, Driver firstDriver, Driver secondDriver, string img) : this(id)
        {
            this.Name = nome;
            this.FullTeamName = fullTeamName;
            this.Country = country;
            this.PowerUnit = powerUnit;
            this.TechnicalChief = technicalChief;
            this.Chassis = chassis;
            this.FirstDriver = firstDriver;
            this.SecondDriver = secondDriver;
            this.Img = img;
        }
        #endregion

        #region Properties
        public int ID => id;
        public string Name { get => name; set => name = value; }
        public string FullTeamName { get => fullTeamName; set => fullTeamName = value; }
        public Country Country { get => country; set => country = value; }
        public string PowerUnit { get => powerUnit; set => powerUnit = value; }
        public string TechnicalChief { get => technicalChief; set => technicalChief = value; }
        public string Chassis { get => chassis; set => chassis = value; }
        public Driver FirstDriver { get => firstDriver; set => firstDriver = value; }
        public Driver SecondDriver { get => secondDriver; set => secondDriver = value; }
        public string Img { get => img; set => img = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{this.Name} ({this.Country.CountryName})";
        #endregion
    }
}
