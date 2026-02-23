using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugSpansData : CVariable
	{
		private CArray<navgendebugCompactSpan> _spans;
		private CArray<CUInt8> _areas;
		private CArray<CUInt8> _filteredAreas;

		[Ordinal(0)] 
		[RED("spans")] 
		public CArray<navgendebugCompactSpan> Spans
		{
			get => GetProperty(ref _spans);
			set => SetProperty(ref _spans, value);
		}

		[Ordinal(1)] 
		[RED("areas")] 
		public CArray<CUInt8> Areas
		{
			get => GetProperty(ref _areas);
			set => SetProperty(ref _areas, value);
		}

		[Ordinal(2)] 
		[RED("filteredAreas")] 
		public CArray<CUInt8> FilteredAreas
		{
			get => GetProperty(ref _filteredAreas);
			set => SetProperty(ref _filteredAreas, value);
		}

		public navgendebugSpansData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
