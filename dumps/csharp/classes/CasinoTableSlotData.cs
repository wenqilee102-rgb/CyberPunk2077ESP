using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CasinoTableSlotData : CVariable
	{
		private inkWidgetReference _widget;
		private wCHandle<CasinoTableSlotLogicController> _controller;
		private wCHandle<gameInventoryScriptListener> _casinoChipsListener;
		private wCHandle<gameObject> _slotUser;

		[Ordinal(0)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public wCHandle<CasinoTableSlotLogicController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(2)] 
		[RED("casinoChipsListener")] 
		public wCHandle<gameInventoryScriptListener> CasinoChipsListener
		{
			get => GetProperty(ref _casinoChipsListener);
			set => SetProperty(ref _casinoChipsListener, value);
		}

		[Ordinal(3)] 
		[RED("slotUser")] 
		public wCHandle<gameObject> SlotUser
		{
			get => GetProperty(ref _slotUser);
			set => SetProperty(ref _slotUser, value);
		}

		public CasinoTableSlotData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
