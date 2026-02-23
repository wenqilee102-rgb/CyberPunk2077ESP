using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ServerNode : InteractiveDevice
	{
		private CFloat _minWeaponCharge;
		private CFloat _maxWeaponCharge;
		private CArray<CHandle<entMeshComponent>> _livePinMeshes;
		private CArray<CHandle<entMeshComponent>> _deadPinMeshes;
		private CArray<CHandle<entMeshComponent>> _closedFrontPlates;
		private CArray<CHandle<entMeshComponent>> _animatedFrontPlates;
		private CInt32 _numOfPins;
		private CInt32 _alivePins;
		private CArray<CInt32> _pinIndices;
		private CName _nodesDestroyedInTotalQuestFactName;
		private CHandle<AnimFeatureServer> _animFeatureServer;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CHandle<ServerNodeHealthChangeListener> _healthListener;
		private CName _ventingFX;
		private CName _damagedFX;
		private CHandle<entPhysicalMeshComponent> _destroyedMesh;

		[Ordinal(98)] 
		[RED("minWeaponCharge")] 
		public CFloat MinWeaponCharge
		{
			get => GetProperty(ref _minWeaponCharge);
			set => SetProperty(ref _minWeaponCharge, value);
		}

		[Ordinal(99)] 
		[RED("maxWeaponCharge")] 
		public CFloat MaxWeaponCharge
		{
			get => GetProperty(ref _maxWeaponCharge);
			set => SetProperty(ref _maxWeaponCharge, value);
		}

		[Ordinal(100)] 
		[RED("livePinMeshes")] 
		public CArray<CHandle<entMeshComponent>> LivePinMeshes
		{
			get => GetProperty(ref _livePinMeshes);
			set => SetProperty(ref _livePinMeshes, value);
		}

		[Ordinal(101)] 
		[RED("deadPinMeshes")] 
		public CArray<CHandle<entMeshComponent>> DeadPinMeshes
		{
			get => GetProperty(ref _deadPinMeshes);
			set => SetProperty(ref _deadPinMeshes, value);
		}

		[Ordinal(102)] 
		[RED("closedFrontPlates")] 
		public CArray<CHandle<entMeshComponent>> ClosedFrontPlates
		{
			get => GetProperty(ref _closedFrontPlates);
			set => SetProperty(ref _closedFrontPlates, value);
		}

		[Ordinal(103)] 
		[RED("animatedFrontPlates")] 
		public CArray<CHandle<entMeshComponent>> AnimatedFrontPlates
		{
			get => GetProperty(ref _animatedFrontPlates);
			set => SetProperty(ref _animatedFrontPlates, value);
		}

		[Ordinal(104)] 
		[RED("numOfPins")] 
		public CInt32 NumOfPins
		{
			get => GetProperty(ref _numOfPins);
			set => SetProperty(ref _numOfPins, value);
		}

		[Ordinal(105)] 
		[RED("alivePins")] 
		public CInt32 AlivePins
		{
			get => GetProperty(ref _alivePins);
			set => SetProperty(ref _alivePins, value);
		}

		[Ordinal(106)] 
		[RED("pinIndices")] 
		public CArray<CInt32> PinIndices
		{
			get => GetProperty(ref _pinIndices);
			set => SetProperty(ref _pinIndices, value);
		}

		[Ordinal(107)] 
		[RED("nodesDestroyedInTotalQuestFactName")] 
		public CName NodesDestroyedInTotalQuestFactName
		{
			get => GetProperty(ref _nodesDestroyedInTotalQuestFactName);
			set => SetProperty(ref _nodesDestroyedInTotalQuestFactName, value);
		}

		[Ordinal(108)] 
		[RED("animFeatureServer")] 
		public CHandle<AnimFeatureServer> AnimFeatureServer
		{
			get => GetProperty(ref _animFeatureServer);
			set => SetProperty(ref _animFeatureServer, value);
		}

		[Ordinal(109)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(110)] 
		[RED("healthListener")] 
		public CHandle<ServerNodeHealthChangeListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(111)] 
		[RED("ventingFX")] 
		public CName VentingFX
		{
			get => GetProperty(ref _ventingFX);
			set => SetProperty(ref _ventingFX, value);
		}

		[Ordinal(112)] 
		[RED("damagedFX")] 
		public CName DamagedFX
		{
			get => GetProperty(ref _damagedFX);
			set => SetProperty(ref _damagedFX, value);
		}

		[Ordinal(113)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get => GetProperty(ref _destroyedMesh);
			set => SetProperty(ref _destroyedMesh, value);
		}

		public ServerNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
