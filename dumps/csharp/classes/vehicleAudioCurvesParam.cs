using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleAudioCurvesParam : IScriptable
	{
		private rRef<vehicleAudioVehicleCurveSet> _audioCurves;

		[Ordinal(0)] 
		[RED("audioCurves")] 
		public rRef<vehicleAudioVehicleCurveSet> AudioCurves
		{
			get => GetProperty(ref _audioCurves);
			set => SetProperty(ref _audioCurves, value);
		}

		public vehicleAudioCurvesParam(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
