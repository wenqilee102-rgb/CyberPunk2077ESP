using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocCategoryTooltipData : ATooltipData
	{
		private CEnum<gamedataEquipmentArea> _category;
		private CInt32 _ownedItems;
		private CInt32 _availableItems;
		private CEnum<CyberwareScreenType> _screenType;

		[Ordinal(0)] 
		[RED("category")] 
		public CEnum<gamedataEquipmentArea> Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(1)] 
		[RED("ownedItems")] 
		public CInt32 OwnedItems
		{
			get => GetProperty(ref _ownedItems);
			set => SetProperty(ref _ownedItems, value);
		}

		[Ordinal(2)] 
		[RED("availableItems")] 
		public CInt32 AvailableItems
		{
			get => GetProperty(ref _availableItems);
			set => SetProperty(ref _availableItems, value);
		}

		[Ordinal(3)] 
		[RED("screenType")] 
		public CEnum<CyberwareScreenType> ScreenType
		{
			get => GetProperty(ref _screenType);
			set => SetProperty(ref _screenType, value);
		}

		public RipperdocCategoryTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
