using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class NvdrRecord
    {
        public long Id { get; set; }

        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string NvdrName { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum length for the NvdrSerialNumber is 100 characters.")]
        public string NvdrSerialNumber { get; set; }

        [MaxLength(500, ErrorMessage = "Maximum length for the NvdrDescription is 500 characters.")]
        public string NvdrDescription { get; set; }

        [MaxLength(60, ErrorMessage = "Maximum length for the ClientName is 60 characters.")]
        public string ClientName { get; set; }
    }
}
