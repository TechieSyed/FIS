using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Demo03_CRUDOperations.Models;
namespace Demo03_CRUDOperations
{
    public partial class Departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayDepartments();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {          
            using (var context = new FISDemoEntities())
            {
                try
                {
                    var Obj = new Department();
                    Obj.ID = Convert.ToInt32(txtID.Text);
                    Obj.Name = txtName.Text;
                    Obj.EmployeeCount = Convert.ToInt32(txtEmployeeCount.Text);

                    context.Departments.Add(Obj);

                    int Rows = context.SaveChanges();
                    if (Rows == 1)
                    {
                        lblMessage.Text = Rows + " rows added";
                        DisplayDepartments();
                        ClearControls();
                    }
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

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new FISDemoEntities())
            {
                try
                {
                    int id = Convert.ToInt32(txtID.Text);

                    var Dept = context.Departments.Find(id);

                    if (Dept != null)
                    {
                        txtName.Text = Dept.Name;
                        txtEmployeeCount.Text = Dept.EmployeeCount.ToString();
                    }
                    else
                    {
                        lblMessage.Text = "Department not found";
                    }
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new FISDemoEntities())
            {
                try
                {
                    var Id = Convert.ToInt32(txtID.Text);

                    var Dept = context.Departments.Find(Id);

                    if (Dept != null)
                    {
                        context.Departments.Remove(Dept);
                        var Rows = context.SaveChanges();
                        if (Rows == 1)
                        {
                            lblMessage.Text = $"Department {Id} is deleted";
                            DisplayDepartments();
                            ClearControls();
                        }
                    }
                    else
                    {
                        lblMessage.Text = "No such department found";
                    }
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new FISDemoEntities())
            {
                try
                {
                    var Id = Convert.ToInt32(txtID.Text);

                    var Dept = context.Departments.Find(Id);
                    if (Dept != null)
                    {
                        Dept.Name = txtName.Text;
                        Dept.EmployeeCount = Convert.ToInt32(txtEmployeeCount.Text);

                        int Rows = context.SaveChanges();
                        if (Rows == 1)
                        {
                            lblMessage.Text = $"Department {Id} is updated";
                            DisplayDepartments();
                            ClearControls();
                        }
                    }
                    else
                    {
                        lblMessage.Text = "No such department to update";
                    }
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

        private void DisplayDepartments()
        {
            using (var context = new FISDemoEntities())
            {
                try
                {
                    var Departments = from dept in context.Departments
                                      select dept;
                    gvDepartments.DataSource = Departments.ToList();
                    gvDepartments.DataBind();
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

        private void ClearControls()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmployeeCount.Text = string.Empty;
        }
    }
}