using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeakspotPhysicalDestructionProperties : CVariable
	{
		private CFloat _velocity;

		[Ordinal(0)] 
		[RED("velocity")] 
		public CFloat Velocity
		{
			get => GetProperty(ref _velocity);
			set => SetProperty(ref _velocity, value);
		}

		public gameWeakspotPhysicalDestructionProperties(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
