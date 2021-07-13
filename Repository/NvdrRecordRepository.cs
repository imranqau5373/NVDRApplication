﻿using Contracts;
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
            .OrderBy(c => c.NvdrName)
            .ToList();
    }

}