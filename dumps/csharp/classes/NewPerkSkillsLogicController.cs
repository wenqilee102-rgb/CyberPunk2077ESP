using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkSkillsLogicController : inkWidgetLogicController
	{
		private inkVirtualCompoundWidgetReference _virtualGridContainer;
		private inkWidgetReference _scrollBarContainer;
		private wCHandle<inkVirtualGridController> _virtualGrid;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private CHandle<inkVirtualItemTemplateClassifierWrapper> _itemsClassifier;
		private wCHandle<inkScrollController> _scrollBar;
		private wCHandle<PlayerDevelopmentDataManager> _dataManager;
		private CBool _isActiveScreen;
		private CBool _initialized;
		private CArray<CHandle<IScriptable>> _virtualItems;

		[Ordinal(1)] 
		[RED("virtualGridContainer")] 
		public inkVirtualCompoundWidgetReference VirtualGridContainer
		{
			get => GetProperty(ref _virtualGridContainer);
			set => SetProperty(ref _virtualGridContainer, value);
		}

		[Ordinal(2)] 
		[RED("scrollBarContainer")] 
		public inkWidgetReference ScrollBarContainer
		{
			get => GetProperty(ref _scrollBarContainer);
			set => SetProperty(ref _scrollBarContainer, value);
		}

		[Ordinal(3)] 
		[RED("virtualGrid")] 
		public wCHandle<inkVirtualGridController> VirtualGrid
		{
			get => GetProperty(ref _virtualGrid);
			set => SetProperty(ref _virtualGrid, value);
		}

		[Ordinal(4)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(5)] 
		[RED("itemsClassifier")] 
		public CHandle<inkVirtualItemTemplateClassifierWrapper> ItemsClassifier
		{
			get => GetProperty(ref _itemsClassifier);
			set => SetProperty(ref _itemsClassifier, value);
		}

		[Ordinal(6)] 
		[RED("scrollBar")] 
		public wCHandle<inkScrollController> ScrollBar
		{
			get => GetProperty(ref _scrollBar);
			set => SetProperty(ref _scrollBar, value);
		}

		[Ordinal(7)] 
		[RED("dataManager")] 
		public wCHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(8)] 
		[RED("isActiveScreen")] 
		public CBool IsActiveScreen
		{
			get => GetProperty(ref _isActiveScreen);
			set => SetProperty(ref _isActiveScreen, value);
		}

		[Ordinal(9)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(10)] 
		[RED("virtualItems")] 
		public CArray<CHandle<IScriptable>> VirtualItems
		{
			get => GetProperty(ref _virtualItems);
			set => SetProperty(ref _virtualItems, value);
		}

		public NewPerkSkillsLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
