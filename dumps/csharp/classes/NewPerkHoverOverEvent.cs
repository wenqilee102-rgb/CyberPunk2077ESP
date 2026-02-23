using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkHoverOverEvent : redEvent
	{
		private wCHandle<NewPerksPerkItemLogicController> _controller;
		private CHandle<inkPointerEvent> _evt;
		private CHandle<NewPerkDisplayData> _perkData;

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

		[Ordinal(2)] 
		[RED("perkData")] 
		public CHandle<NewPerkDisplayData> PerkData
		{
			get => GetProperty(ref _perkData);
			set => SetProperty(ref _perkData, value);
		}

		public NewPerkHoverOverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
