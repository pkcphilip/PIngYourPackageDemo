﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PingYourPackageDemo.Domain.Entities.Core
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int TotalCount { get; set; }

        public int TotalPageCount { get; set; }

        public PaginatedList(int pageIndex, int pageSize, int totalCount, IQueryable<T> source)
        {
            AddRange(source);
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPageCount = (int) Math.Ceiling(totalCount / (double)pageSize);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex > TotalPageCount);
            }
        }
    }
}