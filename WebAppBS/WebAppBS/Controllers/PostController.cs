using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppBS.Model;
using WebAppBS.Model.VM;
using WebAppBS_BLL.IRepository;

namespace WebAppBS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {


        private readonly IPost _post;
        public PostController(IPost post)
        {
            this._post = post;
        }

        [HttpPost("AddPost")]
        public ActionResult AddPost(Post post)
        {
            return new JsonResult(this._post.AddPost(post));
        }

        [HttpGet("GetPostDetails")]
        public async Task<ActionResult> GetPostDetails(PostFilterPagination postFilter)
        {

            try
            {
                var res = await this._post.GetUserPostDetails(postFilter);
                return Ok(res);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
