using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject
{
    public class Habilidad
    {
        public string idHabilidad { get; set; }
        public string Nombre { get; set; }
        public string Objetivo { get; set; }
        public int CantidadDamage { get; set; }
        public string TipoDamage { get; set; }

        public Habilidad(string id, string nombre, string objetivo, int dmg, string tipodmg)
        {
            this.idHabilidad = id;
            this.Nombre = nombre;
            this.Objetivo = objetivo;
            this.CantidadDamage = dmg;
            this.TipoDamage = tipodmg;
        }
    }    
}
