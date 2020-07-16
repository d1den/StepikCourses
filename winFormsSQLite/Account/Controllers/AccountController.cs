using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Account.Repositories;


namespace Account.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        TransactionRep repos = new TransactionRep();
        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IQueryable<UserTransaction> Get()
        {
            return repos.GetAll();
        }
        
    }
}
