using Linq.Common.Entities;
using System.ComponentModel.DataAnnotations;

namespace Linq.Common.MethodParameters
{
    public class UpdateDataIn
    {
        [Required]
        public int lqID { get; set; }
        [Required]
        public string lq_data { get; set; }
    }
}
