using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraShot : IScriptable
	{
		private CString _name;
		private CBool _enabled;
		private CInt32 _probability;
		private CFloat _duration;
		private CBool _scaleForVehicle;
		private CHandle<vehicleCinematicCameraShotRoot> _root;
		private CArray<CHandle<vehicleCinematicCameraShotEffect>> _effects;
		private CArray<CHandle<vehicleCinematicCameraShotStopCondition>> _stopConditions;
		private CinematicCameraData _runtimeData;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CInt32 Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("scaleForVehicle")] 
		public CBool ScaleForVehicle
		{
			get => GetProperty(ref _scaleForVehicle);
			set => SetProperty(ref _scaleForVehicle, value);
		}

		[Ordinal(5)] 
		[RED("root")] 
		public CHandle<vehicleCinematicCameraShotRoot> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(6)] 
		[RED("effects")] 
		public CArray<CHandle<vehicleCinematicCameraShotEffect>> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		[Ordinal(7)] 
		[RED("stopConditions")] 
		public CArray<CHandle<vehicleCinematicCameraShotStopCondition>> StopConditions
		{
			get => GetProperty(ref _stopConditions);
			set => SetProperty(ref _stopConditions, value);
		}

		[Ordinal(8)] 
		[RED("runtimeData")] 
		public CinematicCameraData RuntimeData
		{
			get => GetProperty(ref _runtimeData);
			set => SetProperty(ref _runtimeData, value);
		}

		public vehicleCinematicCameraShot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
