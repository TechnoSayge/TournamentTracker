﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
