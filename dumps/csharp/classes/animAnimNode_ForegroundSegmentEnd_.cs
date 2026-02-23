using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ForegroundSegmentEnd_ : animAnimNode_OnePoseInput
	{
		private CBool _isAlwaysEnabledForHighEndHardware;

		[Ordinal(12)] 
		[RED("isAlwaysEnabledForHighEndHardware")] 
		public CBool IsAlwaysEnabledForHighEndHardware
		{
			get => GetProperty(ref _isAlwaysEnabledForHighEndHardware);
			set => SetProperty(ref _isAlwaysEnabledForHighEndHardware, value);
		}

		public animAnimNode_ForegroundSegmentEnd_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
