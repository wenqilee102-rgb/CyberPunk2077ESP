using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDynamicSpawnSystemEnemyDistance : questIDistance
	{
		private CName _waveTag;
		private CBool _checkAllEnemies;
		private CEnum<questDistanceType> _distanceType;

		[Ordinal(0)] 
		[RED("waveTag")] 
		public CName WaveTag
		{
			get => GetProperty(ref _waveTag);
			set => SetProperty(ref _waveTag, value);
		}

		[Ordinal(1)] 
		[RED("checkAllEnemies")] 
		public CBool CheckAllEnemies
		{
			get => GetProperty(ref _checkAllEnemies);
			set => SetProperty(ref _checkAllEnemies, value);
		}

		[Ordinal(2)] 
		[RED("distanceType")] 
		public CEnum<questDistanceType> DistanceType
		{
			get => GetProperty(ref _distanceType);
			set => SetProperty(ref _distanceType, value);
		}

		public questDynamicSpawnSystemEnemyDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
