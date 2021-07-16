using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Demo01_EFCodeFirst.Models;
namespace Demo01_EFCodeFirst
{
    public partial class Departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
            }
        }

        private void LoadGridView()
        {
            using (var context=new ProjectManagementModel())
            {
                try
                {
                    var Query = from item in context.Departments
                                select item;
                    gvDepartments.DataSource = Query.ToList();
                    gvDepartments.DataBind();
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context=new ProjectManagementModel())
            {
                try
                {
                    var obj = new Department();
                    obj.DepartmentName = txtName.Text;

                    context.Departments.Add(obj);

                    int Rows = context.SaveChanges();
                    if (Rows == 1)
                    {
                        lblMessage.Text = "Department added";
                        LoadGridView();
                    }

                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context=new ProjectManagementModel())
            {
                try
                {
                    int id = Convert.ToInt32(txtID.Text);

                    var obj = context.Departments.Find(id);
                    //var obj = (from item in context.Departments
                    //          where item.DepartmentName == txtName.Text
                    //          select item).FirstOrDefault();

                    context.Departments.Remove(obj);

                    int Rows = context.SaveChanges();
                    if (Rows == 1)
                    {
                        lblMessage.Text = "Department deleted";
                        LoadGridView();
                    }

                }
                catch (Exception ex)
                {

                    lblMessage.Text = ex.Message;
                }
            }
        }
    }
}