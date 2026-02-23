using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDrivePatrolUpdate : AIDriveCommandUpdate
	{
		private CUInt32 _numPatrolLoops;
		private CBool _emergencyPatrol;

		[Ordinal(3)] 
		[RED("numPatrolLoops")] 
		public CUInt32 NumPatrolLoops
		{
			get => GetProperty(ref _numPatrolLoops);
			set => SetProperty(ref _numPatrolLoops, value);
		}

		[Ordinal(4)] 
		[RED("emergencyPatrol")] 
		public CBool EmergencyPatrol
		{
			get => GetProperty(ref _emergencyPatrol);
			set => SetProperty(ref _emergencyPatrol, value);
		}

		public AIDrivePatrolUpdate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
