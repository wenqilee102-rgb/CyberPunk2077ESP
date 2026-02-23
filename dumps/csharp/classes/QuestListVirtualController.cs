using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListVirtualController : inkVirtualListController
	{
		private CHandle<QuestListVirtualDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private CHandle<QuestListVirtualTemplateClassifier> _classifier;
		private wCHandle<QuestMissionLinkController> _controller;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CEnum<QuestListSortType> _questSortType;

		[Ordinal(9)] 
		[RED("dataView")] 
		public CHandle<QuestListVirtualDataView> DataView
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

		[Ordinal(12)] 
		[RED("controller")] 
		public wCHandle<QuestMissionLinkController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(13)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(14)] 
		[RED("questSortType")] 
		public CEnum<QuestListSortType> QuestSortType
		{
			get => GetProperty(ref _questSortType);
			set => SetProperty(ref _questSortType, value);
		}

		public QuestListVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
