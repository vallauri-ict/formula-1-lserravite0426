using FormulaOneDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FormulaOneWebAPIProject.DTOs
{ 
    [DataContract(Name = "score")]
    public class RaceScoreRace
    {
        [DataMember(Name = "driver")]
        public string driver;
        [DataMember(Name = "pos")]
        public int pos;
        [DataMember(Name = "score")]
        public int score;
        [DataMember(Name = "details")]
        public string details;

        public RaceScoreRace(RaceScore s)
        {
            this.driver = s.Driver.ToString();
            this.pos = s.Pos.Pos;
            this.score = s.Pos.Points;
            this.details = s.Pos.Details;
        }
    }
}