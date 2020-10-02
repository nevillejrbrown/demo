using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.Models.Pocos;

namespace demo.Models
{
    public interface ITopicService
    {
        public ICollection<Topic> GetAllTopics();
        public Topic FindById(int id);
        public void AddTopic(Topic topicToAdd);
        public void deleteTopic(int id);
    }
}
