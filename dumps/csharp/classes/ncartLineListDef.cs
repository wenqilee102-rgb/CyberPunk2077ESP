using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ncartLineListDef : CVariable
	{
		private CUInt32 _lineNumber;
		private CColor _lineColor;
		private CArray<ncartStationListDef> _stationsList;
		private inkWidgetReference _lineSymbolWidget;
		private CBool _lineIsLooped;

		[Ordinal(0)] 
		[RED("lineNumber")] 
		public CUInt32 LineNumber
		{
			get => GetProperty(ref _lineNumber);
			set => SetProperty(ref _lineNumber, value);
		}

		[Ordinal(1)] 
		[RED("lineColor")] 
		public CColor LineColor
		{
			get => GetProperty(ref _lineColor);
			set => SetProperty(ref _lineColor, value);
		}

		[Ordinal(2)] 
		[RED("stationsList")] 
		public CArray<ncartStationListDef> StationsList
		{
			get => GetProperty(ref _stationsList);
			set => SetProperty(ref _stationsList, value);
		}

		[Ordinal(3)] 
		[RED("lineSymbolWidget")] 
		public inkWidgetReference LineSymbolWidget
		{
			get => GetProperty(ref _lineSymbolWidget);
			set => SetProperty(ref _lineSymbolWidget, value);
		}

		[Ordinal(4)] 
		[RED("lineIsLooped")] 
		public CBool LineIsLooped
		{
			get => GetProperty(ref _lineIsLooped);
			set => SetProperty(ref _lineIsLooped, value);
		}

		public ncartLineListDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
