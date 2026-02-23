using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryPartsData : CVariable
	{
		private TweakDBID _slotID;
		private CArray<gameInventoryItemData> _itemData;
		private CBool _toRebuild;

		[Ordinal(0)] 
		[RED("SlotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("ItemData")] 
		public CArray<gameInventoryItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(2)] 
		[RED("ToRebuild")] 
		public CBool ToRebuild
		{
			get => GetProperty(ref _toRebuild);
			set => SetProperty(ref _toRebuild, value);
		}

		public InventoryPartsData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
