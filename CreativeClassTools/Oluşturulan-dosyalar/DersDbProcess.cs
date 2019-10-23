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
public void DersInsert(Ders dersDegisken)
{
SqlCommand insert = new SqlCommand("insert into Ders(derskod,dersad) values(@derskod,@dersad)",con);
insert.Parameters.AddWithValue("@derskod",dersDegisken.derskod);
insert.Parameters.AddWithValue("@dersad",dersDegisken.dersad);
KomutCalistir(insert);
}

public void DersUpdate(Ders dersDegisken)
{
SqlCommand update = new SqlCommand("update Ders set derskod=@derskod,dersad=@dersad where ID=@ID", con);
update.Parameters.AddWithValue("@derskod",dersDegisken.derskod);
update.Parameters.AddWithValue("@dersad",dersDegisken.dersad);
update.Parameters.AddWithValue("@ID",dersDegisken.ID);
KomutCalistir(update);
}

public void DersDelete(Ders dersDegisken)
{
SqlCommand delete= new SqlCommand("delete from Ders where ID=@ID",con);
delete.Parameters.AddWithValue("@ID",dersDegisken.ID);
KomutCalistir(delete);
}

public List<Ders> DersSelect()
{
List<Ders> result = new List<Ders>();
con.Open();
SqlCommand komut = new SqlCommand("select * from Ders",con);
SqlDataReader dr = komut.ExecuteReader();
while (dr.Read())
{
Ders ders = new Ders()
{

derskod = Convert.ToInt32(dr[0]),
dersad = Convert.ToString(dr[1])
};
result.Add(ders);
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
