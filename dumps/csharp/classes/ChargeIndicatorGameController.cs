using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargeIndicatorGameController : ChargedHotkeyItemBaseController
	{
		private inkImageWidgetReference _itemIcon;
		private CEnum<ChargeIndicatorWidgetType> _type;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CString _iconName;
		private CName _itemType;
		private CEnum<gamedataEquipmentArea> _eqArea;
		private CHandle<redCallbackObject> _onEquipmentChangedIDBBID;
		private CFloat _c_fullChargeOpacity;

		[Ordinal(45)] 
		[RED("itemIcon")] 
		public inkImageWidgetReference ItemIcon
		{
			get => GetProperty(ref _itemIcon);
			set => SetProperty(ref _itemIcon, value);
		}

		[Ordinal(46)] 
		[RED("type")] 
		public CEnum<ChargeIndicatorWidgetType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(47)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(48)] 
		[RED("iconName")] 
		public CString IconName
		{
			get => GetProperty(ref _iconName);
			set => SetProperty(ref _iconName, value);
		}

		[Ordinal(49)] 
		[RED("itemType")] 
		public CName ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(50)] 
		[RED("eqArea")] 
		public CEnum<gamedataEquipmentArea> EqArea
		{
			get => GetProperty(ref _eqArea);
			set => SetProperty(ref _eqArea, value);
		}

		[Ordinal(51)] 
		[RED("OnEquipmentChangedIDBBID")] 
		public CHandle<redCallbackObject> OnEquipmentChangedIDBBID
		{
			get => GetProperty(ref _onEquipmentChangedIDBBID);
			set => SetProperty(ref _onEquipmentChangedIDBBID, value);
		}

		[Ordinal(52)] 
		[RED("c_fullChargeOpacity")] 
		public CFloat C_fullChargeOpacity
		{
			get => GetProperty(ref _c_fullChargeOpacity);
			set => SetProperty(ref _c_fullChargeOpacity, value);
		}

		public ChargeIndicatorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
