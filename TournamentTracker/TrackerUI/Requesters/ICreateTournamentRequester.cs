﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerUI.Requesters
{
    public interface ICreateTournamentRequester
    {
        void TournamentComplete(TournamentModel tournament);
    }
}
