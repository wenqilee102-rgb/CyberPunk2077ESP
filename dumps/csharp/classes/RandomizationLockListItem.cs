using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RandomizationLockListItem : inkWidgetLogicController
	{
		private inkWidgetReference _checker;
		private inkWidgetReference _lockIcon;
		private inkWidgetReference _hitArea;
		private inkTextWidgetReference _lockName;
		private wCHandle<inkDiscreteNavigationController> _navigationController;
		private wCHandle<gamedataCharacterRandomizationCategory_Record> _lockCategory;
		private CBool _isHovered;
		private CBool _isInteractable;
		private wCHandle<inkWidget> _rootWidget;

		[Ordinal(1)] 
		[RED("checker")] 
		public inkWidgetReference Checker
		{
			get => GetProperty(ref _checker);
			set => SetProperty(ref _checker, value);
		}

		[Ordinal(2)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get => GetProperty(ref _lockIcon);
			set => SetProperty(ref _lockIcon, value);
		}

		[Ordinal(3)] 
		[RED("hitArea")] 
		public inkWidgetReference HitArea
		{
			get => GetProperty(ref _hitArea);
			set => SetProperty(ref _hitArea, value);
		}

		[Ordinal(4)] 
		[RED("lockName")] 
		public inkTextWidgetReference LockName
		{
			get => GetProperty(ref _lockName);
			set => SetProperty(ref _lockName, value);
		}

		[Ordinal(5)] 
		[RED("navigationController")] 
		public wCHandle<inkDiscreteNavigationController> NavigationController
		{
			get => GetProperty(ref _navigationController);
			set => SetProperty(ref _navigationController, value);
		}

		[Ordinal(6)] 
		[RED("lockCategory")] 
		public wCHandle<gamedataCharacterRandomizationCategory_Record> LockCategory
		{
			get => GetProperty(ref _lockCategory);
			set => SetProperty(ref _lockCategory, value);
		}

		[Ordinal(7)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetProperty(ref _isHovered);
			set => SetProperty(ref _isHovered, value);
		}

		[Ordinal(8)] 
		[RED("isInteractable")] 
		public CBool IsInteractable
		{
			get => GetProperty(ref _isInteractable);
			set => SetProperty(ref _isInteractable, value);
		}

		[Ordinal(9)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		public RandomizationLockListItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
