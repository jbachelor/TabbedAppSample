using System;
using Prism.Events;

namespace TabbedAppSample.Infrastructure
{
	public class TabChanged : PubSubEvent<string> { }
}
