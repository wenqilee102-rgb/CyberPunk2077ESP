using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectAndDamageEventData : gameScriptTaskData
	{
		private CHandle<gameeventsHitEvent> _hitevent;
		private CArray<wCHandle<entEntity>> _threats;
		private CHandle<TriggerAttackOnNearbyEnemiesEffector> _effectorInstance;

		[Ordinal(0)] 
		[RED("hitevent")] 
		public CHandle<gameeventsHitEvent> Hitevent
		{
			get => GetProperty(ref _hitevent);
			set => SetProperty(ref _hitevent, value);
		}

		[Ordinal(1)] 
		[RED("threats")] 
		public CArray<wCHandle<entEntity>> Threats
		{
			get => GetProperty(ref _threats);
			set => SetProperty(ref _threats, value);
		}

		[Ordinal(2)] 
		[RED("effectorInstance")] 
		public CHandle<TriggerAttackOnNearbyEnemiesEffector> EffectorInstance
		{
			get => GetProperty(ref _effectorInstance);
			set => SetProperty(ref _effectorInstance, value);
		}

		public EffectAndDamageEventData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
