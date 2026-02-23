using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemModAttachment : UIInventoryItemMod
	{
		private CBool _isEmpty;
		private CString _slotName;
		private CEnum<gamedataQuality> _quality;
		private CInt32 _abilitiesSize;
		private CArray<gameInventoryItemAbility> _abilities;

		[Ordinal(0)] 
		[RED("IsEmpty")] 
		public CBool IsEmpty
		{
			get => GetProperty(ref _isEmpty);
			set => SetProperty(ref _isEmpty, value);
		}

		[Ordinal(1)] 
		[RED("SlotName")] 
		public CString SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(2)] 
		[RED("Quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(3)] 
		[RED("AbilitiesSize")] 
		public CInt32 AbilitiesSize
		{
			get => GetProperty(ref _abilitiesSize);
			set => SetProperty(ref _abilitiesSize, value);
		}

		[Ordinal(4)] 
		[RED("Abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get => GetProperty(ref _abilities);
			set => SetProperty(ref _abilities, value);
		}

		public UIInventoryItemModAttachment(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
