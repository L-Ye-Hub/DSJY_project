using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
  public  class TeamServices
    {
        TeamManager pm = new TeamManager();
        public int Add(Team Team)
        {
            return pm.Add(Team);
        }

        public int Edit(Team Team)
        {
            return pm.Edit(Team);
        }

        public int PutTrash(Guid id)
        {
            return pm.PutTrash(id);
        }
        /// <summary>
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            return pm.Restore(id);
        }

        public int Delete(Guid id)
        {
            return pm.Delete(id);
        }

        public IList<Team> GetAll()
        {
            return pm.GetAll();
        }

        public IList<Team> GetTeamByTitle(string title)
        {
            return pm.GetTeamByTitle(title);
        }


        public Team GetTeamById(Guid id)
        {
            return pm.GetTeamById(id);
        }

        public IList<Team> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<Team> GetTeamByTitleInTrash(string title)
        {
            return pm.GetTeamByTitleInTrash(title);
        }
    }
}
