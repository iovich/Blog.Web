
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blog.Web.Data;
using Blog.Web.Data.Entities;
using Blog.Web.Helpers;
using Blog.Web.Models.Category;

namespace Blog.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class BlogController : Controller
    {
        private readonly AppEFContext _appEFContext;
        private readonly IMapper _mapper;

        public BlogController(AppEFContext appEFContext, IMapper mapper)
        {
            _appEFContext = appEFContext;
            _mapper = mapper;
        }
    }
}
