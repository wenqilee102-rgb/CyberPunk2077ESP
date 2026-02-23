using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocInventoryController : inkWidgetLogicController
	{
		private inkVirtualCompoundWidgetReference _virtualGridContainer;
		private inkWidgetReference _scrollBarContainer;
		private inkTextWidgetReference _labelPrefix;
		private inkTextWidgetReference _labelSuffix;
		private wCHandle<inkVirtualGridController> _virtualGrid;
		private CHandle<RipperdocInventoryTemplateClassifier> _backpackItemsClassifier;
		private CHandle<inkScriptableDataSourceWrapper> _backpackItemsDataSource;
		private CHandle<inkScriptableDataViewWrapper> _backpackItemsDataView;
		private wCHandle<inkScrollController> _scrollBar;
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _opacityAnimation;
		private CHandle<PulseAnimation> _labelPulse;
		private CArray<CHandle<RipperdocWrappedUIInventoryItem>> _cachedPlayerItems;
		private CArray<CHandle<RipperdocWrappedUIInventoryItem>> _cachedVendorItems;
		private CEnum<gamedataEquipmentArea> _cachedArea;
		private CEnum<gamedataEquipmentArea> _openArea;
		private CEnum<gamedataStatType> _cachedAttribute;
		private CEnum<gamedataStatType> _openAttribute;
		private CBool _hasCache;
		private CBool _isAreaCache;

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
		[RED("labelPrefix")] 
		public inkTextWidgetReference LabelPrefix
		{
			get => GetProperty(ref _labelPrefix);
			set => SetProperty(ref _labelPrefix, value);
		}

		[Ordinal(4)] 
		[RED("labelSuffix")] 
		public inkTextWidgetReference LabelSuffix
		{
			get => GetProperty(ref _labelSuffix);
			set => SetProperty(ref _labelSuffix, value);
		}

		[Ordinal(5)] 
		[RED("virtualGrid")] 
		public wCHandle<inkVirtualGridController> VirtualGrid
		{
			get => GetProperty(ref _virtualGrid);
			set => SetProperty(ref _virtualGrid, value);
		}

		[Ordinal(6)] 
		[RED("backpackItemsClassifier")] 
		public CHandle<RipperdocInventoryTemplateClassifier> BackpackItemsClassifier
		{
			get => GetProperty(ref _backpackItemsClassifier);
			set => SetProperty(ref _backpackItemsClassifier, value);
		}

		[Ordinal(7)] 
		[RED("backpackItemsDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource
		{
			get => GetProperty(ref _backpackItemsDataSource);
			set => SetProperty(ref _backpackItemsDataSource, value);
		}

		[Ordinal(8)] 
		[RED("backpackItemsDataView")] 
		public CHandle<inkScriptableDataViewWrapper> BackpackItemsDataView
		{
			get => GetProperty(ref _backpackItemsDataView);
			set => SetProperty(ref _backpackItemsDataView, value);
		}

		[Ordinal(9)] 
		[RED("scrollBar")] 
		public wCHandle<inkScrollController> ScrollBar
		{
			get => GetProperty(ref _scrollBar);
			set => SetProperty(ref _scrollBar, value);
		}

		[Ordinal(10)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(11)] 
		[RED("opacityAnimation")] 
		public CHandle<inkanimProxy> OpacityAnimation
		{
			get => GetProperty(ref _opacityAnimation);
			set => SetProperty(ref _opacityAnimation, value);
		}

		[Ordinal(12)] 
		[RED("labelPulse")] 
		public CHandle<PulseAnimation> LabelPulse
		{
			get => GetProperty(ref _labelPulse);
			set => SetProperty(ref _labelPulse, value);
		}

		[Ordinal(13)] 
		[RED("cachedPlayerItems")] 
		public CArray<CHandle<RipperdocWrappedUIInventoryItem>> CachedPlayerItems
		{
			get => GetProperty(ref _cachedPlayerItems);
			set => SetProperty(ref _cachedPlayerItems, value);
		}

		[Ordinal(14)] 
		[RED("cachedVendorItems")] 
		public CArray<CHandle<RipperdocWrappedUIInventoryItem>> CachedVendorItems
		{
			get => GetProperty(ref _cachedVendorItems);
			set => SetProperty(ref _cachedVendorItems, value);
		}

		[Ordinal(15)] 
		[RED("cachedArea")] 
		public CEnum<gamedataEquipmentArea> CachedArea
		{
			get => GetProperty(ref _cachedArea);
			set => SetProperty(ref _cachedArea, value);
		}

		[Ordinal(16)] 
		[RED("openArea")] 
		public CEnum<gamedataEquipmentArea> OpenArea
		{
			get => GetProperty(ref _openArea);
			set => SetProperty(ref _openArea, value);
		}

		[Ordinal(17)] 
		[RED("cachedAttribute")] 
		public CEnum<gamedataStatType> CachedAttribute
		{
			get => GetProperty(ref _cachedAttribute);
			set => SetProperty(ref _cachedAttribute, value);
		}

		[Ordinal(18)] 
		[RED("openAttribute")] 
		public CEnum<gamedataStatType> OpenAttribute
		{
			get => GetProperty(ref _openAttribute);
			set => SetProperty(ref _openAttribute, value);
		}

		[Ordinal(19)] 
		[RED("hasCache")] 
		public CBool HasCache
		{
			get => GetProperty(ref _hasCache);
			set => SetProperty(ref _hasCache, value);
		}

		[Ordinal(20)] 
		[RED("isAreaCache")] 
		public CBool IsAreaCache
		{
			get => GetProperty(ref _isAreaCache);
			set => SetProperty(ref _isAreaCache, value);
		}

		public RipperdocInventoryController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
