using Materials.Contracts.Materials;
using MaterialsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaterialsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialsController : ControllerBase
    {
        private readonly ILogger<MaterialsController> _logger;

        public MaterialsController(ILogger<MaterialsController> logger)
        {
            _logger = logger;
        }

        [HttpPut]
        public ActionResult CreateMaterial(CreateMaterialRequest request)
        {
            DateTime date = DateTime.Now;
            Material material = new Material(request.Name,
                                             request.Description,
                                             request.Quantity,
                                             request.UnitPrice,
                                             request.Unit,
                                             date,
                                             date);

            // todo: create new material

            MaterialResponse response = new MaterialResponse();

            return Ok(response);
        }
    }
}