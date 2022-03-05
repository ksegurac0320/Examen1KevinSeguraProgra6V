//KEVIN SEGURA CALVO EXAMEN 1 UTC PROGRA 6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApp.Pages.Institucion
{
    public class GridModel : PageModel
    {
        private readonly IInstitucionService institucion;

        public GridModel(IInstitucionService institucion)
        {
            this.institucion = institucion;
        }

        public IEnumerable<InstitucionEntity> GridLista { get; set; } = new List<InstitucionEntity>();

        public string Mensaje { get; set; } = "";

        #region METODOS
        //Metodo OBTENER LISTA
        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridLista = await institucion.GET();
                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }
                TempData.Clear();

                return Page();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }

        //Metodo ELIMINAR
        public async Task<IActionResult> OnGetEliminar(int id)
        {
            try
            {
                var result = await institucion.DELETE(new() { Id_Institucion = id });

                if (result.CodError != 0)
                {
                    throw new Exception(result.MsgError);
                }
                TempData["Msg"] = "La institucion se elimino correctamente";

                return Redirect("Grid");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        #endregion


    }
}
