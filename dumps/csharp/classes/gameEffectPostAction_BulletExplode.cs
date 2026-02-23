using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_BulletExplode : gameEffectPostAction
	{
		private CFloat _endRangeTolerance;
		private CFloat _explosionDuration;

		[Ordinal(0)] 
		[RED("endRangeTolerance")] 
		public CFloat EndRangeTolerance
		{
			get => GetProperty(ref _endRangeTolerance);
			set => SetProperty(ref _endRangeTolerance, value);
		}

		[Ordinal(1)] 
		[RED("explosionDuration")] 
		public CFloat ExplosionDuration
		{
			get => GetProperty(ref _explosionDuration);
			set => SetProperty(ref _explosionDuration, value);
		}

		public gameEffectPostAction_BulletExplode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
