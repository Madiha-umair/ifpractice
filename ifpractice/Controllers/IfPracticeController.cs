using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ifpractice.Controllers
{
    public class IfPracticeController : ApiController
    {
        [Route ("api/CoinComputer/{Nickles}/{Dimes}/{Quartes}/{Loonies}/{Twoonies}")]
        [HttpGet]
        Public string CoinComputer(Double Nickles, Double Dimes, Double Quarters, Double Loonies, Double Twoonies)
        {
            Double NoOfCoins = Nickles+Dimes+Quarters+Loonies+Twoonies;
            if (NoOfCoins== 10.50)
            { return "True"; }
            else 
            { return "False";
            }
        }

    }
}
