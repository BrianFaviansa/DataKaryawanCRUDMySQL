using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataKaryawan.Model
{
    class Karyawan_m
    {
        string nik, nama, jabatan, alamat, email, no_hp;

        public Karyawan_m() { }

        public Karyawan_m(string nik, string nama, string jabatan, string alamat, string email, string no_hp)
        {
            this.Nik = nik;
            this.Nama = nama;
            this.Jabatan = jabatan;
            this.Alamat = alamat;
            this.Email = email;
            this.No_hp = no_hp;
        }

        public string Nik { get => nik; set => nik = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Jabatan { get => jabatan; set => jabatan = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Email { get => email; set => email = value; }
        public string No_hp { get => no_hp; set => no_hp = value; }
    }
}
