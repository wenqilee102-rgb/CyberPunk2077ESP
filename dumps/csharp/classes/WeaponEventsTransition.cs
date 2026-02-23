using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponEventsTransition : WeaponTransition
	{
		private CHandle<gamestateMachineGameScriptInterface> _scriptInterface;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;

		[Ordinal(3)] 
		[RED("scriptInterface")] 
		public CHandle<gamestateMachineGameScriptInterface> ScriptInterface
		{
			get => GetProperty(ref _scriptInterface);
			set => SetProperty(ref _scriptInterface, value);
		}

		[Ordinal(4)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		public WeaponEventsTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
