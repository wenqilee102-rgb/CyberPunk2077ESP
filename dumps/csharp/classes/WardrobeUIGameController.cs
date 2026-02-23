using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WardrobeUIGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _setEditorWidget;
		private inkCompoundWidgetReference _setGridWidget;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private wCHandle<WardrobeSetEditorUIController> _setEditorController;
		private CBool _isMainScreen;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CArray<CHandle<gameClothingSet>> _sets;
		private wCHandle<ClothingSetController> _currentSetController;
		private CInt32 _maxSetsAmount;
		private CArray<wCHandle<ClothingSetController>> _setControllers;
		private CHandle<inkGameNotificationToken> _confirmationRequestToken;
		private wCHandle<ClothingSetController> _deletedSetController;
		private CHandle<inkanimProxy> _introAnimProxy;
		private CHandle<inkanimProxy> _outroAnimProxy;
		private CBool _introFinished;
		private CEnum<gameWardrobeClothingSetIndex> _finalEquippedSet;
		private wCHandle<gameIBlackboard> _equipmentBlackboard;
		private CHandle<redCallbackObject> _equipmentInProgressCallback;

		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("setEditorWidget")] 
		public inkWidgetReference SetEditorWidget
		{
			get => GetProperty(ref _setEditorWidget);
			set => SetProperty(ref _setEditorWidget, value);
		}

		[Ordinal(6)] 
		[RED("setGridWidget")] 
		public inkCompoundWidgetReference SetGridWidget
		{
			get => GetProperty(ref _setGridWidget);
			set => SetProperty(ref _setGridWidget, value);
		}

		[Ordinal(7)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(8)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(9)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(10)] 
		[RED("setEditorController")] 
		public wCHandle<WardrobeSetEditorUIController> SetEditorController
		{
			get => GetProperty(ref _setEditorController);
			set => SetProperty(ref _setEditorController, value);
		}

		[Ordinal(11)] 
		[RED("isMainScreen")] 
		public CBool IsMainScreen
		{
			get => GetProperty(ref _isMainScreen);
			set => SetProperty(ref _isMainScreen, value);
		}

		[Ordinal(12)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(14)] 
		[RED("sets")] 
		public CArray<CHandle<gameClothingSet>> Sets
		{
			get => GetProperty(ref _sets);
			set => SetProperty(ref _sets, value);
		}

		[Ordinal(15)] 
		[RED("currentSetController")] 
		public wCHandle<ClothingSetController> CurrentSetController
		{
			get => GetProperty(ref _currentSetController);
			set => SetProperty(ref _currentSetController, value);
		}

		[Ordinal(16)] 
		[RED("maxSetsAmount")] 
		public CInt32 MaxSetsAmount
		{
			get => GetProperty(ref _maxSetsAmount);
			set => SetProperty(ref _maxSetsAmount, value);
		}

		[Ordinal(17)] 
		[RED("setControllers")] 
		public CArray<wCHandle<ClothingSetController>> SetControllers
		{
			get => GetProperty(ref _setControllers);
			set => SetProperty(ref _setControllers, value);
		}

		[Ordinal(18)] 
		[RED("confirmationRequestToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationRequestToken
		{
			get => GetProperty(ref _confirmationRequestToken);
			set => SetProperty(ref _confirmationRequestToken, value);
		}

		[Ordinal(19)] 
		[RED("deletedSetController")] 
		public wCHandle<ClothingSetController> DeletedSetController
		{
			get => GetProperty(ref _deletedSetController);
			set => SetProperty(ref _deletedSetController, value);
		}

		[Ordinal(20)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(21)] 
		[RED("outroAnimProxy")] 
		public CHandle<inkanimProxy> OutroAnimProxy
		{
			get => GetProperty(ref _outroAnimProxy);
			set => SetProperty(ref _outroAnimProxy, value);
		}

		[Ordinal(22)] 
		[RED("introFinished")] 
		public CBool IntroFinished
		{
			get => GetProperty(ref _introFinished);
			set => SetProperty(ref _introFinished, value);
		}

		[Ordinal(23)] 
		[RED("finalEquippedSet")] 
		public CEnum<gameWardrobeClothingSetIndex> FinalEquippedSet
		{
			get => GetProperty(ref _finalEquippedSet);
			set => SetProperty(ref _finalEquippedSet, value);
		}

		[Ordinal(24)] 
		[RED("equipmentBlackboard")] 
		public wCHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetProperty(ref _equipmentBlackboard);
			set => SetProperty(ref _equipmentBlackboard, value);
		}

		[Ordinal(25)] 
		[RED("equipmentInProgressCallback")] 
		public CHandle<redCallbackObject> EquipmentInProgressCallback
		{
			get => GetProperty(ref _equipmentInProgressCallback);
			set => SetProperty(ref _equipmentInProgressCallback, value);
		}

		public WardrobeUIGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
