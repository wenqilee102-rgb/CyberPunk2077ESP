using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitiateCyberwareExplosionEffector : gameEffector
	{
		private CFloat _maxRangeAddition;
		private wCHandle<gamedataAttack_Record> _attackRecord;

		[Ordinal(0)] 
		[RED("maxRangeAddition")] 
		public CFloat MaxRangeAddition
		{
			get => GetProperty(ref _maxRangeAddition);
			set => SetProperty(ref _maxRangeAddition, value);
		}

		[Ordinal(1)] 
		[RED("attackRecord")] 
		public wCHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetProperty(ref _attackRecord);
			set => SetProperty(ref _attackRecord, value);
		}

		public InitiateCyberwareExplosionEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
