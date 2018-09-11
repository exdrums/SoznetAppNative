using System;
using System.Collections.Generic;
using System.Text;

namespace NetMobile.Models
{
    public class Pagination
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
    }

    public class PaginatedResult<T>
    {
        public T Result { get; set; }
        public Pagination Pagination { get; set; }
    }
}
