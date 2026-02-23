using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeAttackGenericEvents : MeleeEventsTransition
	{
		private CHandle<gameEffectInstance> _effect;
		private CBool _attackCreated;
		private CBool _blockImpulseCreation;
		private CBool _standUpSend;
		private CBool _trailCreated;
		private wCHandle<ScriptedPuppet> _finisherTarget;
		private CBool _finisherCameraRotReseted;
		private CUInt32 _textLayer;
		private CBool _rumblePlayed;
		private CBool _shouldBlockImpulseUpdate;
		private CBool _enteredFromMeleeLeap;
		private CBool _effectPositionUpdated;
		private CFloat _tppYawOverride;

		[Ordinal(2)] 
		[RED("effect")] 
		public CHandle<gameEffectInstance> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(3)] 
		[RED("attackCreated")] 
		public CBool AttackCreated
		{
			get => GetProperty(ref _attackCreated);
			set => SetProperty(ref _attackCreated, value);
		}

		[Ordinal(4)] 
		[RED("blockImpulseCreation")] 
		public CBool BlockImpulseCreation
		{
			get => GetProperty(ref _blockImpulseCreation);
			set => SetProperty(ref _blockImpulseCreation, value);
		}

		[Ordinal(5)] 
		[RED("standUpSend")] 
		public CBool StandUpSend
		{
			get => GetProperty(ref _standUpSend);
			set => SetProperty(ref _standUpSend, value);
		}

		[Ordinal(6)] 
		[RED("trailCreated")] 
		public CBool TrailCreated
		{
			get => GetProperty(ref _trailCreated);
			set => SetProperty(ref _trailCreated, value);
		}

		[Ordinal(7)] 
		[RED("finisherTarget")] 
		public wCHandle<ScriptedPuppet> FinisherTarget
		{
			get => GetProperty(ref _finisherTarget);
			set => SetProperty(ref _finisherTarget, value);
		}

		[Ordinal(8)] 
		[RED("finisherCameraRotReseted")] 
		public CBool FinisherCameraRotReseted
		{
			get => GetProperty(ref _finisherCameraRotReseted);
			set => SetProperty(ref _finisherCameraRotReseted, value);
		}

		[Ordinal(9)] 
		[RED("textLayer")] 
		public CUInt32 TextLayer
		{
			get => GetProperty(ref _textLayer);
			set => SetProperty(ref _textLayer, value);
		}

		[Ordinal(10)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get => GetProperty(ref _rumblePlayed);
			set => SetProperty(ref _rumblePlayed, value);
		}

		[Ordinal(11)] 
		[RED("shouldBlockImpulseUpdate")] 
		public CBool ShouldBlockImpulseUpdate
		{
			get => GetProperty(ref _shouldBlockImpulseUpdate);
			set => SetProperty(ref _shouldBlockImpulseUpdate, value);
		}

		[Ordinal(12)] 
		[RED("enteredFromMeleeLeap")] 
		public CBool EnteredFromMeleeLeap
		{
			get => GetProperty(ref _enteredFromMeleeLeap);
			set => SetProperty(ref _enteredFromMeleeLeap, value);
		}

		[Ordinal(13)] 
		[RED("effectPositionUpdated")] 
		public CBool EffectPositionUpdated
		{
			get => GetProperty(ref _effectPositionUpdated);
			set => SetProperty(ref _effectPositionUpdated, value);
		}

		[Ordinal(14)] 
		[RED("tppYawOverride")] 
		public CFloat TppYawOverride
		{
			get => GetProperty(ref _tppYawOverride);
			set => SetProperty(ref _tppYawOverride, value);
		}

		public MeleeAttackGenericEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
