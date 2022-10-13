using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class BangunDatar  // base class (parent) 
    {
        public virtual float Luas()
        {
            Console.WriteLine("Menghitung luas bangun datar");
            return 0;
        }
        public virtual float Keliling()
        {
            Console.WriteLine("Menghitung keliling bangun datar");
            return 0;
        }

    }

    class Persegi : BangunDatar  
    {
        public float sisi;
        public override float Luas()
        {
            float HasilLuas = sisi * sisi;
            Console.WriteLine("Hasil Luas  Persegi: " + HasilLuas);
            return 0;
        }
        public override float Keliling()
        {
            float HasilKeliling = 4 * sisi;
            Console.WriteLine("Hasil Keliling Persegi: " + HasilKeliling);
            return 0;
        }
    }

    class PersegiPanjang : BangunDatar
    {
        public float panjang;
        public float lebar;
        public override float Luas()
        {
            float HasilLuas = panjang * lebar;
            Console.WriteLine("Hasil Luas Persegi Panjang: " + HasilLuas);
            return 0;
        }
        public override float Keliling()
        {
            float HasilKeliling = 2*(panjang+lebar);
            Console.WriteLine("Hasil Keliling Persegi Panjang : " + HasilKeliling);
            return 0;
        }
    }

    class Lingkaran : BangunDatar
    {
        public double r;
        public override float Luas()
        {
            double HasilLuas = (Math.PI * r * r);
            Console.WriteLine("Hasil Luas Lingkaran: " + HasilLuas);
            return 0;
        }
        public override float Keliling()
        {
            double HasilKeliling = 2 * (Math.PI * r);
            Console.WriteLine("Hasil Keliling Lingkaran : " + HasilKeliling);
            return 0;
        }
    }

    class Segitiga : BangunDatar
    {
        public float tinggi;
        public float alas;
        public override float Luas()
        {
            double HasilLuas =  0.5 * alas * tinggi;
            Console.WriteLine("Hasil Luas Segitiga: " + HasilLuas);
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar bangunan = new BangunDatar();

            bangunan.Luas();
            bangunan.Keliling();

            Persegi persegi = new Persegi();
            persegi.sisi = 2;
            persegi.Luas();
            persegi.Keliling();

            PersegiPanjang persegipanjang = new PersegiPanjang();
            persegipanjang.panjang = 8;
            persegipanjang.lebar = 4;
            persegi.Luas();
            persegi.Keliling();

            Lingkaran lingkaran = new Lingkaran();
            lingkaran.r = 22;
            lingkaran.Luas();
            lingkaran.Keliling();

            Segitiga segitiga = new Segitiga();
            segitiga.alas = 12;
            segitiga.tinggi = 8;
            segitiga.Luas();

            Console.WriteLine();
        }
    }
}
