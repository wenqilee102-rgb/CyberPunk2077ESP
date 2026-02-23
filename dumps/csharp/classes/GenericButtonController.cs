using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericButtonController : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkWidgetReference _frameHovered;
		private CBool _itemHovered;
		private CBool _enabled;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get => GetProperty(ref _frameHovered);
			set => SetProperty(ref _frameHovered, value);
		}

		[Ordinal(3)] 
		[RED("itemHovered")] 
		public CBool ItemHovered
		{
			get => GetProperty(ref _itemHovered);
			set => SetProperty(ref _itemHovered, value);
		}

		[Ordinal(4)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		public GenericButtonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
