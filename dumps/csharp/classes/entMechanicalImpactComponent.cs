using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMechanicalImpactComponent : entIComponent
	{
		private CFloat _c_impulseMagThreshold;

		[Ordinal(3)] 
		[RED("c_impulseMagThreshold")] 
		public CFloat C_impulseMagThreshold
		{
			get => GetProperty(ref _c_impulseMagThreshold);
			set => SetProperty(ref _c_impulseMagThreshold, value);
		}

		public entMechanicalImpactComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
