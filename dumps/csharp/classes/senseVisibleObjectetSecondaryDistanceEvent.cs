using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseVisibleObjectetSecondaryDistanceEvent : redEvent
	{
		private CFloat _distance;
		private CFloat _extraEvaluationDistance;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(1)] 
		[RED("extraEvaluationDistance")] 
		public CFloat ExtraEvaluationDistance
		{
			get => GetProperty(ref _extraEvaluationDistance);
			set => SetProperty(ref _extraEvaluationDistance, value);
		}

		public senseVisibleObjectetSecondaryDistanceEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
