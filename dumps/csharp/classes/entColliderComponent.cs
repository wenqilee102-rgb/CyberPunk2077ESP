using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entColliderComponent : entIPlacedComponent
	{
		private CArray<CHandle<physicsICollider>> _colliders;
		private CEnum<physicsSimulationType> _simulationType;
		private CBool _startInactive;
		private CBool _useCCD;
		private CFloat _massOverride;
		private CFloat _volume;
		private CFloat _mass;
		private Vector3 _inertia;
		private Transform _comOffset;
		private CHandle<physicsFilterData> _filterData;
		private CBool _isEnabled;
		private TrafficGenDynamicTrafficSetting _dynamicTrafficSetting;

		[Ordinal(5)] 
		[RED("colliders")] 
		public CArray<CHandle<physicsICollider>> Colliders
		{
			get => GetProperty(ref _colliders);
			set => SetProperty(ref _colliders, value);
		}

		[Ordinal(6)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(7)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetProperty(ref _startInactive);
			set => SetProperty(ref _startInactive, value);
		}

		[Ordinal(8)] 
		[RED("useCCD")] 
		public CBool UseCCD
		{
			get => GetProperty(ref _useCCD);
			set => SetProperty(ref _useCCD, value);
		}

		[Ordinal(9)] 
		[RED("massOverride")] 
		public CFloat MassOverride
		{
			get => GetProperty(ref _massOverride);
			set => SetProperty(ref _massOverride, value);
		}

		[Ordinal(10)] 
		[RED("volume")] 
		public CFloat Volume
		{
			get => GetProperty(ref _volume);
			set => SetProperty(ref _volume, value);
		}

		[Ordinal(11)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetProperty(ref _mass);
			set => SetProperty(ref _mass, value);
		}

		[Ordinal(12)] 
		[RED("inertia")] 
		public Vector3 Inertia
		{
			get => GetProperty(ref _inertia);
			set => SetProperty(ref _inertia, value);
		}

		[Ordinal(13)] 
		[RED("comOffset")] 
		public Transform ComOffset
		{
			get => GetProperty(ref _comOffset);
			set => SetProperty(ref _comOffset, value);
		}

		[Ordinal(14)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(15)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(16)] 
		[RED("dynamicTrafficSetting")] 
		public TrafficGenDynamicTrafficSetting DynamicTrafficSetting
		{
			get => GetProperty(ref _dynamicTrafficSetting);
			set => SetProperty(ref _dynamicTrafficSetting, value);
		}

		public entColliderComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
