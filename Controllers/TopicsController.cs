using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demo.Models;
using demo.Models.Pocos;
using Microsoft.Extensions.Logging;

namespace demo.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ILogger<TopicsController> _logger;
        private readonly ITopicService _topicService;

        public TopicsController(ITopicService topicService, ILogger<TopicsController> logger)
        {
            _topicService = topicService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            _logger.LogDebug("Getting list of topics");
         //   ViewData["topics"] = _topicService.GetAllTopics();
            return View(_topicService.GetAllTopics());
        }

        public IActionResult Create()
        {
            _logger.LogDebug("Creating new topic");
            //   ViewData["topics"] = _topicService.GetAllTopics();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] Topic topic)
        {
            _topicService.AddTopic(topic);
            return RedirectToAction(nameof(List), _topicService.GetAllTopics());
        }
    }
}
