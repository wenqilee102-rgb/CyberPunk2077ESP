using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPrereqsDataDef : AIBlackboardDef
	{
		private gamebbScriptID_Variant _npcHitTypeTimeout;

		[Ordinal(0)] 
		[RED("npcHitTypeTimeout")] 
		public gamebbScriptID_Variant NpcHitTypeTimeout
		{
			get => GetProperty(ref _npcHitTypeTimeout);
			set => SetProperty(ref _npcHitTypeTimeout, value);
		}

		public AIPrereqsDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
