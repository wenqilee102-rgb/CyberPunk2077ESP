using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AutodriveAndCinematicCameraContextDecisions : InputContextTransitionDecisions
	{
		private CHandle<redCallbackObject> _autodriveCallbackID;
		private CHandle<redCallbackObject> _cinematicCameraCallbackID;
		private CHandle<redCallbackObject> _delamainTaxiCallbackID;
		private CBool _autodriveEnabled;
		private CBool _cinematicCameraActive;
		private CBool _delamainTaxi;

		[Ordinal(0)] 
		[RED("autodriveCallbackID")] 
		public CHandle<redCallbackObject> AutodriveCallbackID
		{
			get => GetProperty(ref _autodriveCallbackID);
			set => SetProperty(ref _autodriveCallbackID, value);
		}

		[Ordinal(1)] 
		[RED("cinematicCameraCallbackID")] 
		public CHandle<redCallbackObject> CinematicCameraCallbackID
		{
			get => GetProperty(ref _cinematicCameraCallbackID);
			set => SetProperty(ref _cinematicCameraCallbackID, value);
		}

		[Ordinal(2)] 
		[RED("delamainTaxiCallbackID")] 
		public CHandle<redCallbackObject> DelamainTaxiCallbackID
		{
			get => GetProperty(ref _delamainTaxiCallbackID);
			set => SetProperty(ref _delamainTaxiCallbackID, value);
		}

		[Ordinal(3)] 
		[RED("autodriveEnabled")] 
		public CBool AutodriveEnabled
		{
			get => GetProperty(ref _autodriveEnabled);
			set => SetProperty(ref _autodriveEnabled, value);
		}

		[Ordinal(4)] 
		[RED("cinematicCameraActive")] 
		public CBool CinematicCameraActive
		{
			get => GetProperty(ref _cinematicCameraActive);
			set => SetProperty(ref _cinematicCameraActive, value);
		}

		[Ordinal(5)] 
		[RED("delamainTaxi")] 
		public CBool DelamainTaxi
		{
			get => GetProperty(ref _delamainTaxi);
			set => SetProperty(ref _delamainTaxi, value);
		}

		public AutodriveAndCinematicCameraContextDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
