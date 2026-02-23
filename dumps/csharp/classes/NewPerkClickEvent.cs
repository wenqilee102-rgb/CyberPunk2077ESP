using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkClickEvent : redEvent
	{
		private wCHandle<NewPerksPerkItemLogicController> _controller;
		private CName _action;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<NewPerksPerkItemLogicController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CName Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		public NewPerkClickEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
