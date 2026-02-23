using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolValuePerHitEffector : ModifyStatPoolValueEffector
	{
		private CFloat _damageScaleFactor;

		[Ordinal(4)] 
		[RED("damageScaleFactor")] 
		public CFloat DamageScaleFactor
		{
			get => GetProperty(ref _damageScaleFactor);
			set => SetProperty(ref _damageScaleFactor, value);
		}

		public ModifyStatPoolValuePerHitEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
