using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) DropDownList1.Items.Add(new ListItem("Terceira Opção", "3"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "bom dia";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string temp = "";

            temp += "<table border='1'>";

            for (int i = 0; i < 20; i++)
            {
                temp += "<tr><td>Coluna 1 " + i + "</td><td>Coluna 2 " + i + "</td><td>Coluna 3 " + i + "</td><tr>";
            }

            temp += "</table>";
            Label1.Text = temp;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string temp = "";
            temp += "<table border=1>";

            string SQLquery = "select firstname, lastname from customers";

            using (Data cn = new Data())
            {
                SqlDataReader dr = cn.query(SQLquery);

                while (dr.Read())
                {
                    temp += "<tr><td>" + dr["firstname"].ToString() + "</td><td>" + dr["lastname"].ToString() + "</td></tr>";
                }

            }

            temp += "</table>";
            Label1.Text = temp;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string SQLquery = "insert into customers(firstname, lastname) values('" + TextBox2.Text + "', '" + TextBox3.Text + "')";
            using (Data cn = new Data())
            {
                cn.executeSql(SQLquery);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string SQLquery = "update customers set firstname='Timotio', lastname='Andriolino' where firstname = 'Miguel'";
            using (Data cn = new Data())
            {
                cn.executeSql(SQLquery);
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string SQLquery = "delete from customers where firstname='" + TextBox2.Text + "' and lastname='" + TextBox3.Text + "'";
            using (Data cn = new Data())
            {
                cn.executeSql(SQLquery);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string SQLquery = "select top 50 customerid, firstname, lastname from customers";

            using (Data cn = new Data())
            {
                SqlDataReader dr = cn.query(SQLquery);

                while (dr.Read())
                {
                    //DropDownList2.Items.Add(new ListItem("Terceira Opção","3"));
                    DropDownList2.Items.Add(new ListItem(dr["firstname"].ToString() + " " + dr["lastname"].ToString(), dr["customerid"].ToString()));

                }
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SQLquery = "select top 50 salesid, customerid, quantity from sales where customerid= " + DropDownList2.SelectedItem.Value;

            using (Data cn = new Data())
            {
                SqlDataReader dr = cn.query(SQLquery);

                while (dr.Read())
                {
                    //DropDownList2.Items.Add(new ListItem("Terceira Opção","3"));
                    DropDownList3.Items.Add(new ListItem(dr["salesid"].ToString() + " " + dr["customerid"].ToString(), dr["quantity"].ToString()));

                }
            }
        }
    }
}