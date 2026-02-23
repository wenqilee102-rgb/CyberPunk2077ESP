using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemWeaponBars : IScriptable
	{
		private CArray<CHandle<UIInventoryItemWeaponBar>> _values;
		private CEnum<UIInventoryItemWeaponBarsType> _type;
		private CEnum<gamedataItemType> _itemType;
		private CHandle<UIInventoryItemWeaponBars> _comparedBars;

		[Ordinal(0)] 
		[RED("Values")] 
		public CArray<CHandle<UIInventoryItemWeaponBar>> Values
		{
			get => GetProperty(ref _values);
			set => SetProperty(ref _values, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<UIInventoryItemWeaponBarsType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(3)] 
		[RED("comparedBars")] 
		public CHandle<UIInventoryItemWeaponBars> ComparedBars
		{
			get => GetProperty(ref _comparedBars);
			set => SetProperty(ref _comparedBars, value);
		}

		public UIInventoryItemWeaponBars(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
