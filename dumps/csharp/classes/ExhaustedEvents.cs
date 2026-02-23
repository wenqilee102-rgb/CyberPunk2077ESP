using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExhaustedEvents : StaminaEventsTransition
	{
		private CHandle<worldEffectBlackboard> _staminaVfxBlackboard;
		private CHandle<gameConstantStatModifierData_Deprecated> _disableStaminaRegenModifier;
		private wCHandle<PlayerPuppet> _player;

		[Ordinal(1)] 
		[RED("staminaVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> StaminaVfxBlackboard
		{
			get => GetProperty(ref _staminaVfxBlackboard);
			set => SetProperty(ref _staminaVfxBlackboard, value);
		}

		[Ordinal(2)] 
		[RED("disableStaminaRegenModifier")] 
		public CHandle<gameConstantStatModifierData_Deprecated> DisableStaminaRegenModifier
		{
			get => GetProperty(ref _disableStaminaRegenModifier);
			set => SetProperty(ref _disableStaminaRegenModifier, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		public ExhaustedEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
