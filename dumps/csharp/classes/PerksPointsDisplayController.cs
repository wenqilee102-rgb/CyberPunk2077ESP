using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksPointsDisplayController : inkWidgetLogicController
	{
		private inkTextWidgetReference _desc1Text;
		private inkTextWidgetReference _value1Text;
		private inkImageWidgetReference _icon1;
		private inkTextWidgetReference _desc2Text;
		private inkTextWidgetReference _value2Text;
		private inkImageWidgetReference _icon2;
		private inkTextWidgetReference _desc3Text;
		private inkTextWidgetReference _value3Text;
		private inkImageWidgetReference _icon3;
		private CEnum<CharacterScreenType> _screenType;

		[Ordinal(1)] 
		[RED("desc1Text")] 
		public inkTextWidgetReference Desc1Text
		{
			get => GetProperty(ref _desc1Text);
			set => SetProperty(ref _desc1Text, value);
		}

		[Ordinal(2)] 
		[RED("value1Text")] 
		public inkTextWidgetReference Value1Text
		{
			get => GetProperty(ref _value1Text);
			set => SetProperty(ref _value1Text, value);
		}

		[Ordinal(3)] 
		[RED("icon1")] 
		public inkImageWidgetReference Icon1
		{
			get => GetProperty(ref _icon1);
			set => SetProperty(ref _icon1, value);
		}

		[Ordinal(4)] 
		[RED("desc2Text")] 
		public inkTextWidgetReference Desc2Text
		{
			get => GetProperty(ref _desc2Text);
			set => SetProperty(ref _desc2Text, value);
		}

		[Ordinal(5)] 
		[RED("value2Text")] 
		public inkTextWidgetReference Value2Text
		{
			get => GetProperty(ref _value2Text);
			set => SetProperty(ref _value2Text, value);
		}

		[Ordinal(6)] 
		[RED("icon2")] 
		public inkImageWidgetReference Icon2
		{
			get => GetProperty(ref _icon2);
			set => SetProperty(ref _icon2, value);
		}

		[Ordinal(7)] 
		[RED("desc3Text")] 
		public inkTextWidgetReference Desc3Text
		{
			get => GetProperty(ref _desc3Text);
			set => SetProperty(ref _desc3Text, value);
		}

		[Ordinal(8)] 
		[RED("value3Text")] 
		public inkTextWidgetReference Value3Text
		{
			get => GetProperty(ref _value3Text);
			set => SetProperty(ref _value3Text, value);
		}

		[Ordinal(9)] 
		[RED("icon3")] 
		public inkImageWidgetReference Icon3
		{
			get => GetProperty(ref _icon3);
			set => SetProperty(ref _icon3, value);
		}

		[Ordinal(10)] 
		[RED("screenType")] 
		public CEnum<CharacterScreenType> ScreenType
		{
			get => GetProperty(ref _screenType);
			set => SetProperty(ref _screenType, value);
		}

		public PerksPointsDisplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
