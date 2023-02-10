using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class TaskBLL
    {
        public static TaskDTO GetAll()
        {
            TaskDTO dto = new TaskDTO();
            dto.Employees = EmployeeDAO.GetEmployees();
            dto.Departments = DepartmentDAO.GetDepartments();
            dto.Positions = PositionDAO.GetPosition();
            dto.TaskStates = TaskDAO.GetTaskStates();
            dto.Tasks = TaskDAO.GetTasks();
            return dto;
        }

        public static void AddTask(TASK task)
        {
            TaskDAO.AddTask(task);
        }

        public static void UpdateTask(TASK update)
        {
            TaskDAO.UpdateTask(update);
        }

        public static void DeleteTask(int taskID)
        {
            TaskDAO.DeleteTask(taskID);
        }
    }
}
