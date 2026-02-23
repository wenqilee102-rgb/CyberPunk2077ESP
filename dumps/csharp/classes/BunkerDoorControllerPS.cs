using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BunkerDoorControllerPS : DoorControllerPS
	{
		private CFloat _npcOpenSpeed;
		private CFloat _npcOpenTime;
		private CEnum<EMalfunctioningType> _malfunctioningType;
		private CInt32 _malfunctioningChance;
		private CFloat _malfunctioningStimRange;
		private CBool _malfanctioningBehaviourActive;

		[Ordinal(117)] 
		[RED("NpcOpenSpeed")] 
		public CFloat NpcOpenSpeed
		{
			get => GetProperty(ref _npcOpenSpeed);
			set => SetProperty(ref _npcOpenSpeed, value);
		}

		[Ordinal(118)] 
		[RED("NpcOpenTime")] 
		public CFloat NpcOpenTime
		{
			get => GetProperty(ref _npcOpenTime);
			set => SetProperty(ref _npcOpenTime, value);
		}

		[Ordinal(119)] 
		[RED("malfunctioningType")] 
		public CEnum<EMalfunctioningType> MalfunctioningType
		{
			get => GetProperty(ref _malfunctioningType);
			set => SetProperty(ref _malfunctioningType, value);
		}

		[Ordinal(120)] 
		[RED("malfunctioningChance")] 
		public CInt32 MalfunctioningChance
		{
			get => GetProperty(ref _malfunctioningChance);
			set => SetProperty(ref _malfunctioningChance, value);
		}

		[Ordinal(121)] 
		[RED("malfunctioningStimRange")] 
		public CFloat MalfunctioningStimRange
		{
			get => GetProperty(ref _malfunctioningStimRange);
			set => SetProperty(ref _malfunctioningStimRange, value);
		}

		[Ordinal(122)] 
		[RED("malfanctioningBehaviourActive")] 
		public CBool MalfanctioningBehaviourActive
		{
			get => GetProperty(ref _malfanctioningBehaviourActive);
			set => SetProperty(ref _malfanctioningBehaviourActive, value);
		}

		public BunkerDoorControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
