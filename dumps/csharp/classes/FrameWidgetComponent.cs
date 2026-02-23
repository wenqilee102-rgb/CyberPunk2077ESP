using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FrameWidgetComponent : WorldWidgetComponent
	{
		private Vector2 _dimensions;

		[Ordinal(20)] 
		[RED("dimensions")] 
		public Vector2 Dimensions
		{
			get => GetProperty(ref _dimensions);
			set => SetProperty(ref _dimensions, value);
		}

		public FrameWidgetComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
