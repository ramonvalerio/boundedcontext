using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace BoundedContext.NucleoCompartilhado.Domain.Model
{
    public static class NotificationMessage
    {
        private static Dictionary<string, List<string>> _messages;

        static NotificationMessage()
        {
            _messages = new Dictionary<string, List<string>>();
        }

        public static void AddMessage(this AggregateRoot aggregateRoot, string message)
        {
            if (_messages.ContainsKey(aggregateRoot.Id.ToString()))
            {
                _messages[aggregateRoot.Id.ToString()].Add(message);
                return;
            }
                
            _messages.Add(aggregateRoot.Id.ToString(), new List<string> { message });
        }

        public static void AddMessage(this AggregateRoot aggregateRoot, params string[] messages)
        {
            if (_messages.ContainsKey(aggregateRoot.Id.ToString()))
            {
                _messages[aggregateRoot.Id.ToString()].AddRange(messages);
                return;
            }

            _messages.Add(aggregateRoot.Id.ToString(), messages.ToList());
        }

        public static void AddMessage(this Entity entity, string message)
        {
            if (_messages.ContainsKey(entity.Id.ToString()))
            {
                _messages[entity.Id.ToString()].Add(message);
                return;
            }
                
            _messages.Add(entity.Id.ToString(), new List<string> { message });
        }

        public static void AddMessage(this Entity entity, params string[] messages)
        {
            if (_messages.ContainsKey(entity.Id.ToString()))
            {
                _messages[entity.Id.ToString()].AddRange(messages);
                return;
            }

            _messages.Add(entity.Id.ToString(), messages.ToList());
        }

        public static ImmutableList<string> Messages(this AggregateRoot aggregateRoot)
        {
            return _messages[aggregateRoot.Id.ToString()].ToImmutableList();
        }
    }
}