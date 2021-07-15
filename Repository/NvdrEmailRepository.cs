using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class NvdrEmailRepository : RepositoryBase<NvdrEmail>, INvdrEmailRepository
    {
        public NvdrEmailRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public IEnumerable<NvdrEmail> GetAllNvdrEmail(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.EmailTo)
            .ToList();

        public void AddNvdrEmail(NvdrEmail nvdrEmails) => Create(nvdrEmails);
        public void UpdateNvdrEmail(NvdrEmail nvdrEmails) => Update(nvdrEmails);

        public void DeleteNvdrEmail(NvdrEmail nvdrEmails) => Delete(nvdrEmails);

    }

}
