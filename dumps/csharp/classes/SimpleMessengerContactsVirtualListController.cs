using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleMessengerContactsVirtualListController : inkVirtualListController
	{
		private CHandle<SimpleMessengerContactDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private CHandle<QuestListVirtualTemplateClassifier> _classifier;

		[Ordinal(9)] 
		[RED("dataView")] 
		public CHandle<SimpleMessengerContactDataView> DataView
		{
			get => GetProperty(ref _dataView);
			set => SetProperty(ref _dataView, value);
		}

		[Ordinal(10)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(11)] 
		[RED("classifier")] 
		public CHandle<QuestListVirtualTemplateClassifier> Classifier
		{
			get => GetProperty(ref _classifier);
			set => SetProperty(ref _classifier, value);
		}

		public SimpleMessengerContactsVirtualListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
