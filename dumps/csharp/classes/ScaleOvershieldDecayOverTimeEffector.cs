using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScaleOvershieldDecayOverTimeEffector : gameContinuousEffector
	{
		private CBool _effectApplied;
		private CHandle<gameStatModifierData_Deprecated> _decayModifier;
		private wCHandle<gameObject> _owner;
		private CHandle<OvershieldMinValueListener> _overshieldListener;
		private CFloat _delayTime;
		private CFloat _elapsedTime;
		private CFloat _bValue;
		private CFloat _kInitValue;
		private CFloat _kValue;
		private CFloat _maxDecay;
		private CBool _maxValueApplied;
		private CBool _markedForReset;

		[Ordinal(0)] 
		[RED("effectApplied")] 
		public CBool EffectApplied
		{
			get => GetProperty(ref _effectApplied);
			set => SetProperty(ref _effectApplied, value);
		}

		[Ordinal(1)] 
		[RED("decayModifier")] 
		public CHandle<gameStatModifierData_Deprecated> DecayModifier
		{
			get => GetProperty(ref _decayModifier);
			set => SetProperty(ref _decayModifier, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(3)] 
		[RED("overshieldListener")] 
		public CHandle<OvershieldMinValueListener> OvershieldListener
		{
			get => GetProperty(ref _overshieldListener);
			set => SetProperty(ref _overshieldListener, value);
		}

		[Ordinal(4)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetProperty(ref _delayTime);
			set => SetProperty(ref _delayTime, value);
		}

		[Ordinal(5)] 
		[RED("elapsedTime")] 
		public CFloat ElapsedTime
		{
			get => GetProperty(ref _elapsedTime);
			set => SetProperty(ref _elapsedTime, value);
		}

		[Ordinal(6)] 
		[RED("bValue")] 
		public CFloat BValue
		{
			get => GetProperty(ref _bValue);
			set => SetProperty(ref _bValue, value);
		}

		[Ordinal(7)] 
		[RED("kInitValue")] 
		public CFloat KInitValue
		{
			get => GetProperty(ref _kInitValue);
			set => SetProperty(ref _kInitValue, value);
		}

		[Ordinal(8)] 
		[RED("kValue")] 
		public CFloat KValue
		{
			get => GetProperty(ref _kValue);
			set => SetProperty(ref _kValue, value);
		}

		[Ordinal(9)] 
		[RED("maxDecay")] 
		public CFloat MaxDecay
		{
			get => GetProperty(ref _maxDecay);
			set => SetProperty(ref _maxDecay, value);
		}

		[Ordinal(10)] 
		[RED("maxValueApplied")] 
		public CBool MaxValueApplied
		{
			get => GetProperty(ref _maxValueApplied);
			set => SetProperty(ref _maxValueApplied, value);
		}

		[Ordinal(11)] 
		[RED("markedForReset")] 
		public CBool MarkedForReset
		{
			get => GetProperty(ref _markedForReset);
			set => SetProperty(ref _markedForReset, value);
		}

		public ScaleOvershieldDecayOverTimeEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
