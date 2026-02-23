using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_MissEvent : gameEffectAction
	{
		private CBool _npcMissEvents;

		[Ordinal(0)] 
		[RED("npcMissEvents")] 
		public CBool NpcMissEvents
		{
			get => GetProperty(ref _npcMissEvents);
			set => SetProperty(ref _npcMissEvents, value);
		}

		public gameEffectAction_MissEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
