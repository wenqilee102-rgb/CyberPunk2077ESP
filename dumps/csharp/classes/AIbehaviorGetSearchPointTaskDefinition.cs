using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorGetSearchPointTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _inPlayerPositionDelay;
		private CHandle<AIArgumentMapping> _inSearchPositionMaxRadius;
		private CHandle<AIArgumentMapping> _inNearestNavmeshPolyExtent;
		private CHandle<AIArgumentMapping> _inPavementsOnly;
		private CHandle<AIArgumentMapping> _inLastKnownPosition;
		private CHandle<AIArgumentMapping> _outSearchPosition;

		[Ordinal(1)] 
		[RED("inPlayerPositionDelay")] 
		public CHandle<AIArgumentMapping> InPlayerPositionDelay
		{
			get => GetProperty(ref _inPlayerPositionDelay);
			set => SetProperty(ref _inPlayerPositionDelay, value);
		}

		[Ordinal(2)] 
		[RED("inSearchPositionMaxRadius")] 
		public CHandle<AIArgumentMapping> InSearchPositionMaxRadius
		{
			get => GetProperty(ref _inSearchPositionMaxRadius);
			set => SetProperty(ref _inSearchPositionMaxRadius, value);
		}

		[Ordinal(3)] 
		[RED("inNearestNavmeshPolyExtent")] 
		public CHandle<AIArgumentMapping> InNearestNavmeshPolyExtent
		{
			get => GetProperty(ref _inNearestNavmeshPolyExtent);
			set => SetProperty(ref _inNearestNavmeshPolyExtent, value);
		}

		[Ordinal(4)] 
		[RED("inPavementsOnly")] 
		public CHandle<AIArgumentMapping> InPavementsOnly
		{
			get => GetProperty(ref _inPavementsOnly);
			set => SetProperty(ref _inPavementsOnly, value);
		}

		[Ordinal(5)] 
		[RED("inLastKnownPosition")] 
		public CHandle<AIArgumentMapping> InLastKnownPosition
		{
			get => GetProperty(ref _inLastKnownPosition);
			set => SetProperty(ref _inLastKnownPosition, value);
		}

		[Ordinal(6)] 
		[RED("outSearchPosition")] 
		public CHandle<AIArgumentMapping> OutSearchPosition
		{
			get => GetProperty(ref _outSearchPosition);
			set => SetProperty(ref _outSearchPosition, value);
		}

		public AIbehaviorGetSearchPointTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
