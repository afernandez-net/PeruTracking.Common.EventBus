﻿namespace PeruShop.Services.Customers.Messages.Events
{
    using MediatR;
    using Newtonsoft.Json;
    using PeruTracking.Common.EventBus.Messaging;
    using System;

    public class CustomerCreated : IEvent, IRequest
    {
        public Guid Id { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public string Country { get; }

        [JsonConstructor]
        public CustomerCreated(Guid id, string email, string firstName,
            string lastName, string address, string country)
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Country = country;
        }
    }
}