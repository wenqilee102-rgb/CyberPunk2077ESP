using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocTokenPopupData : inkGameNotificationData
	{
		private CyberwareUpgradeCostData _costData;
		private CHandle<UIInventoryItem> _baseItemData;
		private CHandle<UIInventoryItem> _option1InventoryItem;
		private CHandle<UIInventoryItem> _option2InventoryItem;
		private CHandle<UIInventoryItem> _option3InventoryItem;
		private CHandle<InventoryTooltiData_CyberwareUpgradeData> _cyberwareUpgradeData;
		private CHandle<ItemDisplayContextData> _displayContext;
		private CHandle<gameItemData> _option1GameItemData;
		private CHandle<gameItemData> _option2GameItemData;
		private CHandle<gameItemData> _option3GameItemData;
		private CHandle<gameItemData> _option1SideItemData;
		private CHandle<gameItemData> _option2SideItemData;
		private CHandle<gameItemData> _option3SideItemData;

		[Ordinal(7)] 
		[RED("costData")] 
		public CyberwareUpgradeCostData CostData
		{
			get => GetProperty(ref _costData);
			set => SetProperty(ref _costData, value);
		}

		[Ordinal(8)] 
		[RED("baseItemData")] 
		public CHandle<UIInventoryItem> BaseItemData
		{
			get => GetProperty(ref _baseItemData);
			set => SetProperty(ref _baseItemData, value);
		}

		[Ordinal(9)] 
		[RED("option1InventoryItem")] 
		public CHandle<UIInventoryItem> Option1InventoryItem
		{
			get => GetProperty(ref _option1InventoryItem);
			set => SetProperty(ref _option1InventoryItem, value);
		}

		[Ordinal(10)] 
		[RED("option2InventoryItem")] 
		public CHandle<UIInventoryItem> Option2InventoryItem
		{
			get => GetProperty(ref _option2InventoryItem);
			set => SetProperty(ref _option2InventoryItem, value);
		}

		[Ordinal(11)] 
		[RED("option3InventoryItem")] 
		public CHandle<UIInventoryItem> Option3InventoryItem
		{
			get => GetProperty(ref _option3InventoryItem);
			set => SetProperty(ref _option3InventoryItem, value);
		}

		[Ordinal(12)] 
		[RED("cyberwareUpgradeData")] 
		public CHandle<InventoryTooltiData_CyberwareUpgradeData> CyberwareUpgradeData
		{
			get => GetProperty(ref _cyberwareUpgradeData);
			set => SetProperty(ref _cyberwareUpgradeData, value);
		}

		[Ordinal(13)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(14)] 
		[RED("option1GameItemData")] 
		public CHandle<gameItemData> Option1GameItemData
		{
			get => GetProperty(ref _option1GameItemData);
			set => SetProperty(ref _option1GameItemData, value);
		}

		[Ordinal(15)] 
		[RED("option2GameItemData")] 
		public CHandle<gameItemData> Option2GameItemData
		{
			get => GetProperty(ref _option2GameItemData);
			set => SetProperty(ref _option2GameItemData, value);
		}

		[Ordinal(16)] 
		[RED("option3GameItemData")] 
		public CHandle<gameItemData> Option3GameItemData
		{
			get => GetProperty(ref _option3GameItemData);
			set => SetProperty(ref _option3GameItemData, value);
		}

		[Ordinal(17)] 
		[RED("option1SideItemData")] 
		public CHandle<gameItemData> Option1SideItemData
		{
			get => GetProperty(ref _option1SideItemData);
			set => SetProperty(ref _option1SideItemData, value);
		}

		[Ordinal(18)] 
		[RED("option2SideItemData")] 
		public CHandle<gameItemData> Option2SideItemData
		{
			get => GetProperty(ref _option2SideItemData);
			set => SetProperty(ref _option2SideItemData, value);
		}

		[Ordinal(19)] 
		[RED("option3SideItemData")] 
		public CHandle<gameItemData> Option3SideItemData
		{
			get => GetProperty(ref _option3SideItemData);
			set => SetProperty(ref _option3SideItemData, value);
		}

		public RipperdocTokenPopupData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
