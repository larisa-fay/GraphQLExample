using System.Collections.Generic;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class MutationResolver
    {
        public ICreateOtdrFiberContainersResponse GetCreateOtdrFiberContainers([Service]SorEntryService fileService,
            [Service] IMapper mapper,
            //CreateOtdrFiberContainersWhereInput where
            OtdrFiberContainerWhereInput where
            )
        {
            List<SorEntry> sample = fileService.EntriesSample(3);

                StatsDetailsType stats = new StatsDetailsType
                {
                    TotalSorEntries = fileService.EntryCount(),
                    SorEntriesSample = mapper.Map<List<SorEntry>, List<SorEntryType>>(sample)
                };

            CreateOtdrFiberContainersResponseType tempResponse = new CreateOtdrFiberContainersResponseType
            {
                /*
                CreateOtdrFiberContainersResult = new CreateOtdrFiberContainersResultType(),
                CreateOtdrFiberContainersError = new CreateOtdrFiberContainersErrorType() 
                */
            };

            CreateOtdrFiberContainersResultType tempresult = new CreateOtdrFiberContainersResultType()
            {
                OtdrFiberContainerResponseList = new List<OtdrFiberContainerResponseType> ()
            };
            CreateOtdrFiberContainersErrorType temperror = new CreateOtdrFiberContainersErrorType();
            /*
            System.Collections.IList list = where.OtdrFiberContainerWhereList;
			for (int i = 0; i < list.Count; i++)
			{
				List<OtdrFiberContainerWhereInput> contIdFileDirList = (List<OtdrFiberContainerWhereInput>)list[i];
			}
            */
           return tempresult;
           
        }
        public IFooBarBaz GetUniontest([Service] SorEntryService fileService,
            [Service] IMapper mapper)
        {
            BazType b = new BazType()
            {
                Baz = "This is the object of type Baz",
                
                
            };

            BarType r = new BarType()
            {
                Bar = "This is the object of type Bar",


            };
            
            return r;

        }
        public string GetDoABCDE(
            ABCDWhereInput where)
        {
            

            return "Good";

        }
    }
}
