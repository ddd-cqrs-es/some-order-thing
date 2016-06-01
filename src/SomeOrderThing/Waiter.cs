﻿namespace SomeOrderThing
{
    public class Waiter
    {
        private readonly IHandleOrder orderHandler;

        public Waiter(IHandleOrder orderHandler)
        {
            this.orderHandler = orderHandler;
        }

        public void Handle(TableOrder order)
        {
            this.orderHandler.Handle(order);
        }
    }
}