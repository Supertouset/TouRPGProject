using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouRPGProject
{
    public class Combate
    {
        bool CombateTerminado;
        PersonajeJugador Jugador;
        PersonajeEnemigo Enemigo;

        public Combate(PersonajeJugador jugador, PersonajeEnemigo enemigo)
        {
            this.Jugador = jugador;
            this.Enemigo = enemigo;
            this.CombateTerminado = false;
        }

        public void ComenzarCombate()
        {
            while (!CombateTerminado)
            {
                TurnoJugador();
                TurnoEnemigo();
                Thread.Sleep(2000);
            }

            ResultadosCombate();
        }

        private void TurnoJugador()
        {
            SeleccionOpcionJugador dialogo = new SeleccionOpcionJugador();
            if (dialogo.ShowDialog() == null)//DialogResult.Yes)
            {
                int dmg = RealizarAtaqueBasico(Jugador.StatsPersonaje, Enemigo.StatsPersonaje);

                if (dmg != 0)
                {
                    //tbLogCombate.Text = tbLogCombate.Text + $"Causas {dmg} de daño a {PersonajeEnemigoElegido.Nombre}. \n";
                }
                else
                {
                    //tbLogCombate.Text = tbLogCombate.Text + $"El ataque falló... \n";
                }

                Enemigo.SaludActual -= dmg;
                //ActualizarStatsEnemigo();

                if (Enemigo.SaludActual <= 0)
                {
                    CombateTerminado = true;
                }
            }

        }

        private void TurnoEnemigo()
        {
            if (Enemigo.Vivo)
            {
                int dmg = RealizarAtaqueBasico(Enemigo.StatsPersonaje, Jugador.StatsPersonaje);
                Jugador.SaludActual -= dmg;

                if (Jugador.SaludActual <= 0)
                {
                    CombateTerminado = true;
                }
            }
        }

        private int RealizarAtaqueBasico(Stats statsAtacante, Stats statsDefensor)
        {
            int dmg = 0;

            if (CalcularProbabilidadAcierto(statsAtacante.Agilidad, statsDefensor.Agilidad))
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

        private bool CalcularProbabilidadAcierto(int agilidad1, int agilidad2)
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
            //tbLogCombate.Text = tbLogCombate.Text + $"Combate ha terminado, pasamos a ver los resultados... \n";

            if (Enemigo.Vivo == false)
            {
               MessageBox.Show("El jugador ha ganado", "Fin del combate");
            }
            else
            {
                MessageBox.Show("El enemigo ha ganado", "Fin del combate");
            }
        }
    }
}
