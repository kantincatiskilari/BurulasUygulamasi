using System;

namespace BurulasUygulamasi
{
    public class Durak
    {
        public int DurakID { get; set; }
        public string DurakAdi { get; set; }
        public override string ToString() => DurakAdi;
    }

    public class Sefer
    {
        public int SeferID { get; set; }
        public string Kalkis { get; set; }
        public string Varis { get; set; }
        public DateTime SeferTarihi { get; set; }
        public string KalkisSaati { get; set; }
        public string VarisSaati { get; set; }
        public string Plaka { get; set; }
        public int KoltukSayisi { get; set; }
        public decimal Fiyat { get; set; }
        public int BosKoltuk { get; set; }

        public string GorunenAd =>
            $"{KalkisSaati} → {VarisSaati}   |   {BosKoltuk} boş koltuk   |   {Fiyat:N0} ₺";
    }

    public class Yolcu
    {
        public int YolcuID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string TamAd => $"{Ad} {Soyad}";
    }

    public class Bilet
    {
        public int BiletID { get; set; }
        public string BiletNo { get; set; }
        public string Kalkis { get; set; }
        public string Varis { get; set; }
        public DateTime SeferTarihi { get; set; }
        public string KalkisSaati { get; set; }
        public int KoltukNo { get; set; }
        public string BiletTuru { get; set; }
        public decimal Fiyat { get; set; }
        public string Durum { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
