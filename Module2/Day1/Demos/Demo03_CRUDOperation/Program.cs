using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Demo03_CRUDOperation
{
    class Program
    {
        string ConnectionString;
        public Program()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        }
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 7)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Delete Department");
                Console.WriteLine("3. Update Department");
                Console.WriteLine("4. Show Total Employees");
                Console.WriteLine("5. Show all departments");
                Console.WriteLine("6. Show all departments (Disconnected)");
                Console.WriteLine("\nYour choice");
                choice = Convert.ToInt32(Console.ReadLine());
                var P = new Program();
                switch (choice)
                {
                    case 1: P.AddDepartment(); break;
                    case 2: P.DeleteDepartment(); break;
                    case 3: P.UpdateDepartment(); break;
                    case 4: P.GetTotalEmployees(); break;
                    case 5: P.ShowAll(); break;
                    case 6: P.ShowAll_UsingDataSet(); break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        public void AddDepartment()
        {
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter ID");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter employee count");
                    int employeecount = Convert.ToInt32(Console.ReadLine());

                    var query = $"insert into Departments values({id}, '{name}', {employeecount})";

                    var Command = new SqlCommand(query, Connection);

                    Connection.Open();
                    int RowsAffected = Command.ExecuteNonQuery();
                    Console.WriteLine("{0} rows changed", RowsAffected);

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error : {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unknown error : {0}", ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        public void DeleteDepartment()
        {
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter id to delete");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var query = $"delete from Departments where id={id}";

                    var Command = new SqlCommand(query, Connection);

                    Connection.Open();
                    var RowsAffected = Command.ExecuteNonQuery();

                    Console.WriteLine("{0} rows deleted", RowsAffected);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error : {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unknown error : {0}", ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        public void UpdateDepartment()
        {
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter id, name, employeecount");
                    var id = Convert.ToInt32(Console.ReadLine());
                    var name = Console.ReadLine();
                    var employeecount = Convert.ToInt32(Console.ReadLine());

                    var query = $"update departments set name='{name}', employeecount={employeecount} where id={id}";

                    var command = new SqlCommand(query, Connection);
                    Connection.Open();
                    var RowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("{0} rows updated", RowsAffected);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error : {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unknown error : {0}", ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        public void GetTotalEmployees()
        {
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var query = "select sum(EmployeeCount) from Departments";

                    var Command = new SqlCommand(query, Connection);

                    Connection.Open();

                    var Total = Convert.ToInt32(Command.ExecuteScalar());
                    Console.WriteLine("Total employee count : {0}", Total);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error : {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unknown error : {0}", ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        public void ShowAll()
        {
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var query = "select * from Departments";

                    var Command = new SqlCommand(query, Connection);
                    Connection.Open();

                    SqlDataReader DataReader = Command.ExecuteReader();
                    if (DataReader.HasRows)
                    {
                        int id;
                        string name;
                        int count;
                        while (DataReader.Read())
                        {
                            id = DataReader.GetInt32(0);
                            name = DataReader.GetString(1);
                            count = DataReader.GetInt32(2);

                            Console.WriteLine($"{id}\t{name}\t{count}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No records in table");
                    }
                    DataReader.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Database error : {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unknown error : {0}", ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        public void ShowAll_UsingDataSet()
        {

            try
            {
                var query = "select * from departments";
                var DataAdapter = new SqlDataAdapter(query, ConnectionString);

                var FISDataSet = new DataSet("FIS Data Set");

                DataAdapter.Fill(FISDataSet, "Dept");

                Console.WriteLine("Data set name = {0}", FISDataSet.DataSetName);
                Console.WriteLine("Total Tables = {0}", FISDataSet.Tables.Count);
                Console.WriteLine("Name of table at index 0 = {0}", FISDataSet.Tables[0].TableName);

                DataTable Table = FISDataSet.Tables["Dept"];

                foreach(DataColumn column in Table.Columns)
                {
                    Console.Write(column.ColumnName + "\t");
                }

                for(int row=0; row<Table.Rows.Count; row++)
                {
                    Console.WriteLine();
                    for(int column=0; column<Table.Columns.Count; column++)
                    {
                        Console.Write(Table.Rows[row][column]+"\t");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database error : {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown error : {0}", ex.Message);
            }
        }
    }
}
