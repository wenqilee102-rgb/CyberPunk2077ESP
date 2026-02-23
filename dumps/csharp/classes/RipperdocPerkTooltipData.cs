using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocPerkTooltipData : ATooltipData
	{
		private CEnum<RipperdocHoverState> _ripperdocHoverState;

		[Ordinal(0)] 
		[RED("ripperdocHoverState")] 
		public CEnum<RipperdocHoverState> RipperdocHoverState
		{
			get => GetProperty(ref _ripperdocHoverState);
			set => SetProperty(ref _ripperdocHoverState, value);
		}

		public RipperdocPerkTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
