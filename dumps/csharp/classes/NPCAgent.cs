using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCAgent : AgentBase
	{
		private wCHandle<ScriptedPuppet> _unit;
		private CBool _hasBeenAttackedByPlayer;
		private CBool _isQuestNPC;
		private CBool _spawnedAsFallback;
		private CBool _markedToBeDespawned;

		[Ordinal(3)] 
		[RED("unit")] 
		public wCHandle<ScriptedPuppet> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}

		[Ordinal(4)] 
		[RED("hasBeenAttackedByPlayer")] 
		public CBool HasBeenAttackedByPlayer
		{
			get => GetProperty(ref _hasBeenAttackedByPlayer);
			set => SetProperty(ref _hasBeenAttackedByPlayer, value);
		}

		[Ordinal(5)] 
		[RED("isQuestNPC")] 
		public CBool IsQuestNPC
		{
			get => GetProperty(ref _isQuestNPC);
			set => SetProperty(ref _isQuestNPC, value);
		}

		[Ordinal(6)] 
		[RED("spawnedAsFallback")] 
		public CBool SpawnedAsFallback
		{
			get => GetProperty(ref _spawnedAsFallback);
			set => SetProperty(ref _spawnedAsFallback, value);
		}

		[Ordinal(7)] 
		[RED("markedToBeDespawned")] 
		public CBool MarkedToBeDespawned
		{
			get => GetProperty(ref _markedToBeDespawned);
			set => SetProperty(ref _markedToBeDespawned, value);
		}

		public NPCAgent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
