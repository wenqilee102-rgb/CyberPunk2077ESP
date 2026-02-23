using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_AnimFeature : gameEffectExecutor
	{
		private CName _key;
		private CHandle<animAnimFeature> _animFeature;
		private CEnum<gameEffectExecutor_AnimFeatureApplyTo> _applyTo;
		private CBool _ignoreWaterImpacts;

		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(2)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(3)] 
		[RED("applyTo")] 
		public CEnum<gameEffectExecutor_AnimFeatureApplyTo> ApplyTo
		{
			get => GetProperty(ref _applyTo);
			set => SetProperty(ref _applyTo, value);
		}

		[Ordinal(4)] 
		[RED("ignoreWaterImpacts")] 
		public CBool IgnoreWaterImpacts
		{
			get => GetProperty(ref _ignoreWaterImpacts);
			set => SetProperty(ref _ignoreWaterImpacts, value);
		}

		public gameEffectExecutor_AnimFeature(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
