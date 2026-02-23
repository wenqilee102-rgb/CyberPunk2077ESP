using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSpreadingData : CVariable
	{
		private CUInt32 _count;
		private CUInt32 _targets;
		private CFloat _damageMultiplier;
		private CFloat _range;
		private CFloat _coneAngle;

		[Ordinal(0)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(1)] 
		[RED("targets")] 
		public CUInt32 Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(2)] 
		[RED("damageMultiplier")] 
		public CFloat DamageMultiplier
		{
			get => GetProperty(ref _damageMultiplier);
			set => SetProperty(ref _damageMultiplier, value);
		}

		[Ordinal(3)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(4)] 
		[RED("coneAngle")] 
		public CFloat ConeAngle
		{
			get => GetProperty(ref _coneAngle);
			set => SetProperty(ref _coneAngle, value);
		}

		public gameSpreadingData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
