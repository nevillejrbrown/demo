using demo.Models.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Models
{
    public class InMemoryTopicService : ITopicService
    {

        private readonly IDictionary<int,Topic> Topics = new Dictionary<int, Topic>()
        {
            {1,new Topic {Id=1, Name="MVC APIs", Progress = 0, State=TopicState.NOT_STARTED } },
            {2,new Topic {Id=2, Name="MVC Basics", Progress = 0, State=TopicState.NOT_STARTED } },
            {3,new Topic {Id=3, Name="Testing controllers", Progress = 0, State=TopicState.NOT_STARTED } },
        };


        public ICollection<Topic> GetAllTopics()
        {
            return Topics.Values;
        }

        public Topic FindById(int id)
        {
            return Topics[id];
        }

        public void AddTopic(Topic topicToAdd)
        {
            topicToAdd.Id = Topics.Keys.Max() + 1;
            Topics.Add(topicToAdd.Id, topicToAdd);
        }

        public void deleteTopic(int id)
        {
            Topics.Remove(id);
        }


    }
}
