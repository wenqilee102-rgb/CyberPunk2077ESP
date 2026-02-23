using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayerLookAtParams : ISerializable
	{
		private CBool _useOffsetToPlayer;
		private gameEntityReference _lookAtTarget;
		private CName _slotName;
		private Vector3 _offset;
		private CFloat _duration;
		private CBool _adjustPitch;
		private CBool _adjustYaw;
		private CBool _endOnTargetReached;
		private CBool _endOnCameraInputApplied;
		private CBool _endOnTimeExceeded;
		private CFloat _cameraInputMagToBreak;
		private CFloat _precision;
		private CFloat _maxDuration;
		private CBool _easeIn;
		private CBool _easeOut;

		[Ordinal(0)] 
		[RED("useOffsetToPlayer")] 
		public CBool UseOffsetToPlayer
		{
			get => GetProperty(ref _useOffsetToPlayer);
			set => SetProperty(ref _useOffsetToPlayer, value);
		}

		[Ordinal(1)] 
		[RED("lookAtTarget")] 
		public gameEntityReference LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(2)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(3)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(5)] 
		[RED("adjustPitch")] 
		public CBool AdjustPitch
		{
			get => GetProperty(ref _adjustPitch);
			set => SetProperty(ref _adjustPitch, value);
		}

		[Ordinal(6)] 
		[RED("adjustYaw")] 
		public CBool AdjustYaw
		{
			get => GetProperty(ref _adjustYaw);
			set => SetProperty(ref _adjustYaw, value);
		}

		[Ordinal(7)] 
		[RED("endOnTargetReached")] 
		public CBool EndOnTargetReached
		{
			get => GetProperty(ref _endOnTargetReached);
			set => SetProperty(ref _endOnTargetReached, value);
		}

		[Ordinal(8)] 
		[RED("endOnCameraInputApplied")] 
		public CBool EndOnCameraInputApplied
		{
			get => GetProperty(ref _endOnCameraInputApplied);
			set => SetProperty(ref _endOnCameraInputApplied, value);
		}

		[Ordinal(9)] 
		[RED("endOnTimeExceeded")] 
		public CBool EndOnTimeExceeded
		{
			get => GetProperty(ref _endOnTimeExceeded);
			set => SetProperty(ref _endOnTimeExceeded, value);
		}

		[Ordinal(10)] 
		[RED("cameraInputMagToBreak")] 
		public CFloat CameraInputMagToBreak
		{
			get => GetProperty(ref _cameraInputMagToBreak);
			set => SetProperty(ref _cameraInputMagToBreak, value);
		}

		[Ordinal(11)] 
		[RED("precision")] 
		public CFloat Precision
		{
			get => GetProperty(ref _precision);
			set => SetProperty(ref _precision, value);
		}

		[Ordinal(12)] 
		[RED("maxDuration")] 
		public CFloat MaxDuration
		{
			get => GetProperty(ref _maxDuration);
			set => SetProperty(ref _maxDuration, value);
		}

		[Ordinal(13)] 
		[RED("easeIn")] 
		public CBool EaseIn
		{
			get => GetProperty(ref _easeIn);
			set => SetProperty(ref _easeIn, value);
		}

		[Ordinal(14)] 
		[RED("easeOut")] 
		public CBool EaseOut
		{
			get => GetProperty(ref _easeOut);
			set => SetProperty(ref _easeOut, value);
		}

		public questPlayerLookAtParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
