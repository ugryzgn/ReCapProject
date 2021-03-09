using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UsersController : ControllerBase
//    {
//        IUserService _userService;

//        //public UsersController(IUserService userService)
//        //{
//        //    _userService = userService;
//        //}

//        //[HttpGet("getall")]
//        //public IActionResult Get1()
//        //{
//        //    var result = _userService.GetAll();
//        //    if (result.Success)
//        //    {
//        //        return Ok(result);
//        //    }
//        //    return BadRequest(result);
//        //}

//        //[HttpGet("getbyid")]
//        //public IActionResult Get2(int id)
//        //{
//        //    var result = _userService.GetByID(id);
//        //    if (result.Success)
//        //    {
//        //        return Ok(result);
//        //    }
//        //    return BadRequest(result);
//        //}

//        //[HttpGet("getbyfirstname")]
//        //public IActionResult Get3(string name)
//        //{
//        //    var result = _userService.GetByFirstName(name);
//        //    if (result.Success)
//        //    {
//        //        return Ok(result);
//        //    }
//        //    return BadRequest(result);
//        //}

//        //[HttpGet("getbylastname")]
//        //public IActionResult Get4(string name)
//        //{
//        //    var result = _userService.GetByLastName(name);
//        //    if (result.Success)
//        //    {
//        //        return Ok(result);
//        //    }
//        //    return BadRequest(result);
//        //}

//        //[HttpGet("getbyemail")]
//        //public IActionResult Get5(string email)
//        //{
//        //    var result = _userService.GetByEmail(email);
//        //    if (result.Success)
//        //    {
//        //        return Ok(result);
//        //    }
//        //    return BadRequest(result);
//        //}

//        //[HttpPost("add")]
//        //public IActionResult Post1(User user)
//        //{
//        //    var result = _userService.Add(user);
//        //    if (result.Success)
//        //    {
//        //        return Ok(result);
//        //    }
//        //    return BadRequest(result);
//        //}

//        //[HttpPost("delete")]
//        //public IActionResult Post2(User user)
//        //{
//        //    var result = _userService.Delete(user);
//        //    if (result.Success)
//        //    {
//        //        return Ok(result);
//        //    }
//        //    return BadRequest(result);
//        //}

//        //[HttpPost("update")]
//        //public IActionResult Post3(User user)
//        //{
//        //    var result = _userService.Update(user);
//        //    if (result.Success)
//        //    {
//        //        return Ok(result);
//        //    }
//        //    return BadRequest(result);
//        //}
//    }
//}
