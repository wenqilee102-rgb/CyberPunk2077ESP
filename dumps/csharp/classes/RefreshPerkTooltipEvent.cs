using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshPerkTooltipEvent : redEvent
	{
		private wCHandle<inkWidget> _target;
		private CHandle<NewPerkDisplayData> _perkData;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<inkWidget> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("perkData")] 
		public CHandle<NewPerkDisplayData> PerkData
		{
			get => GetProperty(ref _perkData);
			set => SetProperty(ref _perkData, value);
		}

		public RefreshPerkTooltipEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
