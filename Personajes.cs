using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject
{    
    public class PersonajeBase
    {
        public string IdPersonaje { get; set; }
        public int Nivel { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Especializacion { get; set; }
        private int _saludActual = 0;
        public int SaludActual { 
            get { return _saludActual; } 
            set {
                _saludActual = value;
                if (_saludActual <= 0) 
                {
                    Vivo = false; 
                }
            }
        }
        public Stats StatsPersonaje { get; set; }
        public bool Vivo { get; set; }
        public List<Pasiva> Pasivas { get; set; }
        public List<Habilidad> Habilidades { get; set; }
        public Habilidad AtaqueBasico { get; set; }
        private Arma _mano1;
        private Arma _mano2;
        private Equipo _cabeza;
        private Equipo _pecho;
        private Equipo _piernas;
        private Equipo _brazos;
        private Accesorio _amuleto;
        private Accesorio _anillo;
        public Arma Mano1 { get { return _mano1; } set { _mano1 = value; RecalcularStats(); } }
        public Arma Mano2 { get { return _mano2; } set { _mano2 = value; RecalcularStats(); } }
        public Equipo Cabeza { 
            get { return _cabeza; }
            set { if (value != null && value.ZonaEquipable == "cabeza") { _cabeza = value; RecalcularStats(); } else { Cabeza = null; } }
        }
        public Equipo Pecho {
            get { return _pecho; }
            set { if (value != null && value.Tipo == "pecho") { _pecho = value; RecalcularStats(); } else { Pecho = null; } } 
        }
        public Equipo Piernas {
            get { return _piernas; }
            set { if (value != null && value.Tipo == "piernas") { _piernas = value; RecalcularStats(); } else { Piernas = null; } } 
        }
        public Equipo Brazos {
            get { return _brazos; }
            set { if (value != null && value.Tipo == "brazos") { _brazos = value; RecalcularStats(); } else { Brazos = null; } } 
        }
        public Accesorio Amuleto {
            get { return _amuleto; } 
            set { if (value != null && value.Tipo == "amuleto") { _amuleto = value; RecalcularStats(); } else { Amuleto = null; } } 
        }
        public Accesorio Anillo { 
            get { return _anillo; }
            set { if (value != null && value.Tipo == "anillo") { _anillo = value; RecalcularStats(); } else { Anillo = null; } } 
        }

        public PersonajeBase(){}

        public void RecalcularStats()
        {
            StatsBasePersonaje statsBase = new StatsBasePersonaje(Especializacion);
            ModificadoresStatsPersonaje modifsbase = new ModificadoresStatsPersonaje(Especializacion);
            Stats nuevosStats = new Stats(
                    statsBase.statsBase.Fuerza + modifsbase.modifsBase.Fuerza * Nivel,
                    statsBase.statsBase.Magia + modifsbase.modifsBase.Magia * Nivel,
                    statsBase.statsBase.Resistencia + modifsbase.modifsBase.Resistencia * Nivel,
                    statsBase.statsBase.Vitalidad + modifsbase.modifsBase.Vitalidad * Nivel,
                    statsBase.statsBase.Agilidad + modifsbase.modifsBase.Agilidad * Nivel,
                    statsBase.statsBase.Suerte + modifsbase.modifsBase.Suerte * Nivel
                );
            
            if (_mano1 != null)
            {
                nuevosStats.SumarStats(_mano1.StatsArma);
            }
            if (_mano2 != null)
            {
                nuevosStats.SumarStats(_mano2.StatsArma);
            }
            if (_cabeza != null)
            {
                nuevosStats.SumarStats(_cabeza.StatsEquipo);
            }
            if (_brazos != null)
            {
                nuevosStats.SumarStats(_brazos.StatsEquipo);
            }
            if (_pecho != null)
            {
                nuevosStats.SumarStats(_pecho.StatsEquipo);
            }
            if (_piernas != null)
            {
                nuevosStats.SumarStats(_piernas.StatsEquipo);
            }
            if (_amuleto != null)
            {
                nuevosStats.SumarStats(_amuleto.StatsAccesorio);
            }
            if (_anillo != null)
            {
                nuevosStats.SumarStats(_anillo.StatsAccesorio);
            }
            
            StatsPersonaje = nuevosStats;
        }

        public void TopearHP()
        {
            this.SaludActual = this.StatsPersonaje.Vitalidad;
        }


        public void Morir()
        {

            this.Nombre = "Cadáver";
        }
    }

    public class PersonajeJugador : PersonajeBase
    {
        public double ExperienciaSiguienteNivel { get; set; }
        public double Experiencia {
            get { return Experiencia; }
            set { if (value >= ExperienciaSiguienteNivel) { SubirNivel(); } }
        }
        public List<Objeto> BotinObtenido;

        public PersonajeJugador(string idPersonaje, int nivel, string nombre, string titulo, string especializacion)
        {
            this.IdPersonaje = idPersonaje;
            this.Nivel = nivel;
            this.Nombre = nombre;
            this.Titulo = titulo;
            this.Especializacion = especializacion;
            this.StatsPersonaje = new StatsBasePersonaje(especializacion).statsBase;
            RecalcularStats();

            this.SaludActual = this.StatsPersonaje.Vitalidad;
            BotinObtenido = new List<Objeto>(10);
            //Llamada a server



        }

        private void SubirNivel()
        {
            Nivel += 1;
            RecalcularStats();
            double experienciaSobrante = ExperienciaSiguienteNivel - Experiencia;
            ExperienciaSiguienteNivel *= 2;
            Experiencia = experienciaSobrante;
        }
    }

    public class PersonajeEnemigo : PersonajeBase
    {
        public double ExperienciaDropeable { get; set; }
        public List<Objeto> BotinDropeable { get; set; }
        public int NivelDificultad { get; set; }

        public PersonajeEnemigo(string idPersonaje, int nivel, string nombre, string titulo, string especializacion)
        {
            this.IdPersonaje = idPersonaje;
            this.Nivel = nivel;
            this.Nombre = nombre;
            this.Titulo = titulo;
            this.Especializacion = especializacion;
            this.StatsPersonaje = new StatsBasePersonaje(especializacion).statsBase;
            RecalcularStats();
            this.SaludActual = this.StatsPersonaje.Vitalidad;
            //Llamadas a server:

            //Botindropeable: Cada personaje tendrá una lista de lo que puedan dropear y un porcentaje de probabilidad, 
            //la API realizará una lista seleccionando algunos de esos posibles drops y la traerá con el constructor
            //NivelDificultad
            //Experiencia: Cada criatura dará una cantidad base, a la que se le sumará un extra por nivel
            
        }        
    }

    public class PersonajeNeutral : PersonajeBase
    {
        public double ExperienciaDropeable { get; set; }
        public List<Objeto> BotinDropeable { get; set; }
        public int NivelDificultad { get; set; }

        public PersonajeNeutral(string idPersonaje, int nivel, string nombre, string titulo, string especializacion)
        {
            this.IdPersonaje = idPersonaje;
            this.Nivel = nivel;
            this.Nombre = nombre;
            this.Titulo = titulo;
            this.Especializacion = especializacion;
            this.StatsPersonaje = new StatsBasePersonaje(especializacion).statsBase;
            RecalcularStats();
            this.SaludActual = this.StatsPersonaje.Vitalidad;
            //Llamadas a server:

            //Botindropeable: Cada personaje tendrá una lista de lo que puedan dropear y un porcentaje de probabilidad, 
            //la API realizará una lista seleccionando algunos de esos posibles drops y la traerá con el constructor
            //NivelDificultad
            //Experiencia: Cada criatura dará una cantidad base, a la que se le sumará un extra por nivel

        }

        public void Morir()
        {

        }
    }
}
