using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_1214081
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(900,290);
        }

        private void btPilih_Click(object sender, EventArgs e)
        {
            if (tbNIM.Text == "")
            {
                MessageBox.Show("Harus memasukkan NIM anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbNama.Text == "")
            {
                MessageBox.Show("Harus memasukkan nama anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbAlamat.Text == "")
            {
                MessageBox.Show("Harus memasukkan alamat anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbProdi.Text == "")
            {
                MessageBox.Show("Harus memasukkan program studi anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbTahunAkademik.Text == "")
            {
                MessageBox.Show("Harus memasukkan tahun akademik anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(rbLaki.Checked || rbPerempuan.Checked))
            {
                MessageBox.Show("Harus memasukkan jenis kelamin anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (tbSemester.Text == "")
            {
                MessageBox.Show("Harus memasukkan semester anda!", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                MessageBox.Show("Harus memasukkan tahun akademik dengan benar anda!", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(tbSemester.Text).All(Char.IsNumber))
            {
                MessageBox.Show("Harus memasukkan semester dengan benar anda!", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else
            {
                MessageBox.Show("Lengkap!", "Informasi!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Size = new Size(900, 600);
            }
        }

        private void tbTahunAkademik_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                epWrong.SetError(tbTahunAkademik, "");
                epCorrect.SetError(tbTahunAkademik, "benar");
            }
            else
            {
                epWrong.SetError(tbTahunAkademik, "format harus nnnn/nnnn");
                epCorrect.SetError(tbTahunAkademik, "");
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if ((tbSemester.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(tbSemester, "Betul!");
                epWrong.SetError(tbSemester, "");
            }
            else
            {
                epCorrect.SetError(tbSemester, "");
                epWrong.SetError(tbSemester, "Inputan Hanya Boleh Angka!");
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string kurikulum = "";
            string matkul = "";

            //kurikulum
            if (rb2006.Checked)
            {
                kurikulum = rb2006.Text;
            }
            else if (rb2010.Checked)
            {
                kurikulum = rb2010.Text;
            }
            else if (rb2014.Checked)
            {
                kurikulum = rb2014.Text;
            }

            //matkul
            if (cbMatematika.Checked)
            {
                matkul += cbMatematika.Text + ", ";
            }
            if (cbPemrograman1.Checked)
            {
                matkul += cbPemrograman1.Text + ", ";
            }
            if (cbPemrograman2.Checked)
            {
                matkul += cbPemrograman2.Text + ", ";
            }
            if (cbPemrograman3.Checked)
            {
                matkul += cbPemrograman3.Text + ", ";
            }
            if (cbPemrograman4.Checked)
            {
                matkul += cbPemrograman4.Text + ", ";
            }
            if (cbPemrograman5.Checked)
            {
                matkul += cbPemrograman5.Text + ", ";
            }
            if (cbPemrograman6.Checked)
            {
                matkul += cbPemrograman6.Text + ", ";
            }
            if (cbPemrograman7.Checked)
            {
                matkul += cbPemrograman7.Text + ", ";
            }
            if (cbPengantarLogistik.Checked)
            {
                matkul += cbPengantarLogistik.Text + ", ";
            }
            if (cbJaringanKomputer.Checked)
            {
                matkul += cbJaringanKomputer.Text + ", ";
            }
            if (cbSistemOperasi.Checked)
            {
                matkul += cbSistemOperasi.Text + ", ";
            }
            if (cbManagemenRantaiPasok.Checked)
            {
                matkul += cbManagemenRantaiPasok.Text + ", ";
            }

            //tampilkan
            if (rbLaki.Checked)
            {
                if (rb2006.Checked)
                {
                    MessageBox.Show
                    ("NIM\t\t: " + tbNIM.Text +
                    "\nNama\t\t: " + tbNama.Text +
                    "\nJenis Kelain\t: " + rbLaki.Text +
                    "\nAlamat\t\t: " + tbAlamat.Text +
                    "\nProgram Studi\t: " + cbProdi.Text +
                    "\nTahun Akademik\t: " + tbTahunAkademik.Text +
                    "\nSemester\t\t: " + tbSemester.Text +
                    "\n=======================================" +
                    "\nKurikulum\t: " + kurikulum +
                    "\nMatakuliah\t: " + matkul,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rb2010.Checked)
                {
                    MessageBox.Show
                    ("NIM\t\t: " + tbNIM.Text +
                    "\nNama\t\t: " + tbNama.Text +
                    "\nJenis Kelain\t: " + rbLaki.Text +
                    "\nAlamat\t\t: " + tbAlamat.Text +
                    "\nProgram Studi\t: " + cbProdi.Text +
                    "\nTahun Akademik\t: " + tbTahunAkademik.Text +
                    "\nSemester\t\t: " + tbSemester.Text +
                    "\n=======================================" +
                    "\nKurikulum\t: " + kurikulum +
                    "\nMatakuliah\t: " + matkul,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rb2014.Checked)
                {
                    MessageBox.Show
                    ("NIM\t\t: " + tbNIM.Text +
                    "\nNama\t\t: " + tbNama.Text +
                    "\nJenis Kelain\t: " + rbLaki.Text +
                    "\nAlamat\t\t: " + tbAlamat.Text +
                    "\nProgram Studi\t: " + cbProdi.Text +
                    "\nTahun Akademik\t: " + tbTahunAkademik.Text +
                    "\nSemester\t\t: " + tbSemester.Text +
                    "\n=======================================" +
                    "\nKurikulum\t: " + kurikulum +
                    "\nMatakuliah\t: " + matkul,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rbPerempuan.Checked)
            {
                if (rb2010.Checked)
                {
                    MessageBox.Show
                    ("NIM\t\t: " + tbNIM.Text +
                    "\nNama\t\t: " + tbNama.Text +
                    "\nJenis Kelain\t: " + rbPerempuan.Text +
                    "\nAlamat\t\t: " + tbAlamat.Text +
                    "\nProgram Studi\t: " + cbProdi.Text +
                    "\nTahun Akademik\t: " + tbTahunAkademik.Text +
                    "\nSemester\t\t: " + tbSemester.Text +
                    "\n====================================================" +
                    "\nKurikulum\t: " + kurikulum +
                    "\nMatakuliah\t: " + matkul,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rb2010.Checked)
                {
                    MessageBox.Show
                    ("NIM\t\t: " + tbNIM.Text +
                    "\nNama\t\t: " + tbNama.Text +
                    "\nJenis Kelain\t: " + rbPerempuan.Text +
                    "\nAlamat\t\t: " + tbAlamat.Text +
                    "\nProgram Studi\t: " + cbProdi.Text +
                    "\nTahun Akademik\t: " + tbTahunAkademik.Text +
                    "\nSemester\t\t: " + tbSemester.Text +
                    "\n====================================================" +
                    "\nKurikulum\t: " + kurikulum +
                    "\nMatakuliah\t: " + matkul,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rb2014.Checked)
                {
                    MessageBox.Show
                    ("NIM\t\t: " + tbNIM.Text +
                    "\nNama\t\t: " + tbNama.Text +
                    "\nJenis Kelain\t: " + rbPerempuan.Text +
                    "\nAlamat\t\t: " + tbAlamat.Text +
                    "\nProgram Studi\t: " + cbProdi.Text +
                    "\nTahun Akademik\t: " + tbTahunAkademik.Text +
                    "\nSemester\t\t: " + tbSemester.Text +
                    "\n====================================================" +
                    "\nKurikulum\t: " + kurikulum +
                    "\nMatakuliah\t: " + matkul,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rb2006_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2006.Checked)
            {
                cbMatematika.Enabled = true;
                cbPemrograman1.Enabled = true;
                cbPemrograman2.Enabled = true;
                cbPemrograman3.Enabled = true;
                cbPemrograman4.Enabled = true;
                cbPemrograman5.Enabled = true;
                cbPemrograman6.Enabled = true;
                cbPemrograman7.Enabled = true;
                cbPengantarLogistik.Enabled = false;
                cbJaringanKomputer.Enabled = true;
                cbSistemOperasi.Enabled = true;
                cbManagemenRantaiPasok.Enabled = false;
            }
        }

        private void rb2010_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2010.Checked)
            {
                cbMatematika.Enabled = false;
                cbPemrograman1.Enabled = true;
                cbPemrograman2.Enabled = true;
                cbPemrograman3.Enabled = true;
                cbPemrograman4.Enabled = true;
                cbPemrograman5.Enabled = true;
                cbPemrograman6.Enabled = true;
                cbPemrograman7.Enabled = true;
                cbPengantarLogistik.Enabled = false;
                cbJaringanKomputer.Enabled = true;
                cbSistemOperasi.Enabled = true;
                cbManagemenRantaiPasok.Enabled = true;
            }
        }

        private void rb2014_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2014.Checked)
            {
                cbMatematika.Enabled = false;
                cbPemrograman1.Enabled = true;
                cbPemrograman2.Enabled = true;
                cbPemrograman3.Enabled = true;
                cbPemrograman4.Enabled = true;
                cbPemrograman5.Enabled = true;
                cbPemrograman6.Enabled = true;
                cbPemrograman7.Enabled = true;
                cbPengantarLogistik.Enabled = true;
                cbJaringanKomputer.Enabled = true;
                cbSistemOperasi.Enabled = true;
                cbManagemenRantaiPasok.Enabled = false;
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(900, 290);
            tbNIM.ResetText();
            tbNama.ResetText();
            tbAlamat.ResetText();
            cbProdi.ResetText();
            tbTahunAkademik.ResetText();
            tbSemester.ResetText();
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;

            rb2006.Checked = false;
            rb2010.Checked = false;
            rb2014.Checked = false;

            cbMatematika.Checked = false;
            cbPemrograman1.Checked = false;
            cbPemrograman2.Checked = false;
            cbPemrograman3.Checked = false;
            cbPemrograman4.Checked = false;
            cbPemrograman5.Checked = false;
            cbPemrograman6.Checked = false;
            cbPemrograman7.Checked = false;
            cbPengantarLogistik.Checked = false;
            cbJaringanKomputer.Checked = false;
            cbSistemOperasi.Checked = false;
            cbManagemenRantaiPasok.Checked = false;

        }
    }
}
