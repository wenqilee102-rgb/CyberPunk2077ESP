using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LimfaticNanoChargeSystemEffector : gameContinuousEffector
	{
		private CFloat _maxDistance;
		private TweakDBID _statusEffectID;
		private entEntityID _ownerID;
		private CBool _statusEffectIsApplied;

		[Ordinal(0)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(1)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetProperty(ref _statusEffectID);
			set => SetProperty(ref _statusEffectID, value);
		}

		[Ordinal(2)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(3)] 
		[RED("statusEffectIsApplied")] 
		public CBool StatusEffectIsApplied
		{
			get => GetProperty(ref _statusEffectIsApplied);
			set => SetProperty(ref _statusEffectIsApplied, value);
		}

		public LimfaticNanoChargeSystemEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
