using System.Collections.Generic;
using System.Threading.Tasks;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class OTDRQueryResolver
    {
        public Task<StatsDetailsType> GetDetailedStats([Service]SorEntryService fileService,
            [Service] IMapper mapper,
            LimitWhereInput where)
        {
            return Task.Run(() =>
            {
                List<SorEntry> sample = fileService.EntriesSample(where.Limit);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

                return stats;
            });
        }
	}
}
