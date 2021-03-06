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
        public string ID { get; set; } = "1";

        public int MaxValue { get; set; } = 20;
    }
}
