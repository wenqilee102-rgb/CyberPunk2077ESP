using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksAttributeButtonController : inkWidgetLogicController
	{
		private inkWidgetReference _attributePointsButton;
		private inkTextWidgetReference _attributeText;
		private inkTextWidgetReference _currentText;
		private inkTextWidgetReference _textGhost;
		private inkTextWidgetReference _requirementText;
		private inkWidgetReference _buttonWidget;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CInt32 _totalPoints;
		private CHandle<NewPerksScreenInitData> _initData;
		private CBool _isHovered;
		private CBool _isPressed;
		private CHandle<inkanimProxy> _idleAnimProxy;

		[Ordinal(1)] 
		[RED("attributePointsButton")] 
		public inkWidgetReference AttributePointsButton
		{
			get => GetProperty(ref _attributePointsButton);
			set => SetProperty(ref _attributePointsButton, value);
		}

		[Ordinal(2)] 
		[RED("attributeText")] 
		public inkTextWidgetReference AttributeText
		{
			get => GetProperty(ref _attributeText);
			set => SetProperty(ref _attributeText, value);
		}

		[Ordinal(3)] 
		[RED("currentText")] 
		public inkTextWidgetReference CurrentText
		{
			get => GetProperty(ref _currentText);
			set => SetProperty(ref _currentText, value);
		}

		[Ordinal(4)] 
		[RED("textGhost")] 
		public inkTextWidgetReference TextGhost
		{
			get => GetProperty(ref _textGhost);
			set => SetProperty(ref _textGhost, value);
		}

		[Ordinal(5)] 
		[RED("requirementText")] 
		public inkTextWidgetReference RequirementText
		{
			get => GetProperty(ref _requirementText);
			set => SetProperty(ref _requirementText, value);
		}

		[Ordinal(6)] 
		[RED("buttonWidget")] 
		public inkWidgetReference ButtonWidget
		{
			get => GetProperty(ref _buttonWidget);
			set => SetProperty(ref _buttonWidget, value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(8)] 
		[RED("totalPoints")] 
		public CInt32 TotalPoints
		{
			get => GetProperty(ref _totalPoints);
			set => SetProperty(ref _totalPoints, value);
		}

		[Ordinal(9)] 
		[RED("initData")] 
		public CHandle<NewPerksScreenInitData> InitData
		{
			get => GetProperty(ref _initData);
			set => SetProperty(ref _initData, value);
		}

		[Ordinal(10)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetProperty(ref _isHovered);
			set => SetProperty(ref _isHovered, value);
		}

		[Ordinal(11)] 
		[RED("isPressed")] 
		public CBool IsPressed
		{
			get => GetProperty(ref _isPressed);
			set => SetProperty(ref _isPressed, value);
		}

		[Ordinal(12)] 
		[RED("idleAnimProxy")] 
		public CHandle<inkanimProxy> IdleAnimProxy
		{
			get => GetProperty(ref _idleAnimProxy);
			set => SetProperty(ref _idleAnimProxy, value);
		}

		public NewPerksAttributeButtonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
