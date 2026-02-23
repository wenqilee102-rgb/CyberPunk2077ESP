using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeSubwayGateStateEvent : redEvent
	{
		private CBool _open;

		[Ordinal(0)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetProperty(ref _open);
			set => SetProperty(ref _open, value);
		}

		public ChangeSubwayGateStateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
