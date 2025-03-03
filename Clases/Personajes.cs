using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class PersonajeBase : IDisposable
    {
        #region Propiedades Básicas
        private string _nombre;
        private int _nivel;

        public string IdPersonaje { get; protected set; }
        public int Nivel
        {
            get => _nivel;
            protected set => _nivel = value>0 ? value : 1;
        }
        public string Nombre
        {
            get => _nombre;
            protected set => _nombre = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("El nombre no puede estar vacío");
        }
        public string Titulo { get; protected set; }
        public string Especializacion { get; protected set; }
        #endregion

        #region Stats y Estado
        private int _saludActual;
        public int SaludActual
        {
            get => _saludActual;
            set
            {
                _saludActual = Math.Max(0, Math.Min(value, StatsPersonaje?.Vitalidad ?? 0));
                if (_saludActual <= 0)
                {
                    Morir();
                }
            }
        }
        public Stats StatsPersonaje { get; private set; }
        public bool Vivo { get; private set; }
        #endregion

        #region Colecciones
        public IReadOnlyList<Pasiva> Pasivas => _pasivas?.AsReadOnly();
        public IReadOnlyList<Habilidad> Habilidades => _habilidades?.AsReadOnly();
        private List<Pasiva> _pasivas;
        private List<Habilidad> _habilidades;
        public Habilidad AtaqueBasico { get; protected set; }
        #endregion

        #region Equipamiento
        private readonly Dictionary<string, object> _equipamiento;

        public Arma Mano1
        {
            get => _equipamiento["mano1"] as Arma;
            set { _equipamiento["mano1"] = value; RecalcularStats(); }
        }

        public Arma Mano2
        {
            get => _equipamiento["mano2"] as Arma;
            set { _equipamiento["mano2"] = value; RecalcularStats(); }
        }

        public Equipo Cabeza
        {
            get => _equipamiento["cabeza"] as Equipo;
            set
            {
                if (ValidarEquipo(value, "cabeza"))
                {
                    _equipamiento["cabeza"] = value;
                    RecalcularStats();
                }
            }
        }

        // ... Similar para Pecho, Piernas, Brazos, Amuleto, Anillo
        #endregion

        #region Constructores
        protected PersonajeBase(string idPersonaje, int nivel, string nombre,
            string titulo, string especializacion)
        {
            IdPersonaje = idPersonaje ?? throw new ArgumentNullException(nameof(idPersonaje));
            Nivel = nivel > 0 ? nivel : throw new ArgumentException("Nivel debe ser mayor que 0");
            Nombre = nombre;
            Titulo = titulo;
            Especializacion = especializacion ??
                throw new ArgumentNullException(nameof(especializacion));

            _pasivas = new List<Pasiva>();
            _habilidades = new List<Habilidad>();
            _equipamiento = new Dictionary<string, object>();
            Vivo = true;

            InicializarEquipamiento();
        }

        protected PersonajeBase() : this(Guid.NewGuid().ToString(), 1, "Nuevo", "", "")
        {
        }
        #endregion

        #region Métodos Públicos
        public virtual void RecalcularStats()
        {
            var statsBase = new StatsBasePersonaje(Especializacion);
            var modifsBase = new ModificadoresStatsPersonaje(Especializacion);

            StatsPersonaje = CalcularStatsBase(statsBase, modifsBase);
            AplicarBonusEquipamiento();
        }

        //public virtual void TopearHP() => SaludActual = StatsPersonaje.Vitalidad;

        public virtual void Morir()
        {
            Vivo = false;
            Nombre = $"Cadáver de {Nombre}";
        }
        #endregion

        #region Métodos Privados
        private void InicializarEquipamiento()
        {
            var slots = new[] { "mano1", "mano2", "cabeza", "pecho", "piernas",
            "brazos", "amuleto", "anillo" };
            foreach (var slot in slots)
            {
                _equipamiento[slot] = null;
            }
        }

        private Stats CalcularStatsBase(StatsBasePersonaje statsBase,
            ModificadoresStatsPersonaje modifsBase)
        {
            return new Stats(
                statsBase.statsBase.Fuerza + modifsBase.modifsBase.Fuerza * Nivel,
                statsBase.statsBase.Magia + modifsBase.modifsBase.Magia * Nivel,
                statsBase.statsBase.Resistencia + modifsBase.modifsBase.Resistencia * Nivel,
                statsBase.statsBase.Vitalidad + modifsBase.modifsBase.Vitalidad * Nivel,
                statsBase.statsBase.Agilidad + modifsBase.modifsBase.Agilidad * Nivel,
                statsBase.statsBase.Suerte + modifsBase.modifsBase.Suerte * Nivel
            );
        }

        private void AplicarBonusEquipamiento()
        {
            foreach (var equipo in _equipamiento.Values.Where(e => e != null))
            {
                switch (equipo)
                {
                    case Arma arma:
                        StatsPersonaje.SumarStats(arma.StatsArma);
                        break;
                    case Equipo eq:
                        StatsPersonaje.SumarStats(eq.StatsEquipo);
                        break;
                    case Accesorio acc:
                        StatsPersonaje.SumarStats(acc.StatsAccesorio);
                        break;
                }
            }
        }

        private bool ValidarEquipo(Equipo equipo, string zonaRequerida)
        {
            return equipo == null || equipo.ZonaEquipable == zonaRequerida;
        }
        #endregion

        #region IDisposable
        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _pasivas?.Clear();
                    _habilidades?.Clear();
                    _equipamiento?.Clear();
                }
                _disposed = true;
            }
        }
        #endregion
    }

    public sealed class PersonajeJugador : PersonajeBase
    {
        private double _experiencia;
        public double ExperienciaSiguienteNivel { get; private set; }
        public double Experiencia
        {
            get => _experiencia;
            set
            {
                _experiencia = value;
                if (_experiencia >= ExperienciaSiguienteNivel)
                {
                    SubirNivel();
                }
            }
        }
        public IList<Objeto> BotinObtenido { get; }

        public PersonajeJugador(string idPersonaje, int nivel, string nombre,
            string titulo, string especializacion)
            : base(idPersonaje, nivel, nombre, titulo, especializacion)
        {
            BotinObtenido = new List<Objeto>();
            ExperienciaSiguienteNivel = CalcularExperienciaNivel(nivel);
            //TopearHP();
        }

        private void SubirNivel()
        {
            Nivel++;
            RecalcularStats();
            var experienciaSobrante = _experiencia - ExperienciaSiguienteNivel;
            ExperienciaSiguienteNivel = CalcularExperienciaNivel(Nivel);
            _experiencia = experienciaSobrante;
        }

        private static double CalcularExperienciaNivel(int nivel) => Math.Pow(2, nivel) * 1000;
    }

    public sealed class PersonajeEnemigo : PersonajeBase
    {
        public double ExperienciaDropeable { get; private set; }
        public IReadOnlyList<Objeto> BotinDropeable { get; private set; }
        public int NivelDificultad { get; private set; }

        public PersonajeEnemigo(string idPersonaje, int nivel, string nombre,
            string titulo, string especializacion)
            : base(idPersonaje, nivel, nombre, titulo, especializacion)
        {
            //TopearHP();
            // Aquí irían las llamadas al servidor
        }
    }
    

}
