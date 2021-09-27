using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace rockstar_webapi.Controllers
{
    [ApiController]
    public class MusicController : ControllerBase
    {
        private Music myMusic = new Music();

        private readonly ILogger<MusicController> _logger;

        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public String Get()
        {
            return "<h1>My Jukebox!</h1>";
        }

        [HttpGet]
        [Route("[controller]/SleepOnTheFloor")]
        public String GetSleepOnTheFloor()
        {
            return myMusic.SleepOnTheFloor;
        }

        [HttpGet]
        [Route("[controller]/GirlsLikeYou")]
        public String GetGirlsLikeYou()
        {
            return myMusic.GirlsLikeYou;
        }
    }
}
