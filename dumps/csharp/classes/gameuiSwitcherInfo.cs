using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
	{
		private CArray<CName> _uiSlots;
		private CArray<gameuiSwitcherOption> _options;
		private CBool _switchVisibility;

		[Ordinal(14)] 
		[RED("uiSlots")] 
		public CArray<CName> UiSlots
		{
			get => GetProperty(ref _uiSlots);
			set => SetProperty(ref _uiSlots, value);
		}

		[Ordinal(15)] 
		[RED("options")] 
		public CArray<gameuiSwitcherOption> Options
		{
			get => GetProperty(ref _options);
			set => SetProperty(ref _options, value);
		}

		[Ordinal(16)] 
		[RED("switchVisibility")] 
		public CBool SwitchVisibility
		{
			get => GetProperty(ref _switchVisibility);
			set => SetProperty(ref _switchVisibility, value);
		}

		public gameuiSwitcherInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
