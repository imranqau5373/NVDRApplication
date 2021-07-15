using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryManager
    {
        INvdrRecordRepository NvdrRecordRepository { get; }
        INvdrEmailRepository NvdrEmailRepository { get; }
        void Save();

    }
}
