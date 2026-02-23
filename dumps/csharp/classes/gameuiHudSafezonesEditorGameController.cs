using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHudSafezonesEditorGameController : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _rootWidget;
		private inkCompoundWidgetReference _flexWidget;
		private wCHandle<inkGameNotificationData> _data;
		private CFloat _c_adjustment_speed;
		private CFloat _c_stick_dead_zone;

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public inkCompoundWidgetReference RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(4)] 
		[RED("flexWidget")] 
		public inkCompoundWidgetReference FlexWidget
		{
			get => GetProperty(ref _flexWidget);
			set => SetProperty(ref _flexWidget, value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public wCHandle<inkGameNotificationData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(6)] 
		[RED("c_adjustment_speed")] 
		public CFloat C_adjustment_speed
		{
			get => GetProperty(ref _c_adjustment_speed);
			set => SetProperty(ref _c_adjustment_speed, value);
		}

		[Ordinal(7)] 
		[RED("c_stick_dead_zone")] 
		public CFloat C_stick_dead_zone
		{
			get => GetProperty(ref _c_stick_dead_zone);
			set => SetProperty(ref _c_stick_dead_zone, value);
		}

		public gameuiHudSafezonesEditorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
