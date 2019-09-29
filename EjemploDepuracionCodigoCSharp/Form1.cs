using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDepuracionCodigoCSharp
{
    public partial class Form1 : Form
    {
        FuncionesRelleno funcionesRelleno = new FuncionesRelleno();
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            lvnumeros.Clear();
            lbvalores.Items.Clear();
            funcionesRelleno.setNumero(int.Parse(txtnumero.Text));

            for (int i = 0; i<int.Parse(txtnumero.Text); i++){
                lvnumeros.Items.Add(funcionesRelleno.rellenar()[i].ToString());
            }

            foreach (int valores in funcionesRelleno.rellenar())
            {
                lbvalores.Items.Add(valores.ToString());
            }
        }

        private void btnfibonacci_Click(object sender, EventArgs e)
        {
            lvnumeros.Clear();
            lbvalores.Items.Clear();
            funcionesRelleno.setNumero(int.Parse(txtnumero.Text));

            int a, b, c;
            a = 0;
            b = 1;

            for (int i = 0; i < int.Parse(txtnumero.Text); i++)
            {
                int temp = a;
                fibonacci.Add(a);
                lvnumeros.Items.Add(funcionesRelleno.rellenar()[i].ToString());
                a = b;
                b = temp + b;
            }
        }
    }
}
