using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWithEF.Models;
using TodoWithEF.Repositories;

namespace TodoWithEF.Services
{
    public class AssigneeRepository : IAssigneeRepository
    {
        private TodoContext todoContext;

        public AssigneeRepository(TodoContext context)
        {
            todoContext = context;
        }

        public void AddAssignee(Assignee newAssignee)
        {
            todoContext.Assignees.Add(newAssignee);
            todoContext.SaveChanges();
        }

        public void DeleteAssignee(int id)
        {
            todoContext.Assignees.Remove(GetAssignee(id));
            todoContext.SaveChanges();
        }

        public Assignee GetAssignee(int id)
        {
            return todoContext.Assignees.Where(a => a.ID == id).SingleOrDefault();
        }

        public List<Assignee> ListAllAssignees()
        {
            return todoContext.Assignees.ToList();
        }

        public void UpdateAssignee(Assignee updatedAssignee)
        {
            todoContext.Assignees.Update(updatedAssignee);
            todoContext.SaveChanges();
        }
    }
}
