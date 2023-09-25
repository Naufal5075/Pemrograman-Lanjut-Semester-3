using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiInputDataMahasiswa
{
    public partial class Form1 : Form
    {
        // Deklarasi objek collection
        private List<Mahasiswa> list = new List<Mahasiswa>();

        // Membuat Class Mahasiswa
        public class Mahasiswa
        {
            public string Nama, Nim, Kelas, Nilai_huruf, kriteria;
            public int Nilai;
        }

        public static string Nilai_Huruf(int nilai)
        {
            string kriteria = "";

            if (nilai >= 81)
            {
                kriteria = "A";
            }
            else if (nilai >= 61)
            {
                kriteria = "B";
            }
            else if (nilai >= 41)
            {
                kriteria = "C";
            }
            else if (nilai >= 21)
            {
                kriteria = "D";
            }
            else
            {
                kriteria = "E";
            }

            return kriteria;
        }


        // Constructor
        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void ResetForm()
        {
            txtNim.Clear();
            txtNama.Clear();
            txtKelas.Clear();
            txtNilai.Text = "0";
            txtNim.Focus();
        }

        private void InisialisasiListView()
        {
            lvwMahasiswa.View = View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No. ", 30, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("NIM", 91, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama", 70, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Kelas", 70, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai", 50, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai Huruf", 50, HorizontalAlignment.Center);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";

            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                // Inputan selain angka
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }

                return false;
            }
            else
                return false;
        }

        private void txtNilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Membuat Objek Mahasiswa
            Mahasiswa mhs = new Mahasiswa();

            // Set nilai masing-masing property-nya
            // Berdasarkan inputan yang ada di form
            mhs.Nim = txtNim.Text;
            mhs.Nama = txtNama.Text;
            mhs.Kelas = txtKelas.Text;

            // Validasi input nilai
            if (int.TryParse(txtNilai.Text, out int nilai))
            {
                mhs.Nilai = nilai;
                mhs.Nilai_huruf = Nilai_Huruf(nilai); // Menghitung nilai huruf

                // Tambahkan objek mahasiswa ke dalam collection
                list.Add(mhs);

                var msg = "Data Mahasiswa berhasil disimpan.";

                // Tampilkan dialog informasi
                MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form input
                ResetForm();
            }
            else
            {
                // Tampilkan pesan kesalahan jika input nilai tidak valid
                MessageBox.Show("Nilai harus berupa angka yang valid.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void TampilkanData()
        {
            // Kosongkan data listview
            lvwMahasiswa.Items.Clear();

            // Lakukan perulangan untuk menampilkan data mahasiswa ke listview
            foreach (var mhs in list)
            {
                var noUrut = lvwMahasiswa.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(mhs.Nim);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Kelas);
                item.SubItems.Add(mhs.Nilai.ToString());
                item.SubItems.Add(mhs.Nilai_huruf);
                

                lvwMahasiswa.Items.Add(item);
            }
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Cek apakah data mahasiswa sudah dipilih
            if (lvwMahasiswa.SelectedItems.Count > 0)
            {
                // Tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (konfirmasi == DialogResult.Yes)
                {
                    // Ambil index list yang di pilih
                    var index = lvwMahasiswa.SelectedIndices[0];

                    // Hapus objek mahasiswa dari list
                    list.RemoveAt(index);

                    // Refresh tampilan listview
                    TampilkanData();
                }
            }
            else // Data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
