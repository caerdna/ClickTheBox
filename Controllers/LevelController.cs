using ClickTheBox.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClickTheBox.API.Controllers
{
    [Route("api/level")]
    [ApiController]
    public class LevelController : ControllerBase
    {

        private static Dictionary<string, Level> levels;

        public LevelController()
        {
            levels = new Dictionary<string, Level>();

            levels.Add("01", new Level(
                new double[] { 10.0, 6.0, 4.5 },
                new double[] { 1.5, 1, 1 },
                20, 10));
            levels.Add("02", new Level(
                new double[] { 8.5, 3.5, 2.5 },
                new double[] { 2.0, 1, 1 },
                15, 10));
            levels.Add("03", new Level(
                new double[] { 6.5, 4.5, 1.5 },
                new double[] { 3.5, 2, 1 },
                10, 5));
        }



        #region GET INITIALIZE PAGE
        [HttpGet]
        [Route("welcome")]
        public async Task<GameInfoResponse> Welcome()
        {
            return new GameInfoResponse()
            {
                levels = new List<string>() { "01", "02", "03" }
            };
        }
        #endregion



        #region GET LEVEL BY ID
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Level>> GetLevel([FromRoute(Name = "id")] string levelId)
        {
            var level = levels.GetValueOrDefault(levelId);
            if (level == null)
            {
                return NotFound();
            }
            else { return level; }
        }
        #endregion

    }
}
