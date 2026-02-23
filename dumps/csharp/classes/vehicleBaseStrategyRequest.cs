using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleBaseStrategyRequest : IScriptable
	{
		private CEnum<vehiclePoliceStrategy> _strategy;
		private Vector2 _distanceRange;
		private CFloat _minDirectDistance;
		private CBool _forceArriveFromBehind;

		[Ordinal(0)] 
		[RED("strategy")] 
		public CEnum<vehiclePoliceStrategy> Strategy
		{
			get => GetProperty(ref _strategy);
			set => SetProperty(ref _strategy, value);
		}

		[Ordinal(1)] 
		[RED("distanceRange")] 
		public Vector2 DistanceRange
		{
			get => GetProperty(ref _distanceRange);
			set => SetProperty(ref _distanceRange, value);
		}

		[Ordinal(2)] 
		[RED("minDirectDistance")] 
		public CFloat MinDirectDistance
		{
			get => GetProperty(ref _minDirectDistance);
			set => SetProperty(ref _minDirectDistance, value);
		}

		[Ordinal(3)] 
		[RED("forceArriveFromBehind")] 
		public CBool ForceArriveFromBehind
		{
			get => GetProperty(ref _forceArriveFromBehind);
			set => SetProperty(ref _forceArriveFromBehind, value);
		}

		public vehicleBaseStrategyRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
