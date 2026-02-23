using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BloodlustHealingEffector : ApplyEffectToDismemberedEffector
	{
		private CHandle<gameStatPoolsSystem> _poolSystem;
		private CFloat _maxDistanceSquared;
		private CFloat _healAmount;
		private CBool _usePercent;
		private CFloat _lastActivationTime;

		[Ordinal(0)] 
		[RED("poolSystem")] 
		public CHandle<gameStatPoolsSystem> PoolSystem
		{
			get => GetProperty(ref _poolSystem);
			set => SetProperty(ref _poolSystem, value);
		}

		[Ordinal(1)] 
		[RED("maxDistanceSquared")] 
		public CFloat MaxDistanceSquared
		{
			get => GetProperty(ref _maxDistanceSquared);
			set => SetProperty(ref _maxDistanceSquared, value);
		}

		[Ordinal(2)] 
		[RED("healAmount")] 
		public CFloat HealAmount
		{
			get => GetProperty(ref _healAmount);
			set => SetProperty(ref _healAmount, value);
		}

		[Ordinal(3)] 
		[RED("usePercent")] 
		public CBool UsePercent
		{
			get => GetProperty(ref _usePercent);
			set => SetProperty(ref _usePercent, value);
		}

		[Ordinal(4)] 
		[RED("lastActivationTime")] 
		public CFloat LastActivationTime
		{
			get => GetProperty(ref _lastActivationTime);
			set => SetProperty(ref _lastActivationTime, value);
		}

		public BloodlustHealingEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
