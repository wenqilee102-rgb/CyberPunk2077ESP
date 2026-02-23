using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipRecipeDataModule : ItemTooltipModuleController
	{
		private inkTextWidgetReference _randomQualityLabel;
		private inkWidgetReference _randomQualityWrapper;
		private inkTextWidgetReference _statsLabel;
		private inkWidgetReference _statsWrapper;
		private inkCompoundWidgetReference _statsContainer;
		private inkTextWidgetReference _damageTypesLabel;
		private inkWidgetReference _damageTypesWrapper;
		private inkCompoundWidgetReference _damageTypesContainer;

		[Ordinal(5)] 
		[RED("randomQualityLabel")] 
		public inkTextWidgetReference RandomQualityLabel
		{
			get => GetProperty(ref _randomQualityLabel);
			set => SetProperty(ref _randomQualityLabel, value);
		}

		[Ordinal(6)] 
		[RED("randomQualityWrapper")] 
		public inkWidgetReference RandomQualityWrapper
		{
			get => GetProperty(ref _randomQualityWrapper);
			set => SetProperty(ref _randomQualityWrapper, value);
		}

		[Ordinal(7)] 
		[RED("statsLabel")] 
		public inkTextWidgetReference StatsLabel
		{
			get => GetProperty(ref _statsLabel);
			set => SetProperty(ref _statsLabel, value);
		}

		[Ordinal(8)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetProperty(ref _statsWrapper);
			set => SetProperty(ref _statsWrapper, value);
		}

		[Ordinal(9)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetProperty(ref _statsContainer);
			set => SetProperty(ref _statsContainer, value);
		}

		[Ordinal(10)] 
		[RED("damageTypesLabel")] 
		public inkTextWidgetReference DamageTypesLabel
		{
			get => GetProperty(ref _damageTypesLabel);
			set => SetProperty(ref _damageTypesLabel, value);
		}

		[Ordinal(11)] 
		[RED("damageTypesWrapper")] 
		public inkWidgetReference DamageTypesWrapper
		{
			get => GetProperty(ref _damageTypesWrapper);
			set => SetProperty(ref _damageTypesWrapper, value);
		}

		[Ordinal(12)] 
		[RED("damageTypesContainer")] 
		public inkCompoundWidgetReference DamageTypesContainer
		{
			get => GetProperty(ref _damageTypesContainer);
			set => SetProperty(ref _damageTypesContainer, value);
		}

		public ItemTooltipRecipeDataModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
