using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkHoverOutEvent : redEvent
	{
		private wCHandle<NewPerksPerkItemLogicController> _controller;
		private CHandle<inkPointerEvent> _evt;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<NewPerksPerkItemLogicController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(1)] 
		[RED("evt")] 
		public CHandle<inkPointerEvent> Evt
		{
			get => GetProperty(ref _evt);
			set => SetProperty(ref _evt, value);
		}

		public NewPerkHoverOutEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
