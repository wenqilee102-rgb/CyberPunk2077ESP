using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionBossDataDef : AIBlackboardDef
	{
		private gamebbScriptID_Variant _excludedWaypointPosition;
		private gamebbScriptID_Vector4 _excludedTeleportPosition;

		[Ordinal(0)] 
		[RED("excludedWaypointPosition")] 
		public gamebbScriptID_Variant ExcludedWaypointPosition
		{
			get => GetProperty(ref _excludedWaypointPosition);
			set => SetProperty(ref _excludedWaypointPosition, value);
		}

		[Ordinal(1)] 
		[RED("excludedTeleportPosition")] 
		public gamebbScriptID_Vector4 ExcludedTeleportPosition
		{
			get => GetProperty(ref _excludedTeleportPosition);
			set => SetProperty(ref _excludedTeleportPosition, value);
		}

		public AIActionBossDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
