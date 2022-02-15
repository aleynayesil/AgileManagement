using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileManagement.Mvc.Areas.Admin.Models
{
    public class SprintAddInputModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProjectId { get; set; }
    }
}
