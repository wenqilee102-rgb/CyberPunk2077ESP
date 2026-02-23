using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmasherFindTeleportPositionAroundTarget : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _target;
		private CFloat _minDistance;
		private CFloat _maxDistance;
		private CFloat _minDistanceFromLastTeleport;
		private CBool _rotateToTarget;
		private CBool _checkZLevel;
		private CBool _maintainLineOfSight;
		private CBool _teleportInPlayersFOV;
		private CBool _doPathCheck;
		private CBool _doWallCheck;
		private CHandle<AIArgumentMapping> _outPosition;
		private CHandle<AIArgumentMapping> _outRotation;
		private CHandle<AIArgumentMapping> _outDirection;
		private CFloat _c_zLevelTolerance;
		private wCHandle<gameObject> _referenceTarget;
		private Vector4 _fallbackPosition;
		private CInt32 _fallbackPositionQuality;
		private wCHandle<gameIBlackboard> _blackboard;

		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(3)] 
		[RED("minDistanceFromLastTeleport")] 
		public CFloat MinDistanceFromLastTeleport
		{
			get => GetProperty(ref _minDistanceFromLastTeleport);
			set => SetProperty(ref _minDistanceFromLastTeleport, value);
		}

		[Ordinal(4)] 
		[RED("rotateToTarget")] 
		public CBool RotateToTarget
		{
			get => GetProperty(ref _rotateToTarget);
			set => SetProperty(ref _rotateToTarget, value);
		}

		[Ordinal(5)] 
		[RED("checkZLevel")] 
		public CBool CheckZLevel
		{
			get => GetProperty(ref _checkZLevel);
			set => SetProperty(ref _checkZLevel, value);
		}

		[Ordinal(6)] 
		[RED("maintainLineOfSight")] 
		public CBool MaintainLineOfSight
		{
			get => GetProperty(ref _maintainLineOfSight);
			set => SetProperty(ref _maintainLineOfSight, value);
		}

		[Ordinal(7)] 
		[RED("teleportInPlayersFOV")] 
		public CBool TeleportInPlayersFOV
		{
			get => GetProperty(ref _teleportInPlayersFOV);
			set => SetProperty(ref _teleportInPlayersFOV, value);
		}

		[Ordinal(8)] 
		[RED("doPathCheck")] 
		public CBool DoPathCheck
		{
			get => GetProperty(ref _doPathCheck);
			set => SetProperty(ref _doPathCheck, value);
		}

		[Ordinal(9)] 
		[RED("doWallCheck")] 
		public CBool DoWallCheck
		{
			get => GetProperty(ref _doWallCheck);
			set => SetProperty(ref _doWallCheck, value);
		}

		[Ordinal(10)] 
		[RED("outPosition")] 
		public CHandle<AIArgumentMapping> OutPosition
		{
			get => GetProperty(ref _outPosition);
			set => SetProperty(ref _outPosition, value);
		}

		[Ordinal(11)] 
		[RED("outRotation")] 
		public CHandle<AIArgumentMapping> OutRotation
		{
			get => GetProperty(ref _outRotation);
			set => SetProperty(ref _outRotation, value);
		}

		[Ordinal(12)] 
		[RED("outDirection")] 
		public CHandle<AIArgumentMapping> OutDirection
		{
			get => GetProperty(ref _outDirection);
			set => SetProperty(ref _outDirection, value);
		}

		[Ordinal(13)] 
		[RED("c_zLevelTolerance")] 
		public CFloat C_zLevelTolerance
		{
			get => GetProperty(ref _c_zLevelTolerance);
			set => SetProperty(ref _c_zLevelTolerance, value);
		}

		[Ordinal(14)] 
		[RED("referenceTarget")] 
		public wCHandle<gameObject> ReferenceTarget
		{
			get => GetProperty(ref _referenceTarget);
			set => SetProperty(ref _referenceTarget, value);
		}

		[Ordinal(15)] 
		[RED("fallbackPosition")] 
		public Vector4 FallbackPosition
		{
			get => GetProperty(ref _fallbackPosition);
			set => SetProperty(ref _fallbackPosition, value);
		}

		[Ordinal(16)] 
		[RED("fallbackPositionQuality")] 
		public CInt32 FallbackPositionQuality
		{
			get => GetProperty(ref _fallbackPositionQuality);
			set => SetProperty(ref _fallbackPositionQuality, value);
		}

		[Ordinal(17)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		public SmasherFindTeleportPositionAroundTarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
