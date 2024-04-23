// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using CS_First_HTTP_Client;

ScheduleService scheduleService = new(ApiService.Current);

await ApiService.Current.AuthenticateAsync(new("aria.wang@winsor.edu", "fnr843MXU%!&"));

/*
 var user = await ApiService.Current.SendAsync<UserInfo>(HttpMethod.Get, "api/users/self");
Console.WriteLine(user);

var cycleDays = await ApiService.Current.SendAsync<CycleDay[]>
    (HttpMethod.Get, "api.schedule/cycle-day");

foreach (var day in cycleDays)
{
    Console.WriteLine($"{day.date: dddd dd MMMM} is {day.cycleDay}");
}
*/

var schedule = await scheduleService.GetAcademicSchedule();

//foreach(var )
    //Console.WriteLine();