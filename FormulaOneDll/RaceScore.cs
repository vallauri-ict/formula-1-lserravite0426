using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    [DataContract(Name = "raceScore")]
    public class RaceScore
    {
        #region Attributes
        [DataMember(Name ="driver")]
        private Driver driver;
        [DataMember(Name="pos")]
        private Score pos;
        [DataMember(Name ="race")]
        private Race race;
        [DataMember(Name = "fastesLap")]
        private string fastesLap;
        #endregion

        #region Constructors
        public RaceScore() { }

        public RaceScore(Driver driver, Score pos, Race race, string fastesLap)
        {
            this.Driver = driver;
            this.Pos = pos;
            this.Race = race;
            this.FastesLap = fastesLap;
        }
        #endregion

        #region Properties
        public Driver Driver { get => driver; set => driver = value; }
        public Score Pos { get => pos; set => pos = value; }
        public Race Race { get => race; set => race = value; }
        public string FastesLap { get => fastesLap; set => fastesLap = value; }
        #endregion
    }
}
