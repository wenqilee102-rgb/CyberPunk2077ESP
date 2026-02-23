using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class metroMapPlayerPositionReferences : CVariable
	{
		private CUInt32 _lineNumber;
		private inkWidgetReference _positionRefWidget;

		[Ordinal(0)] 
		[RED("lineNumber")] 
		public CUInt32 LineNumber
		{
			get => GetProperty(ref _lineNumber);
			set => SetProperty(ref _lineNumber, value);
		}

		[Ordinal(1)] 
		[RED("positionRefWidget")] 
		public inkWidgetReference PositionRefWidget
		{
			get => GetProperty(ref _positionRefWidget);
			set => SetProperty(ref _positionRefWidget, value);
		}

		public metroMapPlayerPositionReferences(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
