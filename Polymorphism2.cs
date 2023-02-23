using System;

public class simpledataklg
{
    static public void Main()
    {
      datakeluarga ok = new datakeluarga();
      datakeluarga ayahku = new Ayah();
      ayahku.Nama = "         ";
      ayahku.Umur = 40;
      ayahku.Nohp = +62876543214567;
      Console.WriteLine("Data Ayah:");
      Console.WriteLine(ayahku.Nama);
      Console.WriteLine(ayahku.Umur);
      Console.WriteLine(ayahku.Nohp);
      ayahku.Hobi();
      datakeluarga ibuku = new Ibu();
      ibuku.Nama = "     ";
      ibuku.Umur = 30;
      ibuku.Nohp = +62812345678123;
      Console.Write("Data Ibu:");
      Console.WriteLine(ibuku.Nama);
      Console.WriteLine(ibuku.Umur);
      Console.WriteLine(ibuku.Nohp);
      ibuku.Hobi();
      Console.WriteLine("Data Diriku");
      datakeluarga aku = new Anak();
      aku.Nama = "M.Farel w";
      aku.Umur = 16;
      aku.Nohp = +62882009691450;
      Console.WriteLine(aku.Nama);
      Console.WriteLine(aku.Umur);
      Console.WriteLine(aku.Nohp);
      aku.Hobi();      
    }
    class datakeluarga 
    {
        private string nama;
        public string Nama
        {
            get { return nama;}
            set { nama = value;}
        }
        private int umur;
        public int Umur
        {
            get {return umur;}
            set {umur = value;}
        }
        private long nohp;
        public long Nohp
        {
            get {return nohp;}
            set {nohp = value;}
        }
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah:datakeluarga
    {
        public override void Hobi()
        {
            Console.WriteLine("Hobi : Memecahkan misteri");
        }
    }
    class Ibu:datakeluarga 
    {
        public override void Hobi()
        {
            Console.WriteLine("Hobi : Memasak");
        }
    }
    class Anak:datakeluarga 
    {
        public override void Hobi()
        {
            Console.WriteLine("Hobi : Menonton kartun");
        }
    }

}
