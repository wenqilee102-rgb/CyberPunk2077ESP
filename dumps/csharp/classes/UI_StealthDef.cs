using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_StealthDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _combatDebug;
		private gamebbScriptID_Uint32 _numberOfCombatants;
		private gamebbScriptID_Float _highestDetectionOnPlayer;
		private gamebbScriptID_Float _highestHostileDetectionOnPlayer;

		[Ordinal(0)] 
		[RED("CombatDebug")] 
		public gamebbScriptID_Bool CombatDebug
		{
			get => GetProperty(ref _combatDebug);
			set => SetProperty(ref _combatDebug, value);
		}

		[Ordinal(1)] 
		[RED("numberOfCombatants")] 
		public gamebbScriptID_Uint32 NumberOfCombatants
		{
			get => GetProperty(ref _numberOfCombatants);
			set => SetProperty(ref _numberOfCombatants, value);
		}

		[Ordinal(2)] 
		[RED("highestDetectionOnPlayer")] 
		public gamebbScriptID_Float HighestDetectionOnPlayer
		{
			get => GetProperty(ref _highestDetectionOnPlayer);
			set => SetProperty(ref _highestDetectionOnPlayer, value);
		}

		[Ordinal(3)] 
		[RED("highestHostileDetectionOnPlayer")] 
		public gamebbScriptID_Float HighestHostileDetectionOnPlayer
		{
			get => GetProperty(ref _highestHostileDetectionOnPlayer);
			set => SetProperty(ref _highestHostileDetectionOnPlayer, value);
		}

		public UI_StealthDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
