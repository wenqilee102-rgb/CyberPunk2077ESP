using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BloodswellEffectorColdBloodListener : gameScriptStatsListener
	{
		private CHandle<BloodswellEffector> _effector;
		private ScriptGameInstance _gameInstance;

		[Ordinal(0)] 
		[RED("effector")] 
		public CHandle<BloodswellEffector> Effector
		{
			get => GetProperty(ref _effector);
			set => SetProperty(ref _effector, value);
		}

		[Ordinal(1)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		public BloodswellEffectorColdBloodListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
