using System;
using System.Collections.Generic;
using Model;
using System.Linq;
namespace Dal
{
    public class dal
    {
        JanChaContext Db;

        public dal(JanChaContext _db)
        {
            Db = _db;
        }

        public List<Stu> GetList()
        {
            var data = from s in Db.Movies select s;
            return data.ToList();
        }
    }
}
