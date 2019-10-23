using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1
{
public class DbProcess
{

SqlConnection con = new SqlConnection("Server = LAPTOP-IKAK8RDA\\TUNCSERVER; Database = EMRAH; User Id = sa; password = mirac5");
public void OgrenciInsert(Ogrenci ogrenciDegisken)
{
SqlCommand insert = new SqlCommand("insert into ogrenci(ogr_no,ad,soyad,bölüm,adres,cinsiyet,resim) values(@ogr_no,@ad,@soyad,@bölüm,@adres,@cinsiyet,@resim)",con);
insert.Parameters.AddWithValue("@ogr_no",ogrenciDegisken.ogr_no);
insert.Parameters.AddWithValue("@ad",ogrenciDegisken.ad);
insert.Parameters.AddWithValue("@soyad",ogrenciDegisken.soyad);
insert.Parameters.AddWithValue("@bölüm",ogrenciDegisken.bölüm);
insert.Parameters.AddWithValue("@adres",ogrenciDegisken.adres);
insert.Parameters.AddWithValue("@cinsiyet",ogrenciDegisken.cinsiyet);
insert.Parameters.AddWithValue("@resim",ogrenciDegisken.resim);
KomutCalistir(insert);
}

public void OgrenciUpdate(Ogrenci ogrenciDegisken)
{
SqlCommand update = new SqlCommand("update ogrenci set ogr_no=@ogr_no,ad=@ad,soyad=@soyad,bölüm=@bölüm,adres=@adres,cinsiyet=@cinsiyet,resim=@resim where ID=@ID", con);
update.Parameters.AddWithValue("@ogr_no",ogrenciDegisken.ogr_no);
update.Parameters.AddWithValue("@ad",ogrenciDegisken.ad);
update.Parameters.AddWithValue("@soyad",ogrenciDegisken.soyad);
update.Parameters.AddWithValue("@bölüm",ogrenciDegisken.bölüm);
update.Parameters.AddWithValue("@adres",ogrenciDegisken.adres);
update.Parameters.AddWithValue("@cinsiyet",ogrenciDegisken.cinsiyet);
update.Parameters.AddWithValue("@resim",ogrenciDegisken.resim);
update.Parameters.AddWithValue("@ID",ogrenciDegisken.ID);
KomutCalistir(update);
}

public void OgrenciDelete(Ogrenci ogrenciDegisken)
{
SqlCommand delete= new SqlCommand("delete from ogrenci where ID=@ID",con);
delete.Parameters.AddWithValue("@ID",ogrenciDegisken.ID);
KomutCalistir(delete);
}

public List<Ogrenci> OgrenciSelect()
{
List<Ogrenci> result = new List<Ogrenci>();
con.Open();
SqlCommand komut = new SqlCommand("select * from ogrenci",con);
SqlDataReader dr = komut.ExecuteReader();
while (dr.Read())
{
Ogrenci ogrenci = new Ogrenci()
{

ogr_no = Convert.ToInt32(dr[0]),
ad = Convert.ToString(dr[1]),
soyad = Convert.ToString(dr[2]),
bölüm = Convert.ToInt32(dr[3]),
adres = Convert.ToString(dr[4]),
cinsiyet = Convert.ToBoolean(dr[5]),
resim = Convert.ToString(dr[6])
};
result.Add(ogrenci);
}
con.Close();
return result;
}

public Boolean KomutCalistir(SqlCommand komut)
{
con.Open();
komut.ExecuteNonQuery();
komut.Dispose();
con.Close();
return true;
}

}
}
