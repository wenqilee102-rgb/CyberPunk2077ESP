using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StuckInEffector : gameContinuousEffector
	{
		private CFloat _maxEnemyDistance;
		private CInt32 _enemyCount;
		private TweakDBID _statusEffectID;

		[Ordinal(0)] 
		[RED("maxEnemyDistance")] 
		public CFloat MaxEnemyDistance
		{
			get => GetProperty(ref _maxEnemyDistance);
			set => SetProperty(ref _maxEnemyDistance, value);
		}

		[Ordinal(1)] 
		[RED("enemyCount")] 
		public CInt32 EnemyCount
		{
			get => GetProperty(ref _enemyCount);
			set => SetProperty(ref _enemyCount, value);
		}

		[Ordinal(2)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetProperty(ref _statusEffectID);
			set => SetProperty(ref _statusEffectID, value);
		}

		public StuckInEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
