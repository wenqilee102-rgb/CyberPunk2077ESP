using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleController : gameComponent
	{
		private CName _alarmCurve;
		private CFloat _alarmTime;
		private CBool _overrideHeadlightsSettingsForPlayer;

		[Ordinal(4)] 
		[RED("alarmCurve")] 
		public CName AlarmCurve
		{
			get => GetProperty(ref _alarmCurve);
			set => SetProperty(ref _alarmCurve, value);
		}

		[Ordinal(5)] 
		[RED("alarmTime")] 
		public CFloat AlarmTime
		{
			get => GetProperty(ref _alarmTime);
			set => SetProperty(ref _alarmTime, value);
		}

		[Ordinal(6)] 
		[RED("overrideHeadlightsSettingsForPlayer")] 
		public CBool OverrideHeadlightsSettingsForPlayer
		{
			get => GetProperty(ref _overrideHeadlightsSettingsForPlayer);
			set => SetProperty(ref _overrideHeadlightsSettingsForPlayer, value);
		}

		public vehicleController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
