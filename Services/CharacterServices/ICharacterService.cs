using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services.CharacterServices
{
    public interface ICharacterService
    {
        List<CharacterServices> GetAllCharacters();
        Character GetCharacterByID( int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}