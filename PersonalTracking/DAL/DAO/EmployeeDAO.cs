using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class EmployeeDAO : EmployeeContext
    {
        public static void AddEmployee(EMPLOYEE employee)
        {
            try
            {
                db.EMPLOYEE.InsertOnSubmit(employee);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EmployeeDetailDTO> GetEmployees()
        {
            List<EmployeeDetailDTO> employeeList = new List<EmployeeDetailDTO>();
            var list = (from e in db.EMPLOYEE
                        join d in db.DEPARTMENT on e.DepartmentID equals d.ID
                        join p in db.POSITION on e.PositionID equals p.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            Name = e.Name,
                            Surname = e.Surname,
                            EmployeeId = e.ID,
                            Password = e.Password,
                            DepartmentName = d.DepartmentName,
                            PositionName = p.PositionName,
                            DepartmentID = e.DepartmentID,
                            PositionID = e.PositionID,
                            isAdmin = e.isAdmin,
                            Salary = e.Salary,
                            ImagePath = e.ImagePath,
                            Birthday = e.BirthDay,
                            Address = e.Adress
                        }).OrderBy(x => x.UserNo).ToList();
            foreach (var item in list)
            {
                EmployeeDetailDTO dto = new EmployeeDetailDTO();

                dto.UserNo = item.UserNo;
                dto.Name = item.Name;
                dto.Surname = item.Surname;
                dto.EmployeeID = item.EmployeeId;
                dto.Password = item.Password;
                dto.DepartmentName = item.DepartmentName;
                dto.PositionName = item.PositionName;
                dto.PositionID = item.PositionID;
                dto.DepartmentID = item.DepartmentID;
                dto.isAdmin = item.isAdmin;
                dto.Salary = item.Salary;
                dto.ImagePath = item.ImagePath;
                dto.BirthDay = item.Birthday;
                dto.Address = item.Address;

                employeeList.Add(dto);
            }

            return employeeList;
        }

        public static void UpdateEmployee(POSITION position)
        {
            List<EMPLOYEE> list = db.EMPLOYEE.Where(x => x.PositionID == position.ID).ToList();
            foreach(var item in list)
            {
                item.DepartmentID = position.DepartmentID;
            }
            db.SubmitChanges();
        }

        public static void UpdateEmployee(EMPLOYEE employee)
        {
            try
            {
                EMPLOYEE emp = db.EMPLOYEE.First(x => x.ID == employee.ID);
                emp.UserNo = employee.UserNo;
                emp.Name = employee.Name;
                emp.Surname = employee.Surname;
                emp.Password = employee.Password;
                emp.isAdmin = employee.isAdmin;
                emp.BirthDay = employee.BirthDay;
                emp.Adress = employee.Adress;
                emp.DepartmentID = employee.DepartmentID;
                emp.PositionID = employee.PositionID;
                emp.ImagePath = employee.ImagePath;
                emp.Salary = employee.Salary;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdateEmployee(int employeeID, int amount)
        {
            try
            {
                EMPLOYEE employee = db.EMPLOYEE.First(x => x.ID == employeeID);
                employee.Salary = amount;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EMPLOYEE> GetEmployees(int v, string text)
        {
            try
            {
                List<EMPLOYEE> list = db.EMPLOYEE.Where(x => x.UserNo == v && x.Password == text).ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EMPLOYEE> GetUsers(int v)
        {
            return db.EMPLOYEE.Where(x => x.UserNo == v).ToList();
        }
    }
}
