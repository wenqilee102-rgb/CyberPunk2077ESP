using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_TargetingObjectsInCone : gameEffectObjectProvider
	{
		private CHandle<physicsFilterData> _filterData;
		private physicsQueryPreset _queryPreset;
		private gameTargetSearchQuery _searchQuery;
		private CUInt32 _maxTargets;
		private CBool _usePlayerPosAndForward;

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

		[Ordinal(2)] 
		[RED("searchQuery")] 
		public gameTargetSearchQuery SearchQuery
		{
			get => GetProperty(ref _searchQuery);
			set => SetProperty(ref _searchQuery, value);
		}

		[Ordinal(3)] 
		[RED("maxTargets")] 
		public CUInt32 MaxTargets
		{
			get => GetProperty(ref _maxTargets);
			set => SetProperty(ref _maxTargets, value);
		}

		[Ordinal(4)] 
		[RED("usePlayerPosAndForward")] 
		public CBool UsePlayerPosAndForward
		{
			get => GetProperty(ref _usePlayerPosAndForward);
			set => SetProperty(ref _usePlayerPosAndForward, value);
		}

		public gameEffectObjectProvider_TargetingObjectsInCone(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
