using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Demo03_CRUDOperations.Models;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
namespace Demo03_CRUDOperations
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var context = new FISDemoEntities())
                {
                    try
                    {
                        var Query = from dept in context.Departments
                                    select dept;

                        //foreach(var d in Query)
                        //{
                        //    ddlDepartments.Items.Add(new ListItem { Text = d.Name, Value = d.ID.ToString() });
                        //}
                        ddlDepartments.DataSource = Query.ToList();
                        ddlDepartments.DataTextField = "Name";
                        ddlDepartments.DataValueField = "ID";
                        ddlDepartments.DataBind();
                    }
                    catch (DbException ex)
                    {
                        lblMessage.Text = "Error : " + ex.Message;
                    }
                    catch (DbUpdateException ex)
                    {
                        lblMessage.Text = "Error : " + ex.Message;
                    }
                    catch (Exception ex)
                    {
                        lblMessage.Text = "Error : " + ex.Message;
                    }
                }
            }
        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddlDepartments.SelectedIndex==0)
            {
                return;
            }
            var Item = ddlDepartments.SelectedItem;
            lblMessage.Text = $"Selected ID={Item.Value}, Selected Text={Item.Text}";

            using (var context = new FISDemoEntities())
            {
                try
                {
                    int Id = Convert.ToInt32(Item.Value);
                    var Query = from emp in context.Employees
                                where emp.DepartmentId == Id
                                select emp;

                    gvEmployees.DataSource = Query.ToList();
                    gvEmployees.DataBind();
                }
                catch (DbException ex)
                {
                    lblMessage.Text = "Error : " + ex.Message;
                }
                catch (DbUpdateException ex)
                {
                    lblMessage.Text = "Error : " + ex.Message;
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Error : " + ex.Message;
                }
            }
        }
    }
}