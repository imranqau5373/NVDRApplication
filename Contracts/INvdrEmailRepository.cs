using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface INvdrEmailRepository
    {

        IEnumerable<NvdrEmail> GetAllNvdrEmail(bool trackChanges);

        void AddNvdrEmail(NvdrEmail nvdrEmail);
        void UpdateNvdrEmail(NvdrEmail nvdrEmail);
        
        void DeleteNvdrEmail(NvdrEmail nvdrEmail);

    }
}
