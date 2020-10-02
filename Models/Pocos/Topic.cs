using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using demo.Models;

namespace demo.Models.Pocos
{

    public class Topic
    {
        [Display(Name = "Topic ID")]
        public int Id { get; set; }

        [Display(Name = "Topic name")] 
        public String Name { get; set; }

        [Display(Name = "Progress in percent")]
        public int Progress { get; set; }

        [Display(Name = "Topic state")]
        public TopicState State { get; set; }

    }
}
