using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReplaceEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;
		private CInt32 _slotIndex;
		private CBool _addToInventory;
		private CBool _rerollIdOnAddToInventory;
		private CBool _removeOldItem;
		private gameItemID _customPartToGenerateID;
		private CBool _transferInstalledParts;

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(2)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(3)] 
		[RED("addToInventory")] 
		public CBool AddToInventory
		{
			get => GetProperty(ref _addToInventory);
			set => SetProperty(ref _addToInventory, value);
		}

		[Ordinal(4)] 
		[RED("rerollIdOnAddToInventory")] 
		public CBool RerollIdOnAddToInventory
		{
			get => GetProperty(ref _rerollIdOnAddToInventory);
			set => SetProperty(ref _rerollIdOnAddToInventory, value);
		}

		[Ordinal(5)] 
		[RED("removeOldItem")] 
		public CBool RemoveOldItem
		{
			get => GetProperty(ref _removeOldItem);
			set => SetProperty(ref _removeOldItem, value);
		}

		[Ordinal(6)] 
		[RED("customPartToGenerateID")] 
		public gameItemID CustomPartToGenerateID
		{
			get => GetProperty(ref _customPartToGenerateID);
			set => SetProperty(ref _customPartToGenerateID, value);
		}

		[Ordinal(7)] 
		[RED("transferInstalledParts")] 
		public CBool TransferInstalledParts
		{
			get => GetProperty(ref _transferInstalledParts);
			set => SetProperty(ref _transferInstalledParts, value);
		}

		public ReplaceEquipmentRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
