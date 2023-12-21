using VirtualPetCare.API.API.Controllers.Core;
using VirtualPetCare.API.Application.Interfaces;

namespace VirtualPetCare.API.API.Controllers;

public class TrainingsController : BaseApiController
{
    private readonly ITrainingService _service;

    public TrainingsController(ITrainingService service)
    {
        _service = service;
    }
}