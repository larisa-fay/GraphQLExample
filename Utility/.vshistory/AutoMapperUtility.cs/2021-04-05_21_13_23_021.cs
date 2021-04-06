using System;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Service.GraphQL;
using AFL.OTDR.Service.GraphQL.InternalOTDR;
using AFL.OTDR.Service.Utility;
using AutoMapper;

namespace AFL.OTDR.Server
{
	public class AutoMapperUtility
    {

        public static MapperConfiguration CreateMapperConfig()
        {

            return new MapperConfiguration(cfg =>
            {
                
            });
        }
    }
}