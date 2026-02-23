using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileFollowCurveTrajectoryParams : gameprojectileTrajectoryParams
	{
		private wCHandle<gameObject> _target;
		private CName _componentName;
		private wCHandle<entIPlacedComponent> _targetComponent;
		private CName _targetSlotName;
		private Vector4 _targetPosition;
		private CFloat _startVelocity;
		private CFloat _linearTimeRatio;
		private CFloat _interpolationTimeRatio;
		private CFloat _returnTimeMargin;
		private CFloat _bendTimeRatio;
		private CFloat _bendFactor;
		private CFloat _angleInHitPlane;
		private CFloat _angleInVerticalPlane;
		private CBool _shouldRotate;
		private CFloat _halfLeanAngle;
		private CFloat _endLeanAngle;
		private CFloat _angleInterpolationDuration;
		private CFloat _snapRadius;
		private CFloat _accuracy;
		private Vector4 _offset;
		private Vector3 _offsetInPlane;
		private CBool _sendFollowEvent;
		private CBool _startVelocityDirectionCheck;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetProperty(ref _componentName);
			set => SetProperty(ref _componentName, value);
		}

		[Ordinal(2)] 
		[RED("targetComponent")] 
		public wCHandle<entIPlacedComponent> TargetComponent
		{
			get => GetProperty(ref _targetComponent);
			set => SetProperty(ref _targetComponent, value);
		}

		[Ordinal(3)] 
		[RED("targetSlotName")] 
		public CName TargetSlotName
		{
			get => GetProperty(ref _targetSlotName);
			set => SetProperty(ref _targetSlotName, value);
		}

		[Ordinal(4)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(5)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(6)] 
		[RED("linearTimeRatio")] 
		public CFloat LinearTimeRatio
		{
			get => GetProperty(ref _linearTimeRatio);
			set => SetProperty(ref _linearTimeRatio, value);
		}

		[Ordinal(7)] 
		[RED("interpolationTimeRatio")] 
		public CFloat InterpolationTimeRatio
		{
			get => GetProperty(ref _interpolationTimeRatio);
			set => SetProperty(ref _interpolationTimeRatio, value);
		}

		[Ordinal(8)] 
		[RED("returnTimeMargin")] 
		public CFloat ReturnTimeMargin
		{
			get => GetProperty(ref _returnTimeMargin);
			set => SetProperty(ref _returnTimeMargin, value);
		}

		[Ordinal(9)] 
		[RED("bendTimeRatio")] 
		public CFloat BendTimeRatio
		{
			get => GetProperty(ref _bendTimeRatio);
			set => SetProperty(ref _bendTimeRatio, value);
		}

		[Ordinal(10)] 
		[RED("bendFactor")] 
		public CFloat BendFactor
		{
			get => GetProperty(ref _bendFactor);
			set => SetProperty(ref _bendFactor, value);
		}

		[Ordinal(11)] 
		[RED("angleInHitPlane")] 
		public CFloat AngleInHitPlane
		{
			get => GetProperty(ref _angleInHitPlane);
			set => SetProperty(ref _angleInHitPlane, value);
		}

		[Ordinal(12)] 
		[RED("angleInVerticalPlane")] 
		public CFloat AngleInVerticalPlane
		{
			get => GetProperty(ref _angleInVerticalPlane);
			set => SetProperty(ref _angleInVerticalPlane, value);
		}

		[Ordinal(13)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get => GetProperty(ref _shouldRotate);
			set => SetProperty(ref _shouldRotate, value);
		}

		[Ordinal(14)] 
		[RED("halfLeanAngle")] 
		public CFloat HalfLeanAngle
		{
			get => GetProperty(ref _halfLeanAngle);
			set => SetProperty(ref _halfLeanAngle, value);
		}

		[Ordinal(15)] 
		[RED("endLeanAngle")] 
		public CFloat EndLeanAngle
		{
			get => GetProperty(ref _endLeanAngle);
			set => SetProperty(ref _endLeanAngle, value);
		}

		[Ordinal(16)] 
		[RED("angleInterpolationDuration")] 
		public CFloat AngleInterpolationDuration
		{
			get => GetProperty(ref _angleInterpolationDuration);
			set => SetProperty(ref _angleInterpolationDuration, value);
		}

		[Ordinal(17)] 
		[RED("snapRadius")] 
		public CFloat SnapRadius
		{
			get => GetProperty(ref _snapRadius);
			set => SetProperty(ref _snapRadius, value);
		}

		[Ordinal(18)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetProperty(ref _accuracy);
			set => SetProperty(ref _accuracy, value);
		}

		[Ordinal(19)] 
		[RED("offset")] 
		public Vector4 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(20)] 
		[RED("offsetInPlane")] 
		public Vector3 OffsetInPlane
		{
			get => GetProperty(ref _offsetInPlane);
			set => SetProperty(ref _offsetInPlane, value);
		}

		[Ordinal(21)] 
		[RED("sendFollowEvent")] 
		public CBool SendFollowEvent
		{
			get => GetProperty(ref _sendFollowEvent);
			set => SetProperty(ref _sendFollowEvent, value);
		}

		[Ordinal(22)] 
		[RED("startVelocityDirectionCheck")] 
		public CBool StartVelocityDirectionCheck
		{
			get => GetProperty(ref _startVelocityDirectionCheck);
			set => SetProperty(ref _startVelocityDirectionCheck, value);
		}

		public gameprojectileFollowCurveTrajectoryParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
