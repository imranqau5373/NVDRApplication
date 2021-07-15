using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface INvdrFaultEmailRepository
    {

        IEnumerable<NvdrFaultEmail> GetAllNvdrFaultEmail(bool trackChanges);

        void AddNvdrFaultEmail(NvdrFaultEmail nvdrFaultEmail);
        void UpdateNvdrFaultEmail(NvdrFaultEmail nvdrFaultEmail);

        void DeleteNvdrFaultEmail(NvdrFaultEmail nvdrFaultEmail);

    }
}
