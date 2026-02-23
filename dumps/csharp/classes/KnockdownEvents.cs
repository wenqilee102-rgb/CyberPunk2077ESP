using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KnockdownEvents : StatusEffectEvents
	{
		private Vector4 _cachedPlayerVelocity;
		private Vector4 _secondaryKnockdownDir;
		private CFloat _secondaryKnockdownTimer;
		private CBool _playedImpactAnim;
		private CBool _frictionForceApplied;
		private CBool _frictionForceAppliedLastFrame;
		private CBool _delayDamageFrame;
		private CBool _bikeKnockdown;

		[Ordinal(12)] 
		[RED("cachedPlayerVelocity")] 
		public Vector4 CachedPlayerVelocity
		{
			get => GetProperty(ref _cachedPlayerVelocity);
			set => SetProperty(ref _cachedPlayerVelocity, value);
		}

		[Ordinal(13)] 
		[RED("secondaryKnockdownDir")] 
		public Vector4 SecondaryKnockdownDir
		{
			get => GetProperty(ref _secondaryKnockdownDir);
			set => SetProperty(ref _secondaryKnockdownDir, value);
		}

		[Ordinal(14)] 
		[RED("secondaryKnockdownTimer")] 
		public CFloat SecondaryKnockdownTimer
		{
			get => GetProperty(ref _secondaryKnockdownTimer);
			set => SetProperty(ref _secondaryKnockdownTimer, value);
		}

		[Ordinal(15)] 
		[RED("playedImpactAnim")] 
		public CBool PlayedImpactAnim
		{
			get => GetProperty(ref _playedImpactAnim);
			set => SetProperty(ref _playedImpactAnim, value);
		}

		[Ordinal(16)] 
		[RED("frictionForceApplied")] 
		public CBool FrictionForceApplied
		{
			get => GetProperty(ref _frictionForceApplied);
			set => SetProperty(ref _frictionForceApplied, value);
		}

		[Ordinal(17)] 
		[RED("frictionForceAppliedLastFrame")] 
		public CBool FrictionForceAppliedLastFrame
		{
			get => GetProperty(ref _frictionForceAppliedLastFrame);
			set => SetProperty(ref _frictionForceAppliedLastFrame, value);
		}

		[Ordinal(18)] 
		[RED("delayDamageFrame")] 
		public CBool DelayDamageFrame
		{
			get => GetProperty(ref _delayDamageFrame);
			set => SetProperty(ref _delayDamageFrame, value);
		}

		[Ordinal(19)] 
		[RED("bikeKnockdown")] 
		public CBool BikeKnockdown
		{
			get => GetProperty(ref _bikeKnockdown);
			set => SetProperty(ref _bikeKnockdown, value);
		}

		public KnockdownEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
