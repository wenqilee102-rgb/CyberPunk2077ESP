using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GalleryFilterController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _text;
		private inkWidgetReference _filterRootWidget;
		private CEnum<inkGameScreenshotSortMode> _filterType;
		private CName _labelKey;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CBool _active;
		private CBool _hovered;

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
		[RED("filterRootWidget")] 
		public inkWidgetReference FilterRootWidget
		{
			get => GetProperty(ref _filterRootWidget);
			set => SetProperty(ref _filterRootWidget, value);
		}

		[Ordinal(4)] 
		[RED("filterType")] 
		public CEnum<inkGameScreenshotSortMode> FilterType
		{
			get => GetProperty(ref _filterType);
			set => SetProperty(ref _filterType, value);
		}

		[Ordinal(5)] 
		[RED("labelKey")] 
		public CName LabelKey
		{
			get => GetProperty(ref _labelKey);
			set => SetProperty(ref _labelKey, value);
		}

		[Ordinal(6)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(7)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(8)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		public GalleryFilterController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
