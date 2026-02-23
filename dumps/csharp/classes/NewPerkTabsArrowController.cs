using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkTabsArrowController : inkWidgetLogicController
	{
		private CEnum<NewPerkTabsArrowDirection> _direction;
		private CBool _hovered;
		private CBool _pressed;

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<NewPerkTabsArrowDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(2)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		[Ordinal(3)] 
		[RED("pressed")] 
		public CBool Pressed
		{
			get => GetProperty(ref _pressed);
			set => SetProperty(ref _pressed, value);
		}

		public NewPerkTabsArrowController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
