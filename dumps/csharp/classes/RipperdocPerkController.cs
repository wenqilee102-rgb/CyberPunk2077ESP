using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocPerkController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private CHandle<RipperdocPerkData> _perkData;
		private CHandle<RipperdocPerkHoverEvent> _hoverEvent;

		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("perkData")] 
		public CHandle<RipperdocPerkData> PerkData
		{
			get => GetProperty(ref _perkData);
			set => SetProperty(ref _perkData, value);
		}

		[Ordinal(3)] 
		[RED("hoverEvent")] 
		public CHandle<RipperdocPerkHoverEvent> HoverEvent
		{
			get => GetProperty(ref _hoverEvent);
			set => SetProperty(ref _hoverEvent, value);
		}

		public RipperdocPerkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
