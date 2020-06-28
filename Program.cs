﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";
            int pilihan;
            List<Karyawan> listKaryawan = new List<Karyawan>();
            do
            {
                Console.Clear();
                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Nomor Menu [1..4] : ");
                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Tambah Data Karyawan\n");
                        Console.Write("Jenis Karyawan[1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                        int pil = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        switch (pil)
                        {
                            case 1:
                                KaryawanTetap karyawanTetap = new KaryawanTetap();
                                Console.Write("NIK : ");
                                karyawanTetap.Nik = Console.ReadLine();
                                Console.Write("Nama : ");
                                karyawanTetap.Nama = Console.ReadLine();
                                Console.Write("Gaji Bulanan : ");
                                karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(karyawanTetap);
                                break;
                            case 2:
                                KaryawanHarian karyawanHarian = new KaryawanHarian();
                                Console.Write("NIK : ");
                                karyawanHarian.Nik = Console.ReadLine();
                                Console.Write("Nama : ");
                                karyawanHarian.Nama = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                karyawanHarian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Upah Per Jam : ");
                                karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(karyawanHarian);
                                break;
                            case 3:
                                Sales sales = new Sales();
                                Console.Write("NIK : ");
                                sales.Nik = Console.ReadLine();
                                Console.Write("Nama : ");
                                sales.Nama = Console.ReadLine();
                                Console.Write("Jumlah Jam Kerja : ");
                                sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Upah Per Jam : ");
                                sales.Komisi = Convert.ToDouble(Console.ReadLine());
                                listKaryawan.Add(sales);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Hapus Data Karyawan\n");
                        Console.Write("NIK : ");
                        string nik = Console.ReadLine();
                        break;
                    case 3:
                        int noUrut = 1;
                        Console.WriteLine("Data Karyawan\n");
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                            noUrut++;
                        }
                        break;
                }
                Console.WriteLine("\n\nTekan Enter untuk kembali ke Menu");
                Console.ReadKey();
            }
            while (pilihan != 4);
            Console.ReadKey();
        }
    }
}