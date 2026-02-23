using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryCyberwareItemChooser : InventoryGenericItemChooser
	{
		private inkCompoundWidgetReference _leftSlotsContainer;
		private inkCompoundWidgetReference _rightSlotsContainer;
		private gameInventoryItemData _itemData;

		[Ordinal(17)] 
		[RED("leftSlotsContainer")] 
		public inkCompoundWidgetReference LeftSlotsContainer
		{
			get => GetProperty(ref _leftSlotsContainer);
			set => SetProperty(ref _leftSlotsContainer, value);
		}

		[Ordinal(18)] 
		[RED("rightSlotsContainer")] 
		public inkCompoundWidgetReference RightSlotsContainer
		{
			get => GetProperty(ref _rightSlotsContainer);
			set => SetProperty(ref _rightSlotsContainer, value);
		}

		[Ordinal(19)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		public InventoryCyberwareItemChooser(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
