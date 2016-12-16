using Prism.Commands;
using Prism.Mvvm;
using Prism.Events;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace TabbedAppSample.ViewModels.ViewModels
{
	public class TabbedPageHostViewModel : BindableBase
	{
		readonly IEventAggregator _eventAggregator;

		public DelegateCommand PageChangedCommand { get; set; }

		public TabbedPageHostViewModel(IEventAggregator eventAggregator)
		{
			_eventAggregator = eventAggregator;

			PageChangedCommand = new DelegateCommand(PageChanged);
		}

		void PageChanged()
		{
			Debug.WriteLine($"{nameof(TabbedPageHostViewModel)}.PageChanged");
		}
	}
}
