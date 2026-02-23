using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveToPointAutonomousUpdate : AIDriveCommandUpdate
	{
		private Vector4 _targetPosition;
		private CFloat _minimumDistanceToTarget;
		private CBool _driveDownTheRoadIndefinitely;

		[Ordinal(3)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(4)] 
		[RED("minimumDistanceToTarget")] 
		public CFloat MinimumDistanceToTarget
		{
			get => GetProperty(ref _minimumDistanceToTarget);
			set => SetProperty(ref _minimumDistanceToTarget, value);
		}

		[Ordinal(5)] 
		[RED("driveDownTheRoadIndefinitely")] 
		public CBool DriveDownTheRoadIndefinitely
		{
			get => GetProperty(ref _driveDownTheRoadIndefinitely);
			set => SetProperty(ref _driveDownTheRoadIndefinitely, value);
		}

		public AIDriveToPointAutonomousUpdate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
