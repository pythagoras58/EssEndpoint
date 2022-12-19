using EssEndpoint.Model;
using Microsoft.AspNetCore.Mvc;

namespace EssEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BulkLeaveController : ControllerBase
    {
       
        [HttpPost(Name = "GetEndpointLeave")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEndpointLeave(List<LeaveTransactionDTO> leave)
        {
            //LeaveTransactionDTO leaveTransactionDTO = new LeaveTransactionDTO();
            List<LeaveTransactionDTO> leaveTransactionDTOs = new List<LeaveTransactionDTO>();
            
            foreach(LeaveTransactionDTO dTO in leave)
            {
                LeaveTransactionDTO newDto = new LeaveTransactionDTO();
                newDto.leaveCode = dTO.leaveCode;
                newDto.ecode = dTO.ecode;
                newDto.numberOfDays = dTO.numberOfDays;
                newDto.startDate = dTO.startDate;

                leaveTransactionDTOs.Add(newDto);
            }
           

            return Ok(leaveTransactionDTOs);
        }
    }
}