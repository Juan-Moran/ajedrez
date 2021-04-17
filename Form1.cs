using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_caballo_Ajedrez
{
    public partial class Form1 : Form
    {
        public class Pieza_ajedrez
        {
            private bool Color;
            private int tipo;
            private int numero;
            private int posicion_x;
            private int posicion_y;
            //----------------------
            public int poner_x(int _x)
            {
                int todo_bien = 1;

                if (_x > 0 && _x < 9)
                {
                    this.posicion_x = _x;
                }
                else todo_bien = 0;
                return todo_bien;
            }
            public void poner_y(int _y)
            {
                this.posicion_y = _y;
            }
            public void poner_pieza(int _x, int _y)
            {
                this.posicion_x = _x;
                this.posicion_y = _y;
            }

            public  Pieza_ajedrez( bool _color, int _tipo, int _num )
            {
                this.Color = _color;
                this.numero = _num;
                this.tipo = _tipo;
            }
        public Boolean verifica_posicion( int x, int y )
            {
                Boolean si_se_puede = false;
                si_se_puede = x > 0 && x < 9;
                si_se_puede = si_se_puede && y > 0 && y < 9;
                return si_se_puede;
            }
	    public String puede_moverse( )
	    {
                String movimientos = "";
                int esta_en_x = this.posicion_x;
                int esta_en_y = this.posicion_y;
                int nueva_x, nueva_y;
                //-----------------------------------------------------
                //empieza por Arriba
                nueva_y = esta_en_y - 2;
                // por la izquierda
                nueva_x = esta_en_x - 1;
                // convertir las coordenadas a cadena "(x,y)"
                if (this.verifica_posicion(nueva_x,nueva_y))
                    movimientos +=String.Format("(" + nueva_x + "," + nueva_y + "){0}",Environment.NewLine);
                // por la derecha
                nueva_x = esta_en_x + 1;
                if (this.verifica_posicion(nueva_x, nueva_y))
                    movimientos += String.Format("(" + nueva_x + "," + nueva_y + "){0}", Environment.NewLine);
                //-----------------------------------------------------
                //empieza por Abajo
                nueva_y = esta_en_y + 2;
                // por la izquierda
                nueva_x = esta_en_x - 1;
                // convertir las coordenadas a cadena "(x,y)"
                if (this.verifica_posicion(nueva_x, nueva_y))
                    movimientos += String.Format("(" + nueva_x + "," + nueva_y + "){0}", Environment.NewLine);
                // por la derecha
                nueva_x = esta_en_x + 1;
                if (this.verifica_posicion(nueva_x, nueva_y))
                    movimientos += String.Format("(" + nueva_x + "," + nueva_y + "){0}", Environment.NewLine);

                //-----------------------------------------------------
                //empieza por Izquierda
                nueva_x = esta_en_x - 2;
                // para arriba
                nueva_y = esta_en_y - 1;
                // convertir las coordenadas a cadena "(x,y)"
                if (this.verifica_posicion(nueva_x, nueva_y))
                    movimientos += String.Format("(" + nueva_x + "," + nueva_y + "){0}", Environment.NewLine);
                // para abajo
                nueva_y = esta_en_y + 1;
                if (this.verifica_posicion(nueva_x, nueva_y))
                    movimientos += String.Format("(" + nueva_x + "," + nueva_y + "){0}", Environment.NewLine);

                //-----------------------------------------------------
                //empieza por Derecha
                nueva_x = esta_en_x + 2;
                // para arriba
                nueva_y = esta_en_y - 1;
                // convertir las coordenadas a cadena "(x,y)"
                if (this.verifica_posicion(nueva_x, nueva_y))
                    movimientos += String.Format("(" + nueva_x + "," + nueva_y + "){0}", Environment.NewLine);
                // para abajo
                nueva_y = esta_en_y + 1;
                if (this.verifica_posicion(nueva_x, nueva_y))
                    movimientos += String.Format("(" + nueva_x + "," + nueva_y + "){0}", Environment.NewLine);
                return movimientos;
	    }

        }
            public Form1()
        {
            

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = caballo_1.puede_moverse();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
