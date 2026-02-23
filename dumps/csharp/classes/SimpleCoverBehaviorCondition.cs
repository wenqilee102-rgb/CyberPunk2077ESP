using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleCoverBehaviorCondition : AIbehaviorconditionScript
	{
		private CBool _initialized;
		private CBool _isShotgunner;
		private CBool _isHeavyRanged;

		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(1)] 
		[RED("isShotgunner")] 
		public CBool IsShotgunner
		{
			get => GetProperty(ref _isShotgunner);
			set => SetProperty(ref _isShotgunner, value);
		}

		[Ordinal(2)] 
		[RED("isHeavyRanged")] 
		public CBool IsHeavyRanged
		{
			get => GetProperty(ref _isHeavyRanged);
			set => SetProperty(ref _isHeavyRanged, value);
		}

		public SimpleCoverBehaviorCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
