using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> listproduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
        }

        static void TambahProduk()
        {
            Console.Clear();
            
            
            Console.WriteLine();
            Console.WriteLine("Tambah Data produk\n");
            Produk produk = new Produk();
            Console.Write("Kode produk : ");
            produk.kodeproduk = Console.ReadLine();
            Console.Write("Nama produk : ");
            produk.namaproduk = Console.ReadLine();
            Console.Write("Harga beli : ");
            produk.hargabeli = Convert.ToDouble(Console.ReadLine());
            Console.Write("Harga jual : ");
            produk.hargajual = Convert.ToDouble(Console.ReadLine());
            listproduk.Add(produk);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();
            Console.WriteLine("Hapus Produk\n");
            Console.Write("Kode produk : ");
            string kp = Console.ReadLine();
            int urutan = -1, hapus = -1;
            foreach (Produk produk in listproduk)
                    {
                        urutan++;
                        if(produk.kodeproduk == kp)
                        {
                            hapus = urutan;
                        }
                    }
                        
                        if (hapus != -1)
                        
                        {
                            listproduk.RemoveAt(hapus);
                            Console.WriteLine("\nData produk berhasil Dihapus");
                        }
                        
                        else
                        {
                            Console.WriteLine("\nData produk tidak ditemukan");
                        }
                        
                        

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            int nomor = 0;
               string jenis=" ";
               Console.WriteLine("Data Produk\n");
               foreach (Produk produk in listproduk)
                        {
        
                        nomor++;
                        Console.WriteLine("{0}. {1}, {2}, {3:N0}, {4:NO}", nomor, produk.kodeproduk, produk.namaproduk, produk.hargabeli, produk.hargajual);
                        }
                        
                        if (nomor < 1)
                            {
                                Console.WriteLine("Data produk Kosong");
                            }

                        

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}