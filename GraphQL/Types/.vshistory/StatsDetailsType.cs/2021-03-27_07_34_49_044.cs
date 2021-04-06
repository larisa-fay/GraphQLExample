using System.Collections.Generic;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class StatsDetailsType
    {
        public int TotalSorEntries { get; set; }
        public List<SorEntryType> SorEntriesSample { get; set; }

    }
}