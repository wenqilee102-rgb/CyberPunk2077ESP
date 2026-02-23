using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitHistoryItem : CVariable
	{
		private wCHandle<gameObject> _instigator;
		private CFloat _hitTime;
		private CEnum<gamedataAttackType> _attackType;

		[Ordinal(0)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(1)] 
		[RED("hitTime")] 
		public CFloat HitTime
		{
			get => GetProperty(ref _hitTime);
			set => SetProperty(ref _hitTime, value);
		}

		[Ordinal(2)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		public HitHistoryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
