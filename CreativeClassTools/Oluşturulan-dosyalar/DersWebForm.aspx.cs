using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
public partial class DersWebForm : System.Web.UI.Page
{
protected void Page_Load(object sender, EventArgs e)
{
DbProcess db = new DbProcess();
List<Ders> dersListele = new List<Ders>();
dersListele = db.DersSelect();
rptDers.DataSource = dersListele;
rptDers.DataBind();
}
}
}
