using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemQuantityChangedData : CVariable
	{
		private gameItemID _itemID;
		private CBool _isBackpackItem;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("isBackpackItem")] 
		public CBool IsBackpackItem
		{
			get => GetProperty(ref _isBackpackItem);
			set => SetProperty(ref _isBackpackItem, value);
		}

		public ItemQuantityChangedData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
