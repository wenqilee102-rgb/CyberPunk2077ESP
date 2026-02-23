using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionBlinkingStatusRequest : gameScriptableSystemRequest
	{
		private CBool _lockPreventionSystemWhileBlinking;
		private CString _telemetryInfo;

		[Ordinal(0)] 
		[RED("lockPreventionSystemWhileBlinking")] 
		public CBool LockPreventionSystemWhileBlinking
		{
			get => GetProperty(ref _lockPreventionSystemWhileBlinking);
			set => SetProperty(ref _lockPreventionSystemWhileBlinking, value);
		}

		[Ordinal(1)] 
		[RED("telemetryInfo")] 
		public CString TelemetryInfo
		{
			get => GetProperty(ref _telemetryInfo);
			set => SetProperty(ref _telemetryInfo, value);
		}

		public PreventionBlinkingStatusRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
