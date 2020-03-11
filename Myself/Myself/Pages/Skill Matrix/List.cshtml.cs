using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Myself.Data;

namespace Myself.Pages.SkillMatrix
{
    public class ListModel : PageModel
    {

        private readonly ISkillMatrixData skillMatrixData;

        public IEnumerable<SkillMatrix> SkillMatrix { get; set; }

        public string SearchTerm { get; set; }



        public ListModel(ISkillMatrixData skillMatrixData)
        {
        }

        public void OnGet()
        {
            
        }
    }
}
