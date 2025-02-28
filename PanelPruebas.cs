using System.Data;
using System.Security.Cryptography;
using TouRPGProject.Clases;

namespace TouRPGProject
{
    public partial class FormAlgoritmoRPG : Form
    {
        private List<Objeto> listaItems = [];
        public Dictionary<string, string> listaHabilidadesItems;
        public List<PersonajeBase> listaPersonajes = [];
        //public Personaje pjSeleccionado;
        //public Personaje enemigoSeleccionado;
        //public Item itemSeleccionado;

        //Variables Coliseo
        public List<Habilidad> listaHabsPersonajes = [];
        public List<PersonajeJugador> listaAspirantes = [];
        public List<PersonajeEnemigo> listaEnemigos = [];
        PersonajeJugador personajeJugadorElegido;
        PersonajeEnemigo PersonajeEnemigoElegido;
        bool CombateTerminado = false;

        public FormAlgoritmoRPG()
        {
            InitializeComponent();
            //listaHabilidadesItems = CalculosRPGItems.GenerarListaHabilidades();
            //listaPersonajes.Add(CalculosRPGPersonajes.GenerarPersonajeRandom("PJTest"));
            lbListaPJ.Items.Add(listaPersonajes[0]);
            //pjSeleccionado = listaPersonajes[0];
            //MostrarDatosPJ(pjSeleccionado);
            //pbImagenPJ.Image = Properties.Resources.dummy;
            //enemigoSeleccionado = CalculosRPGPersonajes.GenerarPersonajeRandom("Dummy");
            //MostrarDatosEnemigo(enemigoSeleccionado);


            //Parte Coliseo
            tbLogCombate.ScrollBars = ScrollBars.Both;
            listaAspirantes = GenerarAspirantes();
            listaEnemigos = GenerarEnemigos();
            listaHabsPersonajes = GenerarHabilidadesPersonajes();
            listaAspirantes.ForEach(AgregarAspiranteALista);
            listaEnemigos.ForEach(AgregarEnemigoALista);

        }

        private void AgregarEnemigoALista(PersonajeEnemigo p)
        {
            lbListaEnemigos.Items.Add(p.Nombre);
        }

        private void AgregarAspiranteALista(PersonajeJugador p)
        {
            lbListaAspirantes.Items.Add(p.Nombre);
        }

        private List<PersonajeEnemigo> GenerarEnemigos()
        {
            List<PersonajeEnemigo> listaEnemigos = new List<PersonajeEnemigo>();
            listaEnemigos.Add(new PersonajeEnemigo("E-001", 1, "Goblin Test", "Test de enemigo", "test"));
            listaEnemigos.Add(new PersonajeEnemigo("E-002", 1, "Zuday", "El justiciero abrasador", "paladin"));
            listaEnemigos.Add(new PersonajeEnemigo("E-003", 25, "Halgel", "Maestro de hachas", "barbaro"));
            listaEnemigos.Add(new PersonajeEnemigo("E-004", 10, "Munka", "Conjurador del mañana", "brujo"));
            listaEnemigos.Add(new PersonajeEnemigo("E-005", 100, "Lord Pitstrike", "Nosequé de un dios", "pirata"));
            listaEnemigos.Add(new PersonajeEnemigo("E-006", 100, "Rongrol", "Pesadilla orca", "guardian"));
            //PersonajeEnemigo nuevoEnemigo = new PersonajeEnemigo("E-001", 1, "Trasgo llorón", "", "asesino");

            return listaEnemigos;
        }

        private List<PersonajeJugador> GenerarAspirantes()
        {
            List<PersonajeJugador> listaAspirantes = new List<PersonajeJugador>();
            listaAspirantes.Add(new PersonajeJugador("001", 1, "Demoboy", "Test personaje", "test"));

            return listaAspirantes;
        }

        private List<Habilidad> GenerarHabilidadesPersonajes()
        {
            //Habilidad hab1 = new Habilidad();

            return null;
        }

        /*
        #region elementos Interfaz
        private void tbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13) //Tecla intro
            {
                e.Handled = true;
                pjSeleccionado.nivel = int.Parse(tbNivel.Text.ToString().Trim());
                pjSeleccionado.stats = CalculosRPGPersonajes.RecalcularStats(pjSeleccionado);
                MostrarStats(pjSeleccionado.stats);
            }
        }

        private void MostrarStats(EstadisticasPersonaje stats)
        {
            lblFUEPJ.Text = stats.fuerza.ToString();
            lblRESPJ.Text = stats.resistencia.ToString();
            lblCONPJ.Text = stats.constitucion.ToString();
            lblAGIPJ.Text = stats.agilidad.ToString();
            lblMAGPJ.Text = stats.magia.ToString();
            lblSUEPJ.Text = stats.suerte.ToString();
        }

        private void MostrarDatosPJ(Personaje pj)
        {
            MostrarStats(pj.stats);
            lblNombrePersonaje.Text = pj.nombre;
            lblClase.Text = pj.clase;
            lblElemento.Text = pj.elemento;
            lblEspecializacion.Text = pj.especializacion;
            tbNivel.Text = pj.nivel.ToString();
            lblItemManoDerecha.Text = pj.objetoManoDerecha != null ? pj.objetoManoDerecha.nombre : "Nada";
            lblItemManoIzquierda.Text = pj.objetoManoIzquierda != null ? pj.objetoManoIzquierda.nombre : "Nada";
            lblListaHabilidadesPJ.Text = pj.habilidadesPJ[0].MostrarNombreHabilidad() + ": \n" + pj.habilidadesPJ[0].descripcionHabilidad;
        }

        private void MostrarDatosEnemigo(Personaje enemigoSeleccionado)
        {
            lblNombreEnemigo.Text = $"{enemigoSeleccionado.nombre} de nivel {enemigoSeleccionado.nivel}";
        }

        private void btnGenerarPJ_Click(object sender, EventArgs e)
        {
            int numeroNuevoPJ = listaPersonajes.Count;
            Personaje nuevoPJ = CalculosRPGPersonajes.GenerarPersonajeRandom($"NuevoPJ {numeroNuevoPJ}");
            listaPersonajes.Add(nuevoPJ);
            lbListaPJ.Items.Add(nuevoPJ);
        }

        private void lbListaPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            pjSeleccionado = (Personaje)lbListaPJ.SelectedItem;
            MostrarDatosPJ(pjSeleccionado);
        }

        private void btnGenerarItem_Click(object sender, EventArgs e)
        {
            //1: Generamos un item
            Item nuevoItem = CalculosRPGItems.GenerarItemRandom();

            //2: Lo agregamos a la lista de items
            listaItems.Add(nuevoItem);
            lsbListaItems.Items.Add(nuevoItem.nombre + ": " + nuevoItem.tipoItem + " de lv" + nuevoItem.nivel);
        }

        private void lsbListaItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1: Encuentra el item en la lista
            itemSeleccionado = listaItems.Find(Item => Item.nombre == lsbListaItems.SelectedItem.ToString().Split(':').FirstOrDefault());

            //2: Lo muestra en pantalla
            lblNivelItem.Text = $"Nivel de objeto: {itemSeleccionado.nivel}";
            lblNombreItem.Text = $"{itemSeleccionado.nombre}";
            lblTipoItem.Text = $"{itemSeleccionado.tipoItem}";
            lblStatsItem.Text = $"{itemSeleccionado.stats.MostrarStats()}";

            if (itemSeleccionado.habilidad1 != null)
            {
                lblHabilidad.Text = $"{itemSeleccionado.habilidad1.nombreHabilidad}: {itemSeleccionado.habilidad1.descHabilidad}";
            }
            else
            {
                lblHabilidad.Text = "";
            }
        }

        private void btnDarItemAPJ_Click(object sender, EventArgs e)
        {
            if (new Random().Next(10) % 2 == 0)
            {
                pjSeleccionado.ManoDerecha = itemSeleccionado;
                lblItemManoDerecha.Text = itemSeleccionado.nombre;
                MostrarStats(pjSeleccionado.stats);
            }
            else
            {
                pjSeleccionado.ManoIzquierda = itemSeleccionado;
                lblItemManoIzquierda.Text = itemSeleccionado.nombre;
                MostrarStats(pjSeleccionado.stats);
            }
        }

        private void btnQuitarManoDerecha_Click(object sender, EventArgs e)
        {
            pjSeleccionado.ManoDerecha = null;
            lblItemManoDerecha.Text = "Nada";
            MostrarStats(pjSeleccionado.stats);
        }

        private void btnQuitarManoIzquierda_Click(object sender, EventArgs e)
        {
            pjSeleccionado.ManoIzquierda = null;
            lblItemManoIzquierda.Text = "Nada";
            MostrarStats(pjSeleccionado.stats);
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            int damage = CalculosRPGCombate.AplicarAtaque(pjSeleccionado, enemigoSeleccionado);
            if (damage == 0)
            {
                lblLogAtaque.Text = $"El ataque falló \n";
            }
            else
            {
                if (enemigoSeleccionado.salud <= 0)
                {
                    lblLogAtaque.Text = $"{enemigoSeleccionado.nombre} ya está muerto.";
                }
                else
                {
                    enemigoSeleccionado.salud = enemigoSeleccionado.salud - damage;
                    lblLogAtaque.Text = $"{pjSeleccionado.nombre} ataca a {enemigoSeleccionado.nombre}. " +
                        $"\n Salud del objetivo: {enemigoSeleccionado.salud}/{enemigoSeleccionado.stats.constitucion} \n";
                }
            }
        }

        private void btnGenerarAspirante_Click(object sender, EventArgs e)
        {
            //PersonajeJugador nuevoPj = new PersonajeJugador("J-001",1,"Kayden","Maestro armero","monje");
            //MessageBox.Show($"{nuevoPj.Nombre}: {nuevoPj.Titulo}. \n {nuevoPj.Especializacion} de nivel {nuevoPj.Nivel}. \n Sus stats son: {nuevoPj.StatsPersonaje.GetCadenaStats()}", "Viva españa, nuevo personaje creado");
        }

        private void btnGenerarEnemigo_click(object sender, EventArgs e)
        {
            //PersonajeEnemigo nuevo = new PersonajeEnemigo("E-001", 1,"Zuday", "El justiciero abrasador", "paladin");
            //PersonajeEnemigo nuevo = new PersonajeEnemigo("E-002", 25, "Halgel", "Maestro de hachas", "barbaro");
            //PersonajeEnemigo nuevo = new PersonajeEnemigo("E-003", 10, "Munka", "Conjurador del mañana", "brujo");
            //PersonajeEnemigo nuevo = new PersonajeEnemigo("E-001", 100, "Lord Pitstrike", "Nosequé de un dios", "pirata");
            //PersonajeEnemigo nuevo = new PersonajeEnemigo("E-001", 100, "Rongrol", "Pesadilla orca", "guardian");
            //PersonajeEnemigo nuevoEnemigo = new PersonajeEnemigo("E-001", 1, "Trasgo llorón", "", "asesino");
            //MessageBox.Show($"{nuevoEnemigo.Nombre}: {nuevoEnemigo.Titulo}. \n {nuevoEnemigo.Especializacion} de nivel {nuevoEnemigo.Nivel}. \n Sus stats son: {nuevoEnemigo.StatsPersonaje.GetCadenaStats()}", "Viva españa, nuevo personaje creado");

        }

        //Seccion rework Coliseo
        private void lbListaAspirantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            personajeJugadorElegido = listaAspirantes.Find(Item => Item.Nombre == lbListaAspirantes.SelectedItem.ToString());
            ActualizarStats();
            if (personajeJugadorElegido != null && PersonajeEnemigoElegido != null)
            {
                btnIniciarCombate.Enabled = true;
            }
        }

        private void lbListaEnemigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonajeEnemigoElegido = listaEnemigos.Find(Item => Item.Nombre == lbListaEnemigos.SelectedItem.ToString());
            ActualizarStats();
            if (personajeJugadorElegido != null && PersonajeEnemigoElegido != null)
            {
                btnIniciarCombate.Enabled = true;
            }
        }

        private void ActualizarStats()
        {
            if (personajeJugadorElegido != null)
            {
                lblFueAspirante.Text = personajeJugadorElegido.StatsPersonaje.Fuerza.ToString();
                lblResAspirante.Text = personajeJugadorElegido.StatsPersonaje.Resistencia.ToString();
                lblVitAspirante.Text = personajeJugadorElegido.StatsPersonaje.Vitalidad.ToString();
                lblMagAspirante.Text = personajeJugadorElegido.StatsPersonaje.Magia.ToString();
                lblAgiAspirante.Text = personajeJugadorElegido.StatsPersonaje.Agilidad.ToString();
                lblSueAspirante.Text = personajeJugadorElegido.StatsPersonaje.Suerte.ToString();
                lblHPAspirante.Text = personajeJugadorElegido.SaludActual.ToString();
            }

            if (PersonajeEnemigoElegido != null)
            {
                lblFueEnemigo.Text = PersonajeEnemigoElegido.StatsPersonaje.Fuerza.ToString();
                lblResEnemigo.Text = PersonajeEnemigoElegido.StatsPersonaje.Resistencia.ToString();
                lblVitEnemigo.Text = PersonajeEnemigoElegido.StatsPersonaje.Vitalidad.ToString();
                lblMagEnemigo.Text = PersonajeEnemigoElegido.StatsPersonaje.Magia.ToString();
                lblAgiEnemigo.Text = PersonajeEnemigoElegido.StatsPersonaje.Agilidad.ToString();
                lblSueEnemigo.Text = PersonajeEnemigoElegido.StatsPersonaje.Suerte.ToString();
                lblHPEnemigo.Text = PersonajeEnemigoElegido.SaludActual.ToString();
            }
        }

        private void btnIniciarCombate_Click(object sender, EventArgs e)
        {
            tbLogCombate.Text += $" COMIENZA EL COMBATE \n";
            ComenzarCombate();
        }


        public void ComenzarCombate()
        {
            while (!CombateTerminado)
            {
                TurnoJugador();
                Thread.Sleep(1000);
                TurnoEnemigo();
                Thread.Sleep(1000);
            }

            ResultadosCombate();
        }

        private void TurnoJugador()
        {
            SeleccionOpcionJugador dialogo = new SeleccionOpcionJugador();
            if (dialogo.ShowDialog() == DialogResult.Yes)
            {
                int dmg = CausarDMG(personajeJugadorElegido.StatsPersonaje, PersonajeEnemigoElegido.StatsPersonaje);

                if (dmg != 0)
                {
                    tbLogCombate.Text += $"Causas {dmg} de daño a {PersonajeEnemigoElegido.Nombre}. \n";
                }
                else
                {
                    tbLogCombate.Text += $"El ataque falló... \n";
                }

                PersonajeEnemigoElegido.SaludActual -= dmg;
                ActualizarStats();

                if (PersonajeEnemigoElegido.SaludActual <= 0)
                {
                    CombateTerminado = true;
                }
            }
        }

        private void TurnoEnemigo()
        {
            if (PersonajeEnemigoElegido.Vivo)
            {
                int dmg = CausarDMG(PersonajeEnemigoElegido.StatsPersonaje, personajeJugadorElegido.StatsPersonaje);

                if (dmg != 0)
                {
                    tbLogCombate.Text += $"{PersonajeEnemigoElegido.Nombre} ataca, causando {dmg} de daño. \n";
                }
                else
                {
                    tbLogCombate.Text += $"{PersonajeEnemigoElegido.Nombre} ataca, pero falló. \n";
                }

                personajeJugadorElegido.SaludActual -= dmg;
                ActualizarStats();

                if (personajeJugadorElegido.SaludActual <= 0)
                {
                    CombateTerminado = true;
                }
            }
        }

        private int CausarDMG(Stats statsAtacante, Stats statsDefensor)
        {
            int dmg = 0;

            if (CalcularProbabilidadImpacto(statsAtacante.Agilidad, statsDefensor.Agilidad))
            {
                dmg = CalcularDmg(statsAtacante.Fuerza, statsDefensor.Resistencia);
            }

            return dmg;
        }

        private int CalcularDmg(int fuerza, int resistencia)
        {
            double damages = fuerza * (100 / (100 + (double)resistencia));
            return (int)damages;
        }

        private bool CalcularProbabilidadImpacto(int agilidad1, int agilidad2)
        {
            bool acierta = false;
            int constanteDivision = 150;
            double seccionPorcentaje = constanteDivision / (agilidad1 + agilidad2);
            int probabilidadAcierto = new Random().Next(0, 100);
            if (0 <= probabilidadAcierto
                && probabilidadAcierto <= agilidad1 * seccionPorcentaje)
            {
                acierta = true;
            }

            return acierta;
        }

        public void ResultadosCombate()
        {
            tbLogCombate.Text = tbLogCombate.Text + $"Combate ha terminado, pasamos a ver los resultados... \n";

            if (PersonajeEnemigoElegido.Vivo == false)
            {
                MessageBox.Show("Has ganado, enhorabuena :)", "Fin del combate");
            }
            else
            {
                MessageBox.Show("Oh, no. Has perdido D:", "Fin del combate");
            }
        }
    }
    #endregion
    */

        #region sección Items
        /*public class Item
        {
            public int nivel;
            public string tipoItem;
            public string nombre;
            public EstadisticasItems stats;
            public HabilidadItem habilidad1;

            public Item() { }

            public Item(int nivel, string tipo, string nombre, EstadisticasItems stats, HabilidadItem habilidad1)
            {
                this.nivel = nivel;
                this.nombre = nombre;
                this.tipoItem = tipo;
                this.stats = stats;
                this.habilidad1 = habilidad1;
            }
        }

        public enum TipoItems
        {
            espada,
            escudo,
            lanza,
            hacha,
            varita,
            baston,
            arco,
            amuleto
        }

        public enum HabilidadesItems
        {
            Gelido,
            Igneo,
            Corrupto,
            Divino,
            Suertudo,
            Contundente
        }

        public class EstadisticasItems
        {
            public int fuerza;
            public int resistencia;
            public int constitucion;
            public int agilidad;
            public int magia;
            public int suerte;

            public EstadisticasItems(int fue, int res, int con, int agi, int mag, int sue)
            {
                this.fuerza = fue;
                this.resistencia = res;
                this.constitucion = con;
                this.agilidad = agi;
                this.magia = mag;
                this.suerte = sue;
            }

            public int SumatorioStats()
            {
                return fuerza + resistencia + constitucion + agilidad + magia + suerte;
            }

            public string MostrarStats()
            {
                string cadena = "";

                if (fuerza != 0)
                {
                    cadena = $"{cadena}+{fuerza}FUE ";
                }
                if (resistencia != 0)
                {
                    cadena = $"{cadena}+{resistencia}RES ";
                }
                if (constitucion != 0)
                {
                    cadena = $"{cadena}+{constitucion}CON ";
                }
                if (agilidad != 0)
                {
                    cadena = $"{cadena}+{agilidad}AGI ";
                }
                if (magia != 0)
                {
                    cadena = $"{cadena}+{magia}MAG ";
                }
                if (suerte != 0)
                {
                    cadena = $"{cadena}+{suerte}SUE ";
                }

                return cadena;
            }
        }

        public class HabilidadItem
        {
            //private int idHabilidad;
            public string nombreHabilidad;
            public string descHabilidad;

            public HabilidadItem(string nombre, string desc)
            {
                //this.idHabilidad = 0;
                this.nombreHabilidad = nombre;
                this.descHabilidad = desc;
            }
        }

        public static class CalculosRPGItems
        {
            public static int GenerarStatAleatoria(string tipo, string stat, int nivel)
            {
                Random rnd = new Random();
                int valor = 0;
                switch (tipo)
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
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 3)
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
                                //if (generarNumeroSuperRandom(0, 10) > 0)
                                //{
                                valor = rnd.Next(nivel * 3 + 1, nivel * 5 + 1);
                                //}
                                break;
                        }
                        break;

                    case "escudo":
                        switch (stat)
                        {
                            case "res":
                                //if (generarNumeroSuperRandom(0, 10) > 0)
                                //{
                                valor = rnd.Next(nivel * 3 + 1, nivel * 5 - 1);
                                //}
                                break;
                            case "con":
                                //if (generarNumeroSuperRandom(0, 10) <= 8)
                                //{
                                valor = rnd.Next(nivel * 10, nivel * 25);
                                //}
                                break;
                        }
                        break;

                    case "hacha":
                        switch (stat)
                        {
                            case "fue":
                                //if (generarNumeroSuperRandom(0, 10) > 0)
                                //{
                                valor = rnd.Next(nivel * 3 + 1, nivel * 6 - 1);
                                //}
                                break;
                        }
                        break;

                    case "lanza":
                        switch (stat)
                        {
                            case "fue":
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) > 0)
                                {
                                    valor = rnd.Next(nivel + 2, nivel * 3);
                                }
                                break;
                            case "agi":
                                //if (generarNumeroSuperRandom(0, 10) <= 7)
                                //{
                                valor = rnd.Next(nivel + 3, nivel * 3 + 2);
                                //}
                                break;
                        }
                        break;

                    case "arco":
                        switch (stat)
                        {
                            case "fue":
                                //if (generarNumeroSuperRandom(0, 10) > 0)
                                //{
                                valor = rnd.Next(nivel * 2, nivel * 3 - 1);
                                //}
                                break;
                            case "agi":
                                //if (generarNumeroSuperRandom(0, 10) <= 7)
                                //{
                                valor = rnd.Next(nivel, nivel * 2 - 1);
                                //}
                                break;
                            case "sue":
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 4)
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
                                //if (generarNumeroSuperRandom(0, 10) <= 7)
                                //{
                                valor = rnd.Next(nivel * 2, nivel * 3 - 1);
                                //}
                                break;
                            case "mag":
                                //if (generarNumeroSuperRandom(0, 10) <= 7)
                                //{
                                valor = rnd.Next(nivel * 2, nivel * 3 - 1);
                                //}
                                break;
                            case "sue":
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 3)
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
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 5)
                                {
                                    valor = rnd.Next(nivel * 3 + 1, nivel * 5 - 1);
                                }
                                break;
                            case "res":
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 5)
                                {
                                    valor = rnd.Next(nivel * 3 + 1, nivel * 4 - 1);
                                }
                                break;
                            case "con":
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 5)
                                {
                                    valor = rnd.Next(nivel * 10, nivel * 25);
                                }
                                break;
                            case "agi":
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 5)
                                {
                                    valor = rnd.Next(nivel * 3 + 1, nivel * 4 + 2);
                                }
                                break;
                            case "mag":
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 5)
                                {
                                    valor = rnd.Next(nivel * 3 + 1, nivel * 5 - 1);
                                }
                                break;
                            case "sue":
                                if (CalculosRPGGenerales.GenerarNumeroSuperRandom(0, 10) <= 3)
                                {
                                    valor = rnd.Next(nivel * 1, nivel * 2 - nivel);
                                }
                                break;
                        }
                        break;
                }

                return valor;
            }

            internal static Item GenerarItemRandom()
            {
                //Generamos el nivel de objeto
                int randomNivel = new Random().Next(1, 100);

                //Generamos el tipo de objeto, según este, obtendrá unos stats y en un rango específicos
                string randomTipo = typeof(TipoItems).GenerarSeleccionEnumRandom().ToString();

                //El nombre se hará de alguna forma que aún no se me ha ocurrido
                string nombre = randomTipo + " de Debug";

                //Generamos los stats según el tipo de item y el atributo
                EstadisticasItems stats = new EstadisticasItems(
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

                Item nuevoItem = new Item(randomNivel, randomTipo, nombre, stats, skill);

                return nuevoItem;
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
        */
        #endregion

        #region sección Personajes
        /*
        public class Personaje
        {
            //Variables
            public string nombre;
            public string clase;
            public string elemento;
            public string especializacion;
            public int nivel;
            public int salud;
            public EstadisticasPersonaje stats;
            public Item objetoManoIzquierda;
            public Item objetoManoDerecha;
            public List<HabilidadPersonaje> habilidadesPJ;

            //Propiedades
            public Item ManoIzquierda
            {
                get { return objetoManoIzquierda; }
                set
                {
                    if (value != null)
                    {
                        stats = CalculosRPGPersonajes.RestarStatsItems(stats, objetoManoIzquierda);
                        stats = CalculosRPGPersonajes.SumarStatsItems(stats, value);
                    }
                    else
                    {
                        stats = CalculosRPGPersonajes.RestarStatsItems(stats, objetoManoIzquierda);
                    }

                    objetoManoIzquierda = value;
                }
            }

            public Item ManoDerecha
            {
                get { return objetoManoDerecha; }
                set
                {
                    if (value != null)
                    {
                        stats = CalculosRPGPersonajes.RestarStatsItems(stats, objetoManoDerecha);
                        stats = CalculosRPGPersonajes.SumarStatsItems(stats, value);
                    }
                    else
                    {
                        stats = CalculosRPGPersonajes.RestarStatsItems(stats, objetoManoDerecha);
                    }

                    objetoManoDerecha = value;
                }
            }

            //Constructores
            public Personaje() { }

            public Personaje(string nombre, string clase, string elemento, int nivel)
            {
                this.nombre = nombre;
                this.clase = clase;
                this.elemento = elemento;
                this.especializacion = CalculosRPGPersonajes.CalcularEspecializacion(clase, elemento);
                this.nivel = nivel;
                this.stats = CalculosRPGPersonajes.RecalcularStats(this);
                this.salud = stats.constitucion;
                this.habilidadesPJ = new List<HabilidadPersonaje>();
            }

            public void DarHabilidad(HabilidadPersonaje skill)
            {
                //1: Comprobar que no posee esta habilidad ya, ponerla si no la posee
                if (!habilidadesPJ.Any(x => x.nombreHabilidad == skill.nombreHabilidad))
                {
                    habilidadesPJ.Add(skill);
                }
                else
                {
                    //2: Si ya posee la habilidad con ese nombre, comprobar si la que le quieres otorgar es de nivel superior, si es así, subir el nivel de la que ya tiene.
                    int indice = habilidadesPJ.IndexOf(habilidadesPJ.Single(i => i.nombreHabilidad == skill.nombreHabilidad));

                    if (habilidadesPJ[indice].nivelHabilidad < skill.nivelHabilidad)
                    {
                        habilidadesPJ[indice].nivelHabilidad = skill.nivelHabilidad;
                    }
                }
            }
        }

        public class EstadisticasPersonaje
        {
            public int fuerza;
            public int resistencia; //blindaje FIS
            public int constitucion;
            public int agilidad;
            public int magia;
            public int suerte;

            public EstadisticasPersonaje() { }

            public EstadisticasPersonaje(int fue, int res, int con, int agi, int mag, int sue)
            {
                this.fuerza = fue;
                this.resistencia = res;
                this.constitucion = con;
                this.agilidad = agi;
                this.magia = mag;
                this.suerte = sue;
            }

            public int SumatorioStats()
            {
                return fuerza + resistencia + constitucion + agilidad + magia + suerte;
            }

            public string MostrarStats()
            {
                string cadena = $"FUE:{fuerza}/RES:{resistencia}/CON:{constitucion}/AGI:{agilidad}/MAG:{magia}/SUE:{suerte}";
                return cadena;
            }
        }

        public class HabilidadPersonaje
        {
            public string nombreHabilidad;
            public string descripcionHabilidad;
            public int nivelHabilidad;

            public HabilidadPersonaje(string nombre, string desc, int nivel)
            {
                this.nombreHabilidad = nombre;
                this.descripcionHabilidad = desc;
                this.nivelHabilidad = nivel;
                //las habilidades de nivel 0 se deben considerar legendarias
            }

            public string MostrarNombreHabilidad()
            {
                string nombre = nombreHabilidad.Replace("_", " ");
                string nivel = nivelHabilidad != 0 ? nivelHabilidad.ToString() : "";
                return $"{nombre} {nivel}";
            }
        }

        public class PJ : Personaje
        {
            public PJ(string nombre, string clase, string elemento, int nivel) : base(nombre, clase, elemento, nivel)
            {

            }
        }

        public class NPC : Personaje
        {
            public NPC(string nombre, string clase, string elemento, int nivel) : base(nombre, clase, elemento, nivel)
            {

            }
        }

        public enum ClasesPrimariasPersonaje
        {
            caballero,
            mago,
            picaro
        }

        public enum ElementosPersonaje
        {
            fuego,
            agua,
            tierra,
            aire,
            luz,
            oscuridad
        }

        public enum EspecializacionesPersonaje
        {
            barbaro,
            guardian,
            guerrero,
            monje,
            paladin,
            cabnegro,
            piromante,
            chaman,
            druida,
            vidente,
            clerigo,
            brujo,
            artificiero,
            pirata,
            forajido,
            ninja,
            tirador,
            asesino
        }

        public class EstadisticasBasePersonajes
        {
            public EstadisticasPersonaje statsBase;

            public EstadisticasBasePersonajes(string especializacion)
            {
                switch (especializacion)
                {
                    case "barbaro":
                        statsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 1);
                        break;
                    case "guardian":
                        statsBase = new EstadisticasPersonaje(3, 5, 8, 2, 3, 1);
                        break;
                    case "guerrero":
                        statsBase = new EstadisticasPersonaje(3, 3, 5, 2, 1, 1);
                        break;
                    case "monje":
                        statsBase = new EstadisticasPersonaje(4, 3, 3, 4, 2, 1);
                        break;
                    case "paladin":
                        statsBase = new EstadisticasPersonaje(2, 5, 8, 2, 4, 1);
                        break;
                    case "cabnegro":
                        statsBase = new EstadisticasPersonaje(3, 4, 6, 1, 3, 1);
                        break;
                    case "piromante":
                        statsBase = new EstadisticasPersonaje(3, 2, 3, 1, 6, 1);
                        break;
                    case "chaman":
                        statsBase = new EstadisticasPersonaje(2, 3, 4, 1, 5, 1);
                        break;
                    case "druida":
                        statsBase = new EstadisticasPersonaje(3, 3, 4, 3, 4, 1);
                        break;
                    case "vidente":
                        statsBase = new EstadisticasPersonaje(1, 2, 3, 1, 5, 3);
                        break;
                    //desde aqui revisar stats base
                    case "clerigo":
                        statsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 1);
                        break;
                    case "brujo":
                        statsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 1);
                        break;
                    case "artificiero":
                        statsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 1);
                        break;
                    case "pirata":
                        statsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 1);
                        break;
                    case "forajido":
                        statsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 1);
                        break;
                    case "ninja":
                        statsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 1);
                        break;
                    case "asesino":
                        statsBase = new EstadisticasPersonaje(5, 2, 3, 5, 2, 1);
                        break;
                    case "tirador":
                        statsBase = new EstadisticasPersonaje(5, 2, 3, 5, 2, 1);
                        break;
                    default:
                        statsBase = new EstadisticasPersonaje(3, 3, 3, 3, 3, 1);
                        break;
                }
            }
        }

        public class ModificadoresBasePersonajes
        {
            public EstadisticasPersonaje modifsBase;

            public ModificadoresBasePersonajes(string especializacion)
            {
                switch (especializacion)
                {
                    case "barbaro":
                        modifsBase = new EstadisticasPersonaje(2, 2, 3, 1, 0, 0);
                        break;
                    case "guardian":
                        modifsBase = new EstadisticasPersonaje(3, 5, 8, 2, 3, 0);
                        break;
                    case "guerrero":
                        modifsBase = new EstadisticasPersonaje(3, 3, 5, 2, 1, 0);
                        break;
                    case "monje":
                        modifsBase = new EstadisticasPersonaje(4, 3, 3, 4, 2, 0);
                        break;
                    case "paladin":
                        modifsBase = new EstadisticasPersonaje(2, 5, 8, 2, 4, 0);
                        break;
                    case "cabnegro":
                        modifsBase = new EstadisticasPersonaje(3, 4, 6, 1, 3, 0);
                        break;
                    case "piromante":
                        modifsBase = new EstadisticasPersonaje(3, 2, 3, 1, 6, 0);
                        break;
                    case "chaman":
                        modifsBase = new EstadisticasPersonaje(2, 3, 4, 1, 5, 0);
                        break;
                    case "druida":
                        modifsBase = new EstadisticasPersonaje(3, 3, 4, 3, 4, 0);
                        break;
                    case "vidente":
                        modifsBase = new EstadisticasPersonaje(1, 2, 3, 1, 5, 1);
                        break;
                    //desde aqui revisar stats base
                    case "clerigo":
                        modifsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 0);
                        break;
                    case "brujo":
                        modifsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 0);
                        break;
                    case "artificiero":
                        modifsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 0);
                        break;
                    case "pirata":
                        modifsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 0);
                        break;
                    case "forajido":
                        modifsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 0);
                        break;
                    case "ninja":
                        modifsBase = new EstadisticasPersonaje(4, 3, 5, 3, 0, 0);
                        break;
                    case "asesino":
                        modifsBase = new EstadisticasPersonaje(5, 2, 3, 5, 2, 0);
                        break;
                    case "tirador":
                        modifsBase = new EstadisticasPersonaje(5, 2, 3, 5, 2, 0);
                        break;
                    default:
                        modifsBase = new EstadisticasPersonaje(3, 3, 3, 3, 3, 1);
                        break;
                }
            }
        }

        public static class CalculosRPGPersonajes
        {
            public static Personaje GenerarPersonajeRandom(string nombre)
            {
                Personaje nuevoPJ = new Personaje(
                    nombre,
                    typeof(ClasesPrimariasPersonaje).GenerarSeleccionEnumRandom().ToString(),
                    typeof(ElementosPersonaje).GenerarSeleccionEnumRandom().ToString(),
                    new Random().Next(1, 100));

                //Con esto damos una habilidad al azar
                List<HabilidadPersonaje> listaSkills = GenerarListaHabilidadesPJ();
                nuevoPJ.DarHabilidad(listaSkills[new Random().Next(listaSkills.Count - 1)]);

                return nuevoPJ;
            }

            public static string CalcularEspecializacion(string clase, string elemento)
            {
                string[,] tablaEspecializaciones = new string[3, 6];
                int num = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        tablaEspecializaciones[i, j] = Enum.GetName(typeof(EspecializacionesPersonaje), num);
                        num++;
                    }
                }

                int x = (int)Enum.Parse(typeof(ClasesPrimariasPersonaje), clase);
                int y = (int)Enum.Parse(typeof(ElementosPersonaje), elemento);

                return tablaEspecializaciones[x, y];
            }

            public static EstadisticasPersonaje RecalcularStats(Personaje pj)
            {
                //1: obtener stats base según la especializacion del pj
                EstadisticasBasePersonajes statsBase = new EstadisticasBasePersonajes(pj.especializacion);

                //2: obtener los modificadores base según especializacion
                ModificadoresBasePersonajes modifsbase = new ModificadoresBasePersonajes(pj.especializacion);

                //3: multiplicar los modificadores base por el nivel
                //3.5: si el pj es especial (legendario, evento), sumar modificadores adicionales
                EstadisticasPersonaje nuevosStats = new EstadisticasPersonaje(
                        (statsBase.statsBase.fuerza + modifsbase.modifsBase.fuerza * (pj.nivel - 1)),
                        (statsBase.statsBase.resistencia + modifsbase.modifsBase.resistencia * (pj.nivel - 1)),
                        (statsBase.statsBase.constitucion + modifsbase.modifsBase.constitucion * (pj.nivel - 1)),
                        (statsBase.statsBase.agilidad + modifsbase.modifsBase.agilidad * (pj.nivel - 1)),
                        (statsBase.statsBase.magia + modifsbase.modifsBase.magia * (pj.nivel - 1)),
                        (statsBase.statsBase.suerte + modifsbase.modifsBase.suerte * (pj.nivel - 1))
                    );

                //4: devolver stats
                return nuevosStats;
            }

            internal static EstadisticasPersonaje SumarStatsItems(EstadisticasPersonaje stats, Item itemEquipado)
            {
                if (itemEquipado != null)
                {
                    EstadisticasPersonaje nuevosStats = new EstadisticasPersonaje
                    {
                        fuerza = stats.fuerza + itemEquipado.stats.fuerza,
                        resistencia = stats.resistencia + itemEquipado.stats.resistencia,
                        constitucion = stats.constitucion + itemEquipado.stats.constitucion,
                        agilidad = stats.agilidad + itemEquipado.stats.agilidad,
                        magia = stats.magia + itemEquipado.stats.magia,
                        suerte = stats.suerte + itemEquipado.stats.suerte
                    };

                    return nuevosStats;
                }

                return stats;
            }

            internal static EstadisticasPersonaje RestarStatsItems(EstadisticasPersonaje stats, Item itemEquipado)
            {
                if (itemEquipado != null)
                {
                    EstadisticasPersonaje nuevosStats = new EstadisticasPersonaje
                    {
                        fuerza = stats.fuerza - itemEquipado.stats.fuerza,
                        resistencia = stats.resistencia - itemEquipado.stats.resistencia,
                        constitucion = stats.constitucion - itemEquipado.stats.constitucion,
                        agilidad = stats.agilidad - itemEquipado.stats.agilidad,
                        magia = stats.magia - itemEquipado.stats.magia,
                        suerte = stats.suerte - itemEquipado.stats.suerte
                    };

                    return nuevosStats;
                }

                return stats;
            }

            internal static List<HabilidadPersonaje> GenerarListaHabilidadesPJ()
            {
                List<HabilidadPersonaje> PJ = new List<HabilidadPersonaje>();
                PJ.Add(new HabilidadPersonaje("Retornado", "La primera vez que este personaje muera, retorna con la mitad de su salud máxima", 0));
                PJ.Add(new HabilidadPersonaje("Destructivo", "El daño que causa con sus ataques es en area, por lo que puede causar daño a varios objetivos", 0));
                PJ.Add(new HabilidadPersonaje("Corrupto", "El daño realizado por este personaje no se puede curar", 0));
                PJ.Add(new HabilidadPersonaje("Esperanzador", "Atacar con este personaje cura en area al resto de personajes el 30% de tu daño", 1));
                PJ.Add(new HabilidadPersonaje("Esperanzador", "Atacar con este personaje cura en area al resto de personajes el 60% de tu daño", 2));
                PJ.Add(new HabilidadPersonaje("Habilidoso", "Ligera probabilidad (10%) de golpear dos veces en vez de una", 1));
                PJ.Add(new HabilidadPersonaje("Habilidoso", "Moderada probabilidad (25%) de golpear dos veces en vez de una. \n + 10% Agilidad", 2));
                PJ.Add(new HabilidadPersonaje("Rabioso", "+1 al daño de ataque por cada 6 HP que te falten", 1));
                PJ.Add(new HabilidadPersonaje("Rabioso", "+1 al daño de ataque por cada 3 HP que te falten", 2));
                PJ.Add(new HabilidadPersonaje("Certero", "Sus ataques ignoran el 25% de la resistencia del objetivo", 1));
                PJ.Add(new HabilidadPersonaje("Certero", "Sus ataques ignoran el 50% de la resistencia del objetivo, los golpes críticos ignoran el 100%", 2));
                PJ.Add(new HabilidadPersonaje("Imparable", "Los aturdimientos y las ralentizaciones duran la mitad", 1));
                PJ.Add(new HabilidadPersonaje("Imparable", "Los aturdimientos y las ralentizaciones duran la cuarta parte", 2));
                PJ.Add(new HabilidadPersonaje("Imparable", "Ignoras completamente aturdimientos y ralentizaciones", 3));
                PJ.Add(new HabilidadPersonaje("Ultima_Esperanza", "Cuando mueras, podrás lanzar una habilidad una última vez. \n Matar utilizando esa habilidad te devuelve a la vida con tantos HP como daño causado con la habilidad usada", 0));
                PJ.Add(new HabilidadPersonaje("Usurpador", "Dañar a un objetivo tiene una ligera probabilidad (10%) de robarle una estadística aleatoria", 0));
                PJ.Add(new HabilidadPersonaje("Ardiente", "El daño que causas deja un efecto de quemado, el cual causa el 5% de tu daño por segundo y reduce las curaciones un 50% durante 5 segundos", 1));
                PJ.Add(new HabilidadPersonaje("Mente_Colmena", "Atacar a un objetivo que haya sido atacado por otro personaje causa un 10% de daño adicional", 0));
                PJ.Add(new HabilidadPersonaje("Golpe_Del_Asesino", "Golpear a un objetivo que tiene su salud al máximo causa un 40% de daño extra", 1));
                PJ.Add(new HabilidadPersonaje("Golpe_Del_Asesino", "Golpear a un objetivo que tiene su salud al máximo causa un 80% de daño extra", 2));
                //PJ.Add(new HabilidadPersonaje("", "", 0));

                return PJ;
            }
        }
        */
        #endregion

        #region sección Combate
        /*
        public class Ataque
        {

            double dmg;
            bool ataquemagico;
            string tipodanyo;
            string elementodanyo;
            EfectosAtaque[] listaEfectos;

            public Ataque()
            {

            }

            public double ObtenerDMG()
            {
                //1: obtener dmg
                //2: obtener suma de dmg plano y de porcentajes de modificacion
                //3: calcular dmg final y devolverlo
                return 0d;
            }
        }

        public class EfectosAtaque
        {
            string nombre;
            double modificadorDmg;
            double porcentajeModificador;
            double armaduraIgnorada;
            double modificadorCritico;
            bool infalible;
            EfectosCombate[] efectosAplicables;

        }

        public class EfectosCombate
        {
            string nombre;
        }



        public static class CalculosRPGCombate
        {
            public static int AplicarAtaque(Personaje atacante, Personaje defensor)
            {
                int dmg = 0;

                //attack*(100/(100+defense))
                if (CalcularProbabilidadImpacto(atacante.stats.suerte, defensor.stats.suerte))
                {
                    if (atacante.clase != "mago")
                    {
                        dmg = CalcularDañoFisico(atacante.stats.fuerza, atacante.stats.resistencia);
                    }
                    else
                    {
                        dmg = CalcularDañoMagico(atacante.stats.magia);
                    }
                }

                return (int)dmg;
            }

            private static bool CalcularProbabilidadImpacto(int suerte1, int suerte2)
            {
                //comparar ambas suertes y calcular porcentajes entre 100 unidades
                //si la suerte del defensor es mayor que la del atacante, el ataque falla
                //si tienen la misma cantidad de suerte, es 50/50
                //si el atacante acierta, se podría calcular una estadística adicional de probabilidad de crítico

                bool acierta = false;
                int constanteDivision = 150;
                double seccionPorcentaje = constanteDivision / (suerte1 + suerte2);
                int probabilidadAcierto = new Random().Next(0, 100);
                if (0 <= probabilidadAcierto
                    && probabilidadAcierto <= suerte1 * seccionPorcentaje)
                {
                    acierta = true;
                }

                return acierta;
            }

            private static int CalcularDañoFisico(int fuerza, int resistencia)
            {
                double damages = fuerza * (100 / (100 + (double)resistencia));
                return (int)damages;
            }

            private static int CalcularDañoMagico(int magia)
            {
                double damages = magia;
                return (int)damages;
            }
        }
        #endregion

        #region sección General
        public static class CalculosRPGGenerales
        {
            public static Enum GenerarSeleccionEnumRandom(this Type t)
            {
                return Enum.GetValues(t).OfType<Enum>().OrderBy(e => Guid.NewGuid()).FirstOrDefault();
            }

            public static int GenerarNumeroSuperRandom(int min, int max)
            {
                int num = min - 1;

                RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider();
                byte[] rno = new byte[4];
                rg.GetBytes(rno);
                int randomvalue = BitConverter.ToInt32(rno, 0);
                num = randomvalue / 5 - 1;
                Random rnd = new Random();
                if (rnd.Next(Math.Abs(num)) % 2 == 0)
                {
                    num = rnd.Next(Math.Abs(num));
                }
                else
                {
                    num = rno[0] / (rno[3] + 1) * rnd.Next(Math.Abs(max));
                }

                return num;
            }
         */
        #endregion
    }
}
