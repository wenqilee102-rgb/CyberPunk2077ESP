using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleCanUseCover : AIbehaviorconditionScript
	{
		private wCHandle<gamedataGameplayAbility_Record> _ability;
		private CArray<CHandle<gameIPrereq>> _prereqs;
		private CInt32 _prereqCount;
		private ScriptGameInstance _game;

		[Ordinal(0)] 
		[RED("ability")] 
		public wCHandle<gamedataGameplayAbility_Record> Ability
		{
			get => GetProperty(ref _ability);
			set => SetProperty(ref _ability, value);
		}

		[Ordinal(1)] 
		[RED("prereqs")] 
		public CArray<CHandle<gameIPrereq>> Prereqs
		{
			get => GetProperty(ref _prereqs);
			set => SetProperty(ref _prereqs, value);
		}

		[Ordinal(2)] 
		[RED("prereqCount")] 
		public CInt32 PrereqCount
		{
			get => GetProperty(ref _prereqCount);
			set => SetProperty(ref _prereqCount, value);
		}

		[Ordinal(3)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		public SimpleCanUseCover(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
