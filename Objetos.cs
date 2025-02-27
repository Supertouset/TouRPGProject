using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject
{
    public class Objeto
    {
        public string Tipo { get; set; }

        public Objeto() { }
    }

    public class Arma : Objeto
    {
        public Stats StatsArma { get; set; }
        public Pasiva PasivaArma { get; set; }

        public Arma(string tipoArma, Pasiva pasivaArma = null)
        {
            Tipo = tipoArma;
            if (pasivaArma != null)
            {
                PasivaArma = pasivaArma;
            }
        }
    }

    public class Equipo : Objeto
    {
        public Stats StatsEquipo { get; set; }
        public string ZonaEquipable { get; set; }

        public Equipo(string zonaEquipable, string tipoEquipo)
        {
            ZonaEquipable = zonaEquipable;
            Tipo = tipoEquipo;
        }
    }

    public class Accesorio : Objeto
    {
        public Stats StatsAccesorio { get; set; }
        public Pasiva PasivaObjeto { get; set; }
        public string ZonaEquipable { get; set; }

        public Accesorio (string zonaEquipable, string tipoEquipo, Pasiva pasivaAccesorio)
        {
            ZonaEquipable = zonaEquipable;
            Tipo = tipoEquipo;
            PasivaObjeto = pasivaAccesorio;
        }
    }

    public class Consumible : Objeto
    {
        public bool Gastado { get; set; } = false;

        public Consumible(string tipoObjeto)
        {
            Tipo = tipoObjeto;
        }

        public void Usar()
        {
            Gastado = true;
        }
    }
}
