using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiTest.Repository.IRepository;
using CommentDataAccess;
namespace ApiTest.Repository
{
    public class EmplyeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmplyeeRepository(EmplyeeDBEntities9 context) : base(context)
        {

        }
        public List<Employee> Get(string query)
        {

            Comment model = new Comment();
            model.Comment1 = query;
            this.context.Comments.Add(model);
            base.SaveChanges();
            return context.Employees.Where(c => c.FirstName == query).ToList();

        }

    }
}