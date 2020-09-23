﻿using System;

namespace OutbackProducts.Models.ViewModels
{
    public class PagingInfo
    {
        // Purpose of this class is to pass info to the view about the number of 
        // pages available, the current page, and the total numbber of products 
        // in the repository.
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}