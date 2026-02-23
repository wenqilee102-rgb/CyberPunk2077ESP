using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveAllModifiersEffector : gameEffector
	{
		private CEnum<gamedataStatType> _statType;
		private CName _applicationTarget;
		private gameStatsObjectID _target;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public gameStatsObjectID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public RemoveAllModifiersEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
