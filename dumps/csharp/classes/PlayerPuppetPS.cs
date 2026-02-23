using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerPuppetPS : ScriptedPuppetPS
	{
		private KeyBindings _keybindigs;
		private CArray<gameuiMinigameProgramData> _availablePrograms;
		private CBool _hasAutoReveal;
		private CFloat _combatExitTimestamp;
		private CBool _isInDriverCombat;
		private CInt32 _pocketRadioStation;
		private CFloat _permanentHealthBonus;
		private CFloat _permanentStaminaBonus;
		private CFloat _permanentMemoryBonus;
		private wCHandle<gameIBlackboard> _minigameBB;

		[Ordinal(35)] 
		[RED("keybindigs")] 
		public KeyBindings Keybindigs
		{
			get => GetProperty(ref _keybindigs);
			set => SetProperty(ref _keybindigs, value);
		}

		[Ordinal(36)] 
		[RED("availablePrograms")] 
		public CArray<gameuiMinigameProgramData> AvailablePrograms
		{
			get => GetProperty(ref _availablePrograms);
			set => SetProperty(ref _availablePrograms, value);
		}

		[Ordinal(37)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetProperty(ref _hasAutoReveal);
			set => SetProperty(ref _hasAutoReveal, value);
		}

		[Ordinal(38)] 
		[RED("combatExitTimestamp")] 
		public CFloat CombatExitTimestamp
		{
			get => GetProperty(ref _combatExitTimestamp);
			set => SetProperty(ref _combatExitTimestamp, value);
		}

		[Ordinal(39)] 
		[RED("isInDriverCombat")] 
		public CBool IsInDriverCombat
		{
			get => GetProperty(ref _isInDriverCombat);
			set => SetProperty(ref _isInDriverCombat, value);
		}

		[Ordinal(40)] 
		[RED("pocketRadioStation")] 
		public CInt32 PocketRadioStation
		{
			get => GetProperty(ref _pocketRadioStation);
			set => SetProperty(ref _pocketRadioStation, value);
		}

		[Ordinal(41)] 
		[RED("permanentHealthBonus")] 
		public CFloat PermanentHealthBonus
		{
			get => GetProperty(ref _permanentHealthBonus);
			set => SetProperty(ref _permanentHealthBonus, value);
		}

		[Ordinal(42)] 
		[RED("permanentStaminaBonus")] 
		public CFloat PermanentStaminaBonus
		{
			get => GetProperty(ref _permanentStaminaBonus);
			set => SetProperty(ref _permanentStaminaBonus, value);
		}

		[Ordinal(43)] 
		[RED("permanentMemoryBonus")] 
		public CFloat PermanentMemoryBonus
		{
			get => GetProperty(ref _permanentMemoryBonus);
			set => SetProperty(ref _permanentMemoryBonus, value);
		}

		[Ordinal(44)] 
		[RED("minigameBB")] 
		public wCHandle<gameIBlackboard> MinigameBB
		{
			get => GetProperty(ref _minigameBB);
			set => SetProperty(ref _minigameBB, value);
		}

		public PlayerPuppetPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
