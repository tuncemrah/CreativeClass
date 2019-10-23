using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
public partial class OgrenciWebForm : System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
DbProcess db = new DbProcess();
List<Ogrenci> ogrenciListele = new List<Ogrenci>();
ogrenciListele = db.OgrenciSelect();
rptogrenci.DataSource = ogrenciListele;
rptogrenci.DataBind();
}
}
}
