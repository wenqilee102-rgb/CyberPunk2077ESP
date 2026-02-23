using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_BodySlam : animAnimFeature
	{
		private CInt32 _chargeLevel;

		[Ordinal(0)] 
		[RED("chargeLevel")] 
		public CInt32 ChargeLevel
		{
			get => GetProperty(ref _chargeLevel);
			set => SetProperty(ref _chargeLevel, value);
		}

		public AnimFeature_BodySlam(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
