using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FormulaOneWebAPIProject.DTOs
{
    [DataContract(Name = "race")]
    public class RaceItem
    {
        [DataMember(Name = "id")]
        public int id;
        [DataMember(Name = "name")]
        public string name;
        [DataMember(Name = "circuit")]
        public string circuit;
        [DataMember(Name = "date")]
        public string date;

        public RaceItem(Race r)
        {
            this.id = r.ID;
            this.name = r.Name;
            this.circuit = r.Circuit.Name;
            this.date = r.Date.ToShortDateString();
        }
    }
}