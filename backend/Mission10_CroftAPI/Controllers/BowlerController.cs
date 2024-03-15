//Author: Nya Croft
//Section 004

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_CroftAPI.Data;

namespace Mission10_CroftAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        // Connects and queries table
        [HttpGet]
        public IEnumerable<Object> Get()
        {
            var bowlerData = from bowler in _bowlerRepository.Bowlers
                             join team in _bowlerRepository.Teams
                             on bowler.TeamID equals team.TeamID
                             where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                             select new
                             {
                                 BowlerID = bowler.BowlerID,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerMiddleInit = bowler.BowlerMiddleInit,
                                 BowlerLastName = bowler.BowlerLastName,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                 TeamName = team.TeamName
                             };

            var joinedList = bowlerData.ToList();

            return joinedList;
        }

    }
}
