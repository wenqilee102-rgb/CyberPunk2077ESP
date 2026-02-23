using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterLevelController : inkWidgetLogicController
	{
		private inkWidgetReference _playerSpawnPoint;
		private inkWidgetReference _background;
		private inkWidgetReference _collision;
		private CEnum<gameuiarcadeShooterLevelType> _levelType;
		private inkWidgetReference _spawner;
		private inkWidgetReference _enemyBulletSpawner;
		private inkWidgetReference _playerBulletSpawner;
		private inkWidgetReference _vfxSpawner;
		private Vector2 _mapEndBorder;

		[Ordinal(1)] 
		[RED("playerSpawnPoint")] 
		public inkWidgetReference PlayerSpawnPoint
		{
			get => GetProperty(ref _playerSpawnPoint);
			set => SetProperty(ref _playerSpawnPoint, value);
		}

		[Ordinal(2)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(3)] 
		[RED("collision")] 
		public inkWidgetReference Collision
		{
			get => GetProperty(ref _collision);
			set => SetProperty(ref _collision, value);
		}

		[Ordinal(4)] 
		[RED("levelType")] 
		public CEnum<gameuiarcadeShooterLevelType> LevelType
		{
			get => GetProperty(ref _levelType);
			set => SetProperty(ref _levelType, value);
		}

		[Ordinal(5)] 
		[RED("spawner")] 
		public inkWidgetReference Spawner
		{
			get => GetProperty(ref _spawner);
			set => SetProperty(ref _spawner, value);
		}

		[Ordinal(6)] 
		[RED("enemyBulletSpawner")] 
		public inkWidgetReference EnemyBulletSpawner
		{
			get => GetProperty(ref _enemyBulletSpawner);
			set => SetProperty(ref _enemyBulletSpawner, value);
		}

		[Ordinal(7)] 
		[RED("playerBulletSpawner")] 
		public inkWidgetReference PlayerBulletSpawner
		{
			get => GetProperty(ref _playerBulletSpawner);
			set => SetProperty(ref _playerBulletSpawner, value);
		}

		[Ordinal(8)] 
		[RED("vfxSpawner")] 
		public inkWidgetReference VfxSpawner
		{
			get => GetProperty(ref _vfxSpawner);
			set => SetProperty(ref _vfxSpawner, value);
		}

		[Ordinal(9)] 
		[RED("mapEndBorder")] 
		public Vector2 MapEndBorder
		{
			get => GetProperty(ref _mapEndBorder);
			set => SetProperty(ref _mapEndBorder, value);
		}

		public gameuiarcadeShooterLevelController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
