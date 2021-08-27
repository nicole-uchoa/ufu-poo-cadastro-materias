using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroMaterias
{
    public partial class Form1 : Form
    {
        private List<Aluno> alunos = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alunos.Add(new Aluno()
            {
                Nome = textBox1.Text
            });
            comboBox1.Items.Add(textBox1.Text);
            comboBox2.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string alunoSelecionado = comboBox1.SelectedItem.ToString();
            foreach (Aluno aluno in alunos)
            {
                if (aluno.Nome == alunoSelecionado)
                {
                    aluno.Materias.Add(textBox2.Text);
                    textBox2.Clear();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usuarioSelecionado = comboBox2.SelectedItem.ToString();
            listView1.Items.Clear();
            foreach (Aluno aluno in alunos)
            {
                if (aluno.Nome == usuarioSelecionado)
                {
                    foreach (String materia in aluno.Materias)
                    {
                        listView1.Items.Add(materia);
                    }

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuarioSelecionado = comboBox2.SelectedItem.ToString();
            foreach (Aluno aluno in alunos)
            {
                if (aluno.Nome == usuarioSelecionado)
                {
                    aluno.Materias.Clear();
                    listView1.Items.Clear();
                }
            }
        }
    }
}
