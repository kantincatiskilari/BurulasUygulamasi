using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BurulasUygulamasi.Helpers
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString =
            "Server=DESKTOP-CDUPO4I;Database=BurulasDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        // ── Duraklar ──────────────────────────────────────────────────
        public static List<Durak> GetDuraklar()
        {
            var list = new List<Durak>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SELECT DurakID, DurakAdi FROM Duraklar WHERE Aktif=1 ORDER BY DurakAdi", conn))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                    list.Add(new Durak { DurakID = rdr.GetInt32(0), DurakAdi = rdr.GetString(1) });
            }
            return list;
        }

        // ── Sefer Ara ─────────────────────────────────────────────────
        public static List<Sefer> SeferAra(int kalkisDurakID, int varisDurakID, DateTime tarih)
        {
            var list = new List<Sefer>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SP_SeferAra", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KalkisDurakID", kalkisDurakID);
                cmd.Parameters.AddWithValue("@VarisDurakID", varisDurakID);
                cmd.Parameters.AddWithValue("@Tarih", tarih.Date);

                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new Sefer
                        {
                            SeferID = rdr.GetInt32(0),
                            Kalkis = rdr.GetString(1),
                            Varis = rdr.GetString(2),
                            SeferTarihi = rdr.GetDateTime(3),
                            KalkisSaati = rdr.GetString(4),
                            VarisSaati = rdr.GetString(5),
                            Plaka = rdr.GetString(6),
                            KoltukSayisi = rdr.GetInt32(7),
                            Fiyat = rdr.GetDecimal(8),
                            BosKoltuk = rdr.GetInt32(9)
                        });
                    }
                }
            }
            return list;
        }

        // ── Dolu Koltuklar ────────────────────────────────────────────
        public static List<int> GetDoluKoltuklar(int seferID)
        {
            var list = new List<int>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SP_DoluKoltuklar", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SeferID", seferID);
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        list.Add(rdr.GetInt32(0));
            }
            return list;
        }

        // ── Giriş Yap ─────────────────────────────────────────────────
        public static Yolcu GirisYap(string tc, string sifre)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT YolcuID, Ad, Soyad, TC, Telefon, Email FROM Yolcular WHERE TC=@TC AND Sifre=@Sifre", conn))
            {
                cmd.Parameters.AddWithValue("@TC", tc);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                        return new Yolcu
                        {
                            YolcuID = rdr.GetInt32(0),
                            Ad = rdr.GetString(1),
                            Soyad = rdr.GetString(2),
                            TC = rdr.GetString(3),
                            Telefon = rdr.IsDBNull(4) ? "" : rdr.GetString(4),
                            Email = rdr.IsDBNull(5) ? "" : rdr.GetString(5)
                        };
                }
            }
            return null;
        }

        // ── Üye Ol ────────────────────────────────────────────────────
        public static bool UyeOl(string ad, string soyad, string tc, string telefon, string email, string sifre)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(
                    "INSERT INTO Yolcular (Ad,Soyad,TC,Telefon,Email,Sifre) VALUES (@Ad,@Soyad,@TC,@Tel,@Email,@Sifre)", conn))
                {
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@TC", tc);
                    cmd.Parameters.AddWithValue("@Tel", telefon);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        // ── Bilet Oluştur ─────────────────────────────────────────────
        public static string BiletOlustur(int seferID, int yolcuID, int koltukNo,
                                          string biletTuru, decimal fiyat, string odemeTuru)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SP_BiletOlustur", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SeferID", seferID);
                cmd.Parameters.AddWithValue("@YolcuID", yolcuID);
                cmd.Parameters.AddWithValue("@KoltukNo", koltukNo);
                cmd.Parameters.AddWithValue("@BiletTuru", biletTuru);
                cmd.Parameters.AddWithValue("@Fiyat", fiyat);
                cmd.Parameters.AddWithValue("@OdemeTuru", odemeTuru);

                var biletNoParam = new SqlParameter("@BiletNo", SqlDbType.NVarChar, 20)
                { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(biletNoParam);

                cmd.ExecuteNonQuery();
                return biletNoParam.Value?.ToString();
            }
        }

        // ── Yolcu Biletleri ───────────────────────────────────────────
        public static List<Bilet> GetYolcuBiletleri(int yolcuID)
        {
            var list = new List<Bilet>();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SP_YolcuBiletleri", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@YolcuID", yolcuID);
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new Bilet
                        {
                            BiletNo = rdr.GetString(0),
                            BiletID = rdr.GetInt32(1),
                            Kalkis = rdr.GetString(2),
                            Varis = rdr.GetString(3),
                            SeferTarihi = rdr.GetDateTime(4),
                            KalkisSaati = rdr.GetString(5),
                            KoltukNo = rdr.GetInt32(6),
                            BiletTuru = rdr.GetString(7),
                            Fiyat = rdr.GetDecimal(8),
                            Durum = rdr.GetString(9),
                            SatisTarihi = rdr.GetDateTime(10)
                        });
                    }
                }
            }
            return list;
        }

        // ── Bilet İptal ───────────────────────────────────────────────
        public static void BiletIptal(int biletID)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("SP_BiletIptal", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BiletID", biletID);
                cmd.ExecuteNonQuery();
            }
        }

        // ── Bağlantı Testi ────────────────────────────────────────────
        public static bool TestConnection(out string hata)
        {
            hata = "";
            try
            {
                using (var conn = GetConnection())
                    return true;
            }
            catch (Exception ex)
            {
                hata = ex.Message;
                return false;
            }
        }
    }
}
