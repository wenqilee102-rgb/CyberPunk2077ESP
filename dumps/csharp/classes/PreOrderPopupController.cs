using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreOrderPopupController : inkWidgetLogicController
	{
		private inkWidgetReference _preOrderButtonRef;
		private inkTextWidgetReference _preOrderButtonText;
		private inkWidgetReference _preOrderButtonInputIcon;
		private inkWidgetReference _releaseDateContainer;
		private wCHandle<inkButtonController> _buttonController;

		[Ordinal(1)] 
		[RED("preOrderButtonRef")] 
		public inkWidgetReference PreOrderButtonRef
		{
			get => GetProperty(ref _preOrderButtonRef);
			set => SetProperty(ref _preOrderButtonRef, value);
		}

		[Ordinal(2)] 
		[RED("preOrderButtonText")] 
		public inkTextWidgetReference PreOrderButtonText
		{
			get => GetProperty(ref _preOrderButtonText);
			set => SetProperty(ref _preOrderButtonText, value);
		}

		[Ordinal(3)] 
		[RED("preOrderButtonInputIcon")] 
		public inkWidgetReference PreOrderButtonInputIcon
		{
			get => GetProperty(ref _preOrderButtonInputIcon);
			set => SetProperty(ref _preOrderButtonInputIcon, value);
		}

		[Ordinal(4)] 
		[RED("releaseDateContainer")] 
		public inkWidgetReference ReleaseDateContainer
		{
			get => GetProperty(ref _releaseDateContainer);
			set => SetProperty(ref _releaseDateContainer, value);
		}

		[Ordinal(5)] 
		[RED("buttonController")] 
		public wCHandle<inkButtonController> ButtonController
		{
			get => GetProperty(ref _buttonController);
			set => SetProperty(ref _buttonController, value);
		}

		public PreOrderPopupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
