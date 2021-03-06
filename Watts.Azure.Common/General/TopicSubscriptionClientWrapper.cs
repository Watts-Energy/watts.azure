﻿namespace Watts.Azure.Common.General
{
    using System;
    using Interfaces.Wrappers;
    using Microsoft.ServiceBus.Messaging;

    public class TopicSubscriptionClientWrapper : ITopicSubscriptionClient
    {
        private readonly SubscriptionClient subscriptionClient;

        public TopicSubscriptionClientWrapper(string connectionString, string topicPath, string name)
        {
            this.subscriptionClient = SubscriptionClient.CreateFromConnectionString(connectionString, topicPath, name);
        }

        public void OnMessage(Action<BrokeredMessage> callback)
        {
            this.subscriptionClient.OnMessage(callback);
        }
    }
}