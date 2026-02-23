using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLinearTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _startVel;
		private CFloat _acceleration;

		[Ordinal(0)] 
		[RED("startVel")] 
		public CFloat StartVel
		{
			get => GetProperty(ref _startVel);
			set => SetProperty(ref _startVel, value);
		}

		[Ordinal(1)] 
		[RED("acceleration")] 
		public CFloat Acceleration
		{
			get => GetProperty(ref _acceleration);
			set => SetProperty(ref _acceleration, value);
		}

		public gameprojectileLinearTrajectoryParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
