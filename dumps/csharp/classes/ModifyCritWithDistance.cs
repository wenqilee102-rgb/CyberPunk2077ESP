using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyCritWithDistance : ModifyAttackEffector
	{
		private CFloat _critChanceBonus;
		private CFloat _minDistance;
		private CFloat _maxDistance;
		private CBool _improveWithDistance;

		[Ordinal(0)] 
		[RED("critChanceBonus")] 
		public CFloat CritChanceBonus
		{
			get => GetProperty(ref _critChanceBonus);
			set => SetProperty(ref _critChanceBonus, value);
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(3)] 
		[RED("improveWithDistance")] 
		public CBool ImproveWithDistance
		{
			get => GetProperty(ref _improveWithDistance);
			set => SetProperty(ref _improveWithDistance, value);
		}

		public ModifyCritWithDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
