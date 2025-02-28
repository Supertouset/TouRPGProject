using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject.Clases
{
    public class Habilidad
    {
        public string idHabilidad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Objetivo { get; set; }
        public int CantidadDamage { get; set; }
        public string TipoDamage { get; set; }

        public Habilidad(string id, string nombre,string descripcion, string objetivo, int dmg, string tipodmg)
        {
            idHabilidad = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Objetivo = objetivo;
            CantidadDamage = dmg;
            TipoDamage = tipodmg;
        }
    }    
}
