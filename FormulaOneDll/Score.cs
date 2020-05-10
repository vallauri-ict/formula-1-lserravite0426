using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOneDll
{
    [DataContract(Name ="score")]
    public class Score
    {
        #region Attributes
        [DataMember(Name="pos")]
        private int pos;
        [DataMember(Name = "score")]
        private int points;
        [DataMember(Name = "details")]
        private string details;
        #endregion

        #region Constructors
        public Score() { }
        
        public Score(int pos, int score, string details)
        {
            this.Pos = pos;
            this.Points = score;
            this.Details = details;
        }
        #endregion

        #region Properties
        public int Pos { get => pos; set => pos = value; }
        public int Points { get => points; set => points = value; }
        public string Details { get => details; set => details = value; }
        #endregion

        #region Methods

        #endregion
    }
}
