﻿using System.Collections.Generic;
using Itinerary.Common.Models;
using Itinerary.Common.Models.Google;

namespace Itinerary.Business.Services.Places
{
  public interface IGooglePlacesService
  {
    IEnumerable<Autocomplete> Autocomplete( string keyword );

    Location Location( string placeId );
  }
}
