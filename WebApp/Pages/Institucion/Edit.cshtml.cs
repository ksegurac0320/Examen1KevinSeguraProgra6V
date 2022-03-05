using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Institucion
{
    public class EditModel : PageModel
    {
        private readonly IInstitucionService institucion;

        public EditModel(IInstitucionService institucion)
        {
            this.institucion = institucion;
        }

        public void OnGet()
        {
        }
    }
}
