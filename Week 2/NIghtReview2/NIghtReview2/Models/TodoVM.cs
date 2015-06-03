using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NIghtReview2.Models
{
    public class TodoVM
    {
        public Todo Todo { get; set; }

        public TodoVM()
        {
            this.Todo = new Todo();
        }
    }
}