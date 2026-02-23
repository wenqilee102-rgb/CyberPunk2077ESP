using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChimeraComponent : gameScriptableComponent
	{
		private wCHandle<NPCPuppet> _owner;
		private entEntityID _ownerId;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CHandle<entSimpleColliderComponent> _npcDeathCollisionComponent;
		private CHandle<gameTargetingComponent> _targetingBody;
		private CHandle<ChimeraHealthChangeListener> _healthListener;
		private CBool _defeatedOnAttach;
		private CHandle<gameWeakspotComponent> _weakspotComponent;
		private CArray<wCHandle<gameWeakspotObject>> _weakspots;
		private CBool _weakspotsInvulnerable;
		private gameDelayID _weakspotsDelay;
		private CHandle<AITargetTrackerComponent> _targetTrackerComponent;

		[Ordinal(5)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("ownerId")] 
		public entEntityID OwnerId
		{
			get => GetProperty(ref _ownerId);
			set => SetProperty(ref _ownerId, value);
		}

		[Ordinal(7)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(8)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(9)] 
		[RED("npcDeathCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent
		{
			get => GetProperty(ref _npcDeathCollisionComponent);
			set => SetProperty(ref _npcDeathCollisionComponent, value);
		}

		[Ordinal(10)] 
		[RED("targetingBody")] 
		public CHandle<gameTargetingComponent> TargetingBody
		{
			get => GetProperty(ref _targetingBody);
			set => SetProperty(ref _targetingBody, value);
		}

		[Ordinal(11)] 
		[RED("healthListener")] 
		public CHandle<ChimeraHealthChangeListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(12)] 
		[RED("defeatedOnAttach")] 
		public CBool DefeatedOnAttach
		{
			get => GetProperty(ref _defeatedOnAttach);
			set => SetProperty(ref _defeatedOnAttach, value);
		}

		[Ordinal(13)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetProperty(ref _weakspotComponent);
			set => SetProperty(ref _weakspotComponent, value);
		}

		[Ordinal(14)] 
		[RED("weakspots")] 
		public CArray<wCHandle<gameWeakspotObject>> Weakspots
		{
			get => GetProperty(ref _weakspots);
			set => SetProperty(ref _weakspots, value);
		}

		[Ordinal(15)] 
		[RED("weakspotsInvulnerable")] 
		public CBool WeakspotsInvulnerable
		{
			get => GetProperty(ref _weakspotsInvulnerable);
			set => SetProperty(ref _weakspotsInvulnerable, value);
		}

		[Ordinal(16)] 
		[RED("weakspotsDelay")] 
		public gameDelayID WeakspotsDelay
		{
			get => GetProperty(ref _weakspotsDelay);
			set => SetProperty(ref _weakspotsDelay, value);
		}

		[Ordinal(17)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetProperty(ref _targetTrackerComponent);
			set => SetProperty(ref _targetTrackerComponent, value);
		}

		public ChimeraComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
