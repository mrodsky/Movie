﻿using Movie.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Library.Models
{
    public class Voting : AModel
    {
        public MovieClass Movie
        {
            get;
            set;
        }
        public Voting()
        {

        }
    }
}
