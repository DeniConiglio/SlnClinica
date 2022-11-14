using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Models.derivada;
using Microsoft.VisualBasic;

namespace WindowsAppClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearPediatra_Click(object sender, EventArgs e)
        {
            string NombrePediatra = (Interaction.InputBox("Ingrese Nombre"));
            string ApellidoPediatra = (Interaction.InputBox("Ingrese Apellido"));
            int NumMatriculaPediatra =Convert.ToInt32 (Interaction.InputBox("Ingrese Numero de Matricula"));
            string DniPediatra = (Interaction.InputBox("Ingrese DNI"));
            DateTime FechaNacimientoPediatra =Convert.ToDateTime (Interaction.InputBox("Ingrese Fecha de Nacimiento"));


            MessageBox.Show($"Nombre: {NombrePediatra} \nApellido: {ApellidoPediatra} \nNumero de matricula: {NumMatriculaPediatra} \nDNI: {DniPediatra} \nFecha de nacimiento: {FechaNacimientoPediatra}");
        }

        
    }
}
