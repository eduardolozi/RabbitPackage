﻿namespace RabbitCommon.Entities;

public class QueueBind
{
    public string QueueName { get; set; }
    public string ExchangeName { get; set; }
    public string RoutingKey { get; set; }
}