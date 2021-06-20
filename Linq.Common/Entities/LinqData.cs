
using System;

namespace Linq.Common.Entities
{
    public class LinqData
    {
        public int lqID { get; set; }
        public string lq_data { get; set; }
        public FullInput lq_fullInput { get; set; }
        public string lq_response { get; set; }
        public DateTime lq_creaDate { get; set; }
        public bool lq_status { get; set; }
        public string status { get; set; }
    }
}
