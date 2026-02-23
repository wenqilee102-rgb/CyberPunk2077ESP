using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugCompactSpan : CVariable
	{
		private CUInt32 _spanData;

		[Ordinal(0)] 
		[RED("spanData")] 
		public CUInt32 SpanData
		{
			get => GetProperty(ref _spanData);
			set => SetProperty(ref _spanData, value);
		}

		public navgendebugCompactSpan(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
