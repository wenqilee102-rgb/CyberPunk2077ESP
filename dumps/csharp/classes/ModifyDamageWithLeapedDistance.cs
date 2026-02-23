using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithLeapedDistance : ModifyDamageEffector
	{
		private CFloat _maxPercentMult;
		private CFloat _minDistance;
		private CFloat _maxDistance;

		[Ordinal(6)] 
		[RED("maxPercentMult")] 
		public CFloat MaxPercentMult
		{
			get => GetProperty(ref _maxPercentMult);
			set => SetProperty(ref _maxPercentMult, value);
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

		public ModifyDamageWithLeapedDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
