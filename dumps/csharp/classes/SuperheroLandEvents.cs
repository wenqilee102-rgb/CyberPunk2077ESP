using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SuperheroLandEvents : AbstractLandEvents
	{
		private CBool _spawnedLandingAttack;
		private CFloat _superheroFallTime;

		[Ordinal(7)] 
		[RED("spawnedLandingAttack")] 
		public CBool SpawnedLandingAttack
		{
			get => GetProperty(ref _spawnedLandingAttack);
			set => SetProperty(ref _spawnedLandingAttack, value);
		}

		[Ordinal(8)] 
		[RED("superheroFallTime")] 
		public CFloat SuperheroFallTime
		{
			get => GetProperty(ref _superheroFallTime);
			set => SetProperty(ref _superheroFallTime, value);
		}

		public SuperheroLandEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
