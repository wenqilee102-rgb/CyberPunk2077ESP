using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeBankOnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		private wCHandle<StatusEffectBasedTimeBankEffector> _effector;

		[Ordinal(0)] 
		[RED("effector")] 
		public wCHandle<StatusEffectBasedTimeBankEffector> Effector
		{
			get => GetProperty(ref _effector);
			set => SetProperty(ref _effector, value);
		}

		public TimeBankOnStatusEffectAppliedListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
