using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Library.Models;
using System.Net.Http;
using System.Text.Json;
using System.Dynamic;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _client;
        [ViewData]
        public string MyData { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI1IiwianRpIjoiNGVmZjM2ZjcxNThhMjhiNzc3M2I0YjdhZjRlN2E0ZjFjN2E4NzA5NWNiY2IyMDI4YTYxYTU1NTU0OGViNzliZWU0ZDE1ZDFiMDFkZTI0YjAiLCJpYXQiOjE2NDA0NDc2MzYsIm5iZiI6MTY0MDQ0NzYzNiwiZXhwIjoxNjcxOTgzNjM2LCJzdWIiOiIxMTQiLCJzY29wZXMiOltdfQ.JnMi5GDgI917NTHJd2eIRcDbYPxDn9nBUrFUI4ZxZrjkIigPIxAIPYXjpkNuXmVm0SV1KXTnlfZ2Kv1J4oPpwCR7Ke2ofsgeXk1dPbBXjcCwM6y_KYAgYmInthmnkGsKy8NhF350PAEU54zgJhhfaDXh7JoR8852e_jmMcK6WoM0hmviZO9CvqCtryyFMBJJHeuqc0ljIkmQ0b3oTdGDRSeUiRH6Ma5AH5q8jI6ATY9pAydCEiJPpKGu_7s-xB1BHIOv9BnPI_nlS29koaZXfGp2XOcCgZ_t_oPXLjm8CHZZA-FD0hSjnJE29OXfYfh83z2lY68ZmLTHBlIB0OKEXgfixjmF6umodCTBiVCDM0mRTNI26RVccVcN0uoQKPcwv_tMAlXZa_yLo4yXYT_6Vl1XTO-SYJsC0854Wmf_GWDdmtVLZlVGEBqCUxLbghtQTi4nNrlf-eggDrzhbhOguiB4DIEYNwQKFXnrKIM9iJy_d_VKVYtV3pBeEcHc0LQTP0iV9GSwuqwOCKPTLBTdyjLhhswHCVpNmIN8b2CVrctfH_KRuIla7gWZysOtu7qpF6dlVq4R7K4GnYESnqBKJwbNh0IV2P3O531605zbf5Qd90qw8ifvfeMuqA8F9hhbGqk8lzvlfmdJZO0jkBuKolLZovW0Ogeu9k9EOGe5LKw");
        }

        public IActionResult Index()
        {
            MyData =  "Mohammed" ;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }

        public ViewResult FAQ()
        {
            return View();
        }



        public async Task<IActionResult> AllContestAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get ,  "https://prize.wim-store.com/api/user/get_all_contest");
            var response = await _client.SendAsync(request);
            var responseBody = await response.Content.ReadAsStringAsync();
            var objectBody = JsonSerializer.Deserialize<KhModel.Root>(responseBody);
            return View(objectBody.data.data);
        }
    }
}
