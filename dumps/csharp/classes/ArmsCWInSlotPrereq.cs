using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArmsCWInSlotPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataCheckType> _slotCheckType;
		private CEnum<gamedataItemType> _itemType;
		private CName _itemTag;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(1)] 
		[RED("slotCheckType")] 
		public CEnum<gamedataCheckType> SlotCheckType
		{
			get => GetProperty(ref _slotCheckType);
			set => SetProperty(ref _slotCheckType, value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(3)] 
		[RED("itemTag")] 
		public CName ItemTag
		{
			get => GetProperty(ref _itemTag);
			set => SetProperty(ref _itemTag, value);
		}

		[Ordinal(4)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public ArmsCWInSlotPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
