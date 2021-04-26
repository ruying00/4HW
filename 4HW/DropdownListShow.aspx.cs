using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4HW {
    public partial class DropdownListShow : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (ddl_Area.Items.Count == 0)
            {
                ddl_Area.Items.Add(new ListItem("北區"));
                ddl_Area.Items.Add(new ListItem("中區"));
            }
           

            
            if (ddl_Area.SelectedValue == "北區")
            {
                ddl_Place.Items.Clear();
                ddl_Place.Items.Add(new ListItem("基隆", "基隆"));
                ddl_Place.Items.Add(new ListItem("台北", "台北"));
                ddl_Place.Items.Add(new ListItem("新北", "新北"));
            }
            else if (ddl_Area.SelectedValue == "中區")
            {
                 ddl_Place.Items.Clear();
                ddl_Place.Items.Add(new ListItem("苗栗", "苗栗"));
                ddl_Place.Items.Add(new ListItem("台中", "台中"));
                ddl_Place.Items.Add(new ListItem("南投", "南投"));
            }
          

        }
    }
}