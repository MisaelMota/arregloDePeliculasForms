using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arregloDePeliculasForms
{
    public partial class Form1 : Form
    {
        
        public Form1[] MiPeliculas= new Form1[3];
        int n = 0;

        public string titulo { get; set; }
        public string director { get; set; }
        public string escritor { get; set; }
        public string genero { get; set; }
        public string duracion { get; set; }
        public string clasificacion { get; set; }
        public string productora { get; set; }


        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\LENOVO\OneDrive\Escritorio\Universidad\9no Semestre\Optimización de algoritmos\peliculas.txt", false))
            {
                for (int j = 0; j < MiPeliculas.Length; j++)
                {
                    writer.WriteLine(
                        $"Pelicula numero {j + 1}:\n\n"
                    + $"{MiPeliculas[j].titulo}\n"
                    + $"{MiPeliculas[j].director}\n"
                    + $"{MiPeliculas[j].escritor}\n"
                    + $"{MiPeliculas[j].genero}\n"
                    + $"{MiPeliculas[j].duracion}\n"
                    + $"{MiPeliculas[j].clasificacion}\n"
                    + $"{MiPeliculas[j].productora}\n"



                        );
                }

                writer.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            
            
                leerPeliculas(n);
                n += 1;
           
                

            

        }

        private void leerPeliculas(int i)
        {
            

            
            
                Form1 form1 = new Form1();
                form1.titulo = textBox1.Text;
                form1.director = textBox2.Text;
                form1.escritor = textBox3.Text;
                form1.genero = textBox4.Text;
                form1.duracion = textBox5.Text;
                form1.clasificacion = textBox6.Text;
                form1.productora = textBox7.Text;

                MiPeliculas[i] = form1;

                    dataGridView1.Rows.Add(
                MiPeliculas[i].titulo,
                MiPeliculas[i].director,
                MiPeliculas[i].escritor,
                MiPeliculas[i].genero,
                MiPeliculas[i].duracion,
                MiPeliculas[i].clasificacion,
                MiPeliculas[i].productora);


            

           
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
