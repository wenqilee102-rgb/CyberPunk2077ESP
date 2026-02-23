using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttachCapsuleVisionBlockerEffector : gameEffector
	{
		private CHandle<senseVisionBlockersRegistrar> _visionBlockerRegistrar;
		private CEnum<EVisionBlockerType> _visionBlockerType;
		private CUInt32 _visionBlockerId;
		private Vector3 _visionBlockerOffset;
		private CFloat _visionBlockerRadius;
		private CFloat _visionBlockerHeight;
		private CFloat _visionBlockerDetectionModifier;
		private CFloat _visionBlockerTBHModifier;
		private CBool _isBlockingCompletely;
		private CBool _blocksParent;

		[Ordinal(0)] 
		[RED("visionBlockerRegistrar")] 
		public CHandle<senseVisionBlockersRegistrar> VisionBlockerRegistrar
		{
			get => GetProperty(ref _visionBlockerRegistrar);
			set => SetProperty(ref _visionBlockerRegistrar, value);
		}

		[Ordinal(1)] 
		[RED("visionBlockerType")] 
		public CEnum<EVisionBlockerType> VisionBlockerType
		{
			get => GetProperty(ref _visionBlockerType);
			set => SetProperty(ref _visionBlockerType, value);
		}

		[Ordinal(2)] 
		[RED("visionBlockerId")] 
		public CUInt32 VisionBlockerId
		{
			get => GetProperty(ref _visionBlockerId);
			set => SetProperty(ref _visionBlockerId, value);
		}

		[Ordinal(3)] 
		[RED("visionBlockerOffset")] 
		public Vector3 VisionBlockerOffset
		{
			get => GetProperty(ref _visionBlockerOffset);
			set => SetProperty(ref _visionBlockerOffset, value);
		}

		[Ordinal(4)] 
		[RED("visionBlockerRadius")] 
		public CFloat VisionBlockerRadius
		{
			get => GetProperty(ref _visionBlockerRadius);
			set => SetProperty(ref _visionBlockerRadius, value);
		}

		[Ordinal(5)] 
		[RED("visionBlockerHeight")] 
		public CFloat VisionBlockerHeight
		{
			get => GetProperty(ref _visionBlockerHeight);
			set => SetProperty(ref _visionBlockerHeight, value);
		}

		[Ordinal(6)] 
		[RED("visionBlockerDetectionModifier")] 
		public CFloat VisionBlockerDetectionModifier
		{
			get => GetProperty(ref _visionBlockerDetectionModifier);
			set => SetProperty(ref _visionBlockerDetectionModifier, value);
		}

		[Ordinal(7)] 
		[RED("visionBlockerTBHModifier")] 
		public CFloat VisionBlockerTBHModifier
		{
			get => GetProperty(ref _visionBlockerTBHModifier);
			set => SetProperty(ref _visionBlockerTBHModifier, value);
		}

		[Ordinal(8)] 
		[RED("isBlockingCompletely")] 
		public CBool IsBlockingCompletely
		{
			get => GetProperty(ref _isBlockingCompletely);
			set => SetProperty(ref _isBlockingCompletely, value);
		}

		[Ordinal(9)] 
		[RED("blocksParent")] 
		public CBool BlocksParent
		{
			get => GetProperty(ref _blocksParent);
			set => SetProperty(ref _blocksParent, value);
		}

		public AttachCapsuleVisionBlockerEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
