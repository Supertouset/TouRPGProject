using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject.Clases
{
    public class Pasiva
    {
        string idPasiva;
        string nombrePasiva;
        string descPasiva;
        int nivelPasiva;

        //constructor de llamada a server
        public Pasiva(string id)
        {            
            //buscar los datos por id, traer el resto de valores
            idPasiva = id;
        }

        //constructor manual
        public Pasiva(string id, string nombre, string desc, int nivel)
        {
            idPasiva = id;
            nombrePasiva = nombre;
            descPasiva = desc;
            nivelPasiva = nivel;
        }
    }
}
