﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{   [Table("Security_Logins_Log")]
    class SecurityLoginsLogPoco:IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Login { get; set; }

        [Column("Source_IP")]
        public string SourceIP { get; set; }

        [Column("Logon_Date")]
        public DateTime LogonDate { get; set; }

        [Column("Is_Succesful")]
        public Boolean IsSuccesful { get; set; }
    }
}
