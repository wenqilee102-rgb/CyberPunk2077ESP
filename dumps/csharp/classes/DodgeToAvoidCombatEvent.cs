using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DodgeToAvoidCombatEvent : redEvent
	{
		private gameDelayID _delayID;
		private entEntityID _npcID;

		[Ordinal(0)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		[Ordinal(1)] 
		[RED("npcID")] 
		public entEntityID NpcID
		{
			get => GetProperty(ref _npcID);
			set => SetProperty(ref _npcID, value);
		}

		public DodgeToAvoidCombatEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
