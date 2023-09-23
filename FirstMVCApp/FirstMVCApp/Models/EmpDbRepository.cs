using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class EmpDbRepository
    {
        public static List<Employee> GetEmpList()
        {
            List<Employee> list = new List<Employee>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "Select * from emptbl";
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    Employee emp = new Employee
                    {
                        eno = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3)
                    };
                    list.Add(emp);
                }
            }
            return list;
        }
        public static Employee GetEmpById(int Id)
        {
            Employee empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                { cn.Open(); }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "Select * from emptbl";
                selectempcmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new Employee
                    {



                        eno = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3)
                    };


                }
            }
            return empFound;
        }


        public static int AddNewEmp(Employee newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl values( @eno,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@eno", SqlDbType.Int).Value = newEmp.eno;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.Name;
                insertEmpcmd.Parameters.Add("@Salary", SqlDbType.Decimal).Value = newEmp.salary;
                insertEmpcmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = newEmp.City;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;
           
        }
    

        public static int UpdateEmp(Employee ModifiedEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@eno", SqlDbType.Int).Value = ModifiedEmp.eno;
                updateEmpcmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = ModifiedEmp.Name;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.NVarChar).Value = ModifiedEmp.salary;
                updateEmpcmd.Parameters.Add("@City", SqlDbType.Decimal).Value = ModifiedEmp.City;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;

        }
       public static int DeleteEmp(int Id)
       {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;

        }


    }
}
