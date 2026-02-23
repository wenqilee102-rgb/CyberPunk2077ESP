using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoyceComponent : gameScriptableComponent
	{
		private wCHandle<NPCPuppet> _owner;
		private entEntityID _owner_id;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entSimpleColliderComponent> _npcDeathCollisionComponent;
		private CHandle<entIComponent> _npcHitRepresentationComponent;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CHandle<animAnimFeature_HitReactionsData> _hitData;
		private CBool _weakspotDestroyed;

		[Ordinal(5)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get => GetProperty(ref _owner_id);
			set => SetProperty(ref _owner_id, value);
		}

		[Ordinal(7)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetProperty(ref _npcCollisionComponent);
			set => SetProperty(ref _npcCollisionComponent, value);
		}

		[Ordinal(8)] 
		[RED("npcDeathCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcDeathCollisionComponent
		{
			get => GetProperty(ref _npcDeathCollisionComponent);
			set => SetProperty(ref _npcDeathCollisionComponent, value);
		}

		[Ordinal(9)] 
		[RED("npcHitRepresentationComponent")] 
		public CHandle<entIComponent> NpcHitRepresentationComponent
		{
			get => GetProperty(ref _npcHitRepresentationComponent);
			set => SetProperty(ref _npcHitRepresentationComponent, value);
		}

		[Ordinal(10)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(11)] 
		[RED("hitData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitData
		{
			get => GetProperty(ref _hitData);
			set => SetProperty(ref _hitData, value);
		}

		[Ordinal(12)] 
		[RED("weakspotDestroyed")] 
		public CBool WeakspotDestroyed
		{
			get => GetProperty(ref _weakspotDestroyed);
			set => SetProperty(ref _weakspotDestroyed, value);
		}

		public RoyceComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
