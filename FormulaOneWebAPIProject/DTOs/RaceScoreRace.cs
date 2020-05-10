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
        private string driver;
        [DataMember(Name = "pos")]
        private int pos;
        [DataMember(Name = "score")]
        private int score;
        [DataMember(Name = "details")]
        private string details;

        public RaceScoreRace(RaceScore s)
        {
            this.driver = s.Driver.ToString();
            this.pos = s.Pos.Pos;
            this.score = s.Pos.Points;
            this.details = s.Pos.Details;
        }
    }
}