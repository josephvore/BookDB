﻿using System;
using System.Collections.Generic;
namespace assignment_5.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
