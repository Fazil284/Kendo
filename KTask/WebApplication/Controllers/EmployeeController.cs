using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        SqlConnection conn;
        SqlCommand cmd;
        string strConnection;

        public EmployeeController()
        {
            strConnection = @"Server=LAPTOP-AUGUV4DQ;Integrated Security=true;database=db_task";
            conn = new SqlConnection(strConnection);
        }

        public ICollection<EmpClass> SelectEmployees()
        {
            List<EmpClass> employees = new List<EmpClass>();
            SqlCommand cmd = new SqlCommand("proc_employee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter daEmployee = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                daEmployee.Fill(ds, "EmpClass");//Connect-->Fetch the data->put it in the dataset->give the name provided->disconnect from db
                EmpClass employee;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    employee = new EmpClass();
                    employee.Id = Convert.ToInt32(dr[0]);
                    employee.Name = dr[1].ToString();
                    employee.Salary = Convert.ToDouble(dr[3].ToString());
                    employee.Dob = (DateTime)dr[4];
                    employee.Address = dr[5].ToString();
                    employee.Status = dr[6].ToString();
                    employees.Add(employee);
                }
                return employees;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<EmpClass> employees = new List<EmpClass>();
            SqlCommand cmd = new SqlCommand("proc_employee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter daEmployee = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                daEmployee.Fill(ds, "EmpClass");//Connect-->Fetch the data->put it in the dataset->give the name provided->disconnect from db
                EmpClass employee;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    employee = new EmpClass();
                    employee.Id = Convert.ToInt32(dr[0]);
                    employee.Name = dr[1].ToString();
                    employee.Salary = Convert.ToDouble(dr[2].ToString());
                    employee.Dob = (DateTime)dr[3];
                    employee.Address = dr[4].ToString();
                    employee.Status = dr[5].ToString();
                    employees.Add(employee);
                }
                //return View(employees);
                return View(employees);
            }
            catch (Exception e)
            {
                return RedirectToAction("Privacy", "Home");
            }
        }

        public JsonResult Kendo(EmpClass empClass)
        {
            List<EmpClass> employees = new List<EmpClass>();
            SqlCommand cmd = new SqlCommand("proc_employee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            SqlDataAdapter daEmployee = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                daEmployee.Fill(ds, "EmpClass");//Connect-->Fetch the data->put it in the dataset->give the name provided->disconnect from db
                EmpClass employee;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    employee = new EmpClass();
                    employee.Id = Convert.ToInt32(dr[0]);
                    employee.Name = dr[1].ToString();
                    employee.Salary = Convert.ToDouble(dr[2].ToString());
                    employee.Dob = (DateTime)dr[3];
                    employee.Address = dr[4].ToString();
                    employee.Status = dr[5].ToString();
                    employees.Add(employee);
                }
                //return View(employees);
                return Json(new { Id=empClass.Id });
            }
            catch (Exception e)
            {
                return Json(new { message="failure" });
            }
        }
    }
}
