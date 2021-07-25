using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface INvdrRecordRepository
    {

        IEnumerable<NvdrRecord> GetAllNvdrRecord(bool trackChanges);
        NvdrRecord GetNvdrRecord(long id,bool trackChanges);
        void AddNvdrRecord(NvdrRecord nvdrRecords);
        void UpdateNvdrRecord(NvdrRecord nvdrRecords);
        
        void DeleteNvdrRecord(NvdrRecord nvdrRecords);

    }
}
