using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlotUserData : IScriptable
	{
		private wCHandle<UIInventoryItem> _item;
		private CInt32 _index;
		private CEnum<gamedataEquipmentArea> _area;
		private CBool _isLocked;
		private CBool _visibleWhenLocked;
		private CEnum<CyberwareScreenType> _screen;
		private CBool _isPerkRequired;
		private CBool _canUpgrade;
		private wCHandle<gamedataItem_Record> _upgradeItem;
		private CEnum<gamedataQuality> _upgradeItemQuality;

		[Ordinal(0)] 
		[RED("item")] 
		public wCHandle<UIInventoryItem> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(2)] 
		[RED("area")] 
		public CEnum<gamedataEquipmentArea> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(3)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(4)] 
		[RED("visibleWhenLocked")] 
		public CBool VisibleWhenLocked
		{
			get => GetProperty(ref _visibleWhenLocked);
			set => SetProperty(ref _visibleWhenLocked, value);
		}

		[Ordinal(5)] 
		[RED("screen")] 
		public CEnum<CyberwareScreenType> Screen
		{
			get => GetProperty(ref _screen);
			set => SetProperty(ref _screen, value);
		}

		[Ordinal(6)] 
		[RED("isPerkRequired")] 
		public CBool IsPerkRequired
		{
			get => GetProperty(ref _isPerkRequired);
			set => SetProperty(ref _isPerkRequired, value);
		}

		[Ordinal(7)] 
		[RED("canUpgrade")] 
		public CBool CanUpgrade
		{
			get => GetProperty(ref _canUpgrade);
			set => SetProperty(ref _canUpgrade, value);
		}

		[Ordinal(8)] 
		[RED("upgradeItem")] 
		public wCHandle<gamedataItem_Record> UpgradeItem
		{
			get => GetProperty(ref _upgradeItem);
			set => SetProperty(ref _upgradeItem, value);
		}

		[Ordinal(9)] 
		[RED("upgradeItemQuality")] 
		public CEnum<gamedataQuality> UpgradeItemQuality
		{
			get => GetProperty(ref _upgradeItemQuality);
			set => SetProperty(ref _upgradeItemQuality, value);
		}

		public SlotUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
