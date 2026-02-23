using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questParamRubberbanding : ISerializable
	{
		private CHandle<questUniversalRef> _targetRef;
		private CFloat _targetForwardOffset;
		private CFloat _minDistance;
		private CFloat _maxDistance;
		private CBool _stopAndWait;
		private CBool _teleportToCatchUp;
		private CBool _stayInFront;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public CHandle<questUniversalRef> TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(1)] 
		[RED("targetForwardOffset")] 
		public CFloat TargetForwardOffset
		{
			get => GetProperty(ref _targetForwardOffset);
			set => SetProperty(ref _targetForwardOffset, value);
		}

		[Ordinal(2)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(3)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(4)] 
		[RED("stopAndWait")] 
		public CBool StopAndWait
		{
			get => GetProperty(ref _stopAndWait);
			set => SetProperty(ref _stopAndWait, value);
		}

		[Ordinal(5)] 
		[RED("teleportToCatchUp")] 
		public CBool TeleportToCatchUp
		{
			get => GetProperty(ref _teleportToCatchUp);
			set => SetProperty(ref _teleportToCatchUp, value);
		}

		[Ordinal(6)] 
		[RED("stayInFront")] 
		public CBool StayInFront
		{
			get => GetProperty(ref _stayInFront);
			set => SetProperty(ref _stayInFront, value);
		}

		public questParamRubberbanding(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
