using System;
using System.Collections.Generic;

using R5T.T0064;


namespace R5T.D0119
{
	[ServiceImplementationMarker]
    public class NotificationService : IServiceImplementation
    {
        public Dictionary<string, EventNotifier> ChannelsByName { get; } = new Dictionary<string, EventNotifier>();
    }
}