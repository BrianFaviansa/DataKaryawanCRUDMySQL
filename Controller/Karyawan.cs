using DataKaryawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataKaryawan.Controller
{
    class Karyawan
    {
        //PANGGIL CLASS KONEKSI DAN MEMBUAT OBJEK DARI CLASS TERSEBUT
        Koneksi koneksi = new Koneksi();

        //METHOD INSERT
        public bool Insert(Karyawan_m karyawan)
        {
            Boolean status = false;
            try
            {
                koneksi.openConnection();
                koneksi.executeQuery("INSERT INTO karyawan (nik, nama, jabatan, alamat, email, no_hp) VALUES ('" + karyawan.Nik + "', '" + karyawan.Nama + "', '" + karyawan.Jabatan + "', '" + karyawan.Alamat + "', '" + karyawan.Email + "', '" + karyawan.No_hp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            return status;
        }

        public bool Update(Karyawan_m karyawan, string id)
        {
            Boolean status = false;
            try
            {
                koneksi.openConnection();
                koneksi.executeQuery("UPDATE karyawan SET nik='" + karyawan.Nik + "', " + "nama='" + karyawan.Nama + "', " + "jabatan='" + karyawan.Jabatan + "'," + "alamat= '" + karyawan.Alamat + "', " + "email= '" + karyawan.Email + "', " + "no_hp = '" + karyawan.No_hp + "' WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete (string id)
        {
            Boolean status = false;
            try
            {
                koneksi.openConnection();
                koneksi.executeQuery("DELETE FROM karyawan WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
