using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class OtdrFiberContainerResponseResolver
    {
        public CopyFiberMessageType GetMessages([Service]SorEntryService fileService,
            [Service] IMapper mapper,
            CopyRequestWhereInput where)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            CopyFiberMessageType tempResult = new CopyFiberMessageType 
            {
                Message = MessageLevel.WARNING,
                DisplayCode = "niceDisplayCodeHere",
                InternalMessage = "All Good"
            };
           return tempResult;
           
        }
        public CopyFiberDataType GetCopyFiberData([Service] SorEntryService fileService,
            [Service] IMapper mapper,
            CopyRequestWhereInput where)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

            StatsDetailsType stats = new StatsDetailsType
            {
                TotalSorEntries = fileService.EntryCount(),
                SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
            };

            CopyFiberDataType tempResult = 
                new CopyFiberDataType 
                {
                    PassFailStatus = PassFailStatus.NOTEVALUATED
                };
            return tempResult;

        }
    }
}
