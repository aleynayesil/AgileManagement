using AgileManagement.Domain.models;
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

    public class ProjectSprintDto
    {
        public string ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SprintDto> Sprints { get; set; } = new List<SprintDto>();
    }


    public class SprintResponseDto
    {
        public ProjectSprintDto ProjectSprintDto { get; set; } = new ProjectSprintDto();
    }
}
