using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FormulaOneWebAPIProject.DTOs
{
    [DataContract(Name = "circuit")]
    public class CircuitItem
    {
        [DataMember(Name = "id")]
        private int id;
        [DataMember(Name = "name")]
        private string name;
        [DataMember(Name = "country")]
        private string country;
        [DataMember(Name = "img")]
        private string img;
        [DataMember(Name = "length")]
        private int length;

        public CircuitItem(Circuit c)
        {
            this.id = c.ID;
            this.name = c.Name;
            this.country = c.Country.CountryName;
            this.img = c.Img;
            this.length = c.Length;
        }
    }
}