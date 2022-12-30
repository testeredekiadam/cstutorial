using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PermissionDAO : EmployeeContext
    {
        public static void AddPermission(PERMISSION permission)
        {
            try
            {
                db.PERMISSION.InsertOnSubmit(permission);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PERMISSIONSTATE> GetStates()
        {
            return db.PERMISSIONSTATE.ToList();
        }

        public static List<PermissionDetailDTO> GetPermissions()
        {
            List<PermissionDetailDTO> permissions = new List<PermissionDetailDTO>();

            var list = (from p in db.PERMISSION
                        join s in db.PERMISSIONSTATE on p.PermissionState equals s.ID
                        join e in db.EMPLOYEE on p.EmployeeID equals e.ID
                        select new
                        {
                            UserNo = e.UserNo,
                            name = e.Name,
                            surname = e.Surname,
                            StateName = s.StateName,
                            stateID = s.ID,
                            startDate = p.PermissionStartDate,
                            endDate = p.PermissionEndDate,
                            employeeID = e.ID,
                            permissionID = p.ID,
                            explanation = p.PermissionExplanation,
                            DayAmount = p.PermissionDay,
                            departmentID = e.DepartmentID,
                            positionID = p.ID
                        }).OrderBy(x => x.startDate).ToList();

            foreach (var item in list)
            {
                PermissionDetailDTO dto = new PermissionDetailDTO();

                dto.UserNo = item.UserNo;
                dto.Name = item.Name
            }

            return permissions;
        }
    }
}