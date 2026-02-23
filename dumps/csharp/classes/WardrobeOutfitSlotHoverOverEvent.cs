using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WardrobeOutfitSlotHoverOverEvent : redEvent
	{
		private CHandle<inkPointerEvent> _evt;
		private wCHandle<WardrobeOutfitSlotController> _controller;

		[Ordinal(0)] 
		[RED("evt")] 
		public CHandle<inkPointerEvent> Evt
		{
			get => GetProperty(ref _evt);
			set => SetProperty(ref _evt, value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public wCHandle<WardrobeOutfitSlotController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		public WardrobeOutfitSlotHoverOverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
