using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject
{
    public class Stats
    {
        public int Fuerza { get; set; }
        public int Magia { get; set; }
        public int Resistencia { get; set; }
        public int Vitalidad { get; set; }
        public int Agilidad { get; set; }
        public int Suerte { get; set; }

        public Stats() { }

        public Stats(int fue, int mag, int res, int vit, int agi, int sue)
        {
            Fuerza = fue;
            Magia = mag;
            Resistencia = res;
            Vitalidad = vit;
            Agilidad = agi;
            Suerte = sue;
        }

        public int SumatorioStats()
        {
            return Fuerza + Magia + Resistencia + Vitalidad + Agilidad + Suerte;
        }

        public string GetCadenaStats()
        {
            return $"FUE:{Fuerza}/MAG:{Magia}/RES:{Resistencia}/CON:{Vitalidad}/AGI:{Agilidad}/SUE:{Suerte}";
        }

        public void SumarStats(Stats statsASumar)
        {
            Fuerza += statsASumar.Fuerza;
            Magia += statsASumar.Magia;
            Resistencia += statsASumar.Resistencia;
            Vitalidad += statsASumar.Vitalidad;
            Agilidad += statsASumar.Agilidad;
            Suerte += statsASumar.Suerte;
        }

        public void RestarStats(Stats statsARestar)
        {
            Fuerza -= statsARestar.Fuerza;
            if (Fuerza < 0) { Fuerza = 0; }
            Magia -= statsARestar.Magia;
            if (Magia < 0) { Magia = 0; }
            Resistencia -= statsARestar.Resistencia;
            if (Resistencia < 0) { Resistencia = 0; }
            Vitalidad -= statsARestar.Vitalidad;
            if (Vitalidad < 0) { Vitalidad = 0; }
            Agilidad -= statsARestar.Agilidad;
            if (Agilidad < 0) { Agilidad = 0; }
            Suerte -= statsARestar.Suerte;
            if (Suerte < 0) { Suerte = 0; }
        }
    }

    public class StatsBasePersonaje
    {
        public Stats statsBase;

        public StatsBasePersonaje(string idPersonaje)
        {
            switch (idPersonaje)
            {
                case "barbaro":
                    statsBase = new Stats(4, 3, 5, 3, 0, 1);
                    break;
                case "guardian":
                    statsBase = new Stats(3, 5, 8, 2, 3, 1);
                    break;
                case "guerrero":
                    statsBase = new Stats(3, 3, 5, 2, 1, 1);
                    break;
                case "monje":
                    statsBase = new Stats(4, 3, 3, 4, 2, 1);
                    break;
                case "paladin":
                    statsBase = new Stats(2, 5, 8, 2, 4, 1);
                    break;
                case "cabnegro":
                    statsBase = new Stats(3, 4, 6, 1, 3, 1);
                    break;
                case "piromante":
                    statsBase = new Stats(3, 2, 3, 1, 6, 1);
                    break;
                case "chaman":
                    statsBase = new Stats(2, 3, 4, 1, 5, 1);
                    break;
                case "druida":
                    statsBase = new Stats(3, 3, 4, 3, 4, 1);
                    break;
                case "vidente":
                    statsBase = new Stats(1, 2, 3, 1, 5, 3);
                    break;
                case "clerigo":
                    statsBase = new Stats(4, 3, 5, 3, 0, 1);
                    break;
                case "brujo":
                    statsBase = new Stats(4, 3, 5, 3, 0, 1);
                    break;
                case "artificiero":
                    statsBase = new Stats(4, 3, 5, 3, 0, 1);
                    break;
                case "pirata":
                    statsBase = new Stats(4, 3, 5, 3, 0, 1);
                    break;
                case "forajido":
                    statsBase = new Stats(4, 3, 5, 3, 0, 1);
                    break;
                case "ninja":
                    statsBase = new Stats(4, 3, 5, 3, 0, 1);
                    break;
                case "asesino":
                    statsBase = new Stats(5, 2, 3, 5, 2, 1);
                    break;
                case "tirador":
                    statsBase = new Stats(5, 2, 3, 5, 2, 1);
                    break;
                default:
                    statsBase = new Stats(3, 3, 3, 3, 3, 1);
                    break;
            }
        }
    }

    public class ModificadoresStatsPersonaje
    {
        public Stats modifsBase;

        public ModificadoresStatsPersonaje(string idPersonaje)
        {
            switch (idPersonaje)
            {
                case "barbaro":
                    modifsBase = new Stats(2, 0, 3, 1, 0, 0);
                    break;
                case "guardian":
                    modifsBase = new Stats(3, 5, 8, 2, 3, 0);
                    break;
                case "guerrero":
                    modifsBase = new Stats(3, 3, 5, 2, 1, 0);
                    break;
                case "monje":
                    modifsBase = new Stats(4, 3, 3, 4, 2, 0);
                    break;
                case "paladin":
                    modifsBase = new Stats(2, 5, 8, 2, 4, 0);
                    break;
                case "cabnegro":
                    modifsBase = new Stats(3, 4, 6, 1, 3, 0);
                    break;
                case "piromante":
                    modifsBase = new Stats(3, 2, 3, 1, 6, 0);
                    break;
                case "chaman":
                    modifsBase = new Stats(2, 3, 4, 1, 5, 0);
                    break;
                case "druida":
                    modifsBase = new Stats(3, 3, 4, 3, 4, 0);
                    break;
                case "vidente":
                    modifsBase = new Stats(1, 2, 3, 1, 5, 1);
                    break;
                case "clerigo":
                    modifsBase = new Stats(4, 3, 5, 3, 0, 0);
                    break;
                case "brujo":
                    modifsBase = new Stats(4, 3, 5, 3, 0, 0);
                    break;
                case "artificiero":
                    modifsBase = new Stats(4, 3, 5, 3, 0, 0);
                    break;
                case "pirata":
                    modifsBase = new Stats(4, 3, 5, 3, 0, 0);
                    break;
                case "forajido":
                    modifsBase = new Stats(4, 3, 5, 3, 0, 0);
                    break;
                case "ninja":
                    modifsBase = new Stats(4, 3, 5, 3, 0, 0);
                    break;
                case "asesino":
                    modifsBase = new Stats(5, 2, 3, 5, 2, 0);
                    break;
                case "tirador":
                    modifsBase = new Stats(5, 2, 3, 5, 2, 0);
                    break;
                default:
                    modifsBase = new Stats(3, 3, 5, 20, 3, 1);
                    break;
            }
        }
    }
}
