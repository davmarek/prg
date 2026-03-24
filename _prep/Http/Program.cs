using System.Net.Http.Headers;
using System.Net.Http.Json;

HttpClient httpClient = new();
httpClient.BaseAddress = new Uri("https://tictactoe.davmarek.cz/");

var r = await httpClient.GetAsync("/");
Console.WriteLine(r.StatusCode);
