using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugCompactCell : CVariable
	{
		private CUInt64 _cellData;

		[Ordinal(0)] 
		[RED("cellData")] 
		public CUInt64 CellData
		{
			get => GetProperty(ref _cellData);
			set => SetProperty(ref _cellData, value);
		}

		public navgendebugCompactCell(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
