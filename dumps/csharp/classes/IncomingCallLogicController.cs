using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncomingCallLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _contactNameWidget;
		private inkWidgetReference _buttonHint;
		private inkImageWidgetReference _avatar;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("contactNameWidget")] 
		public inkTextWidgetReference ContactNameWidget
		{
			get => GetProperty(ref _contactNameWidget);
			set => SetProperty(ref _contactNameWidget, value);
		}

		[Ordinal(2)] 
		[RED("buttonHint")] 
		public inkWidgetReference ButtonHint
		{
			get => GetProperty(ref _buttonHint);
			set => SetProperty(ref _buttonHint, value);
		}

		[Ordinal(3)] 
		[RED("avatar")] 
		public inkImageWidgetReference Avatar
		{
			get => GetProperty(ref _avatar);
			set => SetProperty(ref _avatar, value);
		}

		[Ordinal(4)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public IncomingCallLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
