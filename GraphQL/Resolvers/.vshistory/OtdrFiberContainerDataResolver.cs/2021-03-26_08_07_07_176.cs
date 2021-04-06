﻿using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class CopyFiberDataResolver
    {
        public PassFailStatus GetPassFailStatus([Service]SorEntryService fileService,
            [Service] IMapper mapper,
            CopyRequestWhereInput where)
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

           return PassFailStatus.NOTEVALUATED;
           
        }
	}
}
