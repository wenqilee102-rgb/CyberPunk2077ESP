using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SadismEffector : gameEffector
	{
		private CFloat _healingItemChargeRestorePercentage;

		[Ordinal(0)] 
		[RED("healingItemChargeRestorePercentage")] 
		public CFloat HealingItemChargeRestorePercentage
		{
			get => GetProperty(ref _healingItemChargeRestorePercentage);
			set => SetProperty(ref _healingItemChargeRestorePercentage, value);
		}

		public SadismEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
