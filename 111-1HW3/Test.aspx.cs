using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class Test : System.Web.UI.Page
    {
        string[] i_cat = new string[2] { "蔬菜", "水果" };
        string[,] i_2D = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i_Ct = 0; i_Ct < i_cat.Length; i_Ct++)
            {
                ListItem o_L = new ListItem();
                o_L.Text = o_L.Value = i_cat[i_Ct];

                ddl_Category.Items.Add(o_L);
            }
            mt_GensecondList();
        }

        protected void mt_GensecondList() 
        {
            int i_ind = ddl_Category.SelectedIndex;
            ddl_Food.Items.Clear();
            for(int i_Ct=0; i_Ct< i_2D.GetLength(1); i_Ct++)
            {
                ListItem o_L = new ListItem();
                o_L.Text = o_L.Value = i_2D[i_ind,i_Ct];

                ddl_Food.Items.Add(o_L);
            }
        }

        protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_GensecondList();
        }
    }
}