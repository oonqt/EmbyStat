﻿using System;
using System.Collections.Generic;
using System.Text;
using EmbyStat.Common.Models;
using EmbyStat.Services.Models;
using EmbyStat.Services.Models.Movie;

namespace EmbyStat.Services.Interfaces
{
    public interface IMovieService
    {
        List<Collection> GetMovieCollections();
        MovieStats GetGeneralStatsForCollections(List<string> collectionIds);
    }
}
