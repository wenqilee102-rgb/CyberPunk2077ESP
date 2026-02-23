using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpeedExitingEvents : ExitingEvents
	{
		private Vector4 _exitForce;

		[Ordinal(5)] 
		[RED("exitForce")] 
		public Vector4 ExitForce
		{
			get => GetProperty(ref _exitForce);
			set => SetProperty(ref _exitForce, value);
		}

		public SpeedExitingEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
