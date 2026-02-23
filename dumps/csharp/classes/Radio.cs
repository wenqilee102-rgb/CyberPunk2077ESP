using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Radio : InteractiveDevice
	{
		private CHandle<ScriptableDeviceAction> _effectAction;
		private gameEffectRef _effectRef;
		private TweakDBID _statusEffect;
		private TweakDBID _damageType;
		private CInt32 _startingStation;
		private CBool _isInteractive;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CHandle<gameEffectInstance> _effectInstance;
		private CArray<wCHandle<ScriptedPuppet>> _targets;
		private CHandle<gameFxInstance> _vfxInstance;

		[Ordinal(98)] 
		[RED("effectAction")] 
		public CHandle<ScriptableDeviceAction> EffectAction
		{
			get => GetProperty(ref _effectAction);
			set => SetProperty(ref _effectAction, value);
		}

		[Ordinal(99)] 
		[RED("effectRef")] 
		public gameEffectRef EffectRef
		{
			get => GetProperty(ref _effectRef);
			set => SetProperty(ref _effectRef, value);
		}

		[Ordinal(100)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}

		[Ordinal(101)] 
		[RED("damageType")] 
		public TweakDBID DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}

		[Ordinal(102)] 
		[RED("startingStation")] 
		public CInt32 StartingStation
		{
			get => GetProperty(ref _startingStation);
			set => SetProperty(ref _startingStation, value);
		}

		[Ordinal(103)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		[Ordinal(104)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(105)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(106)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetProperty(ref _effectInstance);
			set => SetProperty(ref _effectInstance, value);
		}

		[Ordinal(107)] 
		[RED("targets")] 
		public CArray<wCHandle<ScriptedPuppet>> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(108)] 
		[RED("vfxInstance")] 
		public CHandle<gameFxInstance> VfxInstance
		{
			get => GetProperty(ref _vfxInstance);
			set => SetProperty(ref _vfxInstance, value);
		}

		public Radio(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
