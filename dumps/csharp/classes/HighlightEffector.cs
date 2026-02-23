using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighlightEffector : gameContinuousEffector
	{
		private wCHandle<gameObject> _owner;
		private CFloat _maxDistance;
		private CFloat _effectDuraton;
		private CBool _highlightVisible;
		private CName _searchFilter;
		private CName _targetingSet;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(2)] 
		[RED("effectDuraton")] 
		public CFloat EffectDuraton
		{
			get => GetProperty(ref _effectDuraton);
			set => SetProperty(ref _effectDuraton, value);
		}

		[Ordinal(3)] 
		[RED("highlightVisible")] 
		public CBool HighlightVisible
		{
			get => GetProperty(ref _highlightVisible);
			set => SetProperty(ref _highlightVisible, value);
		}

		[Ordinal(4)] 
		[RED("searchFilter")] 
		public CName SearchFilter
		{
			get => GetProperty(ref _searchFilter);
			set => SetProperty(ref _searchFilter, value);
		}

		[Ordinal(5)] 
		[RED("targetingSet")] 
		public CName TargetingSet
		{
			get => GetProperty(ref _targetingSet);
			set => SetProperty(ref _targetingSet, value);
		}

		public HighlightEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
