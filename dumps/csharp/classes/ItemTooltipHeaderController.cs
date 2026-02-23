using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipHeaderController : ItemTooltipModuleController
	{
		private inkTextWidgetReference _itemNameText;
		private inkTextWidgetReference _itemRarityText;
		private inkTextWidgetReference _itemTypeText;
		private inkImageWidgetReference _itemEvolutionIcon;
		private CString _localizedIconicText;

		[Ordinal(5)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(6)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get => GetProperty(ref _itemRarityText);
			set => SetProperty(ref _itemRarityText, value);
		}

		[Ordinal(7)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get => GetProperty(ref _itemTypeText);
			set => SetProperty(ref _itemTypeText, value);
		}

		[Ordinal(8)] 
		[RED("itemEvolutionIcon")] 
		public inkImageWidgetReference ItemEvolutionIcon
		{
			get => GetProperty(ref _itemEvolutionIcon);
			set => SetProperty(ref _itemEvolutionIcon, value);
		}

		[Ordinal(9)] 
		[RED("localizedIconicText")] 
		public CString LocalizedIconicText
		{
			get => GetProperty(ref _localizedIconicText);
			set => SetProperty(ref _localizedIconicText, value);
		}

		public ItemTooltipHeaderController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
