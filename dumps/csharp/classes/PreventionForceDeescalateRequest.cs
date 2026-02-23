using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionForceDeescalateRequest : gameScriptableSystemRequest
	{
		private CFloat _fakeBlinkingDuration;
		private CString _telemetryInfo;

		[Ordinal(0)] 
		[RED("fakeBlinkingDuration")] 
		public CFloat FakeBlinkingDuration
		{
			get => GetProperty(ref _fakeBlinkingDuration);
			set => SetProperty(ref _fakeBlinkingDuration, value);
		}

		[Ordinal(1)] 
		[RED("telemetryInfo")] 
		public CString TelemetryInfo
		{
			get => GetProperty(ref _telemetryInfo);
			set => SetProperty(ref _telemetryInfo, value);
		}

		public PreventionForceDeescalateRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
