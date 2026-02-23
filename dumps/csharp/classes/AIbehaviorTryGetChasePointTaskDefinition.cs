using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTryGetChasePointTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _inPlayerPositionDelay;
		private CHandle<AIArgumentMapping> _inPlayerPositionMaxDistance;
		private CHandle<AIArgumentMapping> _inNearestNavmeshPolyExtent;
		private CHandle<AIArgumentMapping> _outChasePosition;

		[Ordinal(1)] 
		[RED("inPlayerPositionDelay")] 
		public CHandle<AIArgumentMapping> InPlayerPositionDelay
		{
			get => GetProperty(ref _inPlayerPositionDelay);
			set => SetProperty(ref _inPlayerPositionDelay, value);
		}

		[Ordinal(2)] 
		[RED("inPlayerPositionMaxDistance")] 
		public CHandle<AIArgumentMapping> InPlayerPositionMaxDistance
		{
			get => GetProperty(ref _inPlayerPositionMaxDistance);
			set => SetProperty(ref _inPlayerPositionMaxDistance, value);
		}

		[Ordinal(3)] 
		[RED("inNearestNavmeshPolyExtent")] 
		public CHandle<AIArgumentMapping> InNearestNavmeshPolyExtent
		{
			get => GetProperty(ref _inNearestNavmeshPolyExtent);
			set => SetProperty(ref _inNearestNavmeshPolyExtent, value);
		}

		[Ordinal(4)] 
		[RED("outChasePosition")] 
		public CHandle<AIArgumentMapping> OutChasePosition
		{
			get => GetProperty(ref _outChasePosition);
			set => SetProperty(ref _outChasePosition, value);
		}

		public AIbehaviorTryGetChasePointTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
