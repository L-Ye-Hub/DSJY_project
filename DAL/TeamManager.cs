using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
  public  class TeamManager
    {
        public int Add(Team Team)
        {
            string sql = "insert into Team(Team_Id,Team_Title,Team_Image,Team_Content,Team_DeleteId,Team_CreateTime,Team_UpdateTime) " +
                         "values(@Team_Id,@Team_Title,@Team_Image,@Team_Content,@Team_DeleteId,@Team_CreateTime,@Team_UpdateTime)";

            return SqlHelper<Team>.ExceuteNonQuery(sql, Team);
        }

        public int Edit(Team Team)
        {
            string sql = "update Team set Team_Title = @Team_Title ,Team_Image = @Team_Image , Team_Content = @Team_Content,Team_UpdateTime = @Team_UpdateTime where Team_Id = @Team_Id";
            return SqlHelper<Team>.ExceuteNonQuery(sql, Team);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Team set Team_DeleteId = 0 where Team_Id = @Team_Id";
            return SqlHelper<Team>.ExceuteNonQuery(sql, new Team() { Team_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            string sql = "update Team set Team_DeleteId = 1 where Team_Id = @Team_Id";
            return SqlHelper<Team>.ExceuteNonQuery(sql, new Team() { Team_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Team where Team_DeleteId = 0 and Team_Id = @Team_Id";
            return SqlHelper<Team>.ExceuteNonQuery(sql, new Team() { Team_Id = id });
        }

        public IList<Team> GetAll()
        {
            string sql = "select * from Team where Team_DeleteId = 1";
            return SqlHelper<Team>.Query(sql, null);
        }

        public IList<Team> GetTeamByTitle(string title)
        {
            string sql = "select * from Team where Team_DeleteId = 1 and Team_Title like @Team_Title";
            return SqlHelper<Team>.Query(sql, new Team { Team_Title = "%" + title + "%" });
        }


        public Team GetTeamById(Guid id)
        {
            string sql = "select * from Team where Team_Id = @Team_Id";
            return SqlHelper<Team>.Query(sql, new Team() { Team_Id = id }).FirstOrDefault();
        }

        public IList<Team> GetAllInTrash()
        {
            string sql = "select * from Team where Team_DeleteId = 0";
            return SqlHelper<Team>.Query(sql, null);
        }

        public IList<Team> GetTeamByTitleInTrash(string title)
        {
            string sql = "select * from Team where Team_DeleteId = 0 and Team_Title like @Team_Title";
            return SqlHelper<Team>.Query(sql, new Team { Team_Title = "%" + title + "%" });
        }

    }
}
