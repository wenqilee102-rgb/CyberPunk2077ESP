using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleDrivePatrolCommand : AIVehicleCommand
	{
		private CFloat _maxSpeed;
		private CFloat _minSpeed;
		private CBool _clearTrafficOnPath;
		private CBool _emergencyPatrol;
		private CUInt32 _numPatrolLoops;
		private CFloat _forcedStartSpeed;

		[Ordinal(6)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(7)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(8)] 
		[RED("clearTrafficOnPath")] 
		public CBool ClearTrafficOnPath
		{
			get => GetProperty(ref _clearTrafficOnPath);
			set => SetProperty(ref _clearTrafficOnPath, value);
		}

		[Ordinal(9)] 
		[RED("emergencyPatrol")] 
		public CBool EmergencyPatrol
		{
			get => GetProperty(ref _emergencyPatrol);
			set => SetProperty(ref _emergencyPatrol, value);
		}

		[Ordinal(10)] 
		[RED("numPatrolLoops")] 
		public CUInt32 NumPatrolLoops
		{
			get => GetProperty(ref _numPatrolLoops);
			set => SetProperty(ref _numPatrolLoops, value);
		}

		[Ordinal(11)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		public AIVehicleDrivePatrolCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
