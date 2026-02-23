using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocTokenPopup : gameuiWidgetGameController
	{
		private CArrayFixedSize<inkWidgetReference> _optionRef;
		private CArrayFixedSize<inkWidgetReference> _optionTooltipParent;
		private inkWidgetReference _option1ProgressBarRef;
		private inkWidgetReference _option2ProgressBarRef;
		private inkWidgetReference _option3ProgressBarRef;
		private inkWidgetReference _option1HoverZone;
		private inkWidgetReference _option2HoverZone;
		private inkWidgetReference _option3HoverZone;
		private CName _progressEffectName;
		private inkWidgetReference _option1UpgradeBtnAnchor;
		private inkWidgetReference _option2UpgradeBtnAnchor;
		private inkWidgetReference _option3UpgradeBtnAnchor;
		private inkWidgetReference _upgradeBtnContainerRef;
		private CString _upgradeButtonLabelKey;
		private CFloat _upgradeButtonAnimDuration;
		private redResourceReferenceScriptToken _upgradeButtonResRef;
		private CName _upgradeButtonResName;
		private CName _noChoiceIntroAnimName;
		private CName _twoChoiceIntroAnimName;
		private CName _threeChoiceIntroAnimName;
		private CName _noChoiceOutroAnimName;
		private CName _twoChoice1OutroAnimName;
		private CName _twoChoice2OutroAnimName;
		private CName _threeChoice1OutroAnimName;
		private CName _threeChoice2OutroAnimName;
		private CName _threeChoice3OutroAnimName;
		private CName _holdInputName;
		private CName _exitInputName;
		private inkWidgetReference _buttonHintsRoot;
		private redResourceReferenceScriptToken _itemToolitpResRef;
		private CName _itemTooltipName;
		private redResourceReferenceScriptToken _cyberdeckToolitpResRef;
		private CName _cyberdeckTooltipName;
		private redResourceReferenceScriptToken _toolitpWidgetRef;
		private CName _tooltipName;
		private wCHandle<AGenericTooltipController> _itemTooltipController0;
		private wCHandle<AGenericTooltipController> _itemTooltipController1;
		private wCHandle<AGenericTooltipController> _itemTooltipController2;
		private wCHandle<AGenericTooltipController> _itemTooltipController3;
		private wCHandle<ItemTooltipCyberwareUpgradeController> _itemTooltipCyberwareUpgrade;
		private wCHandle<inkWidget> _option1ProgressBar;
		private wCHandle<inkWidget> _option2ProgressBar;
		private wCHandle<inkWidget> _option3ProgressBar;
		private wCHandle<gameGameAudioSystem> _audioSystem;
		private CHandle<RipperdocTokenPopupData> _data;
		private CBool _multichoice;
		private CBool _thirdChoiceAvailable;
		private CBool _progressStarted;
		private CBool _introAnimationPlaying;
		private CHandle<inkanimProxy> _choicesAnimProxy;
		private CHandle<inkanimProxy> _buttonAnimProxy;
		private CInt32 _currentOption;
		private CInt32 _choice;
		private CBool _result;
		private CBool _inputListenersRegistered;

		[Ordinal(2)] 
		[RED("optionRef", 4)] 
		public CArrayFixedSize<inkWidgetReference> OptionRef
		{
			get => GetProperty(ref _optionRef);
			set => SetProperty(ref _optionRef, value);
		}

		[Ordinal(3)] 
		[RED("optionTooltipParent", 4)] 
		public CArrayFixedSize<inkWidgetReference> OptionTooltipParent
		{
			get => GetProperty(ref _optionTooltipParent);
			set => SetProperty(ref _optionTooltipParent, value);
		}

		[Ordinal(4)] 
		[RED("option1ProgressBarRef")] 
		public inkWidgetReference Option1ProgressBarRef
		{
			get => GetProperty(ref _option1ProgressBarRef);
			set => SetProperty(ref _option1ProgressBarRef, value);
		}

		[Ordinal(5)] 
		[RED("option2ProgressBarRef")] 
		public inkWidgetReference Option2ProgressBarRef
		{
			get => GetProperty(ref _option2ProgressBarRef);
			set => SetProperty(ref _option2ProgressBarRef, value);
		}

		[Ordinal(6)] 
		[RED("option3ProgressBarRef")] 
		public inkWidgetReference Option3ProgressBarRef
		{
			get => GetProperty(ref _option3ProgressBarRef);
			set => SetProperty(ref _option3ProgressBarRef, value);
		}

		[Ordinal(7)] 
		[RED("option1HoverZone")] 
		public inkWidgetReference Option1HoverZone
		{
			get => GetProperty(ref _option1HoverZone);
			set => SetProperty(ref _option1HoverZone, value);
		}

		[Ordinal(8)] 
		[RED("option2HoverZone")] 
		public inkWidgetReference Option2HoverZone
		{
			get => GetProperty(ref _option2HoverZone);
			set => SetProperty(ref _option2HoverZone, value);
		}

		[Ordinal(9)] 
		[RED("option3HoverZone")] 
		public inkWidgetReference Option3HoverZone
		{
			get => GetProperty(ref _option3HoverZone);
			set => SetProperty(ref _option3HoverZone, value);
		}

		[Ordinal(10)] 
		[RED("progressEffectName")] 
		public CName ProgressEffectName
		{
			get => GetProperty(ref _progressEffectName);
			set => SetProperty(ref _progressEffectName, value);
		}

		[Ordinal(11)] 
		[RED("option1UpgradeBtnAnchor")] 
		public inkWidgetReference Option1UpgradeBtnAnchor
		{
			get => GetProperty(ref _option1UpgradeBtnAnchor);
			set => SetProperty(ref _option1UpgradeBtnAnchor, value);
		}

		[Ordinal(12)] 
		[RED("option2UpgradeBtnAnchor")] 
		public inkWidgetReference Option2UpgradeBtnAnchor
		{
			get => GetProperty(ref _option2UpgradeBtnAnchor);
			set => SetProperty(ref _option2UpgradeBtnAnchor, value);
		}

		[Ordinal(13)] 
		[RED("option3UpgradeBtnAnchor")] 
		public inkWidgetReference Option3UpgradeBtnAnchor
		{
			get => GetProperty(ref _option3UpgradeBtnAnchor);
			set => SetProperty(ref _option3UpgradeBtnAnchor, value);
		}

		[Ordinal(14)] 
		[RED("upgradeBtnContainerRef")] 
		public inkWidgetReference UpgradeBtnContainerRef
		{
			get => GetProperty(ref _upgradeBtnContainerRef);
			set => SetProperty(ref _upgradeBtnContainerRef, value);
		}

		[Ordinal(15)] 
		[RED("upgradeButtonLabelKey")] 
		public CString UpgradeButtonLabelKey
		{
			get => GetProperty(ref _upgradeButtonLabelKey);
			set => SetProperty(ref _upgradeButtonLabelKey, value);
		}

		[Ordinal(16)] 
		[RED("upgradeButtonAnimDuration")] 
		public CFloat UpgradeButtonAnimDuration
		{
			get => GetProperty(ref _upgradeButtonAnimDuration);
			set => SetProperty(ref _upgradeButtonAnimDuration, value);
		}

		[Ordinal(17)] 
		[RED("upgradeButtonResRef")] 
		public redResourceReferenceScriptToken UpgradeButtonResRef
		{
			get => GetProperty(ref _upgradeButtonResRef);
			set => SetProperty(ref _upgradeButtonResRef, value);
		}

		[Ordinal(18)] 
		[RED("upgradeButtonResName")] 
		public CName UpgradeButtonResName
		{
			get => GetProperty(ref _upgradeButtonResName);
			set => SetProperty(ref _upgradeButtonResName, value);
		}

		[Ordinal(19)] 
		[RED("noChoiceIntroAnimName")] 
		public CName NoChoiceIntroAnimName
		{
			get => GetProperty(ref _noChoiceIntroAnimName);
			set => SetProperty(ref _noChoiceIntroAnimName, value);
		}

		[Ordinal(20)] 
		[RED("twoChoiceIntroAnimName")] 
		public CName TwoChoiceIntroAnimName
		{
			get => GetProperty(ref _twoChoiceIntroAnimName);
			set => SetProperty(ref _twoChoiceIntroAnimName, value);
		}

		[Ordinal(21)] 
		[RED("threeChoiceIntroAnimName")] 
		public CName ThreeChoiceIntroAnimName
		{
			get => GetProperty(ref _threeChoiceIntroAnimName);
			set => SetProperty(ref _threeChoiceIntroAnimName, value);
		}

		[Ordinal(22)] 
		[RED("noChoiceOutroAnimName")] 
		public CName NoChoiceOutroAnimName
		{
			get => GetProperty(ref _noChoiceOutroAnimName);
			set => SetProperty(ref _noChoiceOutroAnimName, value);
		}

		[Ordinal(23)] 
		[RED("twoChoice1OutroAnimName")] 
		public CName TwoChoice1OutroAnimName
		{
			get => GetProperty(ref _twoChoice1OutroAnimName);
			set => SetProperty(ref _twoChoice1OutroAnimName, value);
		}

		[Ordinal(24)] 
		[RED("twoChoice2OutroAnimName")] 
		public CName TwoChoice2OutroAnimName
		{
			get => GetProperty(ref _twoChoice2OutroAnimName);
			set => SetProperty(ref _twoChoice2OutroAnimName, value);
		}

		[Ordinal(25)] 
		[RED("threeChoice1OutroAnimName")] 
		public CName ThreeChoice1OutroAnimName
		{
			get => GetProperty(ref _threeChoice1OutroAnimName);
			set => SetProperty(ref _threeChoice1OutroAnimName, value);
		}

		[Ordinal(26)] 
		[RED("threeChoice2OutroAnimName")] 
		public CName ThreeChoice2OutroAnimName
		{
			get => GetProperty(ref _threeChoice2OutroAnimName);
			set => SetProperty(ref _threeChoice2OutroAnimName, value);
		}

		[Ordinal(27)] 
		[RED("threeChoice3OutroAnimName")] 
		public CName ThreeChoice3OutroAnimName
		{
			get => GetProperty(ref _threeChoice3OutroAnimName);
			set => SetProperty(ref _threeChoice3OutroAnimName, value);
		}

		[Ordinal(28)] 
		[RED("holdInputName")] 
		public CName HoldInputName
		{
			get => GetProperty(ref _holdInputName);
			set => SetProperty(ref _holdInputName, value);
		}

		[Ordinal(29)] 
		[RED("exitInputName")] 
		public CName ExitInputName
		{
			get => GetProperty(ref _exitInputName);
			set => SetProperty(ref _exitInputName, value);
		}

		[Ordinal(30)] 
		[RED("buttonHintsRoot")] 
		public inkWidgetReference ButtonHintsRoot
		{
			get => GetProperty(ref _buttonHintsRoot);
			set => SetProperty(ref _buttonHintsRoot, value);
		}

		[Ordinal(31)] 
		[RED("itemToolitpResRef")] 
		public redResourceReferenceScriptToken ItemToolitpResRef
		{
			get => GetProperty(ref _itemToolitpResRef);
			set => SetProperty(ref _itemToolitpResRef, value);
		}

		[Ordinal(32)] 
		[RED("itemTooltipName")] 
		public CName ItemTooltipName
		{
			get => GetProperty(ref _itemTooltipName);
			set => SetProperty(ref _itemTooltipName, value);
		}

		[Ordinal(33)] 
		[RED("cyberdeckToolitpResRef")] 
		public redResourceReferenceScriptToken CyberdeckToolitpResRef
		{
			get => GetProperty(ref _cyberdeckToolitpResRef);
			set => SetProperty(ref _cyberdeckToolitpResRef, value);
		}

		[Ordinal(34)] 
		[RED("cyberdeckTooltipName")] 
		public CName CyberdeckTooltipName
		{
			get => GetProperty(ref _cyberdeckTooltipName);
			set => SetProperty(ref _cyberdeckTooltipName, value);
		}

		[Ordinal(35)] 
		[RED("toolitpWidgetRef")] 
		public redResourceReferenceScriptToken ToolitpWidgetRef
		{
			get => GetProperty(ref _toolitpWidgetRef);
			set => SetProperty(ref _toolitpWidgetRef, value);
		}

		[Ordinal(36)] 
		[RED("tooltipName")] 
		public CName TooltipName
		{
			get => GetProperty(ref _tooltipName);
			set => SetProperty(ref _tooltipName, value);
		}

		[Ordinal(37)] 
		[RED("itemTooltipController0")] 
		public wCHandle<AGenericTooltipController> ItemTooltipController0
		{
			get => GetProperty(ref _itemTooltipController0);
			set => SetProperty(ref _itemTooltipController0, value);
		}

		[Ordinal(38)] 
		[RED("itemTooltipController1")] 
		public wCHandle<AGenericTooltipController> ItemTooltipController1
		{
			get => GetProperty(ref _itemTooltipController1);
			set => SetProperty(ref _itemTooltipController1, value);
		}

		[Ordinal(39)] 
		[RED("itemTooltipController2")] 
		public wCHandle<AGenericTooltipController> ItemTooltipController2
		{
			get => GetProperty(ref _itemTooltipController2);
			set => SetProperty(ref _itemTooltipController2, value);
		}

		[Ordinal(40)] 
		[RED("itemTooltipController3")] 
		public wCHandle<AGenericTooltipController> ItemTooltipController3
		{
			get => GetProperty(ref _itemTooltipController3);
			set => SetProperty(ref _itemTooltipController3, value);
		}

		[Ordinal(41)] 
		[RED("itemTooltipCyberwareUpgrade")] 
		public wCHandle<ItemTooltipCyberwareUpgradeController> ItemTooltipCyberwareUpgrade
		{
			get => GetProperty(ref _itemTooltipCyberwareUpgrade);
			set => SetProperty(ref _itemTooltipCyberwareUpgrade, value);
		}

		[Ordinal(42)] 
		[RED("option1ProgressBar")] 
		public wCHandle<inkWidget> Option1ProgressBar
		{
			get => GetProperty(ref _option1ProgressBar);
			set => SetProperty(ref _option1ProgressBar, value);
		}

		[Ordinal(43)] 
		[RED("option2ProgressBar")] 
		public wCHandle<inkWidget> Option2ProgressBar
		{
			get => GetProperty(ref _option2ProgressBar);
			set => SetProperty(ref _option2ProgressBar, value);
		}

		[Ordinal(44)] 
		[RED("option3ProgressBar")] 
		public wCHandle<inkWidget> Option3ProgressBar
		{
			get => GetProperty(ref _option3ProgressBar);
			set => SetProperty(ref _option3ProgressBar, value);
		}

		[Ordinal(45)] 
		[RED("audioSystem")] 
		public wCHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetProperty(ref _audioSystem);
			set => SetProperty(ref _audioSystem, value);
		}

		[Ordinal(46)] 
		[RED("data")] 
		public CHandle<RipperdocTokenPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(47)] 
		[RED("multichoice")] 
		public CBool Multichoice
		{
			get => GetProperty(ref _multichoice);
			set => SetProperty(ref _multichoice, value);
		}

		[Ordinal(48)] 
		[RED("thirdChoiceAvailable")] 
		public CBool ThirdChoiceAvailable
		{
			get => GetProperty(ref _thirdChoiceAvailable);
			set => SetProperty(ref _thirdChoiceAvailable, value);
		}

		[Ordinal(49)] 
		[RED("progressStarted")] 
		public CBool ProgressStarted
		{
			get => GetProperty(ref _progressStarted);
			set => SetProperty(ref _progressStarted, value);
		}

		[Ordinal(50)] 
		[RED("introAnimationPlaying")] 
		public CBool IntroAnimationPlaying
		{
			get => GetProperty(ref _introAnimationPlaying);
			set => SetProperty(ref _introAnimationPlaying, value);
		}

		[Ordinal(51)] 
		[RED("choicesAnimProxy")] 
		public CHandle<inkanimProxy> ChoicesAnimProxy
		{
			get => GetProperty(ref _choicesAnimProxy);
			set => SetProperty(ref _choicesAnimProxy, value);
		}

		[Ordinal(52)] 
		[RED("buttonAnimProxy")] 
		public CHandle<inkanimProxy> ButtonAnimProxy
		{
			get => GetProperty(ref _buttonAnimProxy);
			set => SetProperty(ref _buttonAnimProxy, value);
		}

		[Ordinal(53)] 
		[RED("currentOption")] 
		public CInt32 CurrentOption
		{
			get => GetProperty(ref _currentOption);
			set => SetProperty(ref _currentOption, value);
		}

		[Ordinal(54)] 
		[RED("choice")] 
		public CInt32 Choice
		{
			get => GetProperty(ref _choice);
			set => SetProperty(ref _choice, value);
		}

		[Ordinal(55)] 
		[RED("result")] 
		public CBool Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		[Ordinal(56)] 
		[RED("inputListenersRegistered")] 
		public CBool InputListenersRegistered
		{
			get => GetProperty(ref _inputListenersRegistered);
			set => SetProperty(ref _inputListenersRegistered, value);
		}

		public RipperdocTokenPopup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
