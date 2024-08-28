using Microsoft.AspNetCore.Mvc;

using Web.Ej1;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public List<string> Get([FromQuery] List<String> listNames)
    {
        // var persona1 = new Persona(name1);
        // var persona2 = new Persona(name2);
        // var persona3 = new Persona(name3);
        // var personas = new List<string> {persona1.Saludar(), persona2.Saludar(),persona3.Saludar()};
        // return personas;

        List<String> saludos = new List<String>();
        List<Persona> personas = new List<Persona>();
        // names.Add(name1);
        // names.Add(name2);
        // names.Add(name3);
        foreach (String name in listNames)
        {
            personas.Add(new Persona(name));
        }
        foreach (Persona Persona in personas)
        {
            saludos.Add(Persona.Saludar());
        }

        return saludos;




    }
}