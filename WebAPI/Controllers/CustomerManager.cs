using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerManager : ControllerBase
    {
        ICustomerService _customerService;
        public CustomerManager(ICustomerService customerService)
        {
            _customerService = customerService;
        }
    }
}
