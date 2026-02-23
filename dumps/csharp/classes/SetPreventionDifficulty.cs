using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetPreventionDifficulty : gameScriptableSystemRequest
	{
		private CFloat _damageDealtToPlayerMultiplier;
		private CFloat _chaseAggressivnessMultiplier;
		private CBool _difficuiltyReset;
		private CName _source;

		[Ordinal(0)] 
		[RED("damageDealtToPlayerMultiplier")] 
		public CFloat DamageDealtToPlayerMultiplier
		{
			get => GetProperty(ref _damageDealtToPlayerMultiplier);
			set => SetProperty(ref _damageDealtToPlayerMultiplier, value);
		}

		[Ordinal(1)] 
		[RED("chaseAggressivnessMultiplier")] 
		public CFloat ChaseAggressivnessMultiplier
		{
			get => GetProperty(ref _chaseAggressivnessMultiplier);
			set => SetProperty(ref _chaseAggressivnessMultiplier, value);
		}

		[Ordinal(2)] 
		[RED("difficuiltyReset")] 
		public CBool DifficuiltyReset
		{
			get => GetProperty(ref _difficuiltyReset);
			set => SetProperty(ref _difficuiltyReset, value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public SetPreventionDifficulty(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
