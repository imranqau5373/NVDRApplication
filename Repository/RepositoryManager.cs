using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private INvdrRecordRepository _nvdrRecordRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public INvdrRecordRepository NvdrRecordRepository
        {
            get
            {
                if (_nvdrRecordRepository == null)
                    _nvdrRecordRepository = new NvdrRecordRepository(_repositoryContext);
                return _nvdrRecordRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
