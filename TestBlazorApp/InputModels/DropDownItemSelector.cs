using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazorApp.InputModels
{
    public class DropDownItemSelector
    {
        [Required]  
        public string RowsPerPage { get; set; } = "5"; //initialize to first value acceptable in this instance

        public string CurrentPage { get; set; } = "1"; //initialize to page 1

        public int CurrentIndex { get; set; } = 1; //initialize to first ID of DB
    }
}
