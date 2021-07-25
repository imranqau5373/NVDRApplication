using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class NvdrRecordRepository : RepositoryBase<NvdrRecord>, INvdrRecordRepository
    {
        public NvdrRecordRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public IEnumerable<NvdrRecord> GetAllNvdrRecord(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Id)
            .ToList();

        public void AddNvdrRecord(NvdrRecord nvdrRecords) => Create(nvdrRecords);
        public void UpdateNvdrRecord(NvdrRecord nvdrRecords) => Update(nvdrRecords);

        public void DeleteNvdrRecord(NvdrRecord nvdrRecords) => Delete(nvdrRecords);

        public NvdrRecord GetNvdrRecord(long id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(id), trackChanges)
            .SingleOrDefault();


    }

}
