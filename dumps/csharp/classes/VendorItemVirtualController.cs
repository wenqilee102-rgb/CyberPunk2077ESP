using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorItemVirtualController : inkVirtualCompoundItemController
	{
		private CHandle<VendorInventoryItemData> _data;
		private CHandle<VendorUIInventoryItemData> _newData;
		private wCHandle<InventoryItemDisplayController> _itemViewController;
		private CBool _isSpawnInProgress;

		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<VendorInventoryItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(19)] 
		[RED("newData")] 
		public CHandle<VendorUIInventoryItemData> NewData
		{
			get => GetProperty(ref _newData);
			set => SetProperty(ref _newData, value);
		}

		[Ordinal(20)] 
		[RED("itemViewController")] 
		public wCHandle<InventoryItemDisplayController> ItemViewController
		{
			get => GetProperty(ref _itemViewController);
			set => SetProperty(ref _itemViewController, value);
		}

		[Ordinal(21)] 
		[RED("isSpawnInProgress")] 
		public CBool IsSpawnInProgress
		{
			get => GetProperty(ref _isSpawnInProgress);
			set => SetProperty(ref _isSpawnInProgress, value);
		}

		public VendorItemVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
