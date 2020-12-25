using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAppBS.Model;
using WebAppBS.Model.VM;

namespace WebAppBS_BLL.IRepository
{
   public interface IPost
    {

        Task<Post> AddPost(Post post);
        Task<object> GetUserPostDetails(PostFilterPagination postFilter);
    }
}
