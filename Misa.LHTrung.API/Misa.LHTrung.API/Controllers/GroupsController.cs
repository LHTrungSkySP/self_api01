using Microsoft.AspNetCore.Mvc;
using Misa.LHTrung.API.Entity;
using Swashbuckle.AspNetCore.Annotations;

namespace Misa.LHTrung.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        /// <summary>
        /// API Lấy toàn bộ danh sách tổ
        /// </summary>
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(List<Group>))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAllGroups()
        {
            return StatusCode(StatusCodes.Status200OK, new List<Group>
            {
                new Group
                {
                    GroupID = Guid.NewGuid(),
                    GroupCode = "D001",
                    GroupName = "Tổ Toán - Tin",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "admin",
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = "admin"
                },
                new Group
                {
                    GroupID = Guid.NewGuid(),
                    GroupCode = "D002",
                    GroupName = "Tổ Lý - Hóa",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "admin",
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = "admin"
                },
                new Group
                {
                    GroupID = Guid.NewGuid(),
                    GroupCode = "D003",
                    GroupName = "Tổ Sinh - Sử - Địa",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "admin",
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = "admin"
                },
                new Group
                {
                    GroupID = Guid.NewGuid(),
                    GroupCode = "D004",
                    GroupName = "tổ Anh Văn",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "admin",
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = "admin"
                },
                new Group
                {
                    GroupID = Guid.NewGuid(),
                    GroupCode = "D005",
                    GroupName = "Tổ Ngữ Văn",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "admin",
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = "admin"
                },
                new Group
                {
                    GroupID = Guid.NewGuid(),
                    GroupCode = "D006",
                    GroupName = "Tổ Văn Phòng",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "admin",
                    ModifiedDate = DateTime.UtcNow,
                    ModifiedBy = "admin"
                }


            });
        }
    }
}