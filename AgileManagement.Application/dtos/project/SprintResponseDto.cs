using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application
{


    public class SprintDto
    {
        public int SiraNo { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public ProjectDto Project { get; set; }
    }
    

    public class SprintResponseDto
    {
        public ProjectDto ProjectDto { get; set; } 
    }
}
