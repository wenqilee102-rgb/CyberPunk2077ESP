using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDevice : BasicDistractionDevice
	{
		private CInt32 _numberOfComponentsToON;
		private CInt32 _numberOfComponentsToOFF;
		private CArray<CInt32> _indexesOfComponentsToOFF;
		private CBool _shouldDistractionEnableCollider;
		private CBool _shouldDistractionVFXstay;
		private CName _loopAudioEvent;
		private CArray<CHandle<gameFxInstance>> _spawnedFxInstancesToKill;
		private CHandle<entMeshComponent> _mesh;
		private CHandle<entIPlacedComponent> _collider;
		private CHandle<entIPlacedComponent> _distractionCollider;
		private CInt32 _numberOfReceivedHits;
		private CFloat _devicePenetrationHealth;
		private CBool _killedByExplosion;
		private CFloat _distractionTimeStart;
		private CBool _isBroadcastingEnvironmentalHazardStim;
		private CBool _explodedByQuickhack;
		private CBool _switchAppearanceOnExplosion;
		private CName _explodedAppearanceName;
		private CArray<CHandle<entIPlacedComponent>> _componentsON;
		private CArray<CHandle<entIPlacedComponent>> _componentsOFF;

		[Ordinal(106)] 
		[RED("numberOfComponentsToON")] 
		public CInt32 NumberOfComponentsToON
		{
			get => GetProperty(ref _numberOfComponentsToON);
			set => SetProperty(ref _numberOfComponentsToON, value);
		}

		[Ordinal(107)] 
		[RED("numberOfComponentsToOFF")] 
		public CInt32 NumberOfComponentsToOFF
		{
			get => GetProperty(ref _numberOfComponentsToOFF);
			set => SetProperty(ref _numberOfComponentsToOFF, value);
		}

		[Ordinal(108)] 
		[RED("indexesOfComponentsToOFF")] 
		public CArray<CInt32> IndexesOfComponentsToOFF
		{
			get => GetProperty(ref _indexesOfComponentsToOFF);
			set => SetProperty(ref _indexesOfComponentsToOFF, value);
		}

		[Ordinal(109)] 
		[RED("shouldDistractionEnableCollider")] 
		public CBool ShouldDistractionEnableCollider
		{
			get => GetProperty(ref _shouldDistractionEnableCollider);
			set => SetProperty(ref _shouldDistractionEnableCollider, value);
		}

		[Ordinal(110)] 
		[RED("shouldDistractionVFXstay")] 
		public CBool ShouldDistractionVFXstay
		{
			get => GetProperty(ref _shouldDistractionVFXstay);
			set => SetProperty(ref _shouldDistractionVFXstay, value);
		}

		[Ordinal(111)] 
		[RED("loopAudioEvent")] 
		public CName LoopAudioEvent
		{
			get => GetProperty(ref _loopAudioEvent);
			set => SetProperty(ref _loopAudioEvent, value);
		}

		[Ordinal(112)] 
		[RED("spawnedFxInstancesToKill")] 
		public CArray<CHandle<gameFxInstance>> SpawnedFxInstancesToKill
		{
			get => GetProperty(ref _spawnedFxInstancesToKill);
			set => SetProperty(ref _spawnedFxInstancesToKill, value);
		}

		[Ordinal(113)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(114)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}

		[Ordinal(115)] 
		[RED("distractionCollider")] 
		public CHandle<entIPlacedComponent> DistractionCollider
		{
			get => GetProperty(ref _distractionCollider);
			set => SetProperty(ref _distractionCollider, value);
		}

		[Ordinal(116)] 
		[RED("numberOfReceivedHits")] 
		public CInt32 NumberOfReceivedHits
		{
			get => GetProperty(ref _numberOfReceivedHits);
			set => SetProperty(ref _numberOfReceivedHits, value);
		}

		[Ordinal(117)] 
		[RED("devicePenetrationHealth")] 
		public CFloat DevicePenetrationHealth
		{
			get => GetProperty(ref _devicePenetrationHealth);
			set => SetProperty(ref _devicePenetrationHealth, value);
		}

		[Ordinal(118)] 
		[RED("killedByExplosion")] 
		public CBool KilledByExplosion
		{
			get => GetProperty(ref _killedByExplosion);
			set => SetProperty(ref _killedByExplosion, value);
		}

		[Ordinal(119)] 
		[RED("distractionTimeStart")] 
		public CFloat DistractionTimeStart
		{
			get => GetProperty(ref _distractionTimeStart);
			set => SetProperty(ref _distractionTimeStart, value);
		}

		[Ordinal(120)] 
		[RED("isBroadcastingEnvironmentalHazardStim")] 
		public CBool IsBroadcastingEnvironmentalHazardStim
		{
			get => GetProperty(ref _isBroadcastingEnvironmentalHazardStim);
			set => SetProperty(ref _isBroadcastingEnvironmentalHazardStim, value);
		}

		[Ordinal(121)] 
		[RED("explodedByQuickhack")] 
		public CBool ExplodedByQuickhack
		{
			get => GetProperty(ref _explodedByQuickhack);
			set => SetProperty(ref _explodedByQuickhack, value);
		}

		[Ordinal(122)] 
		[RED("switchAppearanceOnExplosion")] 
		public CBool SwitchAppearanceOnExplosion
		{
			get => GetProperty(ref _switchAppearanceOnExplosion);
			set => SetProperty(ref _switchAppearanceOnExplosion, value);
		}

		[Ordinal(123)] 
		[RED("explodedAppearanceName")] 
		public CName ExplodedAppearanceName
		{
			get => GetProperty(ref _explodedAppearanceName);
			set => SetProperty(ref _explodedAppearanceName, value);
		}

		[Ordinal(124)] 
		[RED("componentsON")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsON
		{
			get => GetProperty(ref _componentsON);
			set => SetProperty(ref _componentsON, value);
		}

		[Ordinal(125)] 
		[RED("componentsOFF")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsOFF
		{
			get => GetProperty(ref _componentsOFF);
			set => SetProperty(ref _componentsOFF, value);
		}

		public ExplosiveDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
