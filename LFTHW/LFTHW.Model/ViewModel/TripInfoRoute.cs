using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LFTHW.Model
{
    [NotMapped]
    public class TripInfoRoute: P_PdtInfo
    {
        public List<P_Route> routeList { get; set; }
    }
}
