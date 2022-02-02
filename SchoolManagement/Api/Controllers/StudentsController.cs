using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DomainModels.Dtos;
using DomainModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.DAL;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public StudentsController(AppDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet(Name ="list")]
        public async Task<IActionResult> Get()
        {
            ICollection<Student> students =await _dbContext.Students.ToListAsync();
            return Ok(_mapper.Map<List<StudentDto>>(students));
        }
    }
}
