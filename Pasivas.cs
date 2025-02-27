using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject
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
            this.idPasiva = id;


        }

        //constructor manual
        public Pasiva(string id, string nombre, string desc, int nivel)
        {
            this.idPasiva = id;
            this.nombrePasiva = nombre;
            this.descPasiva = desc;
            this.nivelPasiva = nivel;
        }
    }
}
