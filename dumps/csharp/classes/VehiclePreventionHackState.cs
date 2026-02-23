using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehiclePreventionHackState : IScriptable
	{
		private wCHandle<vehicleBaseObject> _vehicle;
		private entEntityID _vehicleID;
		private CFloat _progressBarProgressSoFar;
		private CFloat _progressBarProgressStart;
		private CBool _hacked;
		private CBool _hackInProgress;
		private CBool _stoppedVehicle;
		private wCHandle<UploadFromNPCToPlayerListener> _progressBar;
		private CEnum<EAppliedTriangulationHackSpeed> _appliedHackSpeed;

		[Ordinal(0)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(1)] 
		[RED("vehicleID")] 
		public entEntityID VehicleID
		{
			get => GetProperty(ref _vehicleID);
			set => SetProperty(ref _vehicleID, value);
		}

		[Ordinal(2)] 
		[RED("progressBarProgressSoFar")] 
		public CFloat ProgressBarProgressSoFar
		{
			get => GetProperty(ref _progressBarProgressSoFar);
			set => SetProperty(ref _progressBarProgressSoFar, value);
		}

		[Ordinal(3)] 
		[RED("progressBarProgressStart")] 
		public CFloat ProgressBarProgressStart
		{
			get => GetProperty(ref _progressBarProgressStart);
			set => SetProperty(ref _progressBarProgressStart, value);
		}

		[Ordinal(4)] 
		[RED("hacked")] 
		public CBool Hacked
		{
			get => GetProperty(ref _hacked);
			set => SetProperty(ref _hacked, value);
		}

		[Ordinal(5)] 
		[RED("hackInProgress")] 
		public CBool HackInProgress
		{
			get => GetProperty(ref _hackInProgress);
			set => SetProperty(ref _hackInProgress, value);
		}

		[Ordinal(6)] 
		[RED("stoppedVehicle")] 
		public CBool StoppedVehicle
		{
			get => GetProperty(ref _stoppedVehicle);
			set => SetProperty(ref _stoppedVehicle, value);
		}

		[Ordinal(7)] 
		[RED("progressBar")] 
		public wCHandle<UploadFromNPCToPlayerListener> ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(8)] 
		[RED("appliedHackSpeed")] 
		public CEnum<EAppliedTriangulationHackSpeed> AppliedHackSpeed
		{
			get => GetProperty(ref _appliedHackSpeed);
			set => SetProperty(ref _appliedHackSpeed, value);
		}

		public VehiclePreventionHackState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
