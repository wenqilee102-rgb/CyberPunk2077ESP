using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipRequirementsModule : ItemTooltipModuleController
	{
		private inkWidgetReference _levelRequirementsWrapper;
		private inkWidgetReference _strenghtOrReflexWrapper;
		private inkWidgetReference _smartlinkGunWrapper;
		private inkCompoundWidgetReference _anyAttributeWrapper;
		private inkWidgetReference _line;
		private inkTextWidgetReference _levelRequirementsText;
		private inkTextWidgetReference _strenghtOrReflexText;
		private inkTextWidgetReference _perkText;
		private inkImageWidgetReference _perkDot;

		[Ordinal(5)] 
		[RED("levelRequirementsWrapper")] 
		public inkWidgetReference LevelRequirementsWrapper
		{
			get => GetProperty(ref _levelRequirementsWrapper);
			set => SetProperty(ref _levelRequirementsWrapper, value);
		}

		[Ordinal(6)] 
		[RED("strenghtOrReflexWrapper")] 
		public inkWidgetReference StrenghtOrReflexWrapper
		{
			get => GetProperty(ref _strenghtOrReflexWrapper);
			set => SetProperty(ref _strenghtOrReflexWrapper, value);
		}

		[Ordinal(7)] 
		[RED("smartlinkGunWrapper")] 
		public inkWidgetReference SmartlinkGunWrapper
		{
			get => GetProperty(ref _smartlinkGunWrapper);
			set => SetProperty(ref _smartlinkGunWrapper, value);
		}

		[Ordinal(8)] 
		[RED("anyAttributeWrapper")] 
		public inkCompoundWidgetReference AnyAttributeWrapper
		{
			get => GetProperty(ref _anyAttributeWrapper);
			set => SetProperty(ref _anyAttributeWrapper, value);
		}

		[Ordinal(9)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetProperty(ref _line);
			set => SetProperty(ref _line, value);
		}

		[Ordinal(10)] 
		[RED("levelRequirementsText")] 
		public inkTextWidgetReference LevelRequirementsText
		{
			get => GetProperty(ref _levelRequirementsText);
			set => SetProperty(ref _levelRequirementsText, value);
		}

		[Ordinal(11)] 
		[RED("strenghtOrReflexText")] 
		public inkTextWidgetReference StrenghtOrReflexText
		{
			get => GetProperty(ref _strenghtOrReflexText);
			set => SetProperty(ref _strenghtOrReflexText, value);
		}

		[Ordinal(12)] 
		[RED("perkText")] 
		public inkTextWidgetReference PerkText
		{
			get => GetProperty(ref _perkText);
			set => SetProperty(ref _perkText, value);
		}

		[Ordinal(13)] 
		[RED("perkDot")] 
		public inkImageWidgetReference PerkDot
		{
			get => GetProperty(ref _perkDot);
			set => SetProperty(ref _perkDot, value);
		}

		public ItemTooltipRequirementsModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
