using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorProximityDetector : ProximityDetector
	{
		private gameDelayID _triggeredAlarmID;
		private CFloat _blinkInterval;
		private CEnum<ESecurityAccessLevel> _authorizationLevel;

		[Ordinal(94)] 
		[RED("triggeredAlarmID")] 
		public gameDelayID TriggeredAlarmID
		{
			get => GetProperty(ref _triggeredAlarmID);
			set => SetProperty(ref _triggeredAlarmID, value);
		}

		[Ordinal(95)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get => GetProperty(ref _blinkInterval);
			set => SetProperty(ref _blinkInterval, value);
		}

		[Ordinal(96)] 
		[RED("authorizationLevel")] 
		public CEnum<ESecurityAccessLevel> AuthorizationLevel
		{
			get => GetProperty(ref _authorizationLevel);
			set => SetProperty(ref _authorizationLevel, value);
		}

		public DoorProximityDetector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
