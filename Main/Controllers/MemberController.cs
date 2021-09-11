using Common;
using Microsoft.AspNetCore.Mvc;

namespace Main.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        Member _member = new Member
        {
            Name = "Tester",
            Age = 18
        };

        [HttpGet]
        public IActionResult Get()
        {
            // 200 但沒資料顯示，已確認解法為：
            // 1. 安裝套件 Microsoft.AspNetCore.Mvc.NewtonsoftJson
            // 2. Startup.cs ConfigureServices() 加上 services.AddControllers().AddNewtonsoftJson();
            return Ok(_member);
        }

        // solution 2: don't using IActionResult
        //[HttpGet]
        //public Member Get()
        //{
        //    return _member;
        //}

    }
}
