using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PermissionDTO
    {
        public List<DEPARTMENT> Departments { get; set; }
        public List<PositionDTO> Position { get; set; }
        public List<PERMISSIONSTATE> States { get; set; }
        public List<PermissionDetailDTO> Permission { get; set; }
    }
}
