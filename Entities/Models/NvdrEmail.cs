using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class NvdrEmail
    {

        public long Id { get; set; }
        //--------------------------------
        public long NvdrDeviceId { get; set; }
        [ForeignKey("NvdrDeviceId")]
        public NvdrRecord NvdrRecord { get; set; }
        //--------------------------------      

        [MaxLength(250, ErrorMessage = "Maximum length for the Email To is 250 characters.")]
        public string EmailTo { get; set; }

        [MaxLength(250, ErrorMessage = "Maximum length for the Email CC is 250 characters.")]
        public string EmailCC { get; set; }

        [MaxLength(250, ErrorMessage = "Maximum length for the Email BCC is 250 characters.")]
        public string EmailBCC { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum length for the Title is 100 characters.")]
        public string EmailTitle { get; set; }

        [MaxLength(500, ErrorMessage = "Maximum length for the Email Body is 500 characters.")]
        public string EmailBody { get; set; }

        [MaxLength(60, ErrorMessage = "Maximum length for the Client Name is 60 characters.")]
        public string ClientName { get; set; }

        // [MaxLength(60, ErrorMessage = "Maximum length for the EmailTime is 60 characters.")]
        public DateTime EmailTime { get; set; }

         [MaxLength(60, ErrorMessage = "Maximum length for the Sender IP is 60 characters.")]
        public string SenderIP { get; set; }

    }
}
