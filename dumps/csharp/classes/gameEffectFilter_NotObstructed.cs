using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectFilter_NotObstructed : gameEffectObjectSingleFilter
	{
		private CFloat _forwardOffset;
		private CHandle<physicsFilterData> _filterData;
		private physicsQueryPreset _queryPreset;
		private CBool _playerUseCameraPositionForCheck;

		[Ordinal(0)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get => GetProperty(ref _forwardOffset);
			set => SetProperty(ref _forwardOffset, value);
		}

		[Ordinal(1)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(2)] 
		[RED("queryPreset")] 
		public physicsQueryPreset QueryPreset
		{
			get => GetProperty(ref _queryPreset);
			set => SetProperty(ref _queryPreset, value);
		}

		[Ordinal(3)] 
		[RED("playerUseCameraPositionForCheck")] 
		public CBool PlayerUseCameraPositionForCheck
		{
			get => GetProperty(ref _playerUseCameraPositionForCheck);
			set => SetProperty(ref _playerUseCameraPositionForCheck, value);
		}

		public gameEffectFilter_NotObstructed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
