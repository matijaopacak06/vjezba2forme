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
    public partial class UnosNovogStudenta : Form
    {
        private Student student1;

        internal Student Student1 { get => student1; set => student1 = value; }

        private UnosNovogStudenta(Student student1)
        {
            this.student1 = student1;
        }
     


        public UnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void txtBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void UnosNovogStudenta_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            student1 = new Student();

            // pristup odgovarajucim atrubutima klase Student

            student1.Ime = txtBoxIme.Text;

            student1.Prezime = txtBoxPrezime.Text;

            student1.BrojIndeksa = txtBoxBrojIndeksa.Text;

            student1.Smjer = comboBox1.SelectedItem.ToString();

            student1.DatumRodjenja =
            DateTimePickerDatumRodjenja.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
