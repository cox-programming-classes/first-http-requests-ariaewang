// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using CS_First_HTTP_Client;

HttpClient client = new()
{
    BaseAddress = new Uri("https://forms-dev.winsor.edu")
};

#region Build Authentication Request
var login = new Login("aria.wang@winsor.edu", "fnr843MXU%!&");

var jsonContent = JsonSerializer.Serialize(login);

var request = new HttpRequestMessage(HttpMethod.Post, "api/auth");
request.Content = new StringContent(
    jsonContent, Encoding.UTF8, "application/json");
#endregion

var response = await client.SendAsync(request);

var jsonResponse = await response.Content.ReadAsStringAsync();

AuthResponse auth = JsonSerializer.Deserialize<AuthResponse>(jsonResponse);

Console.WriteLine(auth);

request = new(HttpMethod.Get,"api/users/self");
request.Headers.Authorization =
    new("Bearer", auth.jwt);

response = await client.SendAsync(request);
jsonResponse = await response.Content.ReadAsStringAsync();
UserInfo user = JsonSerializer.Deserialize<UserInfo>(jsonResponse);
Console.WriteLine(user);