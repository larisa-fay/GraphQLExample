using System;
using System.IO;
using AFL.OTDR.Server.Models;
using AFL.OTDR.Server.Services;
using AutoMapper;
using HotChocolate;

namespace AFL.OTDR.Service.GraphQL.InternalOTDR
{
	public class OTDRSorEntryResolver
    {
        public string GetId(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.SorUUID.ToString();
        }
        public string GetFilePath(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.FilePath;
        }
        public string GetFileName(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.FileName;
        }
        public string GetFolderPath(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.FolderPath;
        }

        public string GetSorFile(
            [Parent] SorEntryType sorEntry,
            [Service] SorEntryService fileService,
            [Service] IMapper mapper)
        {
            string sorFileJson;

            using (MemoryStream mem = new MemoryStream()) {
                SorEntry sEntry = mapper.Map<SorEntryType, SorEntry>(sorEntry);
                fileService.WriteSorFileAsJsonToStream(sEntry, mem);
                sorFileJson = System.Text.Encoding.UTF8.GetString(mem.ToArray());
                mem.Close();
            }
            
			return sorFileJson;
		}

        public DateTime GetLastUpdated(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.LastUpdated;
        }

        public string GetContainerUUID(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.ContainerUUID;
        }

        public string GetProjectUUID(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.ProjectUUID;
        }

        public string GetWarnings(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.Warnings;
        }

        public int GetWavelength(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.Wavelength;
        }

        public TraceTypeDirection GetDirections(
            [Parent] SorEntryType sorEntry)
        {
            // TODO cleanup here - ticket ARSLNK-392
            return TraceTypeDirection.STANDARD_TRACE;
        }
        public string GetErrorMessage(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.ErrorMessage;
        }
        public int GetErrorCode(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.ErrorCode;
        }

        public string GetCreatedBy(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.CreatedBy;
        }

        public DateTime GetCreatedOn(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.CreatedOn;
        }

        public PassFailStatus GetPassFailStatus(
            [Parent] SorEntryType sorEntry)
        {

            return sorEntry.PassFailStatus;
        }

        public int GetFiberNumber(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.FiberNumber;
        }

        public string GetCable(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.Cable;
        }

        public string GetEnd1(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.End1;
        }

        public string GetEnd2(
            [Parent] SorEntryType sorEntry)
        {
            return sorEntry.End2;
        }
    }
}
