﻿using Microsoft.AspNetCore.Mvc;
using WebApp2.Controller.Services;

namespace WebApp2.Controllers;

[ApiController]
[Route("[controller]")]
public class RobotSpottedController : ControllerBase // Map request to a response 
{
    private readonly ILogger<RobotSpottedController> _logger;
    private readonly LocationService _service;

    public RobotSpottedController(LocationService service, ILogger<RobotSpottedController> logger)
    {
        _service = service;
        _logger = logger;
    }    

    [HttpGet(Name = "RobotSpotted")]
    public string Get(double latitude, double longitude)
    {
        return $"Parameters are {latitude} & {longitude}";
    }

    [HttpPost(Name = "RobotSpotted")]
    public async Task<string> Post(Location location)
    {

        _logger.Log(LogLevel.Information, new EventId(), null, "Location name sent: " + location.Name, null);
       var x = await _service.GetNearestWaterLocation(location);

       return x.display_name;
    }
}

