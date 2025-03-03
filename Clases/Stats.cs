using System;

namespace TouRPGProject.Clases
{
    public class Stats
    {
        #region Propiedades
        public int Fuerza { get; private set; }
        public int Magia { get; private set; }
        public int Resistencia { get; private set; }
        public int Vitalidad { get; private set; }
        public int Agilidad { get; private set; }
        public int Suerte { get; private set; }
        #endregion

        #region Constructores
        public Stats() : this(0, 0, 0, 0, 0, 0) { }

        public Stats(int fuerza, int magia, int resistencia, int vitalidad, int agilidad, int suerte)
        {
            Fuerza = fuerza;
            Magia = magia;
            Resistencia = resistencia;
            Vitalidad = vitalidad;
            Agilidad = agilidad;
            Suerte = suerte;
        }
        #endregion

        #region Métodos Públicos

        public override string ToString() => $"FUE:{Fuerza}/MAG:{Magia}/RES:{Resistencia}/VIT:{Vitalidad}/AGI:{Agilidad}/SUE:{Suerte}";

        public int SumatorioStats()
        {
            return Fuerza + Magia + Resistencia + Vitalidad + Agilidad + Suerte;
        }

        public void SumarStats(Stats statsASumar)
        {
            if (statsASumar == null) throw new ArgumentNullException(nameof(statsASumar));

            Fuerza += statsASumar.Fuerza;
            Magia += statsASumar.Magia;
            Resistencia += statsASumar.Resistencia;
            Vitalidad += statsASumar.Vitalidad;
            Agilidad += statsASumar.Agilidad;
            Suerte += statsASumar.Suerte;
        }

        public void RestarStats(Stats statsARestar)
        {
            if (statsARestar == null) throw new ArgumentNullException(nameof(statsARestar));

            Fuerza = Math.Max(0, Fuerza - statsARestar.Fuerza);
            Magia = Math.Max(0, Magia - statsARestar.Magia);
            Resistencia = Math.Max(0, Resistencia - statsARestar.Resistencia);
            Vitalidad = Math.Max(0, Vitalidad - statsARestar.Vitalidad);
            Agilidad = Math.Max(0, Agilidad - statsARestar.Agilidad);
            Suerte = Math.Max(0, Suerte - statsARestar.Suerte);
        }
        #endregion
    }

    public class StatsBasePersonaje
    {
        public Stats statsBase { get; private set; }

        public StatsBasePersonaje(string idPersonaje)
        {
            statsBase = idPersonaje switch
            {
                "barbaro" => new Stats(4, 3, 5, 3, 0, 1),
                "guardian" => new Stats(3, 5, 8, 2, 3, 1),
                "guerrero" => new Stats(3, 3, 5, 2, 1, 1),
                "monje" => new Stats(4, 3, 3, 4, 2, 1),
                "paladin" => new Stats(2, 5, 8, 2, 4, 1),
                "cabnegro" => new Stats(3, 4, 6, 1, 3, 1),
                "piromante" => new Stats(3, 2, 3, 1, 6, 1),
                "chaman" => new Stats(2, 3, 4, 1, 5, 1),
                "druida" => new Stats(3, 3, 4, 3, 4, 1),
                "vidente" => new Stats(1, 2, 3, 1, 5, 3),
                "clerigo" => new Stats(4, 3, 5, 3, 0, 1),
                "brujo" => new Stats(4, 3, 5, 3, 0, 1),
                "artificiero" => new Stats(4, 3, 5, 3, 0, 1),
                "pirata" => new Stats(4, 3, 5, 3, 0, 1),
                "forajido" => new Stats(4, 3, 5, 3, 0, 1),
                "ninja" => new Stats(4, 3, 5, 3, 0, 1),
                "asesino" => new Stats(5, 2, 3, 5, 2, 1),
                "tirador" => new Stats(5, 2, 3, 5, 2, 1),
                _ => new Stats(3, 3, 3, 3, 3, 1),
            };
        }
    }

    public class ModificadoresStatsPersonaje
    {
        public Stats modifsBase { get; private set; }

        public ModificadoresStatsPersonaje(string idPersonaje)
        {
            modifsBase = idPersonaje switch
            {
                "barbaro" => new Stats(2, 0, 3, 1, 0, 0),
                "guardian" => new Stats(3, 5, 8, 2, 3, 0),
                "guerrero" => new Stats(3, 3, 5, 2, 1, 0),
                "monje" => new Stats(4, 3, 3, 4, 2, 0),
                "paladin" => new Stats(2, 5, 8, 2, 4, 0),
                "cabnegro" => new Stats(3, 4, 6, 1, 3, 0),
                "piromante" => new Stats(3, 2, 3, 1, 6, 0),
                "chaman" => new Stats(2, 3, 4, 1, 5, 0),
                "druida" => new Stats(3, 3, 4, 3, 4, 0),
                "vidente" => new Stats(1, 2, 3, 1, 5, 1),
                "clerigo" => new Stats(4, 3, 5, 3, 0, 0),
                "brujo" => new Stats(4, 3, 5, 3, 0, 0),
                "artificiero" => new Stats(4, 3, 5, 3, 0, 0),
                "pirata" => new Stats(4, 3, 5, 3, 0, 0),
                "forajido" => new Stats(4, 3, 5, 3, 0, 0),
                "ninja" => new Stats(4, 3, 5, 3, 0, 0),
                "asesino" => new Stats(5, 2, 3, 5, 2, 0),
                "tirador" => new Stats(5, 2, 3, 5, 2, 0),
                _ => new Stats(3, 3, 3, 3, 3, 0),
            };
        }
    }
}
