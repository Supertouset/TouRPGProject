using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouRPGProject
{
    public partial class SeleccionOpcionJugador : Form
    {
        public class ResultSeleccionOpt
        {
            public DialogResult Result { get; set; }
            public string Seleccion { get; set; }
        }

        public SeleccionOpcionJugador()
        {
            InitializeComponent();
        }

        public static ResultSeleccionOpt GenerarOpcion(object sender, EventArgs e)
        {
            using (var f = new SeleccionOpcionJugador())
            {
                ResultSeleccionOpt result = new ResultSeleccionOpt
                {
                    Result = f.ShowDialog()
                };

                switch (result.Result)
                {
                    case DialogResult.Yes:
                        result.Seleccion = "atacar";
                        break;
                    case DialogResult.No:
                        result.Seleccion = "habilidad";
                        break;
                    case DialogResult.Ignore:
                        result.Seleccion = "defender";
                        break;
                    case DialogResult.Abort:
                        result.Seleccion = "objeto";
                        break;
                }

                return result;
            }
        }
    }
}
