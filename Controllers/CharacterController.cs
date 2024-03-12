global using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService CharacterService)
        {
            _characterService = CharacterService;
        }
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get(){
            // NotFound, BadRequest
            return Ok(_characterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public ActionResult<List<Character>> GetSingle( int id ){
            // NotFound, BadRequest
            return Ok(_characterService.GetCharacterByID(id));
        }
        [HttpPost]
        public ActionResult <List<Character>> AddCharacter (Character newCharacter)
        {
            return Ok (_characterService.AddCharacter(newCharacter));
        }
    }
}