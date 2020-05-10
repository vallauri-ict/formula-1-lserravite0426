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
        private readonly int id;
        [DataMember(Name = "name")]
        private string fullname;
        [DataMember(Name = "country")]
        private string country;
        [DataMember(Name = "img")]
        private string img;
        [DataMember(Name = "description")]
        private string description;

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