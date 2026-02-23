using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelaySetCoverNPCCurrentlyExposed : redEvent
	{
		private CBool _exposed;

		[Ordinal(0)] 
		[RED("exposed")] 
		public CBool Exposed
		{
			get => GetProperty(ref _exposed);
			set => SetProperty(ref _exposed, value);
		}

		public DelaySetCoverNPCCurrentlyExposed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
