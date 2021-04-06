using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class OtdrFiberContainerResponseResolver
    {
        public List<OtdrFiberContainerMessageType> GetMessages([Service]SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            OtdrFiberContainerMessageType tempResult = new OtdrFiberContainerMessageType
            {
                MessageLevel = MessageLevel.WARNING,
                MessageCode = 123,
                InternalMessage = "All Good"
            };
            List<OtdrFiberContainerMessageType> resMessageList = new List<OtdrFiberContainerMessageType>();
            resMessageList.Add(tempResult);
           return resMessageList;
           
        }
        public OtdrFiberContainerDataType GetOtdrFiberContainerData([Service] SorEntryService fileService,
            [Service] IMapper mapper)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

            StatsDetailsType stats = new StatsDetailsType
            {
                TotalSorEntries = fileService.EntryCount(),
                SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
            };

            OtdrFiberContainerDataType tempResult = 
                new OtdrFiberContainerDataType
                {
                    PassFailStatus = PassFailStatus.NOTEVALUATED
                };
            return tempResult;

        }
    }
}
