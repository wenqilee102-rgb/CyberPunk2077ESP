using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_PhysicalImpulseFromInstigator_Value : gameEffectExecutor
	{
		private CFloat _magnitude;
		private CBool _forceUseHitPosition;

		[Ordinal(1)] 
		[RED("magnitude")] 
		public CFloat Magnitude
		{
			get => GetProperty(ref _magnitude);
			set => SetProperty(ref _magnitude, value);
		}

		[Ordinal(2)] 
		[RED("forceUseHitPosition")] 
		public CBool ForceUseHitPosition
		{
			get => GetProperty(ref _forceUseHitPosition);
			set => SetProperty(ref _forceUseHitPosition, value);
		}

		public gameEffectExecutor_PhysicalImpulseFromInstigator_Value(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
