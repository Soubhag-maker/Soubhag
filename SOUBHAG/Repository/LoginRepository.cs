using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOUBHAG.Entity;
using SOUBHAG.Data;

namespace SOUBHAG.Repository
{
    public interface ILoginRepository
    {
        LoginEntity Login(LoginEntity entity);
        adm0001Entity GetModules(int UserId );
        adm0001Entity GetSubModules(int menuId);
        adm0001Entity GetPagesList(int UserId);
    }

    public class LoginRepository: ILoginRepository
    {
       

        private readonly AppDbContext _Context;

        public LoginRepository(AppDbContext Context)
        {
            _Context = Context;
            //Rslt = rslt;
        }

        public LoginEntity Login(LoginEntity entity)
        {
            var onj = new LoginEntity();
            _Context.Database.BeginTransaction();
            List<string> lsterror = new List<string>();
            try
            {
                var getdata = (_Context.ba1110.Where(x => x.UserNam == entity.UserNam && x.UserLgnPwd== entity.UserLgnPwd)).FirstOrDefault();
                if (getdata != null)
                {
                    return getdata;
                }
                else
                {
                    _Context.Database.CurrentTransaction.Rollback();
                    return getdata;
                }
            }
            catch (Exception ex)
            {
                _Context.Database.CurrentTransaction.Rollback();
                lsterror.Add(ex.Message);
               
                return onj;
            }
        }
        public adm0001Entity GetModules(int UserId)
        {
            var obj1 = new adm0001Entity();
            try
            {
                if (UserId == 2)
                {
                    obj1.ModuleList = (from A in _Context.Adm0001
                                      where A.IsModule==1 && A.Active==1
                                       select new adm0001Entity()
                                       {
                                           MenuID = A.MenuId,
                                           MenuCaption = A.MenuCaption


                                       }).ToList();

                }
                else
                {
                    obj1.ModuleList = (from A in _Context.ba1110
                                       let B = _Context.ba1111.Where(r => A.UserId == r.FkUserId && r.FkCompId == 3).FirstOrDefault()
                                       //join B in Context.Ba1111 on A.UserId equals B.FkUserId
                                       let C = _Context.usr0050.Where(r => (B.FkRoleId == r.RoleId) || (A.FkRoleId == r.RoleId)).FirstOrDefault()
                                       //join C in Context.Usr0050 on B.FkRoleId equals C.RoleId
                                       //join D in _Context.usr0051 on C.RoleId equals D.FkRoleId
                                       join E in _Context.Adm0001
                                           on A.PortalUser equals E.ApplicableForPortal
                                       where A.UserId == UserId && new[] { 1, 2, 3 }.Contains(E.MenuId)
                                       select new adm0001Entity()
                                       {
                                           MenuID = E.MenuId,
                                           MenuCaption = E.MenuCaption


                                       }).ToList();
                }
            }
            catch(Exception ex)
            {

            }


            return obj1;
        }

        public adm0001Entity GetSubModules(int menuId)
        {
            var obj1 = new adm0001Entity();
            try
            {

                obj1.SubModuleList = (from A in _Context.Adm0001
                                   where A.IsSubModule==1 && A.FkMenuId== menuId && A.Active==1
                                      select new adm0001Entity()
                                   {
                                       MenuID = A.MenuID,
                                       MenuCaption = A.MenuCaption


                                   }).ToList();
            }
            catch (Exception ex)
            {

            }


            return obj1;
        }

        public adm0001Entity GetPagesList(int UserId)
        {
            var obj1 = new adm0001Entity();
            try
            {
               
                    obj1.ModuleList = obj1.ModuleList = GetModuleListRecursive(UserId);


            }
            catch (Exception ex)
            {

            }


            return obj1;
        }
        private List<adm0001Entity> GetModuleListRecursive(int userId)
        {
            List<adm0001Entity> moduleList = new List<adm0001Entity>();

            var initialModules = _Context.Adm0001
                .Where(a => a.FkMenuId == userId && a.Active == 1)
                .Select(a => new adm0001Entity()
                {
                    MenuID = a.MenuId,
                    MenuCaption = a.MenuCaption,
                    IsPage=a.IsPage,
                    FkMenuId=a.FkMenuId,
                    MenuOrderNo=a.MenuOrderNo,
                    PageUrl=a.PageUrl
                    
                }).ToList();

            moduleList.AddRange(initialModules);

            foreach (var module in initialModules)
            {
                if (module.PageID != 1) // Keep fetching until PageId == 1
                {
                    moduleList.AddRange(GetModuleListRecursive(module.MenuID));
                }
            }

            return moduleList;
        }


    }
}
