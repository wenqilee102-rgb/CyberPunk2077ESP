using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PropagateStatusEffectInAreaEffector : ApplyEffectToDismemberedEffector
	{
		private TweakDBID _statusEffect;
		private CFloat _range;
		private CFloat _duration;
		private CName _applicationTarget;
		private CBool _propagateToInstigator;

		[Ordinal(0)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(4)] 
		[RED("propagateToInstigator")] 
		public CBool PropagateToInstigator
		{
			get => GetProperty(ref _propagateToInstigator);
			set => SetProperty(ref _propagateToInstigator, value);
		}

		public PropagateStatusEffectInAreaEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
