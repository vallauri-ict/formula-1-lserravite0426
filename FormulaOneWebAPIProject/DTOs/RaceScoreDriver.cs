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
        private string race;
        [DataMember(Name = "circuit")]
        private string circuit;
        [DataMember(Name = "pos")]
        private int pos;
        [DataMember(Name = "score")]
        private int score;
        [DataMember(Name = "details")]
        private string details;

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