using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlideExitingEvents : ExitingEvents
	{
		private Vector4 _exitMomentum;

		[Ordinal(5)] 
		[RED("exitMomentum")] 
		public Vector4 ExitMomentum
		{
			get => GetProperty(ref _exitMomentum);
			set => SetProperty(ref _exitMomentum, value);
		}

		public SlideExitingEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
