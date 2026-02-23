using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocShardController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _text;
		private CHandle<RipperdocShardData> _data;
		private CHandle<PulseAnimation> _pulse;
		private wCHandle<inkWidget> _rootWidget;

		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public CHandle<RipperdocShardData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(4)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}

		[Ordinal(5)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		public RipperdocShardController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
