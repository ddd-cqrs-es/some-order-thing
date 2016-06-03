﻿namespace SomeOrderThing.Messages.Events
{
    using System;

    public class OrderPlaced : MessageBase
    {
        public OrderPlaced() : base()
        {
            this.CausationId = Guid.Empty;
            this.CorrelationId = Guid.NewGuid();
        }

        public TableOrder Order { get; set; }
    }
}
