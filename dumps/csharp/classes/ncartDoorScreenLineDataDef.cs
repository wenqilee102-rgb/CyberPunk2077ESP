using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ncartDoorScreenLineDataDef : CVariable
	{
		private CUInt32 _lineNumber;
		private CColor _lineColor;
		private inkWidgetReference _lineSymbolWidget;

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
		[RED("lineSymbolWidget")] 
		public inkWidgetReference LineSymbolWidget
		{
			get => GetProperty(ref _lineSymbolWidget);
			set => SetProperty(ref _lineSymbolWidget, value);
		}

		public ncartDoorScreenLineDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
