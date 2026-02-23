using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipCyberwareWeaponModule : ItemTooltipModuleController
	{
		private inkWidgetReference _wrapper;
		private CArray<inkWidgetReference> _bars;
		private CArray<inkWidgetReference> _diffBars;
		private inkWidgetReference _betterColorDummyHolder;
		private inkWidgetReference _worseColorDummyHolder;
		private CArray<CEnum<WeaponBarType>> _statsToDisplay;
		private CBool _disableSeparators;

		[Ordinal(5)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(6)] 
		[RED("bars")] 
		public CArray<inkWidgetReference> Bars
		{
			get => GetProperty(ref _bars);
			set => SetProperty(ref _bars, value);
		}

		[Ordinal(7)] 
		[RED("diffBars")] 
		public CArray<inkWidgetReference> DiffBars
		{
			get => GetProperty(ref _diffBars);
			set => SetProperty(ref _diffBars, value);
		}

		[Ordinal(8)] 
		[RED("betterColorDummyHolder")] 
		public inkWidgetReference BetterColorDummyHolder
		{
			get => GetProperty(ref _betterColorDummyHolder);
			set => SetProperty(ref _betterColorDummyHolder, value);
		}

		[Ordinal(9)] 
		[RED("worseColorDummyHolder")] 
		public inkWidgetReference WorseColorDummyHolder
		{
			get => GetProperty(ref _worseColorDummyHolder);
			set => SetProperty(ref _worseColorDummyHolder, value);
		}

		[Ordinal(10)] 
		[RED("statsToDisplay")] 
		public CArray<CEnum<WeaponBarType>> StatsToDisplay
		{
			get => GetProperty(ref _statsToDisplay);
			set => SetProperty(ref _statsToDisplay, value);
		}

		[Ordinal(11)] 
		[RED("disableSeparators")] 
		public CBool DisableSeparators
		{
			get => GetProperty(ref _disableSeparators);
			set => SetProperty(ref _disableSeparators, value);
		}

		public ItemTooltipCyberwareWeaponModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
