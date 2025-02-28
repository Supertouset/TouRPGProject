using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouRPGProject.Clases
{
    public enum TipoArma
    {
        espada,
        escudo,
        lanza,
        hacha,
        varita,
        baston,
        arco,
        focoarcano
    }

    public enum HabilidadesObjeto
    {
        Gelido,
        Igneo,
        Corrupto,
        Divino,
        Suertudo,
        Contundente
    }

    public class Objeto
    {
        public string Tipo { get; set; }
        public string nombre { get; set; }

        public Objeto() { }
    }

    public class Arma : Objeto
    {
        public Stats StatsArma { get; set; }
        public Pasiva PasivaArma { get; set; }

        public TipoArma tipoArma1 { get; set; }
        public int nivel { get; set; }

        public Arma(string tipoArma, int nivelArma, Pasiva pasivaArma = null)
        {
            Tipo = tipoArma;

            if (pasivaArma != null)
            {
                PasivaArma = pasivaArma;
            }

            nivel = nivelArma;
        }

        public int SumatorioStats()
        {
            return this.StatsArma.SumatorioStats();
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

    public static class CalculosRPGObjetos
    {
        public static int GenerarStatAleatoria(TipoArma tipo, string stat, int nivel)
        {
            Random rnd = new Random();
            int valor = 0;
            switch (tipo.ToString())
            {
                case "espada":
                    switch (stat)
                    {
                        case "fue":
                            //if (generarNumeroSuperRandom(0, 10) > 0)
                            //{
                            valor = rnd.Next(nivel * 2, nivel * 4);
                            //}
                            break;
                        case "agi":
                            //if (generarNumeroSuperRandom(0, 10) <= 5)
                            //{
                            valor = rnd.Next(nivel, nivel * 3 - 1);
                            //}
                            break;
                        case "sue":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 3)
                            {
                                valor = rnd.Next(nivel - 1, nivel * 2);
                            }
                            break;
                    }
                    break;

                case "varita":
                    switch (stat)
                    {
                        case "mag":
                            valor = rnd.Next(nivel * 3 + 1, nivel * 5 + 1);                            
                        break;
                    }
                    break;

                case "escudo":
                    switch (stat)
                    {
                        case "res":
                            valor = rnd.Next(nivel * 3 + 1, nivel * 5 - 1);
                        break;
                        case "con":
                            valor = rnd.Next(nivel * 10, nivel * 25);
                        break;
                    }
                    break;

                case "hacha":
                    switch (stat)
                    {
                        case "fue":
                            valor = rnd.Next(nivel * 3 + 1, nivel * 6 - 1);                            
                        break;
                    }
                    break;

                case "lanza":
                    switch (stat)
                    {
                        case "fue":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) > 0)
                            {
                                valor = rnd.Next(nivel + 2, nivel * 3);
                            }
                        break;
                        case "agi":
                            valor = rnd.Next(nivel + 3, nivel * 3 + 2);
                        break;
                    }
                break;

                case "arco":
                    switch (stat)
                    {
                        case "fue":
                            valor = rnd.Next(nivel * 2, nivel * 3 - 1);
                        break;
                        case "agi":
                            valor = rnd.Next(nivel, nivel * 2 - 1);
                        break;
                        case "sue":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 4)
                            {
                                valor = rnd.Next(nivel * 2, nivel * 4);
                            }
                        break;
                    }
                break;

                case "baston":
                    switch (stat)
                    {
                        case "fue":
                            valor = rnd.Next(nivel * 2, nivel * 3 - 1);
                        break;
                        case "mag":
                            valor = rnd.Next(nivel * 2, nivel * 3 - 1);
                        break;
                        case "sue":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 3)
                            {
                                valor = rnd.Next(nivel * 2, nivel * 4);
                            }
                        break;
                    }
                break;

                default:
                    switch (stat)
                    {
                        case "fue":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 5)
                            {
                                valor = rnd.Next(nivel * 3 + 1, nivel * 5 - 1);
                            }
                            break;
                        case "res":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 5)
                            {
                                valor = rnd.Next(nivel * 3 + 1, nivel * 4 - 1);
                            }
                            break;
                        case "con":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 5)
                            {
                                valor = rnd.Next(nivel * 10, nivel * 25);
                            }
                            break;
                        case "agi":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 5)
                            {
                                valor = rnd.Next(nivel * 3 + 1, nivel * 4 + 2);
                            }
                            break;
                        case "mag":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 5)
                            {
                                valor = rnd.Next(nivel * 3 + 1, nivel * 5 - 1);
                            }
                            break;
                        case "sue":
                            if (CalculosRPG.GenerarNumeroSuperRandom(0, 10) <= 3)
                            {
                                valor = rnd.Next(nivel * 1, nivel * 2 - nivel);
                            }
                            break;
                    }
                    break;
            }

            return valor;
        }

        internal static Objeto GenerarItemRandom()
        {
            //Generamos el nivel de objeto
            int randomNivel = new Random().Next(1, 100);

            //Generamos el tipo de objeto, según este, obtendrá unos stats y en un rango específicos
            string randomTipo = typeof(TipoArma).GenerarSeleccionEnumRandom().ToString();

            //El nombre se hará de alguna forma que aún no se me ha ocurrido
            string nombre = randomTipo + " de Debug";

            //Generamos los stats según el tipo de item y el atributo
            /*Stats stats = new Stats(
                GenerarStatAleatoria(randomTipo, "fue", randomNivel),
                GenerarStatAleatoria(randomTipo, "res", randomNivel),
                GenerarStatAleatoria(randomTipo, "con", randomNivel),
                GenerarStatAleatoria(randomTipo, "agi", randomNivel),
                GenerarStatAleatoria(randomTipo, "mag", randomNivel),
                GenerarStatAleatoria(randomTipo, "sue", randomNivel));

            //Generamos una habilidad (o ninguna)
            HabilidadItem skill = null;

            if (new Random().Next(2) == 0)
            {
                Dictionary<string, string> habilidadesItems = GenerarListaHabilidades();
                string nombreSkill = typeof(HabilidadesItems).GenerarSeleccionEnumRandom().ToString();
                skill = new HabilidadItem(nombreSkill, habilidadesItems[nombreSkill]);
            }

            Objeto nuevoItem = new Objeto(randomNivel, randomTipo, nombre, stats, skill);
            */
            return null;
        }

        internal static Dictionary<string, string> GenerarListaHabilidades()
        {
            Dictionary<string, string> listaSkills = new Dictionary<string, string>();
            listaSkills.Add("Gelido", "El enemigo que sufra daño de esta arma también sufrirá una ralentización");
            listaSkills.Add("Igneo", "El enemigo que sufra daño de esta arma sufre daño adicional con ataques consecutivos");
            listaSkills.Add("Corrupto", "El daño realizado con esta arma no se puede curar a menos que se purifique");
            listaSkills.Add("Divino", "Causar daño con esta arma restaura una parte de ese daño como vida al portador. \nCausa daño adicional a no muertos");
            listaSkills.Add("Suertudo", "Esquivar un ataque aumenta la probabilidad de crítico en el siguiente turno. \nAsestar un crítico aumenta la posibilidad de que tu enemigo falle su siguiente ataque");
            listaSkills.Add("Contundente", "Golpear con esta arma tiene una probabilidad de aturdir a su objetivo");

            return listaSkills;
        }
    }
}
