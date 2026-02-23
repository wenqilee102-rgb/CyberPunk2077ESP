using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDynamicVehicleDespawn_NodeType : questIDynamicSpawnSystemType
	{
		private CBool _immediateDespawn;
		private CName _waveTag;

		[Ordinal(0)] 
		[RED("ImmediateDespawn")] 
		public CBool ImmediateDespawn
		{
			get => GetProperty(ref _immediateDespawn);
			set => SetProperty(ref _immediateDespawn, value);
		}

		[Ordinal(1)] 
		[RED("waveTag")] 
		public CName WaveTag
		{
			get => GetProperty(ref _waveTag);
			set => SetProperty(ref _waveTag, value);
		}

		public questDynamicVehicleDespawn_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
