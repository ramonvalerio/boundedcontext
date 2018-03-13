using BoundedContext.Common.Domain.Model;
using System;
using System.Collections.Generic;

namespace BoundedContext.ControleAcesso.Application.Commands
{
    public class PessoaCache
    {
        Dictionary<int, Pessoa> pessoas;
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public EventBroker Broker { get; set; }

        public Pessoa(EventBroker broker)
        {
            Broker = broker;
            Broker.Commands += BrokerOnCommands;
            Broker.Queries += BrokerOnQueries;
        }

        private void BrokerOnCommands(object sender, Command e)
        {
            var command = e as AlterarEmailCommand;

            if (command != null && command.IdTarget == this.Id)
            {
                Email = command.Email;
            }
        }

        private void BrokerOnQueries(object sender, Query e)
        {
            var query = e as EmailQuery;

            if (query != null && query.Target == this)
            {
                
            }
        }
    }

    public class AlterarEmailCommand : Command
    {
        public int IdTarget { get; set; }
        public string Email { get; set; }

        public AlterarEmailCommand(int idTarget, string email)
        {
            IdTarget = idTarget;
            Email = email;
        }
    }

    public class EmailQuery : Query
    {
        public Pessoa Target { get; set; }
    }

    public class EventBroker
    {
        public IList<Event> Events { get; set; }

        public event EventHandler<Command> Commands;

        public event EventHandler<Query> Queries;

        public void Command(Command command)
        {
            Commands?.Invoke(this, command);
        }

        public T Query<T>(Query query)
        {
            Queries?.Invoke(this, query);
            return (T)query.Result;
        }
    }

    public class Event
    {
        // backtrack
    }

    public class Query
    {
        public object Result { get; set; }
    }
}