using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimsetVariableCondition : animIRuntimeCondition
	{
		private CName _variableToCompare;

		[Ordinal(0)] 
		[RED("variableToCompare")] 
		public CName VariableToCompare
		{
			get => GetProperty(ref _variableToCompare);
			set => SetProperty(ref _variableToCompare, value);
		}

		public animAnimsetVariableCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
