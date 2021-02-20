using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment01.Models;
using assignment01.DS;
using System.Net.Http;
using System.Text.Json;


namespace assignment01.Controllers
{
    public class TeamController : Controller
    {
        const string BASE_URL = "https://statsapi.web.nhl.com/api/v1/";
        private readonly ILogger<TeamController> _logger;
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public People Peoples { get; set; }
        
        public ResponseDS ResponseDS { get; set; }

        public ResponsePlayerDS ResponsePlayerDS {get; set;}

        public PeopleResponseDS PeopleResponseDS {get; set;}

        public TeamController(ILogger<TeamController> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        
    public async Task<IActionResult> Index() {


        var message = new HttpRequestMessage();
        message.Method = HttpMethod.Get;
        message.RequestUri = new Uri($"{BASE_URL}/teams");
        message.Headers.Add("Accept", "application/json");

        var client = _clientFactory.CreateClient();

        var response = await client.SendAsync(message);
      

        if (response.IsSuccessStatusCode) {
            var responseStream = await response.Content.ReadAsStreamAsync();
            ResponseDS = await JsonSerializer.DeserializeAsync<ResponseDS>(responseStream);
            Teams = ResponseDS.teams;

        } else {
            Teams=Array.Empty<Team>();
        }

        return View(Teams);
  }

    public async Task<IActionResult> Details(int id) {


        var message = new HttpRequestMessage();
        message.Method = HttpMethod.Get;
        message.RequestUri = new Uri($"{BASE_URL}/teams/{id}/roster");
        message.Headers.Add("Accept", "application/json");

        var client = _clientFactory.CreateClient();

        var response = await client.SendAsync(message);
      

        if (response.IsSuccessStatusCode) {
            var responseStream = await response.Content.ReadAsStreamAsync();
            ResponsePlayerDS = await JsonSerializer.DeserializeAsync<ResponsePlayerDS>(responseStream);
            Players = ResponsePlayerDS.roster;

        } else {
            Players=Array.Empty<Player>();
        }

        return View(Players);
  }  
    public async Task<IActionResult> PeopleDetails(int id) {


        var message = new HttpRequestMessage();
        message.Method = HttpMethod.Get;
        message.RequestUri = new Uri($"{BASE_URL}/people/{id}");
        message.Headers.Add("Accept", "application/json");

        var client = _clientFactory.CreateClient();

        var response = await client.SendAsync(message);
      

        if (response.IsSuccessStatusCode) {
            var responseStream = await response.Content.ReadAsStreamAsync();
            PeopleResponseDS = await JsonSerializer.DeserializeAsync<PeopleResponseDS>(responseStream);
            Peoples = PeopleResponseDS.people.ElementAt(0);

        } else {
            // Peoples=Array.Empty<People>();
        }

        return View(Peoples);
  }    


    }
}
