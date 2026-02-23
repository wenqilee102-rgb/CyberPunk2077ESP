using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipAttachmentGroupController : inkWidgetLogicController
	{
		private inkWidgetReference _indicatorContainer;
		private inkWidgetReference _indicatorWidget;
		private inkWidgetReference _rarityContainer;
		private inkImageWidgetReference _rarityWidget;
		private inkCompoundWidgetReference _entriesContainer;
		private CArray<wCHandle<NewItemTooltipAttachmentEntryController>> _entriesControllers;
		private CArray<CHandle<NewItemTooltipAttachmentEntryData>> _entriesData;
		private CInt32 _requestedEntries;
		private CBool _isEmpty;
		private CName _colorState;
		private CBool _isCrafting;

		[Ordinal(1)] 
		[RED("indicatorContainer")] 
		public inkWidgetReference IndicatorContainer
		{
			get => GetProperty(ref _indicatorContainer);
			set => SetProperty(ref _indicatorContainer, value);
		}

		[Ordinal(2)] 
		[RED("indicatorWidget")] 
		public inkWidgetReference IndicatorWidget
		{
			get => GetProperty(ref _indicatorWidget);
			set => SetProperty(ref _indicatorWidget, value);
		}

		[Ordinal(3)] 
		[RED("rarityContainer")] 
		public inkWidgetReference RarityContainer
		{
			get => GetProperty(ref _rarityContainer);
			set => SetProperty(ref _rarityContainer, value);
		}

		[Ordinal(4)] 
		[RED("rarityWidget")] 
		public inkImageWidgetReference RarityWidget
		{
			get => GetProperty(ref _rarityWidget);
			set => SetProperty(ref _rarityWidget, value);
		}

		[Ordinal(5)] 
		[RED("entriesContainer")] 
		public inkCompoundWidgetReference EntriesContainer
		{
			get => GetProperty(ref _entriesContainer);
			set => SetProperty(ref _entriesContainer, value);
		}

		[Ordinal(6)] 
		[RED("entriesControllers")] 
		public CArray<wCHandle<NewItemTooltipAttachmentEntryController>> EntriesControllers
		{
			get => GetProperty(ref _entriesControllers);
			set => SetProperty(ref _entriesControllers, value);
		}

		[Ordinal(7)] 
		[RED("entriesData")] 
		public CArray<CHandle<NewItemTooltipAttachmentEntryData>> EntriesData
		{
			get => GetProperty(ref _entriesData);
			set => SetProperty(ref _entriesData, value);
		}

		[Ordinal(8)] 
		[RED("requestedEntries")] 
		public CInt32 RequestedEntries
		{
			get => GetProperty(ref _requestedEntries);
			set => SetProperty(ref _requestedEntries, value);
		}

		[Ordinal(9)] 
		[RED("isEmpty")] 
		public CBool IsEmpty
		{
			get => GetProperty(ref _isEmpty);
			set => SetProperty(ref _isEmpty, value);
		}

		[Ordinal(10)] 
		[RED("colorState")] 
		public CName ColorState
		{
			get => GetProperty(ref _colorState);
			set => SetProperty(ref _colorState, value);
		}

		[Ordinal(11)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetProperty(ref _isCrafting);
			set => SetProperty(ref _isCrafting, value);
		}

		public NewItemTooltipAttachmentGroupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
