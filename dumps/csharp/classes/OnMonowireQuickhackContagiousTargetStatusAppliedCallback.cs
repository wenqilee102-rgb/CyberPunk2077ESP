using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnMonowireQuickhackContagiousTargetStatusAppliedCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<ScriptedPuppet> _contagiousTarget;

		[Ordinal(0)] 
		[RED("ContagiousTarget")] 
		public wCHandle<ScriptedPuppet> ContagiousTarget
		{
			get => GetProperty(ref _contagiousTarget);
			set => SetProperty(ref _contagiousTarget, value);
		}

		public OnMonowireQuickhackContagiousTargetStatusAppliedCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
