using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExpansionStatePopupGameController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _statusRef;
		private CName _animationName;

		[Ordinal(2)] 
		[RED("statusRef")] 
		public inkTextWidgetReference StatusRef
		{
			get => GetProperty(ref _statusRef);
			set => SetProperty(ref _statusRef, value);
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		public ExpansionStatePopupGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
