using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class TaskDAO : EmployeeContext
    {
        public static List<TASKSTATE> GetTaskStates()
        {
            return db.TASKSTATE.ToList();
        }

        public static void AddTask(TASK task)
        {
            try
            {
                db.TASK.InsertOnSubmit(task);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<TaskDetailDTO> GetTasks()
        {
            List<TaskDetailDTO> tasklist = new List<TaskDetailDTO>();

            var list = (from t in db.TASK
                        join s in db.TASKSTATE on t.TaskState equals s.ID
                        join e in db.EMPLOYEE on t.EmployeeID equals e.ID
                        join d in db.DEPARTMENT on e.DepartmentID equals d.ID
                        join p in db.POSITION on e.PositionID equals p.ID
                        select new
                        {
                            taskID = t.ID,
                            title = t.TaskTitle,
                            content = t.TaskContent,
                            startDate = t.TaskStartDate,
                            deliveryDate = t.TaskDeliveryDate,
                            taskStateName = s.StateName,
                            taskStateID = t.TaskState,
                            UserNo = e.UserNo,
                            Name = e.Name,
                            EmployeeID = t.EmployeeID,
                            Surname = e.Surname,
                            positionName = p.PositionName,
                            departmentName = d.DepartmentName,
                            positionID = e.PositionID,
                            departmentID = e.DepartmentID
                        }).OrderBy(x => x.startDate).ToList();

            foreach (var item in list)
            {
                TaskDetailDTO dto = new TaskDetailDTO();
                dto.TaskID = item.taskID;
                dto.Title = item.title;
                dto.Content = item.content;
                dto.TaskStartDate = item.startDate;
                dto.TaskDeliveryDate = item.deliveryDate;
                dto.TaskStateName = item.taskStateName;
                dto.TaskStateID = item.taskStateID;
                dto.UserNo = item.UserNo;
                dto.Name = item.Name;
                dto.EmployeeID = item.EmployeeID;
                dto.Surname = item.Surname;
                dto.PositionName = item.positionName;
                dto.DepartmentName = item.departmentName;
                dto.PositionID = item.positionID;
                tasklist.Add(dto);

            }

            return tasklist;
        }

        public static void DeleteTask(int taskID)
        {
          /*  try
            {
                TASK ts = db.
            }
            catch (Exception ex)
            {

                throw ex;
            }*/
        }

        public static void UpdateTask(TASK update)
        {
            try
            {
                TASK ts = db.TASK.First(x => x.ID == update.ID);
                ts.TaskTitle = update.TaskTitle;
                ts.TaskContent = update.TaskContent;
                ts.TaskState = update.TaskState;
                ts.EmployeeID = update.EmployeeID;
                ts.TaskDeliveryDate = update.TaskDeliveryDate;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
