using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDynamicVehicleDespawnAll_NodeType : questIDynamicSpawnSystemType
	{
		private CBool _immediateDespawn;

		[Ordinal(0)] 
		[RED("ImmediateDespawn")] 
		public CBool ImmediateDespawn
		{
			get => GetProperty(ref _immediateDespawn);
			set => SetProperty(ref _immediateDespawn, value);
		}

		public questDynamicVehicleDespawnAll_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
