using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConsecutiveHitsPrereqCondition : BaseHitPrereqCondition
	{
		private CFloat _timeOut;
		private CInt32 _consecutiveHitsRequired;
		private CBool _uniqueTarget;
		private CInt32 _consecutiveHits;
		private entEntityID _lastTargetID;
		private CFloat _lastHitTime;

		[Ordinal(3)] 
		[RED("timeOut")] 
		public CFloat TimeOut
		{
			get => GetProperty(ref _timeOut);
			set => SetProperty(ref _timeOut, value);
		}

		[Ordinal(4)] 
		[RED("consecutiveHitsRequired")] 
		public CInt32 ConsecutiveHitsRequired
		{
			get => GetProperty(ref _consecutiveHitsRequired);
			set => SetProperty(ref _consecutiveHitsRequired, value);
		}

		[Ordinal(5)] 
		[RED("uniqueTarget")] 
		public CBool UniqueTarget
		{
			get => GetProperty(ref _uniqueTarget);
			set => SetProperty(ref _uniqueTarget, value);
		}

		[Ordinal(6)] 
		[RED("consecutiveHits")] 
		public CInt32 ConsecutiveHits
		{
			get => GetProperty(ref _consecutiveHits);
			set => SetProperty(ref _consecutiveHits, value);
		}

		[Ordinal(7)] 
		[RED("lastTargetID")] 
		public entEntityID LastTargetID
		{
			get => GetProperty(ref _lastTargetID);
			set => SetProperty(ref _lastTargetID, value);
		}

		[Ordinal(8)] 
		[RED("lastHitTime")] 
		public CFloat LastHitTime
		{
			get => GetProperty(ref _lastHitTime);
			set => SetProperty(ref _lastHitTime, value);
		}

		public ConsecutiveHitsPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
