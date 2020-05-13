using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FormulaOneWebAPIProject.DTOs
{
    [DataContract(Name = "driver")]
    public class DriverItem
    {
        [DataMember(Name = "id")]
        public readonly int id;
        [DataMember(Name = "name")]
        public string fullname;
        [DataMember(Name = "country")]
        public string country;
        [DataMember(Name = "img")]
        public string img;
        [DataMember(Name = "description")]
        public string description;

        public DriverItem(Driver d)
        {
            this.id = d.ID;
            this.fullname = $"{d.Firstname} {d.Lastname}";
            this.country = d.Country.CountryName;
            this.img = d.Img;
            this.description = d.Description;
        }
    }
}