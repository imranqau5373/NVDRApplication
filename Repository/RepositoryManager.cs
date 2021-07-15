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

        private INvdrEmailRepository _nvdrEmailRepository;

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

        public INvdrEmailRepository NvdrEmailRepository
        {
            get
            {
                if (_nvdrEmailRepository == null)
                    _nvdrEmailRepository = new NvdrEmailRepository(_repositoryContext);
                return _nvdrEmailRepository;
            }
        }
        public void Save() => _repositoryContext.SaveChanges();
    }
}
