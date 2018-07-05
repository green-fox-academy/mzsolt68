using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Models;

namespace TodoWithEF.Services
{
    public interface IAssigneeRepository
    {
        List<Assignee> ListAllAssignees();
        void AddAssignee(Assignee newAssignee);
        void DeleteAssignee(int id);
        void UpdateAssignee(Assignee updatedAssignee);
        Assignee GetAssignee(int id);
    }
}
