using AgileManagement.Application.services.project;
using AgileManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManagement.Application.service
{
    public class SprintService : ISprintService
    {
        private readonly IProjectRepository _projectRepository;

        public SprintService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public SprintResponseDto OnProcess(SprintRequestDto request)
        {
            var projectSprint = _projectRepository.GetQuery().Include(x => x.Sprints).Where(y => y.Id == request.ProjectId).Select(a => new ProjectSprintDto
            {
                ProjectId = a.Id,
                Name = a.Name,
                Description = a.Description,
                Sprints = a.Sprints.OrderBy(b=>b.Name).Select(z => new
                SprintDto
                {
                    StartDate = z.StartDate,
                    EndDate = z.EndDate,
                    Name = z.Project.Name

                }).ToList()
            }).FirstOrDefault();

            var response = new SprintResponseDto
            {
                ProjectSprintDto = projectSprint
            };

            return response;
        }
    }
}
