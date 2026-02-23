using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputContextTransitionEvents : InputContextTransition
	{
		private wCHandle<GameplaySettingsSystem> _gameplaySettings;
		private CHandle<redCallbackObject> _onInputSchemeUpdatedCallback;
		private CHandle<redCallbackObject> _onInputHintManagerInitializedChangedCallback;
		private CBool _onInputSchemeChanged;
		private CBool _hasControllerChanged;
		private CBool _hasControllerSchemeChanged;
		private CBool _isGameplayInputHintManagerInitialized;
		private CBool _isGameplayInputHintRefreshRequired;

		[Ordinal(0)] 
		[RED("gameplaySettings")] 
		public wCHandle<GameplaySettingsSystem> GameplaySettings
		{
			get => GetProperty(ref _gameplaySettings);
			set => SetProperty(ref _gameplaySettings, value);
		}

		[Ordinal(1)] 
		[RED("onInputSchemeUpdatedCallback")] 
		public CHandle<redCallbackObject> OnInputSchemeUpdatedCallback
		{
			get => GetProperty(ref _onInputSchemeUpdatedCallback);
			set => SetProperty(ref _onInputSchemeUpdatedCallback, value);
		}

		[Ordinal(2)] 
		[RED("OnInputHintManagerInitializedChangedCallback")] 
		public CHandle<redCallbackObject> OnInputHintManagerInitializedChangedCallback
		{
			get => GetProperty(ref _onInputHintManagerInitializedChangedCallback);
			set => SetProperty(ref _onInputHintManagerInitializedChangedCallback, value);
		}

		[Ordinal(3)] 
		[RED("onInputSchemeChanged")] 
		public CBool OnInputSchemeChanged
		{
			get => GetProperty(ref _onInputSchemeChanged);
			set => SetProperty(ref _onInputSchemeChanged, value);
		}

		[Ordinal(4)] 
		[RED("hasControllerChanged")] 
		public CBool HasControllerChanged
		{
			get => GetProperty(ref _hasControllerChanged);
			set => SetProperty(ref _hasControllerChanged, value);
		}

		[Ordinal(5)] 
		[RED("hasControllerSchemeChanged")] 
		public CBool HasControllerSchemeChanged
		{
			get => GetProperty(ref _hasControllerSchemeChanged);
			set => SetProperty(ref _hasControllerSchemeChanged, value);
		}

		[Ordinal(6)] 
		[RED("isGameplayInputHintManagerInitialized")] 
		public CBool IsGameplayInputHintManagerInitialized
		{
			get => GetProperty(ref _isGameplayInputHintManagerInitialized);
			set => SetProperty(ref _isGameplayInputHintManagerInitialized, value);
		}

		[Ordinal(7)] 
		[RED("isGameplayInputHintRefreshRequired")] 
		public CBool IsGameplayInputHintRefreshRequired
		{
			get => GetProperty(ref _isGameplayInputHintRefreshRequired);
			set => SetProperty(ref _isGameplayInputHintRefreshRequired, value);
		}

		public InputContextTransitionEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
