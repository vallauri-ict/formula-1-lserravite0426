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
        private int id;
        [DataMember(Name = "name")]
        private string name;
        [DataMember(Name = "country")]
        private string country;
        [DataMember(Name = "powerUnit")]
        private string powerUnit;
        [DataMember(Name = "chassis")]
        private string chassis;
        [DataMember(Name = "drivers")]
        private string[] drivers;
        [DataMember(Name = "logo")]
        private string logo;
        [DataMember(Name = "img")]
        private string img;

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