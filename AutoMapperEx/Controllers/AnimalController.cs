using AutoMapper;
using AutoMapperEx.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IMapper _mapper;

        public AnimalController(IMapper mapper)
        {
            _mapper = mapper;
        }

        //GET request
        [HttpGet("dog")]
        public ActionResult<DogDto> GetDog()
        {
            DateOnly date;

            var dog = new Dog
            {
                Id = 1,
                Name = "Fido",
                Born = date = new(2024, 3, 26),
                Weight = "15 kg",
                Dimension = "Medium",
                Kind = "Labrador"
            };
            var dogDto = _mapper.Map<DogDto>(dog);

            // it's possible to add a field in the response 

            var response = new
            {
                Dog = dogDto,
                FieldExtra = "That's not my dog!",
                StatusCode = 200,
            };

            return Ok(response);

            //return Ok(dogDto);
        }

        [HttpGet("cat")]
        public ActionResult<CatDto> GetCat()
        {
            Cat cat = new Cat
            {
                Id = 1,
                Name = "Felix",
                Born = new DateOnly(2021, 4, 15),
                Weight = "4 kg",
                Dimension = "Small",
                Kind = "Siamese",
                Indipendent = true
            };
            var catDto = _mapper.Map<CatDto>(cat);


            return Ok(catDto);
        }
    }
}
