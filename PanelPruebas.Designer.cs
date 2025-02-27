namespace TouRPGProject
{
    partial class FormAlgoritmoRPG
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlgoritmoRPG));
            btnGenerarItem = new Button();
            lblNombreItem = new Label();
            lblTipoItem = new Label();
            lblNivelItem = new Label();
            lblStatsItem = new Label();
            lsbListaItems = new ListBox();
            lblHabilidad = new Label();
            groupBox1 = new GroupBox();
            btnDarItemAPJ = new Button();
            groupBox2 = new GroupBox();
            lblListaHabilidadesPJ = new Label();
            label9 = new Label();
            btnQuitarManoIzquierda = new Button();
            btnQuitarManoDerecha = new Button();
            lblItemManoIzquierda = new Label();
            lblItemManoDerecha = new Label();
            label8 = new Label();
            label7 = new Label();
            lblEspecializacion = new Label();
            lblElemento = new Label();
            lblClase = new Label();
            lbListaPJ = new ListBox();
            btnGenerarPJ = new Button();
            tbNivel = new TextBox();
            label6 = new Label();
            lblCONPJ = new Label();
            lblMAGPJ = new Label();
            lblSUEPJ = new Label();
            lblRESPJ = new Label();
            lblFUEPJ = new Label();
            lblAGIPJ = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblStats = new Label();
            lblFuerzaPersonaje = new Label();
            lblNombrePersonaje = new Label();
            btnSiguientePersonaje = new Button();
            btnAnteriorPersonaje = new Button();
            pbImagenPJ = new PictureBox();
            groupBox3 = new GroupBox();
            btnRevivirEnemigo = new Button();
            btnDefenderseDeEnemigo = new Button();
            lblNombreEnemigo = new Label();
            lblLogAtaque = new Label();
            btnAtacar = new Button();
            groupBox4 = new GroupBox();
            lblHPEnemigo = new Label();
            label12 = new Label();
            lblHPAspirante = new Label();
            label11 = new Label();
            btnIniciarCombate = new Button();
            tbLogCombate = new TextBox();
            lblVitEnemigo = new Label();
            lblMagEnemigo = new Label();
            lblSueEnemigo = new Label();
            lblResEnemigo = new Label();
            lblFueEnemigo = new Label();
            lblAgiEnemigo = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            lblVitAspirante = new Label();
            lblMagAspirante = new Label();
            lblSueAspirante = new Label();
            lblResAspirante = new Label();
            lblFueAspirante = new Label();
            lblAgiAspirante = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            lbListaEnemigos = new ListBox();
            lbListaAspirantes = new ListBox();
            btnGenerarAspirante = new Button();
            btnGenerarEnemigo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenPJ).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerarItem
            // 
            btnGenerarItem.Location = new Point(273, 22);
            btnGenerarItem.Margin = new Padding(4, 3, 4, 3);
            btnGenerarItem.Name = "btnGenerarItem";
            btnGenerarItem.Size = new Size(321, 90);
            btnGenerarItem.TabIndex = 0;
            btnGenerarItem.Text = "Generar Item";
            btnGenerarItem.UseVisualStyleBackColor = true;
            btnGenerarItem.Click += btnGenerarItem_Click;
            // 
            // lblNombreItem
            // 
            lblNombreItem.Location = new Point(7, 253);
            lblNombreItem.Margin = new Padding(4, 0, 4, 0);
            lblNombreItem.Name = "lblNombreItem";
            lblNombreItem.Size = new Size(232, 27);
            lblNombreItem.TabIndex = 1;
            lblNombreItem.Text = "Nombre del Item";
            // 
            // lblTipoItem
            // 
            lblTipoItem.Location = new Point(7, 279);
            lblTipoItem.Margin = new Padding(4, 0, 4, 0);
            lblTipoItem.Name = "lblTipoItem";
            lblTipoItem.Size = new Size(232, 27);
            lblTipoItem.TabIndex = 2;
            lblTipoItem.Text = "Tipo de Item";
            // 
            // lblNivelItem
            // 
            lblNivelItem.Location = new Point(7, 306);
            lblNivelItem.Margin = new Padding(4, 0, 4, 0);
            lblNivelItem.Name = "lblNivelItem";
            lblNivelItem.Size = new Size(232, 27);
            lblNivelItem.TabIndex = 3;
            lblNivelItem.Text = "Nivel del Item";
            // 
            // lblStatsItem
            // 
            lblStatsItem.Location = new Point(7, 332);
            lblStatsItem.Margin = new Padding(4, 0, 4, 0);
            lblStatsItem.Name = "lblStatsItem";
            lblStatsItem.Size = new Size(426, 30);
            lblStatsItem.TabIndex = 4;
            lblStatsItem.Text = "Stats que otorga";
            // 
            // lsbListaItems
            // 
            lsbListaItems.BorderStyle = BorderStyle.FixedSingle;
            lsbListaItems.FormattingEnabled = true;
            lsbListaItems.ItemHeight = 15;
            lsbListaItems.Location = new Point(7, 22);
            lsbListaItems.Margin = new Padding(4, 3, 4, 3);
            lsbListaItems.Name = "lsbListaItems";
            lsbListaItems.Size = new Size(259, 227);
            lsbListaItems.TabIndex = 5;
            lsbListaItems.SelectedIndexChanged += lsbListaItems_SelectedIndexChanged;
            // 
            // lblHabilidad
            // 
            lblHabilidad.Location = new Point(7, 362);
            lblHabilidad.Margin = new Padding(4, 0, 4, 0);
            lblHabilidad.Name = "lblHabilidad";
            lblHabilidad.Size = new Size(259, 120);
            lblHabilidad.TabIndex = 6;
            lblHabilidad.Text = "Habilidad especial";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDarItemAPJ);
            groupBox1.Controls.Add(lsbListaItems);
            groupBox1.Controls.Add(btnGenerarItem);
            groupBox1.Controls.Add(lblHabilidad);
            groupBox1.Controls.Add(lblNombreItem);
            groupBox1.Controls.Add(lblStatsItem);
            groupBox1.Controls.Add(lblTipoItem);
            groupBox1.Controls.Add(lblNivelItem);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(601, 498);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // btnDarItemAPJ
            // 
            btnDarItemAPJ.Location = new Point(273, 119);
            btnDarItemAPJ.Margin = new Padding(4, 3, 4, 3);
            btnDarItemAPJ.Name = "btnDarItemAPJ";
            btnDarItemAPJ.Size = new Size(321, 90);
            btnDarItemAPJ.TabIndex = 7;
            btnDarItemAPJ.Text = "Dar item al PJ seleccionado";
            btnDarItemAPJ.UseVisualStyleBackColor = true;
            btnDarItemAPJ.Click += btnDarItemAPJ_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblListaHabilidadesPJ);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnQuitarManoIzquierda);
            groupBox2.Controls.Add(btnQuitarManoDerecha);
            groupBox2.Controls.Add(lblItemManoIzquierda);
            groupBox2.Controls.Add(lblItemManoDerecha);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblEspecializacion);
            groupBox2.Controls.Add(lblElemento);
            groupBox2.Controls.Add(lblClase);
            groupBox2.Controls.Add(lbListaPJ);
            groupBox2.Controls.Add(btnGenerarPJ);
            groupBox2.Controls.Add(tbNivel);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblCONPJ);
            groupBox2.Controls.Add(lblMAGPJ);
            groupBox2.Controls.Add(lblSUEPJ);
            groupBox2.Controls.Add(lblRESPJ);
            groupBox2.Controls.Add(lblFUEPJ);
            groupBox2.Controls.Add(lblAGIPJ);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblStats);
            groupBox2.Controls.Add(lblFuerzaPersonaje);
            groupBox2.Controls.Add(lblNombrePersonaje);
            groupBox2.Controls.Add(btnSiguientePersonaje);
            groupBox2.Controls.Add(btnAnteriorPersonaje);
            groupBox2.Controls.Add(pbImagenPJ);
            groupBox2.Location = new Point(972, 14);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(862, 498);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personajes";
            // 
            // lblListaHabilidadesPJ
            // 
            lblListaHabilidadesPJ.Location = new Point(14, 312);
            lblListaHabilidadesPJ.Margin = new Padding(4, 0, 4, 0);
            lblListaHabilidadesPJ.Name = "lblListaHabilidadesPJ";
            lblListaHabilidadesPJ.Size = new Size(323, 177);
            lblListaHabilidadesPJ.TabIndex = 30;
            lblListaHabilidadesPJ.Text = "Ninguna";
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label9.Location = new Point(7, 273);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 27);
            label9.TabIndex = 29;
            label9.Text = "Habilidades:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnQuitarManoIzquierda
            // 
            btnQuitarManoIzquierda.Location = new Point(793, 128);
            btnQuitarManoIzquierda.Margin = new Padding(4, 3, 4, 3);
            btnQuitarManoIzquierda.Name = "btnQuitarManoIzquierda";
            btnQuitarManoIzquierda.Size = new Size(62, 27);
            btnQuitarManoIzquierda.TabIndex = 28;
            btnQuitarManoIzquierda.Text = "Quitar";
            btnQuitarManoIzquierda.UseVisualStyleBackColor = true;
            btnQuitarManoIzquierda.Click += btnQuitarManoIzquierda_Click;
            // 
            // btnQuitarManoDerecha
            // 
            btnQuitarManoDerecha.Location = new Point(793, 75);
            btnQuitarManoDerecha.Margin = new Padding(4, 3, 4, 3);
            btnQuitarManoDerecha.Name = "btnQuitarManoDerecha";
            btnQuitarManoDerecha.Size = new Size(62, 27);
            btnQuitarManoDerecha.TabIndex = 27;
            btnQuitarManoDerecha.Text = "Quitar";
            btnQuitarManoDerecha.UseVisualStyleBackColor = true;
            btnQuitarManoDerecha.Click += btnQuitarManoDerecha_Click;
            // 
            // lblItemManoIzquierda
            // 
            lblItemManoIzquierda.AutoSize = true;
            lblItemManoIzquierda.Location = new Point(670, 134);
            lblItemManoIzquierda.Margin = new Padding(4, 0, 4, 0);
            lblItemManoIzquierda.Name = "lblItemManoIzquierda";
            lblItemManoIzquierda.Size = new Size(35, 15);
            lblItemManoIzquierda.TabIndex = 26;
            lblItemManoIzquierda.Text = "Nada";
            // 
            // lblItemManoDerecha
            // 
            lblItemManoDerecha.AutoSize = true;
            lblItemManoDerecha.Location = new Point(670, 81);
            lblItemManoDerecha.Margin = new Padding(4, 0, 4, 0);
            lblItemManoDerecha.Name = "lblItemManoDerecha";
            lblItemManoDerecha.Size = new Size(35, 15);
            lblItemManoDerecha.TabIndex = 25;
            lblItemManoDerecha.Text = "Nada";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label8.Location = new Point(531, 128);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(132, 27);
            label8.TabIndex = 24;
            label8.Text = "Mano Izquierda:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label7.Location = new Point(531, 75);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 27);
            label7.TabIndex = 23;
            label7.Text = "Mano Derecha:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEspecializacion
            // 
            lblEspecializacion.Font = new Font("Microsoft Sans Serif", 9.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblEspecializacion.Location = new Point(98, 192);
            lblEspecializacion.Margin = new Padding(4, 0, 4, 0);
            lblEspecializacion.Name = "lblEspecializacion";
            lblEspecializacion.Size = new Size(148, 27);
            lblEspecializacion.TabIndex = 22;
            lblEspecializacion.Text = "Especialización";
            lblEspecializacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblElemento
            // 
            lblElemento.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblElemento.Location = new Point(253, 192);
            lblElemento.Margin = new Padding(4, 0, 4, 0);
            lblElemento.Name = "lblElemento";
            lblElemento.Size = new Size(80, 27);
            lblElemento.TabIndex = 21;
            lblElemento.Text = "Elemento";
            lblElemento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClase
            // 
            lblClase.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblClase.Location = new Point(10, 192);
            lblClase.Margin = new Padding(4, 0, 4, 0);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(80, 27);
            lblClase.TabIndex = 20;
            lblClase.Text = "Clase";
            lblClase.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbListaPJ
            // 
            lbListaPJ.BorderStyle = BorderStyle.FixedSingle;
            lbListaPJ.FormattingEnabled = true;
            lbListaPJ.ItemHeight = 15;
            lbListaPJ.Location = new Point(344, 345);
            lbListaPJ.Margin = new Padding(4, 3, 4, 3);
            lbListaPJ.Name = "lbListaPJ";
            lbListaPJ.Size = new Size(179, 137);
            lbListaPJ.TabIndex = 7;
            lbListaPJ.SelectedIndexChanged += lbListaPJ_SelectedIndexChanged;
            // 
            // btnGenerarPJ
            // 
            btnGenerarPJ.Location = new Point(341, 306);
            btnGenerarPJ.Margin = new Padding(4, 3, 4, 3);
            btnGenerarPJ.Name = "btnGenerarPJ";
            btnGenerarPJ.Size = new Size(183, 27);
            btnGenerarPJ.TabIndex = 19;
            btnGenerarPJ.Text = "Generar PJ";
            btnGenerarPJ.UseVisualStyleBackColor = true;
            btnGenerarPJ.Click += btnGenerarPJ_Click;
            // 
            // tbNivel
            // 
            tbNivel.Location = new Point(135, 226);
            tbNivel.Margin = new Padding(4, 3, 4, 3);
            tbNivel.Name = "tbNivel";
            tbNivel.Size = new Size(76, 23);
            tbNivel.TabIndex = 18;
            tbNivel.TextAlign = HorizontalAlignment.Center;
            tbNivel.KeyPress += tbNivel_KeyPress;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Microsoft Sans Serif", 9.4F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label6.Location = new Point(531, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(324, 42);
            label6.TabIndex = 17;
            label6.Text = "Equipación";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCONPJ
            // 
            lblCONPJ.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblCONPJ.Location = new Point(253, 102);
            lblCONPJ.Margin = new Padding(4, 0, 4, 0);
            lblCONPJ.Name = "lblCONPJ";
            lblCONPJ.Size = new Size(80, 27);
            lblCONPJ.TabIndex = 16;
            lblCONPJ.Text = "0";
            lblCONPJ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMAGPJ
            // 
            lblMAGPJ.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblMAGPJ.Location = new Point(132, 155);
            lblMAGPJ.Margin = new Padding(4, 0, 4, 0);
            lblMAGPJ.Name = "lblMAGPJ";
            lblMAGPJ.Size = new Size(80, 27);
            lblMAGPJ.TabIndex = 15;
            lblMAGPJ.Text = "0";
            lblMAGPJ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSUEPJ
            // 
            lblSUEPJ.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblSUEPJ.Location = new Point(253, 155);
            lblSUEPJ.Margin = new Padding(4, 0, 4, 0);
            lblSUEPJ.Name = "lblSUEPJ";
            lblSUEPJ.Size = new Size(80, 27);
            lblSUEPJ.TabIndex = 14;
            lblSUEPJ.Text = "0";
            lblSUEPJ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRESPJ
            // 
            lblRESPJ.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblRESPJ.Location = new Point(132, 102);
            lblRESPJ.Margin = new Padding(4, 0, 4, 0);
            lblRESPJ.Name = "lblRESPJ";
            lblRESPJ.Size = new Size(80, 27);
            lblRESPJ.TabIndex = 13;
            lblRESPJ.Text = "0";
            lblRESPJ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFUEPJ
            // 
            lblFUEPJ.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblFUEPJ.Location = new Point(10, 102);
            lblFUEPJ.Margin = new Padding(4, 0, 4, 0);
            lblFUEPJ.Name = "lblFUEPJ";
            lblFUEPJ.Size = new Size(80, 27);
            lblFUEPJ.TabIndex = 12;
            lblFUEPJ.Text = "0";
            lblFUEPJ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAGIPJ
            // 
            lblAGIPJ.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblAGIPJ.Location = new Point(10, 155);
            lblAGIPJ.Margin = new Padding(4, 0, 4, 0);
            lblAGIPJ.Name = "lblAGIPJ";
            lblAGIPJ.Size = new Size(80, 27);
            lblAGIPJ.TabIndex = 11;
            lblAGIPJ.Text = "0";
            lblAGIPJ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.Location = new Point(132, 128);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 27);
            label5.TabIndex = 10;
            label5.Text = "MAG";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.Location = new Point(253, 128);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 27);
            label4.TabIndex = 9;
            label4.Text = "SUE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.Location = new Point(10, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 27);
            label3.TabIndex = 8;
            label3.Text = "AGI";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.Location = new Point(253, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 27);
            label2.TabIndex = 7;
            label2.Text = "CON";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(132, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 27);
            label1.TabIndex = 6;
            label1.Text = "RES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStats
            // 
            lblStats.BackColor = Color.White;
            lblStats.Font = new Font("Microsoft Sans Serif", 9.4F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblStats.Location = new Point(10, 22);
            lblStats.Margin = new Padding(4, 0, 4, 0);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(323, 42);
            lblStats.TabIndex = 5;
            lblStats.Text = "Stats";
            lblStats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFuerzaPersonaje
            // 
            lblFuerzaPersonaje.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblFuerzaPersonaje.Location = new Point(10, 75);
            lblFuerzaPersonaje.Margin = new Padding(4, 0, 4, 0);
            lblFuerzaPersonaje.Name = "lblFuerzaPersonaje";
            lblFuerzaPersonaje.Size = new Size(80, 27);
            lblFuerzaPersonaje.TabIndex = 4;
            lblFuerzaPersonaje.Text = "FUE";
            lblFuerzaPersonaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombrePersonaje
            // 
            lblNombrePersonaje.BackColor = Color.White;
            lblNombrePersonaje.Location = new Point(341, 271);
            lblNombrePersonaje.Margin = new Padding(4, 0, 4, 0);
            lblNombrePersonaje.Name = "lblNombrePersonaje";
            lblNombrePersonaje.Size = new Size(183, 21);
            lblNombrePersonaje.TabIndex = 3;
            lblNombrePersonaje.Text = "Nombre PJ";
            lblNombrePersonaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSiguientePersonaje
            // 
            btnSiguientePersonaje.Location = new Point(531, 271);
            btnSiguientePersonaje.Margin = new Padding(4, 3, 4, 3);
            btnSiguientePersonaje.Name = "btnSiguientePersonaje";
            btnSiguientePersonaje.Size = new Size(23, 23);
            btnSiguientePersonaje.TabIndex = 2;
            btnSiguientePersonaje.Text = ">";
            btnSiguientePersonaje.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorPersonaje
            // 
            btnAnteriorPersonaje.Location = new Point(310, 271);
            btnAnteriorPersonaje.Margin = new Padding(4, 3, 4, 3);
            btnAnteriorPersonaje.Name = "btnAnteriorPersonaje";
            btnAnteriorPersonaje.Size = new Size(23, 23);
            btnAnteriorPersonaje.TabIndex = 1;
            btnAnteriorPersonaje.Text = "<";
            btnAnteriorPersonaje.UseVisualStyleBackColor = true;
            // 
            // pbImagenPJ
            // 
            pbImagenPJ.BackColor = Color.White;
            pbImagenPJ.Image = Properties.Resources.dummy;
            pbImagenPJ.InitialImage = (Image)resources.GetObject("pbImagenPJ.InitialImage");
            pbImagenPJ.Location = new Point(341, 22);
            pbImagenPJ.Margin = new Padding(4, 3, 4, 3);
            pbImagenPJ.Name = "pbImagenPJ";
            pbImagenPJ.Size = new Size(183, 242);
            pbImagenPJ.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenPJ.TabIndex = 0;
            pbImagenPJ.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRevivirEnemigo);
            groupBox3.Controls.Add(btnDefenderseDeEnemigo);
            groupBox3.Controls.Add(lblNombreEnemigo);
            groupBox3.Controls.Add(lblLogAtaque);
            groupBox3.Controls.Add(btnAtacar);
            groupBox3.Location = new Point(622, 14);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(343, 498);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Log de Ataque";
            // 
            // btnRevivirEnemigo
            // 
            btnRevivirEnemigo.Location = new Point(7, 357);
            btnRevivirEnemigo.Margin = new Padding(4, 3, 4, 3);
            btnRevivirEnemigo.Name = "btnRevivirEnemigo";
            btnRevivirEnemigo.Size = new Size(329, 27);
            btnRevivirEnemigo.TabIndex = 4;
            btnRevivirEnemigo.Text = "Revivir";
            btnRevivirEnemigo.UseVisualStyleBackColor = true;
            // 
            // btnDefenderseDeEnemigo
            // 
            btnDefenderseDeEnemigo.Location = new Point(172, 323);
            btnDefenderseDeEnemigo.Margin = new Padding(4, 3, 4, 3);
            btnDefenderseDeEnemigo.Name = "btnDefenderseDeEnemigo";
            btnDefenderseDeEnemigo.Size = new Size(164, 27);
            btnDefenderseDeEnemigo.TabIndex = 3;
            btnDefenderseDeEnemigo.Text = "Defenderse";
            btnDefenderseDeEnemigo.UseVisualStyleBackColor = true;
            // 
            // lblNombreEnemigo
            // 
            lblNombreEnemigo.AutoSize = true;
            lblNombreEnemigo.Location = new Point(10, 23);
            lblNombreEnemigo.Margin = new Padding(4, 0, 4, 0);
            lblNombreEnemigo.Name = "lblNombreEnemigo";
            lblNombreEnemigo.Size = new Size(0, 15);
            lblNombreEnemigo.TabIndex = 2;
            // 
            // lblLogAtaque
            // 
            lblLogAtaque.BackColor = Color.White;
            lblLogAtaque.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblLogAtaque.Location = new Point(7, 387);
            lblLogAtaque.Margin = new Padding(4, 0, 4, 0);
            lblLogAtaque.Name = "lblLogAtaque";
            lblLogAtaque.Size = new Size(329, 96);
            lblLogAtaque.TabIndex = 1;
            // 
            // btnAtacar
            // 
            btnAtacar.Location = new Point(7, 323);
            btnAtacar.Margin = new Padding(4, 3, 4, 3);
            btnAtacar.Name = "btnAtacar";
            btnAtacar.Size = new Size(158, 27);
            btnAtacar.TabIndex = 0;
            btnAtacar.Text = "Atacar";
            btnAtacar.UseVisualStyleBackColor = true;
            btnAtacar.Click += btnAtacar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblHPEnemigo);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(lblHPAspirante);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(btnIniciarCombate);
            groupBox4.Controls.Add(tbLogCombate);
            groupBox4.Controls.Add(lblVitEnemigo);
            groupBox4.Controls.Add(lblMagEnemigo);
            groupBox4.Controls.Add(lblSueEnemigo);
            groupBox4.Controls.Add(lblResEnemigo);
            groupBox4.Controls.Add(lblFueEnemigo);
            groupBox4.Controls.Add(lblAgiEnemigo);
            groupBox4.Controls.Add(label28);
            groupBox4.Controls.Add(label29);
            groupBox4.Controls.Add(label30);
            groupBox4.Controls.Add(label31);
            groupBox4.Controls.Add(label32);
            groupBox4.Controls.Add(label33);
            groupBox4.Controls.Add(lblVitAspirante);
            groupBox4.Controls.Add(lblMagAspirante);
            groupBox4.Controls.Add(lblSueAspirante);
            groupBox4.Controls.Add(lblResAspirante);
            groupBox4.Controls.Add(lblFueAspirante);
            groupBox4.Controls.Add(lblAgiAspirante);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(lbListaEnemigos);
            groupBox4.Controls.Add(lbListaAspirantes);
            groupBox4.Controls.Add(btnGenerarAspirante);
            groupBox4.Controls.Add(btnGenerarEnemigo);
            groupBox4.Location = new Point(14, 519);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(1820, 519);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rework Coliseo";
            // 
            // lblHPEnemigo
            // 
            lblHPEnemigo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblHPEnemigo.Location = new Point(1283, 167);
            lblHPEnemigo.Margin = new Padding(4, 0, 4, 0);
            lblHPEnemigo.Name = "lblHPEnemigo";
            lblHPEnemigo.Size = new Size(80, 27);
            lblHPEnemigo.TabIndex = 49;
            lblHPEnemigo.Text = "0";
            lblHPEnemigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label12.Location = new Point(1283, 141);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(80, 27);
            label12.TabIndex = 48;
            label12.Text = "HP";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHPAspirante
            // 
            lblHPAspirante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblHPAspirante.Location = new Point(456, 167);
            lblHPAspirante.Margin = new Padding(4, 0, 4, 0);
            lblHPAspirante.Name = "lblHPAspirante";
            lblHPAspirante.Size = new Size(80, 27);
            lblHPAspirante.TabIndex = 47;
            lblHPAspirante.Text = "0";
            lblHPAspirante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label11.Location = new Point(456, 141);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(80, 27);
            label11.TabIndex = 46;
            label11.Text = "HP";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciarCombate
            // 
            btnIniciarCombate.Enabled = false;
            btnIniciarCombate.Location = new Point(715, 290);
            btnIniciarCombate.Margin = new Padding(4, 3, 4, 3);
            btnIniciarCombate.Name = "btnIniciarCombate";
            btnIniciarCombate.Size = new Size(385, 77);
            btnIniciarCombate.TabIndex = 45;
            btnIniciarCombate.Text = "Iniciar Combate";
            btnIniciarCombate.UseVisualStyleBackColor = true;
            btnIniciarCombate.Click += btnIniciarCombate_Click;
            // 
            // tbLogCombate
            // 
            tbLogCombate.Location = new Point(715, 54);
            tbLogCombate.Margin = new Padding(4, 3, 4, 3);
            tbLogCombate.Multiline = true;
            tbLogCombate.Name = "tbLogCombate";
            tbLogCombate.ScrollBars = ScrollBars.Vertical;
            tbLogCombate.Size = new Size(384, 228);
            tbLogCombate.TabIndex = 42;
            // 
            // lblVitEnemigo
            // 
            lblVitEnemigo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblVitEnemigo.Location = new Point(1371, 141);
            lblVitEnemigo.Margin = new Padding(4, 0, 4, 0);
            lblVitEnemigo.Name = "lblVitEnemigo";
            lblVitEnemigo.Size = new Size(80, 27);
            lblVitEnemigo.TabIndex = 40;
            lblVitEnemigo.Text = "0";
            lblVitEnemigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMagEnemigo
            // 
            lblMagEnemigo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblMagEnemigo.Location = new Point(1546, 194);
            lblMagEnemigo.Margin = new Padding(4, 0, 4, 0);
            lblMagEnemigo.Name = "lblMagEnemigo";
            lblMagEnemigo.Size = new Size(80, 27);
            lblMagEnemigo.TabIndex = 39;
            lblMagEnemigo.Text = "0";
            lblMagEnemigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSueEnemigo
            // 
            lblSueEnemigo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblSueEnemigo.Location = new Point(1371, 194);
            lblSueEnemigo.Margin = new Padding(4, 0, 4, 0);
            lblSueEnemigo.Name = "lblSueEnemigo";
            lblSueEnemigo.Size = new Size(80, 27);
            lblSueEnemigo.TabIndex = 38;
            lblSueEnemigo.Text = "0";
            lblSueEnemigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResEnemigo
            // 
            lblResEnemigo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblResEnemigo.Location = new Point(1458, 141);
            lblResEnemigo.Margin = new Padding(4, 0, 4, 0);
            lblResEnemigo.Name = "lblResEnemigo";
            lblResEnemigo.Size = new Size(80, 27);
            lblResEnemigo.TabIndex = 37;
            lblResEnemigo.Text = "0";
            lblResEnemigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFueEnemigo
            // 
            lblFueEnemigo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblFueEnemigo.Location = new Point(1546, 141);
            lblFueEnemigo.Margin = new Padding(4, 0, 4, 0);
            lblFueEnemigo.Name = "lblFueEnemigo";
            lblFueEnemigo.Size = new Size(80, 27);
            lblFueEnemigo.TabIndex = 36;
            lblFueEnemigo.Text = "0";
            lblFueEnemigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAgiEnemigo
            // 
            lblAgiEnemigo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblAgiEnemigo.Location = new Point(1458, 194);
            lblAgiEnemigo.Margin = new Padding(4, 0, 4, 0);
            lblAgiEnemigo.Name = "lblAgiEnemigo";
            lblAgiEnemigo.Size = new Size(80, 27);
            lblAgiEnemigo.TabIndex = 35;
            lblAgiEnemigo.Text = "0";
            lblAgiEnemigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label28.Location = new Point(1546, 167);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(80, 27);
            label28.TabIndex = 34;
            label28.Text = "MAG";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label29.Location = new Point(1371, 167);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(80, 27);
            label29.TabIndex = 33;
            label29.Text = "SUE";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            label30.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label30.Location = new Point(1458, 167);
            label30.Margin = new Padding(4, 0, 4, 0);
            label30.Name = "label30";
            label30.Size = new Size(80, 27);
            label30.TabIndex = 32;
            label30.Text = "AGI";
            label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            label31.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label31.Location = new Point(1371, 114);
            label31.Margin = new Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new Size(80, 27);
            label31.TabIndex = 31;
            label31.Text = "VIT";
            label31.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            label32.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label32.Location = new Point(1458, 114);
            label32.Margin = new Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new Size(80, 27);
            label32.TabIndex = 30;
            label32.Text = "RES";
            label32.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label33.Location = new Point(1546, 114);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(80, 27);
            label33.TabIndex = 29;
            label33.Text = "FUE";
            label33.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVitAspirante
            // 
            lblVitAspirante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblVitAspirante.Location = new Point(369, 141);
            lblVitAspirante.Margin = new Padding(4, 0, 4, 0);
            lblVitAspirante.Name = "lblVitAspirante";
            lblVitAspirante.Size = new Size(80, 27);
            lblVitAspirante.TabIndex = 28;
            lblVitAspirante.Text = "0";
            lblVitAspirante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMagAspirante
            // 
            lblMagAspirante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblMagAspirante.Location = new Point(194, 194);
            lblMagAspirante.Margin = new Padding(4, 0, 4, 0);
            lblMagAspirante.Name = "lblMagAspirante";
            lblMagAspirante.Size = new Size(80, 27);
            lblMagAspirante.TabIndex = 27;
            lblMagAspirante.Text = "0";
            lblMagAspirante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSueAspirante
            // 
            lblSueAspirante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblSueAspirante.Location = new Point(369, 194);
            lblSueAspirante.Margin = new Padding(4, 0, 4, 0);
            lblSueAspirante.Name = "lblSueAspirante";
            lblSueAspirante.Size = new Size(80, 27);
            lblSueAspirante.TabIndex = 26;
            lblSueAspirante.Text = "0";
            lblSueAspirante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResAspirante
            // 
            lblResAspirante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblResAspirante.Location = new Point(281, 141);
            lblResAspirante.Margin = new Padding(4, 0, 4, 0);
            lblResAspirante.Name = "lblResAspirante";
            lblResAspirante.Size = new Size(80, 27);
            lblResAspirante.TabIndex = 25;
            lblResAspirante.Text = "0";
            lblResAspirante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFueAspirante
            // 
            lblFueAspirante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblFueAspirante.Location = new Point(194, 141);
            lblFueAspirante.Margin = new Padding(4, 0, 4, 0);
            lblFueAspirante.Name = "lblFueAspirante";
            lblFueAspirante.Size = new Size(80, 27);
            lblFueAspirante.TabIndex = 24;
            lblFueAspirante.Text = "0";
            lblFueAspirante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAgiAspirante
            // 
            lblAgiAspirante.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lblAgiAspirante.Location = new Point(281, 194);
            lblAgiAspirante.Margin = new Padding(4, 0, 4, 0);
            lblAgiAspirante.Name = "lblAgiAspirante";
            lblAgiAspirante.Size = new Size(80, 27);
            lblAgiAspirante.TabIndex = 23;
            lblAgiAspirante.Text = "0";
            lblAgiAspirante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label16.Location = new Point(194, 167);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(80, 27);
            label16.TabIndex = 22;
            label16.Text = "MAG";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label17.Location = new Point(369, 167);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(80, 27);
            label17.TabIndex = 21;
            label17.Text = "SUE";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label18.Location = new Point(281, 167);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(80, 27);
            label18.TabIndex = 20;
            label18.Text = "AGI";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label19.Location = new Point(369, 114);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(80, 27);
            label19.TabIndex = 19;
            label19.Text = "VIT";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label20.Location = new Point(281, 114);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(80, 27);
            label20.TabIndex = 18;
            label20.Text = "RES";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label21.Location = new Point(194, 114);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(80, 27);
            label21.TabIndex = 17;
            label21.Text = "FUE";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbListaEnemigos
            // 
            lbListaEnemigos.BorderStyle = BorderStyle.FixedSingle;
            lbListaEnemigos.FormattingEnabled = true;
            lbListaEnemigos.ItemHeight = 15;
            lbListaEnemigos.Location = new Point(1633, 114);
            lbListaEnemigos.Margin = new Padding(4, 3, 4, 3);
            lbListaEnemigos.Name = "lbListaEnemigos";
            lbListaEnemigos.Size = new Size(179, 137);
            lbListaEnemigos.TabIndex = 9;
            lbListaEnemigos.SelectedIndexChanged += lbListaEnemigos_SelectedIndexChanged;
            // 
            // lbListaAspirantes
            // 
            lbListaAspirantes.BorderStyle = BorderStyle.FixedSingle;
            lbListaAspirantes.FormattingEnabled = true;
            lbListaAspirantes.ItemHeight = 15;
            lbListaAspirantes.Location = new Point(7, 114);
            lbListaAspirantes.Margin = new Padding(4, 3, 4, 3);
            lbListaAspirantes.Name = "lbListaAspirantes";
            lbListaAspirantes.Size = new Size(179, 137);
            lbListaAspirantes.TabIndex = 8;
            lbListaAspirantes.SelectedIndexChanged += lbListaAspirantes_SelectedIndexChanged;
            // 
            // btnGenerarAspirante
            // 
            btnGenerarAspirante.Location = new Point(7, 22);
            btnGenerarAspirante.Margin = new Padding(4, 3, 4, 3);
            btnGenerarAspirante.Name = "btnGenerarAspirante";
            btnGenerarAspirante.Size = new Size(180, 85);
            btnGenerarAspirante.TabIndex = 1;
            btnGenerarAspirante.Text = "Generar Aspirante";
            btnGenerarAspirante.UseVisualStyleBackColor = true;
            btnGenerarAspirante.Click += btnGenerarAspirante_Click;
            // 
            // btnGenerarEnemigo
            // 
            btnGenerarEnemigo.Location = new Point(1633, 22);
            btnGenerarEnemigo.Margin = new Padding(4, 3, 4, 3);
            btnGenerarEnemigo.Name = "btnGenerarEnemigo";
            btnGenerarEnemigo.Size = new Size(180, 85);
            btnGenerarEnemigo.TabIndex = 0;
            btnGenerarEnemigo.Text = "Generar Enemigo";
            btnGenerarEnemigo.UseVisualStyleBackColor = true;
            btnGenerarEnemigo.Click += btnGenerarEnemigo_click;
            // 
            // FormAlgoritmoRPG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1848, 1051);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAlgoritmoRPG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pruebas de Algoritmos y Elementos RPG";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenPJ).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarItem;
        private System.Windows.Forms.Label lblNombreItem;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.Label lblNivelItem;
        private System.Windows.Forms.Label lblStatsItem;
        private System.Windows.Forms.ListBox lsbListaItems;
        private System.Windows.Forms.Label lblHabilidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCONPJ;
        private System.Windows.Forms.Label lblMAGPJ;
        private System.Windows.Forms.Label lblSUEPJ;
        private System.Windows.Forms.Label lblRESPJ;
        private System.Windows.Forms.Label lblFUEPJ;
        private System.Windows.Forms.Label lblAGIPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblFuerzaPersonaje;
        private System.Windows.Forms.Label lblNombrePersonaje;
        private System.Windows.Forms.Button btnSiguientePersonaje;
        private System.Windows.Forms.Button btnAnteriorPersonaje;
        private System.Windows.Forms.PictureBox pbImagenPJ;
        private System.Windows.Forms.ListBox lbListaPJ;
        private System.Windows.Forms.Button btnGenerarPJ;
        private System.Windows.Forms.Label lblEspecializacion;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Button btnDarItemAPJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblItemManoIzquierda;
        private System.Windows.Forms.Label lblItemManoDerecha;
        private System.Windows.Forms.Button btnQuitarManoIzquierda;
        private System.Windows.Forms.Button btnQuitarManoDerecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLogAtaque;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblListaHabilidadesPJ;
        private System.Windows.Forms.Label lblNombreEnemigo;
        private System.Windows.Forms.Button btnDefenderseDeEnemigo;
        private System.Windows.Forms.Button btnRevivirEnemigo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGenerarEnemigo;
        private System.Windows.Forms.Button btnGenerarAspirante;
        private System.Windows.Forms.ListBox lbListaEnemigos;
        private System.Windows.Forms.ListBox lbListaAspirantes;
        private System.Windows.Forms.Label lblVitEnemigo;
        private System.Windows.Forms.Label lblMagEnemigo;
        private System.Windows.Forms.Label lblSueEnemigo;
        private System.Windows.Forms.Label lblResEnemigo;
        private System.Windows.Forms.Label lblFueEnemigo;
        private System.Windows.Forms.Label lblAgiEnemigo;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblVitAspirante;
        private System.Windows.Forms.Label lblMagAspirante;
        private System.Windows.Forms.Label lblSueAspirante;
        private System.Windows.Forms.Label lblResAspirante;
        private System.Windows.Forms.Label lblFueAspirante;
        private System.Windows.Forms.Label lblAgiAspirante;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbLogCombate;
        private System.Windows.Forms.Button btnIniciarCombate;
        private System.Windows.Forms.Label lblHPEnemigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHPAspirante;
        private System.Windows.Forms.Label label11;
    }
}
