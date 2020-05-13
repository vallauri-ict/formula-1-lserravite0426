using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FormulaOneWebAPIProject.DTOs
{
    [DataContract(Name = "team")]
    public class TeamItem
    {
        [DataMember(Name = "id")]
        public int id;
        [DataMember(Name = "name")]
        public string name;
        [DataMember(Name = "country")]
        public string country;
        [DataMember(Name = "powerUnit")]
        public string powerUnit;
        [DataMember(Name = "chassis")]
        public string chassis;
        [DataMember(Name = "drivers")]
        public string[] drivers;
        [DataMember(Name = "logo")]
        public string logo;
        [DataMember(Name = "img")]
        public string img;

        public TeamItem(Team t)
        {
            this.id = t.ID;
            this.name = t.Name;
            this.country = t.Country.CountryName;
            this.powerUnit = t.PowerUnit;
            this.chassis = t.Chassis;
            this.drivers = new string[]
            {
                t.FirstDriver.ToString(),
                t.SecondDriver.ToString()
            };
            this.logo = t.Logo;
            this.img = t.Img;
        }
    }
}