using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactTextGameController : gameuiWidgetGameController
	{
		private CArray<FactTextStruct> _factTextArray;

		[Ordinal(2)] 
		[RED("factTextArray")] 
		public CArray<FactTextStruct> FactTextArray
		{
			get => GetProperty(ref _factTextArray);
			set => SetProperty(ref _factTextArray, value);
		}

		public FactTextGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
