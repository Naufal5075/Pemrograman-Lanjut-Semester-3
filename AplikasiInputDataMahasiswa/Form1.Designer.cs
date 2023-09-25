namespace AplikasiInputDataMahasiswa
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtNama1 = new System.Windows.Forms.Label();
            this.txtNim2 = new System.Windows.Forms.Label();
            this.txtKelas3 = new System.Windows.Forms.Label();
            this.txtNilai4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(43, 187);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(100, 28);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(171, 187);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(21, 30);
            this.btnTampilkanData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(128, 28);
            this.btnTampilkanData.TabIndex = 2;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(171, 30);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 28);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtNama1
            // 
            this.txtNama1.AutoSize = true;
            this.txtNama1.Location = new System.Drawing.Point(21, 20);
            this.txtNama1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNama1.Name = "txtNama1";
            this.txtNama1.Size = new System.Drawing.Size(44, 16);
            this.txtNama1.TabIndex = 4;
            this.txtNama1.Text = "Nama";
            // 
            // txtNim2
            // 
            this.txtNim2.AutoSize = true;
            this.txtNim2.Location = new System.Drawing.Point(21, 59);
            this.txtNim2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNim2.Name = "txtNim2";
            this.txtNim2.Size = new System.Drawing.Size(31, 16);
            this.txtNim2.TabIndex = 5;
            this.txtNim2.Text = "NIM";
            // 
            // txtKelas3
            // 
            this.txtKelas3.AutoSize = true;
            this.txtKelas3.Location = new System.Drawing.Point(21, 98);
            this.txtKelas3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKelas3.Name = "txtKelas3";
            this.txtKelas3.Size = new System.Drawing.Size(41, 16);
            this.txtKelas3.TabIndex = 6;
            this.txtKelas3.Text = "Kelas";
            // 
            // txtNilai4
            // 
            this.txtNilai4.AutoSize = true;
            this.txtNilai4.Location = new System.Drawing.Point(21, 138);
            this.txtNilai4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNilai4.Name = "txtNilai4";
            this.txtNilai4.Size = new System.Drawing.Size(34, 16);
            this.txtNilai4.TabIndex = 7;
            this.txtNilai4.Text = "Nilai";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(693, 30);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(96, 20);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(184, 22);
            this.txtNama.TabIndex = 9;
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(96, 59);
            this.txtNim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(180, 22);
            this.txtNim.TabIndex = 10;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(96, 98);
            this.txtKelas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(132, 22);
            this.txtKelas.TabIndex = 11;
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(96, 138);
            this.txtNilai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(132, 22);
            this.txtNilai.TabIndex = 12;
            this.txtNilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNilai_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMahasiswa);
            this.groupBox1.Controls.Add(this.btnTampilkanData);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Location = new System.Drawing.Point(320, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(528, 476);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Daftar Mahasiswa ]";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(21, 79);
            this.lvwMahasiswa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(515, 409);
            this.lvwMahasiswa.TabIndex = 14;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtNilai4);
            this.Controls.Add(this.txtKelas3);
            this.Controls.Add(this.txtNim2);
            this.Controls.Add(this.txtNama1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Aplikasi Input Data Mahasiswa";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label txtNama1;
        private System.Windows.Forms.Label txtNim2;
        private System.Windows.Forms.Label txtKelas3;
        private System.Windows.Forms.Label txtNilai4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwMahasiswa;
    }
}

