using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_alumno_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            notasPolitecnicoInternacionalEntities db = new notasPolitecnicoInternacionalEntities();
            tecnologiaDesarrolloSoftware nuevoAlumno = new tecnologiaDesarrolloSoftware();
            nuevoAlumno.CodigoAlumno = txb_id.Text;
            nuevoAlumno.Nombre_Alumnos = txb_ne.Text;
            nuevoAlumno.Nota_primer_corte = decimal.Parse(txb_n1.Text);
            nuevoAlumno.Nota_segundo_corte = decimal.Parse(txb_n2.Text);
            nuevoAlumno.Nota_tercer_corte = decimal.Parse(txb_n3.Text);
            nuevoAlumno.Nota_Final = (nuevoAlumno.Nota_primer_corte * (decimal)0.35 + nuevoAlumno.Nota_segundo_corte * (decimal)0.35 + nuevoAlumno.Nota_tercer_corte * (decimal)0.30);
            db.tecnologiaDesarrolloSoftware.Add(nuevoAlumno);
            db.SaveChanges();
            txb_NF.Text = nuevoAlumno.Nota_Final.ToString("###,###.#");
            MessageBox.Show("Datos grabados");
        }
    }
}
