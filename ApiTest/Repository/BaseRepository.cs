using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Repository
{
    public class BaseRepository
    {
        protected readonly EmplyeeDBEntities9 context;

        public BaseRepository(EmplyeeDBEntities9 context)
        {
            this.context = context;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}