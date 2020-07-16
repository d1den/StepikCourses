using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;

namespace Account.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IQueryable<dynamic> Get()
        {
            TrContext context = new TrContext();
                IQueryable<dynamic> result = context.Transactions.Join(context.Categories,
                    t => t.CategoryId,
                    c => c.Id,
                    (t, c) => new
                    {
                        type = t.Type,
                        category = c.Name,
                        sum = t.Sum,
                        comment = t.Comment,
                        date = t.Date
                    });
                return result;
        }
    }
}
