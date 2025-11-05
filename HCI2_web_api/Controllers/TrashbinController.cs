using HCI2_web_api.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HCI2_web_api.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class TrashbinController : ControllerBase
    {


        private List<Trashbin> trashbins = new List<Trashbin>
        {
            //sample data
            new Trashbin
            {
                TrashbinId = 321,
                BodyColor = "black",
                StorageSizeInLiters = 5.5,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Trashbin
            {
                TrashbinId = 124,
                BodyColor = "blue",
                StorageSizeInLiters = 20,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        };


        [HttpGet]
        public ActionResult<List<Trashbin>> GetTrashbins()
        {
            if (trashbins == null) return NoContent();
            else return Ok(trashbins);
        }

        [HttpGet("{id}")]
        public ActionResult<Trashbin> GetTrashbinById(int id)
        {

            var trashbin = trashbins.FirstOrDefault(x => x.TrashbinId == id);
            if (trashbin == null) return NotFound();
            return Ok(trashbin);
            
        }

        [HttpPost]
        public ActionResult<Trashbin> AddTrashBin(Trashbin newTrashbin)
        {
            if (newTrashbin == null) return BadRequest();
            trashbins.Add(newTrashbin);
            return CreatedAtAction(nameof(GetTrashbinById), new {id = newTrashbin.TrashbinId}, newTrashbin);
        }

        

    }
}
