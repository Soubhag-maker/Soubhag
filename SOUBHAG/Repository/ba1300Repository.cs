using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOUBHAG.Entity;
using SOUBHAG.Data;

namespace SOUBHAG.Repository
{
    public interface Iba1300Repository
    {
        ba1300Entity LoadFind();
    }

    public class ba1300Repository: Iba1300Repository
    {

        private readonly AppDbContext _Context;

        public ba1300Repository(AppDbContext Context)
        {
            _Context = Context;
        }

        public ba1300Entity LoadFind()
        {
            var obj = new ba1300Entity();

            obj.List = (from A in _Context.ba1300
                        select new ba1300Entity()
                        {
                            EmpId = A.EmpId,
                            EmpNo = A.EmpNo
                        }).ToList();

            return obj;
        }


    }
}
