using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_NotObstructed : gameEffectObjectGroupFilter
	{
		private CHandle<physicsFilterData> _filterData;
		private physicsQueryPreset _queryPreset;

		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(1)] 
		[RED("queryPreset")] 
		public physicsQueryPreset QueryPreset
		{
			get => GetProperty(ref _queryPreset);
			set => SetProperty(ref _queryPreset, value);
		}

		public gameEffectObjectFilter_NotObstructed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
