using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AGenericTooltipControllerWithDebug : AGenericTooltipController
	{
		private CBool _dEBUG_showDebug;
		private CBool _dEBUG_openInVSCode;
		private CBool _dEBUG_openInVSCodeBlocked;

		[Ordinal(2)] 
		[RED("DEBUG_showDebug")] 
		public CBool DEBUG_showDebug
		{
			get => GetProperty(ref _dEBUG_showDebug);
			set => SetProperty(ref _dEBUG_showDebug, value);
		}

		[Ordinal(3)] 
		[RED("DEBUG_openInVSCode")] 
		public CBool DEBUG_openInVSCode
		{
			get => GetProperty(ref _dEBUG_openInVSCode);
			set => SetProperty(ref _dEBUG_openInVSCode, value);
		}

		[Ordinal(4)] 
		[RED("DEBUG_openInVSCodeBlocked")] 
		public CBool DEBUG_openInVSCodeBlocked
		{
			get => GetProperty(ref _dEBUG_openInVSCodeBlocked);
			set => SetProperty(ref _dEBUG_openInVSCodeBlocked, value);
		}

		public AGenericTooltipControllerWithDebug(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
