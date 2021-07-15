using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface INvdrEmailRepository
    {

        IEnumerable<NvdrEmail> GetAllNvdrEmail(bool trackChanges);

        void AddNvdrEmail(NvdrEmail nvdrEmails);
        void UpdateNvdrEmail(NvdrEmail nvdrEmails);
        
        void DeleteNvdrEmail(NvdrEmail nvdrEmails);

    }
}
