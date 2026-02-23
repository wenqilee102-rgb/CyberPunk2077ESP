using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePreventionSpawnSystemSavedState : ISerializable
	{
		private CArray<CUInt64> _areaIds;

		[Ordinal(0)] 
		[RED("areaIds")] 
		public CArray<CUInt64> AreaIds
		{
			get => GetProperty(ref _areaIds);
			set => SetProperty(ref _areaIds, value);
		}

		public gamePreventionSpawnSystemSavedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
