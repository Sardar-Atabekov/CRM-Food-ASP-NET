using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class DateTimePaginationModel
    {
        const int MaxPageSize = 100;

        public int PageNumber { get; set; } = 1;

        private int pageSize { get; set; } = 10;

        public int PageSize
        {

            get { return pageSize; }
            set
            {
                pageSize = (value > MaxPageSize) ? MaxPageSize : value;
            }
        }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
