using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemTooltipWrapper : ATooltipData
	{
		private wCHandle<UIInventoryItem> _data;
		private CHandle<ItemDisplayContextData> _displayContext;
		private CInt32 _overridePrice;
		private CHandle<UIInventoryItemComparisonManager> _comparisonData;

		[Ordinal(0)] 
		[RED("data")] 
		public wCHandle<UIInventoryItem> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(2)] 
		[RED("overridePrice")] 
		public CInt32 OverridePrice
		{
			get => GetProperty(ref _overridePrice);
			set => SetProperty(ref _overridePrice, value);
		}

		[Ordinal(3)] 
		[RED("comparisonData")] 
		public CHandle<UIInventoryItemComparisonManager> ComparisonData
		{
			get => GetProperty(ref _comparisonData);
			set => SetProperty(ref _comparisonData, value);
		}

		public UIInventoryItemTooltipWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
