using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModController : inkWidgetLogicController
	{
		private inkWidgetReference _dotIndicator;
		private inkWidgetReference _rarityContainer;
		private inkImageWidgetReference _rarityWidget;
		private inkCompoundWidgetReference _modAbilitiesContainer;
		private wCHandle<InventoryItemPartDisplay> _partIndicatorController;
		private CBool _isCrafting;

		[Ordinal(1)] 
		[RED("dotIndicator")] 
		public inkWidgetReference DotIndicator
		{
			get => GetProperty(ref _dotIndicator);
			set => SetProperty(ref _dotIndicator, value);
		}

		[Ordinal(2)] 
		[RED("rarityContainer")] 
		public inkWidgetReference RarityContainer
		{
			get => GetProperty(ref _rarityContainer);
			set => SetProperty(ref _rarityContainer, value);
		}

		[Ordinal(3)] 
		[RED("rarityWidget")] 
		public inkImageWidgetReference RarityWidget
		{
			get => GetProperty(ref _rarityWidget);
			set => SetProperty(ref _rarityWidget, value);
		}

		[Ordinal(4)] 
		[RED("modAbilitiesContainer")] 
		public inkCompoundWidgetReference ModAbilitiesContainer
		{
			get => GetProperty(ref _modAbilitiesContainer);
			set => SetProperty(ref _modAbilitiesContainer, value);
		}

		[Ordinal(5)] 
		[RED("partIndicatorController")] 
		public wCHandle<InventoryItemPartDisplay> PartIndicatorController
		{
			get => GetProperty(ref _partIndicatorController);
			set => SetProperty(ref _partIndicatorController, value);
		}

		[Ordinal(6)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetProperty(ref _isCrafting);
			set => SetProperty(ref _isCrafting, value);
		}

		public ItemTooltipModController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
