using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsAggressiveCrowd : AIbehaviorconditionScript
	{
		private CHandle<AIReactionSystem> _reactionSystem;
		private entEntityID _entityID;
		private wCHandle<NPCPuppet> _npc;

		[Ordinal(0)] 
		[RED("reactionSystem")] 
		public CHandle<AIReactionSystem> ReactionSystem
		{
			get => GetProperty(ref _reactionSystem);
			set => SetProperty(ref _reactionSystem, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(2)] 
		[RED("npc")] 
		public wCHandle<NPCPuppet> Npc
		{
			get => GetProperty(ref _npc);
			set => SetProperty(ref _npc, value);
		}

		public IsAggressiveCrowd(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
