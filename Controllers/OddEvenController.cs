//Griffin Parker
//October, 25, 2022
//Odd Or Even - Endpoint
//This program takes a user's input through the url. It determines if the input is an int, and if it is, it will tell the user if the number is odd or even
//Peer Review -Elizar Garcia, code runs as intended. tells me if the number i enter is even or odd. shows up on postman without a problem and is clean and easy to read. Great job!!

//https://localhost:xxxx/OddOrEven/    <= To access the instructions
//https://localhost:xxxx/OddOrEven/OddorEven/{number}      <= To access the full program

using Microsoft.AspNetCore.Mvc;

namespace ParkerGOddOrEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
//type https://localhost:xxxx/OddOrEven/    to access the instructions
    public string Instructions()
{
return "In order to determine if your number is odd or even, type \n\nhttps://localhost:xxxx/OddOrEven/OddorEven/{number}\n\nBe sure to change the 'xxxx' to where your system is hosting it locally, and change {number} to the number you want to be tested";
}

    [HttpGet]
    [Route("OddOrEven/{number}")]
    public string OddEven(int number)
    {
    if(number % 2 == 0)
    {return "This is an even number";
    }else return "this is an odd number";
    }

}
