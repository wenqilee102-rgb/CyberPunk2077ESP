using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExhaustedDecisions : StaminaTransition
	{
		private CFloat _staminaRatioEnterCondition;

		[Ordinal(1)] 
		[RED("staminaRatioEnterCondition")] 
		public CFloat StaminaRatioEnterCondition
		{
			get => GetProperty(ref _staminaRatioEnterCondition);
			set => SetProperty(ref _staminaRatioEnterCondition, value);
		}

		public ExhaustedDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
