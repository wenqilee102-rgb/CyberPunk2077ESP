using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramEntry : IScriptable
	{
		private gameItemID _itemID;
		private wCHandle<gamedataItem_Record> _equippedItem;
		private CArray<gameInventoryItemAbility> _abilities;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("equippedItem")] 
		public wCHandle<gamedataItem_Record> EquippedItem
		{
			get => GetProperty(ref _equippedItem);
			set => SetProperty(ref _equippedItem, value);
		}

		[Ordinal(2)] 
		[RED("abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get => GetProperty(ref _abilities);
			set => SetProperty(ref _abilities, value);
		}

		public ProgramEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
