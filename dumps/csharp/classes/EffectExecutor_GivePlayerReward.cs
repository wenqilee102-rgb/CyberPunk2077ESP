using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_GivePlayerReward : gameEffectExecutor_Scripted
	{
		private TweakDBID _reward;
		private CInt32 _amount;

		[Ordinal(1)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get => GetProperty(ref _reward);
			set => SetProperty(ref _reward, value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		public EffectExecutor_GivePlayerReward(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
