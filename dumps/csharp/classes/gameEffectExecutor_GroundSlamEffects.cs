using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_GroundSlamEffects : gameEffectExecutor
	{
		private raRef<worldEffect> _groundEffect;
		private raRef<worldEffect> _waterEffect;
		private raRef<worldEffect> _earthquakeLevel1;
		private raRef<worldEffect> _earthquakeLevel2;
		private CFloat _earthquakeLevel1ChargeThreshold;
		private CFloat _earthquakeLevel2ChargeThreshold;

		[Ordinal(1)] 
		[RED("groundEffect")] 
		public raRef<worldEffect> GroundEffect
		{
			get => GetProperty(ref _groundEffect);
			set => SetProperty(ref _groundEffect, value);
		}

		[Ordinal(2)] 
		[RED("waterEffect")] 
		public raRef<worldEffect> WaterEffect
		{
			get => GetProperty(ref _waterEffect);
			set => SetProperty(ref _waterEffect, value);
		}

		[Ordinal(3)] 
		[RED("earthquakeLevel1")] 
		public raRef<worldEffect> EarthquakeLevel1
		{
			get => GetProperty(ref _earthquakeLevel1);
			set => SetProperty(ref _earthquakeLevel1, value);
		}

		[Ordinal(4)] 
		[RED("earthquakeLevel2")] 
		public raRef<worldEffect> EarthquakeLevel2
		{
			get => GetProperty(ref _earthquakeLevel2);
			set => SetProperty(ref _earthquakeLevel2, value);
		}

		[Ordinal(5)] 
		[RED("earthquakeLevel1ChargeThreshold")] 
		public CFloat EarthquakeLevel1ChargeThreshold
		{
			get => GetProperty(ref _earthquakeLevel1ChargeThreshold);
			set => SetProperty(ref _earthquakeLevel1ChargeThreshold, value);
		}

		[Ordinal(6)] 
		[RED("earthquakeLevel2ChargeThreshold")] 
		public CFloat EarthquakeLevel2ChargeThreshold
		{
			get => GetProperty(ref _earthquakeLevel2ChargeThreshold);
			set => SetProperty(ref _earthquakeLevel2ChargeThreshold, value);
		}

		public gameEffectExecutor_GroundSlamEffects(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
