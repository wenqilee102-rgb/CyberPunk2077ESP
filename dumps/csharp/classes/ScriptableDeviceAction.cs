using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptableDeviceAction : BaseScriptableAction
	{
		private CHandle<gamedeviceActionProperty> _prop;
		private SActionWidgetPackage _actionWidgetPackage;
		private NodeRef _spiderbotActionLocationOverride;
		private CFloat _duration;
		private CBool _canTriggerStim;
		private CBool _wasPerformedOnOwner;
		private CBool _shouldActivateDevice;
		private CBool _disableSpread;
		private CBool _isQuickHack;
		private CBool _isSpiderbotAction;
		private TweakDBID _attachedProgram;
		private TweakDBID _activeStatusEffect;
		private TweakDBID _interactionIconType;
		private CBool _hasInteraction;
		private CString _inactiveReason;
		private CEnum<gamedataComputerUIStyle> _widgetStyle;

		[Ordinal(23)] 
		[RED("prop")] 
		public CHandle<gamedeviceActionProperty> Prop
		{
			get => GetProperty(ref _prop);
			set => SetProperty(ref _prop, value);
		}

		[Ordinal(24)] 
		[RED("actionWidgetPackage")] 
		public SActionWidgetPackage ActionWidgetPackage
		{
			get => GetProperty(ref _actionWidgetPackage);
			set => SetProperty(ref _actionWidgetPackage, value);
		}

		[Ordinal(25)] 
		[RED("spiderbotActionLocationOverride")] 
		public NodeRef SpiderbotActionLocationOverride
		{
			get => GetProperty(ref _spiderbotActionLocationOverride);
			set => SetProperty(ref _spiderbotActionLocationOverride, value);
		}

		[Ordinal(26)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(27)] 
		[RED("canTriggerStim")] 
		public CBool CanTriggerStim
		{
			get => GetProperty(ref _canTriggerStim);
			set => SetProperty(ref _canTriggerStim, value);
		}

		[Ordinal(28)] 
		[RED("wasPerformedOnOwner")] 
		public CBool WasPerformedOnOwner
		{
			get => GetProperty(ref _wasPerformedOnOwner);
			set => SetProperty(ref _wasPerformedOnOwner, value);
		}

		[Ordinal(29)] 
		[RED("shouldActivateDevice")] 
		public CBool ShouldActivateDevice
		{
			get => GetProperty(ref _shouldActivateDevice);
			set => SetProperty(ref _shouldActivateDevice, value);
		}

		[Ordinal(30)] 
		[RED("disableSpread")] 
		public CBool DisableSpread
		{
			get => GetProperty(ref _disableSpread);
			set => SetProperty(ref _disableSpread, value);
		}

		[Ordinal(31)] 
		[RED("isQuickHack")] 
		public CBool IsQuickHack
		{
			get => GetProperty(ref _isQuickHack);
			set => SetProperty(ref _isQuickHack, value);
		}

		[Ordinal(32)] 
		[RED("isSpiderbotAction")] 
		public CBool IsSpiderbotAction
		{
			get => GetProperty(ref _isSpiderbotAction);
			set => SetProperty(ref _isSpiderbotAction, value);
		}

		[Ordinal(33)] 
		[RED("attachedProgram")] 
		public TweakDBID AttachedProgram
		{
			get => GetProperty(ref _attachedProgram);
			set => SetProperty(ref _attachedProgram, value);
		}

		[Ordinal(34)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get => GetProperty(ref _activeStatusEffect);
			set => SetProperty(ref _activeStatusEffect, value);
		}

		[Ordinal(35)] 
		[RED("interactionIconType")] 
		public TweakDBID InteractionIconType
		{
			get => GetProperty(ref _interactionIconType);
			set => SetProperty(ref _interactionIconType, value);
		}

		[Ordinal(36)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetProperty(ref _hasInteraction);
			set => SetProperty(ref _hasInteraction, value);
		}

		[Ordinal(37)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get => GetProperty(ref _inactiveReason);
			set => SetProperty(ref _inactiveReason, value);
		}

		[Ordinal(38)] 
		[RED("widgetStyle")] 
		public CEnum<gamedataComputerUIStyle> WidgetStyle
		{
			get => GetProperty(ref _widgetStyle);
			set => SetProperty(ref _widgetStyle, value);
		}

		public ScriptableDeviceAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
