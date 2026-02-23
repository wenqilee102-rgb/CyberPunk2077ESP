using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class YaibaButton : inkButtonController
	{
		private inkImageWidgetReference _normalBackground;
		private inkImageWidgetReference _pressBackground;
		private inkImageWidgetReference _hoverBackground;
		private inkImageWidgetReference _disabledBackground;
		private inkTextWidgetReference _enabledText;
		private inkTextWidgetReference _disabledText;

		[Ordinal(13)] 
		[RED("normalBackground")] 
		public inkImageWidgetReference NormalBackground
		{
			get => GetProperty(ref _normalBackground);
			set => SetProperty(ref _normalBackground, value);
		}

		[Ordinal(14)] 
		[RED("pressBackground")] 
		public inkImageWidgetReference PressBackground
		{
			get => GetProperty(ref _pressBackground);
			set => SetProperty(ref _pressBackground, value);
		}

		[Ordinal(15)] 
		[RED("hoverBackground")] 
		public inkImageWidgetReference HoverBackground
		{
			get => GetProperty(ref _hoverBackground);
			set => SetProperty(ref _hoverBackground, value);
		}

		[Ordinal(16)] 
		[RED("disabledBackground")] 
		public inkImageWidgetReference DisabledBackground
		{
			get => GetProperty(ref _disabledBackground);
			set => SetProperty(ref _disabledBackground, value);
		}

		[Ordinal(17)] 
		[RED("enabledText")] 
		public inkTextWidgetReference EnabledText
		{
			get => GetProperty(ref _enabledText);
			set => SetProperty(ref _enabledText, value);
		}

		[Ordinal(18)] 
		[RED("disabledText")] 
		public inkTextWidgetReference DisabledText
		{
			get => GetProperty(ref _disabledText);
			set => SetProperty(ref _disabledText, value);
		}

		public YaibaButton(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
