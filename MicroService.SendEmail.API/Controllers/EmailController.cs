using MicroService.SendEmail.Application.Services;
using MicroService.SendEmail.Domain.Entities;
using MicroService.SendEmail.Domain.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroService.SendEmail.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IBaseService<Email> baseService;
        public EmailController(IBaseService<Email> baseService)
        {
            this.baseService = baseService;
        }

        // GET: api/<EmailController>
        [HttpGet]
        public IEnumerable<Email> Get()
        {
            return baseService.GetAll();
        }

        // GET api/<EmailController>/5
        [HttpGet("{id}")]
        public Email Get(int id)
        {
            return baseService.GetById(id);
        }

        // POST api/<EmailController>
        [HttpPost]
        public void Post([FromBody] Email email)
        {
            baseService.Insert(email);
            baseService.Save();
        }

        // PUT api/<EmailController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Email email)
        {
            email.Id = id;
            baseService.Update(email);
            baseService.Save();
        }

        // DELETE api/<EmailController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            baseService.Delete(id);
            baseService.Save();
        }
    }
}
