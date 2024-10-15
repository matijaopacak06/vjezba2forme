using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Forme_vjezba
{
    public partial class Form1 : Form
    {
        UnosNovogStudenta frm = new UnosNovogStudenta();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogResult rez = frm.ShowDialog();

            // unos novog studenta u listBox

            if (rez == System.Windows.Forms.DialogResult.OK)

                listBox.Items.Add(frm.Student1.ToString());
        }

        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (!(listBox.SelectedIndex < 0))

                listBox.Items.RemoveAt(listBox.SelectedIndex);

        }
    }
    }

