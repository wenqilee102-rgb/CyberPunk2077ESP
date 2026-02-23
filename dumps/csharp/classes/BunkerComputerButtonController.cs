using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BunkerComputerButtonController : LinkController
	{
		private CBool _usePopupDefault;

		[Ordinal(17)] 
		[RED("usePopupDefault")] 
		public CBool UsePopupDefault
		{
			get => GetProperty(ref _usePopupDefault);
			set => SetProperty(ref _usePopupDefault, value);
		}

		public BunkerComputerButtonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
