using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using poke_api;


string userInput = GetPokemonName();

while(userInput != "-1"){
    PokemonApiCall(userInput);
    userInput = GetPokemonName();
}




static string GetPokemonName(){
    System.Console.WriteLine("What is the name of the pokemon you would like to view details on? (-1 to stop)");
    return Console.ReadLine();
}

static async Task PokemonApiCall(string pokemonName)
{
    using (HttpClient client = new HttpClient())
    {
        try
        {
            var pokemon = await client.GetFromJsonAsync<Pokemon>("https://pokeapi.co/api/v2/pokemon/" + pokemonName);
            System.Console.WriteLine(pokemon);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
        }
    }
}
