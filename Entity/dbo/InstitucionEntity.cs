﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InstitucionEntity: DBEntity
    {
        public int? Id_Institucion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }



    }
}
