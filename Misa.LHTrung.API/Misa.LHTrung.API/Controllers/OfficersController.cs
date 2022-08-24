using Microsoft.AspNetCore.Mvc;
using Misa.LHTrung.API.Entity;
using Misa.LHTrung.API.Entity.DTO;
using Misa.LHTrung.API.Enums;
using Swashbuckle.AspNetCore.Annotations;

namespace Misa.LHTrung.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficersController : ControllerBase
    {
        #region Method
        /// <summary>
        /// API Thêm mới 1 nhân viên
        /// </summary>
        /// <param name="officer">Đối tượng nhân viên muốn thêm mới</param>
        /// <returns>ID của nhân viên vừa thêm mới</returns>
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, type: typeof(Guid))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public IActionResult InsertEmployee([FromBody] Officer officer)
        {
            return StatusCode(StatusCodes.Status201Created, Guid.NewGuid());
        }

        /// <summary>
        /// API Sửa 1 nhân viên
        /// </summary>
        /// <param name="employeeID">ID của nhân viên muốn sửa</param>
        /// <param name="employee">Đối tượng nhân viên muốn sửa</param>
        /// <returns>ID của nhân viên vừa sửa</returns>
        [HttpPut("{OfficerID}")]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(Guid))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdateEmployee([FromRoute] Guid officerID, [FromBody] Officer officer)
        {
            return StatusCode(StatusCodes.Status200OK, officerID);
        }

        /// <summary>
        /// API Xóa 1 nhân viên
        /// </summary>
        /// <param name="employeeID">ID của nhân viên muốn xóa</param>
        /// <returns>ID của nhân viên vừa xóa</returns>
        /// Created by: TMSANG (09/06/2022)
        [HttpDelete("{OfficerID}")]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(Guid))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteEmployeeByID([FromRoute] Guid officerID)
        {
            return StatusCode(StatusCodes.Status200OK, officerID);
        }

        /// <summary>
        /// API Lấy danh sách nhân viên cho phép lọc và phân trang
        /// </summary>
        /// <param name="keyword">Từ khóa muốn tìm kiếm</param> 
        /// <param name="positionID">ID vị trí</param>
        /// <param name="departmentID">ID phòng ban</param>
        /// <param name="pageSize">Số trang muốn lấy</param>
        /// <param name="pageNumber">Thứ tự trang muốn lấy</param>
        /// <returns>Một đối tượng gồm:
        /// + Danh sách nhân viên thỏa mãn điều kiện lọc và phân trang
        /// + Tổng số nhân viên thỏa mãn điều kiện</returns>
        /// Created by: TMSANG (09/06/2022)
        [HttpGet]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(PagingData<Officer>))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public IActionResult FilterOfficer(
            [FromQuery] string? keyword,
            [FromQuery] Guid? subjectID,
            [FromQuery] Guid? groupID,
            [FromQuery] Guid? storageRoomID,
            [FromQuery] int pageSize = 10,
            [FromQuery] int pageNumber = 1)
        {
            // Object Initialize
            return StatusCode(StatusCodes.Status200OK, new PagingData<Officer>()
            {
                Data = new List<Officer>
                {
                    new Officer
                    {
                        OfficerID = Guid.NewGuid(),
                        OfficerCode = "NV00001",
                        FullName = "Trần Minh Sáng",
                        DateOfBirth = DateTime.UtcNow,
                        Gender = Gender.Male,
                        IdentityNumber = "0231654321",
                        GrantedPlace = "CA Hà Nội",
                        GrantedDay = DateTime.UtcNow,
                        Email = "sangtran.d14ptit@gmail.com",
                        PhoneNumber = "0355557796",
                        GroupID = Guid.NewGuid(),
                        GroupName = "Lập trình viên",
                        StorageRoomID = Guid.NewGuid(),
                        StorageRoomName = "Khối sản xuất",
                        SubjectID = Guid.NewGuid(),
                        SubjectName = "Khối sản xuất",
                        EMT=EMT.HavedEMT,
                        WorkStatus = WorkStatus.CurrentlyWorking,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = "admin",
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = "admin",
                        QuitDate=DateTime.UtcNow
                    },
                    new Officer
                    {
                                               OfficerID = Guid.NewGuid(),
                        OfficerCode = "NV00001",
                        FullName = "Trần Minh Sáng",
                        DateOfBirth = DateTime.UtcNow,
                        Gender = Gender.Male,
                        IdentityNumber = "0231654321",
                        GrantedPlace = "CA Hà Nội",
                        GrantedDay = DateTime.UtcNow,
                        Email = "sangtran.d14ptit@gmail.com",
                        PhoneNumber = "0355557796",
                        GroupID = Guid.NewGuid(),
                        GroupName = "Lập trình viên",
                        StorageRoomID = Guid.NewGuid(),
                        StorageRoomName = "Khối sản xuất",
                        SubjectID = Guid.NewGuid(),
                        SubjectName = "Khối sản xuất",
                        EMT=EMT.HavedEMT,
                        WorkStatus = WorkStatus.CurrentlyWorking,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = "admin",
                        ModifiedDate = DateTime.UtcNow,
                        ModifiedBy = "admin",
                        QuitDate=DateTime.UtcNow
                    }
                },
                TotalCount = 2
            });
        }
        /// <summary>
        /// API Lấy thông tin chi tiết của 1 nhân viên
        /// </summary>
        /// <param name="employeeID">ID của nhân viên muốn lấy thông tin chi tiết</param>
        /// <returns>Đối tượng nhân viên muốn lấy thông tin chi tiết</returns>
        /// Created by: TMSANG (09/06/2022)
        [HttpGet("{officerID}")]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(Officer))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public IActionResult GetOfficerByID([FromRoute] Guid officerID)
        {
            return StatusCode(StatusCodes.Status400BadRequest, new Officer
            {
                OfficerID = Guid.NewGuid(),
                OfficerCode = "NV00001",
                FullName = "Trần Minh Sáng",
                DateOfBirth = DateTime.UtcNow,
                Gender = Gender.Male,
                IdentityNumber = "0231654321",
                GrantedPlace = "CA Hà Nội",
                GrantedDay = DateTime.UtcNow,
                Email = "sangtran.d14ptit@gmail.com",
                PhoneNumber = "0355557796",
                GroupID = Guid.NewGuid(),
                GroupName = "Lập trình viên",
                StorageRoomID = Guid.NewGuid(),
                StorageRoomName = "Khối sản xuất",
                SubjectID = Guid.NewGuid(),
                SubjectName = "Khối sản xuất",
                EMT = EMT.HavedEMT,
                WorkStatus = WorkStatus.CurrentlyWorking,
                CreatedDate = DateTime.UtcNow,
                CreatedBy = "admin",
                ModifiedDate = DateTime.UtcNow,
                ModifiedBy = "admin",
                QuitDate = DateTime.UtcNow
            });
        }

        /// <summary>
        /// Lấy mã nhân viên tự động tăng
        /// </summary>
        /// <returns>
        /// Mã nhân viên tự động tăng
        /// </returns>
        /// Created by: TMSANG (16/08/2022)
        [HttpGet("new-code")]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(string))]
        [SwaggerResponse(StatusCodes.Status400BadRequest)]
        [SwaggerResponse(StatusCodes.Status500InternalServerError)]
        public IActionResult GetNewEmployeeCode()
        {
            return StatusCode(StatusCodes.Status200OK, "NV00003");
        }

    }
    #endregion

}
