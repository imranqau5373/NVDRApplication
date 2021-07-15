using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class NvdrFaultEmailRepository : RepositoryBase<NvdrFaultEmail>, INvdrFaultEmailRepository
    {
        public NvdrFaultEmailRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public IEnumerable<NvdrFaultEmail> GetAllNvdrFaultEmail(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.EmailTo)
            .ToList();

        public void AddNvdrFaultEmail(NvdrFaultEmail nvdrFaultEmail) => Create(nvdrFaultEmail);
        public void UpdateNvdrFaultEmail(NvdrFaultEmail nvdrFaultEmail) => Update(nvdrFaultEmail);

        public void DeleteNvdrFaultEmail(NvdrFaultEmail nvdrFaultEmail) => Delete(nvdrFaultEmail);

    }

}
