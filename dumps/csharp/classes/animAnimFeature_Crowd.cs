using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Crowd : animAnimFeature
	{
		private CInt32 _stopType;
		private CInt32 _speedType;
		private CInt32 _speedOverrideType;
		private CInt32 _bumpDirection;
		private CInt32 _threatSource;
		private CInt32 _locomotionState;
		private CInt32 _bumpSourceLocation;
		private CFloat _lookAtAngle;
		private CInt32 _fearStage;
		private CInt32 _startType;
		private CFloat _startDirectionAngle;
		private CFloat _animTime;
		private CBool _isBlocked;
		private CInt32 _bumpType;
		private CInt32 _fleeType;
		private CFloat _randomVariation;
		private CFloat _animScale;
		private CFloat _slopeRatio;
		private CFloat _distanceToPlayer2D;
		private CFloat _angleToPlayer;

		[Ordinal(0)] 
		[RED("stopType")] 
		public CInt32 StopType
		{
			get => GetProperty(ref _stopType);
			set => SetProperty(ref _stopType, value);
		}

		[Ordinal(1)] 
		[RED("speedType")] 
		public CInt32 SpeedType
		{
			get => GetProperty(ref _speedType);
			set => SetProperty(ref _speedType, value);
		}

		[Ordinal(2)] 
		[RED("speedOverrideType")] 
		public CInt32 SpeedOverrideType
		{
			get => GetProperty(ref _speedOverrideType);
			set => SetProperty(ref _speedOverrideType, value);
		}

		[Ordinal(3)] 
		[RED("bumpDirection")] 
		public CInt32 BumpDirection
		{
			get => GetProperty(ref _bumpDirection);
			set => SetProperty(ref _bumpDirection, value);
		}

		[Ordinal(4)] 
		[RED("threatSource")] 
		public CInt32 ThreatSource
		{
			get => GetProperty(ref _threatSource);
			set => SetProperty(ref _threatSource, value);
		}

		[Ordinal(5)] 
		[RED("locomotionState")] 
		public CInt32 LocomotionState
		{
			get => GetProperty(ref _locomotionState);
			set => SetProperty(ref _locomotionState, value);
		}

		[Ordinal(6)] 
		[RED("bumpSourceLocation")] 
		public CInt32 BumpSourceLocation
		{
			get => GetProperty(ref _bumpSourceLocation);
			set => SetProperty(ref _bumpSourceLocation, value);
		}

		[Ordinal(7)] 
		[RED("lookAtAngle")] 
		public CFloat LookAtAngle
		{
			get => GetProperty(ref _lookAtAngle);
			set => SetProperty(ref _lookAtAngle, value);
		}

		[Ordinal(8)] 
		[RED("fearStage")] 
		public CInt32 FearStage
		{
			get => GetProperty(ref _fearStage);
			set => SetProperty(ref _fearStage, value);
		}

		[Ordinal(9)] 
		[RED("startType")] 
		public CInt32 StartType
		{
			get => GetProperty(ref _startType);
			set => SetProperty(ref _startType, value);
		}

		[Ordinal(10)] 
		[RED("startDirectionAngle")] 
		public CFloat StartDirectionAngle
		{
			get => GetProperty(ref _startDirectionAngle);
			set => SetProperty(ref _startDirectionAngle, value);
		}

		[Ordinal(11)] 
		[RED("animTime")] 
		public CFloat AnimTime
		{
			get => GetProperty(ref _animTime);
			set => SetProperty(ref _animTime, value);
		}

		[Ordinal(12)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetProperty(ref _isBlocked);
			set => SetProperty(ref _isBlocked, value);
		}

		[Ordinal(13)] 
		[RED("bumpType")] 
		public CInt32 BumpType
		{
			get => GetProperty(ref _bumpType);
			set => SetProperty(ref _bumpType, value);
		}

		[Ordinal(14)] 
		[RED("fleeType")] 
		public CInt32 FleeType
		{
			get => GetProperty(ref _fleeType);
			set => SetProperty(ref _fleeType, value);
		}

		[Ordinal(15)] 
		[RED("randomVariation")] 
		public CFloat RandomVariation
		{
			get => GetProperty(ref _randomVariation);
			set => SetProperty(ref _randomVariation, value);
		}

		[Ordinal(16)] 
		[RED("animScale")] 
		public CFloat AnimScale
		{
			get => GetProperty(ref _animScale);
			set => SetProperty(ref _animScale, value);
		}

		[Ordinal(17)] 
		[RED("slopeRatio")] 
		public CFloat SlopeRatio
		{
			get => GetProperty(ref _slopeRatio);
			set => SetProperty(ref _slopeRatio, value);
		}

		[Ordinal(18)] 
		[RED("distanceToPlayer2D")] 
		public CFloat DistanceToPlayer2D
		{
			get => GetProperty(ref _distanceToPlayer2D);
			set => SetProperty(ref _distanceToPlayer2D, value);
		}

		[Ordinal(19)] 
		[RED("angleToPlayer")] 
		public CFloat AngleToPlayer
		{
			get => GetProperty(ref _angleToPlayer);
			set => SetProperty(ref _angleToPlayer, value);
		}

		public animAnimFeature_Crowd(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
