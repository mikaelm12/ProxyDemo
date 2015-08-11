using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataProxy.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        public string MethodType { get; set; }
        public string Url { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
