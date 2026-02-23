using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehiclePatrolNearbyStrategyRequest : vehicleBaseStrategyRequest
	{
		private Vector2 _angleRange;

		[Ordinal(4)] 
		[RED("angleRange")] 
		public Vector2 AngleRange
		{
			get => GetProperty(ref _angleRange);
			set => SetProperty(ref _angleRange, value);
		}

		public vehiclePatrolNearbyStrategyRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
