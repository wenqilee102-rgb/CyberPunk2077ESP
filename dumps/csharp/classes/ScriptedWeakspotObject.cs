using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedWeakspotObject : gameWeakspotObject
	{
		private WeakspotOnDestroyProperties _weakspotOnDestroyProperties;
		private CHandle<entMeshComponent> _mesh;
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<gameTargetingComponent> _targeting;
		private CHandle<entIPlacedComponent> _collider;
		private wCHandle<gameObject> _instigator;
		private WeakspotRecordData _weakspotRecordData;
		private CBool _alive;
		private CBool _hasBeenScanned;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<WeakspotHealthChangeListener> _healthListener;
		private CFloat _parentMaxhealth;
		private CBool _blockHighlight;
		private CBool _blockDamage;

		[Ordinal(36)] 
		[RED("weakspotOnDestroyProperties")] 
		public WeakspotOnDestroyProperties WeakspotOnDestroyProperties
		{
			get => GetProperty(ref _weakspotOnDestroyProperties);
			set => SetProperty(ref _weakspotOnDestroyProperties, value);
		}

		[Ordinal(37)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(38)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}

		[Ordinal(39)] 
		[RED("targeting")] 
		public CHandle<gameTargetingComponent> Targeting
		{
			get => GetProperty(ref _targeting);
			set => SetProperty(ref _targeting, value);
		}

		[Ordinal(40)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}

		[Ordinal(41)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(42)] 
		[RED("weakspotRecordData")] 
		public WeakspotRecordData WeakspotRecordData
		{
			get => GetProperty(ref _weakspotRecordData);
			set => SetProperty(ref _weakspotRecordData, value);
		}

		[Ordinal(43)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(44)] 
		[RED("hasBeenScanned")] 
		public CBool HasBeenScanned
		{
			get => GetProperty(ref _hasBeenScanned);
			set => SetProperty(ref _hasBeenScanned, value);
		}

		[Ordinal(45)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(46)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(47)] 
		[RED("healthListener")] 
		public CHandle<WeakspotHealthChangeListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(48)] 
		[RED("parentMaxhealth")] 
		public CFloat ParentMaxhealth
		{
			get => GetProperty(ref _parentMaxhealth);
			set => SetProperty(ref _parentMaxhealth, value);
		}

		[Ordinal(49)] 
		[RED("blockHighlight")] 
		public CBool BlockHighlight
		{
			get => GetProperty(ref _blockHighlight);
			set => SetProperty(ref _blockHighlight, value);
		}

		[Ordinal(50)] 
		[RED("blockDamage")] 
		public CBool BlockDamage
		{
			get => GetProperty(ref _blockDamage);
			set => SetProperty(ref _blockDamage, value);
		}

		public ScriptedWeakspotObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
