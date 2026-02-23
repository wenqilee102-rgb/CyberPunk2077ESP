using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetPoliceSearchArea : gameScriptableSystemRequest
	{
		private CFloat _searchAreaRadius;
		private CFloat _chaseDistance;
		private CBool _resetToDefault;
		private CName _source;

		[Ordinal(0)] 
		[RED("SearchAreaRadius")] 
		public CFloat SearchAreaRadius
		{
			get => GetProperty(ref _searchAreaRadius);
			set => SetProperty(ref _searchAreaRadius, value);
		}

		[Ordinal(1)] 
		[RED("ChaseDistance")] 
		public CFloat ChaseDistance
		{
			get => GetProperty(ref _chaseDistance);
			set => SetProperty(ref _chaseDistance, value);
		}

		[Ordinal(2)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get => GetProperty(ref _resetToDefault);
			set => SetProperty(ref _resetToDefault, value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public SetPoliceSearchArea(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
