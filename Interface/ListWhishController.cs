using Application.Interfaces; // Asegúrate de tener esta referencia para IListWhishService
using Domain.Entities; // Para ListWhish
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListWhishController : ControllerBase
    {
        private readonly IListWhish _listWhishService;
        private readonly ILogger<ListWhishController> _logger;

        public ListWhishController(IListWhish listWhishService,ILogger<ListWhishController> logger)
        {
            _listWhishService = listWhishService;
            _logger=logger;
            
        }
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<ListWhish>>> GetWishlistItemsByUserId(int userId)
        {
            try
            {
                _logger.LogInformation("Entered GetWishlistItemsByUserId with userId: {UserId}", userId);
                var items = await _listWhishService.GetWishlistItemsByUserIdAsync(userId);
                if (items == null || !items.Any())
                {
                    return NotFound();
                }
                return Ok(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddToWishlist([FromBody] ListWhish item)
        {
            try
            {
                if (item == null)
                {
                    return BadRequest("Item cannot be null");
                }

                await _listWhishService.AddToWishlistAsync(item);
                return CreatedAtAction(nameof(GetWishlistItemsByUserId), new { userId = item.UserId }, item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFromWishlist(int id)
        {
            try
            {
                var item = await _listWhishService.GetListWhish(id);
                if (item == null)
                {
                    return NotFound();
                }

                await _listWhishService.RemoveFromWishlistAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
