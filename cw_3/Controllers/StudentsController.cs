﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw_3.Models;
using cw_3.DAL;
using Microsoft.AspNetCore.Mvc;

namespace cw_3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }


        //previous work
        /*[HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Malewski");
            }

            return NotFound("Nie znaleziono studenta");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult TestPut(int id)
        {
            if (id == 1)
            {
                return Ok("Aktualizacja dokończona");
            }

            return NotFound("Aktualizacja nie dokończona");
        }

        [HttpDelete("{id}")]
        public IActionResult TestDelete(int id)
        {
            if (id == 1)
            {
                return Ok("Usuwanie ukończone");
            }

            return NotFound("Usuwanie nie ukończone");
        }
        */
    }
}