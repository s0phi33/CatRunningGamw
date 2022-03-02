using System;
using System.Collections.Generic;
using System.Text;

namespace CatRunner
{
    [Serializable]
    public class SaveState
    {
        public int Highscore { get; set; }
        public DateTime HighscoreDate { get; set; }
    }
}
