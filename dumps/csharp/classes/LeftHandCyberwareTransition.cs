using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareTransition : DefaultTransition
	{
		private CHandle<AnimFeature_LeftHandCyberware> _leftCWFeature;
		private CHandle<gameStatModifierData_Deprecated> _overchargeStatFlag;

		[Ordinal(0)] 
		[RED("leftCWFeature")] 
		public CHandle<AnimFeature_LeftHandCyberware> LeftCWFeature
		{
			get => GetProperty(ref _leftCWFeature);
			set => SetProperty(ref _leftCWFeature, value);
		}

		[Ordinal(1)] 
		[RED("overchargeStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> OverchargeStatFlag
		{
			get => GetProperty(ref _overchargeStatFlag);
			set => SetProperty(ref _overchargeStatFlag, value);
		}

		public LeftHandCyberwareTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
