using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ColorTemplatePreviewDisplayController : BaseButtonView
	{
		private inkImageWidgetReference _primaryColorMask;
		private inkWidgetReference _primaryColorMaskGroup;
		private inkImageWidgetReference _secondaryColorMask;
		private inkWidgetReference _secondaryColorMaskGroup;
		private inkImageWidgetReference _lightColorMask;
		private inkWidgetReference _lightColorMaskGroup;
		private inkFlexWidgetReference _frame;
		private inkFlexWidgetReference _noTemplate;
		private inkFlexWidgetReference _checkbox;
		private inkImageWidgetReference _templateType;
		private inkRectangleWidgetReference _checkboxSquare;
		private inkImageWidgetReference _addIcon;
		private inkImageWidgetReference _lightsColorGrey;
		private inkImageWidgetReference _uniqueTemplateImage;
		private inkImageWidgetReference _frameSelected;
		private HDRColor _genericColor;
		private HDRColor _uniqueColor;
		private VehicleVisualCustomizationTemplate _currentTemplate;
		private CBool _canAdd;
		private CBool _lightsColorAvailable;

		[Ordinal(5)] 
		[RED("primaryColorMask")] 
		public inkImageWidgetReference PrimaryColorMask
		{
			get => GetProperty(ref _primaryColorMask);
			set => SetProperty(ref _primaryColorMask, value);
		}

		[Ordinal(6)] 
		[RED("primaryColorMaskGroup")] 
		public inkWidgetReference PrimaryColorMaskGroup
		{
			get => GetProperty(ref _primaryColorMaskGroup);
			set => SetProperty(ref _primaryColorMaskGroup, value);
		}

		[Ordinal(7)] 
		[RED("secondaryColorMask")] 
		public inkImageWidgetReference SecondaryColorMask
		{
			get => GetProperty(ref _secondaryColorMask);
			set => SetProperty(ref _secondaryColorMask, value);
		}

		[Ordinal(8)] 
		[RED("secondaryColorMaskGroup")] 
		public inkWidgetReference SecondaryColorMaskGroup
		{
			get => GetProperty(ref _secondaryColorMaskGroup);
			set => SetProperty(ref _secondaryColorMaskGroup, value);
		}

		[Ordinal(9)] 
		[RED("lightColorMask")] 
		public inkImageWidgetReference LightColorMask
		{
			get => GetProperty(ref _lightColorMask);
			set => SetProperty(ref _lightColorMask, value);
		}

		[Ordinal(10)] 
		[RED("lightColorMaskGroup")] 
		public inkWidgetReference LightColorMaskGroup
		{
			get => GetProperty(ref _lightColorMaskGroup);
			set => SetProperty(ref _lightColorMaskGroup, value);
		}

		[Ordinal(11)] 
		[RED("frame")] 
		public inkFlexWidgetReference Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(12)] 
		[RED("noTemplate")] 
		public inkFlexWidgetReference NoTemplate
		{
			get => GetProperty(ref _noTemplate);
			set => SetProperty(ref _noTemplate, value);
		}

		[Ordinal(13)] 
		[RED("checkbox")] 
		public inkFlexWidgetReference Checkbox
		{
			get => GetProperty(ref _checkbox);
			set => SetProperty(ref _checkbox, value);
		}

		[Ordinal(14)] 
		[RED("templateType")] 
		public inkImageWidgetReference TemplateType
		{
			get => GetProperty(ref _templateType);
			set => SetProperty(ref _templateType, value);
		}

		[Ordinal(15)] 
		[RED("checkboxSquare")] 
		public inkRectangleWidgetReference CheckboxSquare
		{
			get => GetProperty(ref _checkboxSquare);
			set => SetProperty(ref _checkboxSquare, value);
		}

		[Ordinal(16)] 
		[RED("addIcon")] 
		public inkImageWidgetReference AddIcon
		{
			get => GetProperty(ref _addIcon);
			set => SetProperty(ref _addIcon, value);
		}

		[Ordinal(17)] 
		[RED("lightsColorGrey")] 
		public inkImageWidgetReference LightsColorGrey
		{
			get => GetProperty(ref _lightsColorGrey);
			set => SetProperty(ref _lightsColorGrey, value);
		}

		[Ordinal(18)] 
		[RED("uniqueTemplateImage")] 
		public inkImageWidgetReference UniqueTemplateImage
		{
			get => GetProperty(ref _uniqueTemplateImage);
			set => SetProperty(ref _uniqueTemplateImage, value);
		}

		[Ordinal(19)] 
		[RED("frameSelected")] 
		public inkImageWidgetReference FrameSelected
		{
			get => GetProperty(ref _frameSelected);
			set => SetProperty(ref _frameSelected, value);
		}

		[Ordinal(20)] 
		[RED("genericColor")] 
		public HDRColor GenericColor
		{
			get => GetProperty(ref _genericColor);
			set => SetProperty(ref _genericColor, value);
		}

		[Ordinal(21)] 
		[RED("uniqueColor")] 
		public HDRColor UniqueColor
		{
			get => GetProperty(ref _uniqueColor);
			set => SetProperty(ref _uniqueColor, value);
		}

		[Ordinal(22)] 
		[RED("currentTemplate")] 
		public VehicleVisualCustomizationTemplate CurrentTemplate
		{
			get => GetProperty(ref _currentTemplate);
			set => SetProperty(ref _currentTemplate, value);
		}

		[Ordinal(23)] 
		[RED("canAdd")] 
		public CBool CanAdd
		{
			get => GetProperty(ref _canAdd);
			set => SetProperty(ref _canAdd, value);
		}

		[Ordinal(24)] 
		[RED("lightsColorAvailable")] 
		public CBool LightsColorAvailable
		{
			get => GetProperty(ref _lightsColorAvailable);
			set => SetProperty(ref _lightsColorAvailable, value);
		}

		public ColorTemplatePreviewDisplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
