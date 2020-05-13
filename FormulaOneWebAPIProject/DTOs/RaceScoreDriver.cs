using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FormulaOneWebAPIProject.DTOs
{
    [DataContract(Name = "score")]
    public class RaceScoreDriver
    {
        [DataMember(Name = "race")]
        public string race;
        [DataMember(Name = "circuit")]
        public string circuit;
        [DataMember(Name = "pos")]
        public int pos;
        [DataMember(Name = "score")]
        public int score;
        [DataMember(Name = "details")]
        public string details;

        public RaceScoreDriver(RaceScore s)
        {
            this.race = s.Race.Name;
            this.circuit = s.Race.Circuit.Name;
            this.pos = s.Pos.Pos;
            this.score = s.Pos.Points;
            this.details = s.Pos.Details;
        }
    }
}