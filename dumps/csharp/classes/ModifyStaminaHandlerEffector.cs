using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStaminaHandlerEffector : gameEffector
	{
		private CName _opSymbol;

		[Ordinal(0)] 
		[RED("opSymbol")] 
		public CName OpSymbol
		{
			get => GetProperty(ref _opSymbol);
			set => SetProperty(ref _opSymbol, value);
		}

		public ModifyStaminaHandlerEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
