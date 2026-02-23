using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithDistance : ModifyDamageEffector
	{
		private CFloat _percentMult;
		private CFloat _minDistance;
		private CFloat _maxDistance;
		private CBool _improveWithDistance;

		[Ordinal(6)] 
		[RED("percentMult")] 
		public CFloat PercentMult
		{
			get => GetProperty(ref _percentMult);
			set => SetProperty(ref _percentMult, value);
		}

		[Ordinal(7)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(8)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(9)] 
		[RED("improveWithDistance")] 
		public CBool ImproveWithDistance
		{
			get => GetProperty(ref _improveWithDistance);
			set => SetProperty(ref _improveWithDistance, value);
		}

		public ModifyDamageWithDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
