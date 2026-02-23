using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeTankGameplayController : gameuiarcadeArcadeGameplayController
	{
		private inkWidgetReference _player;
		private inkWidgetReference _enemySpawner;
		private inkWidgetReference _obstacleSpawner;
		private inkWidgetReference _pickupSpawner;
		private inkWidgetReference _projectileSpawner;
		private inkWidgetReference _background;
		private inkWidgetReference _hudCounter;
		private inkWidgetReference _hudScoreMultiplier;

		[Ordinal(3)] 
		[RED("player")] 
		public inkWidgetReference Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(4)] 
		[RED("enemySpawner")] 
		public inkWidgetReference EnemySpawner
		{
			get => GetProperty(ref _enemySpawner);
			set => SetProperty(ref _enemySpawner, value);
		}

		[Ordinal(5)] 
		[RED("obstacleSpawner")] 
		public inkWidgetReference ObstacleSpawner
		{
			get => GetProperty(ref _obstacleSpawner);
			set => SetProperty(ref _obstacleSpawner, value);
		}

		[Ordinal(6)] 
		[RED("pickupSpawner")] 
		public inkWidgetReference PickupSpawner
		{
			get => GetProperty(ref _pickupSpawner);
			set => SetProperty(ref _pickupSpawner, value);
		}

		[Ordinal(7)] 
		[RED("projectileSpawner")] 
		public inkWidgetReference ProjectileSpawner
		{
			get => GetProperty(ref _projectileSpawner);
			set => SetProperty(ref _projectileSpawner, value);
		}

		[Ordinal(8)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(9)] 
		[RED("hudCounter")] 
		public inkWidgetReference HudCounter
		{
			get => GetProperty(ref _hudCounter);
			set => SetProperty(ref _hudCounter, value);
		}

		[Ordinal(10)] 
		[RED("hudScoreMultiplier")] 
		public inkWidgetReference HudScoreMultiplier
		{
			get => GetProperty(ref _hudScoreMultiplier);
			set => SetProperty(ref _hudScoreMultiplier, value);
		}

		public gameuiarcadeTankGameplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
