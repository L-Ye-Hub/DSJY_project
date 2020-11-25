using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class VideoServices
    {
        VideoManager pm = new VideoManager();
        public int Add(Video Video)
        {
            return pm.Add(Video);
        }

        public int Edit(Video Video)
        {
            return pm.Edit(Video);
        }

        public int PutTrash(Guid id)
        {
            return pm.PutTrash(id);
        }
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

        public IList<Video> GetAll()
        {
            return pm.GetAll();
        }

        public IList<Video> GetVideoByTitle(string title)
        {
            return pm.GetVideoByTitle(title);
        }


        public Video GetVideoById(Guid id)
        {
            return pm.GetVideoById(id);
        }

        public IList<Video> GetAllInTrash()
        {
            return pm.GetAllInTrash();
        }

        public IList<Video> GetVideoByTitleInTrash(string title)
        {
            return pm.GetVideoByTitleInTrash(title);
        }
        public IList<Video> GetVideoFrontPageById(Guid id)
        {
            return pm.GetVideoFrontPageById(id);
        }
    }
}
