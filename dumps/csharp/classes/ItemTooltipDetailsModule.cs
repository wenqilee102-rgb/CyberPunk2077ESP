using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipDetailsModule : ItemTooltipModuleController
	{
		private inkWidgetReference _statsLine;
		private inkWidgetReference _statsWrapper;
		private inkCompoundWidgetReference _statsContainer;
		private inkWidgetReference _dedicatedModsLine;
		private inkWidgetReference _dedicatedModsWrapper;
		private inkCompoundWidgetReference _dedicatedModsContainer;
		private inkWidgetReference _modsLine;
		private inkWidgetReference _modsWrapper;
		private inkCompoundWidgetReference _modsContainer;
		private inkWidgetReference _modifierPowerLine;
		private inkTextWidgetReference _modifierPowerLabel;
		private inkCompoundWidgetReference _modifierPowerWrapper;
		private CBool _isCrafting;

		[Ordinal(5)] 
		[RED("statsLine")] 
		public inkWidgetReference StatsLine
		{
			get => GetProperty(ref _statsLine);
			set => SetProperty(ref _statsLine, value);
		}

		[Ordinal(6)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetProperty(ref _statsWrapper);
			set => SetProperty(ref _statsWrapper, value);
		}

		[Ordinal(7)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetProperty(ref _statsContainer);
			set => SetProperty(ref _statsContainer, value);
		}

		[Ordinal(8)] 
		[RED("dedicatedModsLine")] 
		public inkWidgetReference DedicatedModsLine
		{
			get => GetProperty(ref _dedicatedModsLine);
			set => SetProperty(ref _dedicatedModsLine, value);
		}

		[Ordinal(9)] 
		[RED("dedicatedModsWrapper")] 
		public inkWidgetReference DedicatedModsWrapper
		{
			get => GetProperty(ref _dedicatedModsWrapper);
			set => SetProperty(ref _dedicatedModsWrapper, value);
		}

		[Ordinal(10)] 
		[RED("dedicatedModsContainer")] 
		public inkCompoundWidgetReference DedicatedModsContainer
		{
			get => GetProperty(ref _dedicatedModsContainer);
			set => SetProperty(ref _dedicatedModsContainer, value);
		}

		[Ordinal(11)] 
		[RED("modsLine")] 
		public inkWidgetReference ModsLine
		{
			get => GetProperty(ref _modsLine);
			set => SetProperty(ref _modsLine, value);
		}

		[Ordinal(12)] 
		[RED("modsWrapper")] 
		public inkWidgetReference ModsWrapper
		{
			get => GetProperty(ref _modsWrapper);
			set => SetProperty(ref _modsWrapper, value);
		}

		[Ordinal(13)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get => GetProperty(ref _modsContainer);
			set => SetProperty(ref _modsContainer, value);
		}

		[Ordinal(14)] 
		[RED("modifierPowerLine")] 
		public inkWidgetReference ModifierPowerLine
		{
			get => GetProperty(ref _modifierPowerLine);
			set => SetProperty(ref _modifierPowerLine, value);
		}

		[Ordinal(15)] 
		[RED("modifierPowerLabel")] 
		public inkTextWidgetReference ModifierPowerLabel
		{
			get => GetProperty(ref _modifierPowerLabel);
			set => SetProperty(ref _modifierPowerLabel, value);
		}

		[Ordinal(16)] 
		[RED("modifierPowerWrapper")] 
		public inkCompoundWidgetReference ModifierPowerWrapper
		{
			get => GetProperty(ref _modifierPowerWrapper);
			set => SetProperty(ref _modifierPowerWrapper, value);
		}

		[Ordinal(17)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetProperty(ref _isCrafting);
			set => SetProperty(ref _isCrafting, value);
		}

		public ItemTooltipDetailsModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
