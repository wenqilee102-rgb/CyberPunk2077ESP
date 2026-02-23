using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkHoverEventTooltipData : CVariable
	{
		private wCHandle<inkWidget> _widget;
		private CHandle<IDisplayData> _data;
		private CEnum<gameuiETooltipPlacement> _placement;
		private CBool _isShown;

		[Ordinal(0)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<IDisplayData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("placement")] 
		public CEnum<gameuiETooltipPlacement> Placement
		{
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}

		[Ordinal(3)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetProperty(ref _isShown);
			set => SetProperty(ref _isShown, value);
		}

		public PerkHoverEventTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
