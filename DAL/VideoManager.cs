using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
   public  class VideoManager
    {
        public int Add(Video Video)
        {
            string sql = "insert into Video(Video_Id,Video_Title,Video_Intro,Video_Path,Video_Image,Video_DeleteId,Video_CreateTime,Video_UpdateTime) " +
                         "values(@Video_Id,@Video_Title,@Video_Intro,@Video_Path,@Video_Image,@Video_DeleteId,@Video_CreateTime,@Video_UpdateTime)";

            return SqlHelper<Video>.ExceuteNonQuery(sql, Video);
        }

        public int Edit(Video Video)
        {
            string sql = "update Video set Video_Title = @Video_Title ,Video_Intro = @Video_Intro ,Video_Path = @Video_Path ,Video_Image = @Video_Image,Video_UpdateTime = @Video_UpdateTime where Video_Id = @Video_Id";
            return SqlHelper<Video>.ExceuteNonQuery(sql, Video);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Video set Video_DeleteId = 0 where Video_Id = @Video_Id";
            return SqlHelper<Video>.ExceuteNonQuery(sql, new Video() { Video_Id = id });
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Restore(Guid id)
        {
            string sql = "update Video set Video_DeleteId = 1 where Video_Id = @Video_Id";
            return SqlHelper<Video>.ExceuteNonQuery(sql, new Video() { Video_Id = id });
        }

        public int Delete(Guid id)
        {
            string sql = "delete from Video where Video_DeleteId = 0 and Video_Id = @Video_Id";
            return SqlHelper<Video>.ExceuteNonQuery(sql, new Video() { Video_Id = id });
        }

        public IList<Video> GetAll()
        {
            string sql = "select * from Video where Video_DeleteId = 1";
            return SqlHelper<Video>.Query(sql, null);
        }

        public IList<Video> GetVideoByTitle(string title)
        {
            string sql = "select * from Video where Video_DeleteId = 1 and Video_Title like @Video_Title";
            return SqlHelper<Video>.Query(sql, new Video { Video_Title = "%" + title + "%" });
        }


        public Video GetVideoById(Guid id)
        {
            string sql = "select * from Video where Video_Id = @Video_Id";
            return SqlHelper<Video>.Query(sql, new Video() { Video_Id = id }).FirstOrDefault();
        }

        public IList<Video> GetAllInTrash()
        {
            string sql = "select * from Video where Video_DeleteId = 0";
            return SqlHelper<Video>.Query(sql, null);
        }

        public IList<Video> GetVideoByTitleInTrash(string title)
        {
            string sql = "select * from Video where Video_DeleteId = 0 and Video_Title like @Video_Title";
            return SqlHelper<Video>.Query(sql, new Video { Video_Title = "%" + title + "%" });
        }
        public IList<Video> GetVideoFrontPageById(Guid id) 
        {
            string sql = "select * from Video where Video_Id = @Video_Id";
            return SqlHelper<Video>.Query(sql, new Video() { Video_Id = id });
        }
    }
}
