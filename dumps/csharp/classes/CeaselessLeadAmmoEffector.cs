using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CeaselessLeadAmmoEffector : gameEffector
	{
		private CFloat _percentToRefund;

		[Ordinal(0)] 
		[RED("percentToRefund")] 
		public CFloat PercentToRefund
		{
			get => GetProperty(ref _percentToRefund);
			set => SetProperty(ref _percentToRefund, value);
		}

		public CeaselessLeadAmmoEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
