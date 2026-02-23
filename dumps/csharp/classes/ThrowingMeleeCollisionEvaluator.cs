using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowingMeleeCollisionEvaluator : gameprojectileScriptCollisionEvaluator
	{
		private CBool _projectileStopAndStick;

		[Ordinal(0)] 
		[RED("projectileStopAndStick")] 
		public CBool ProjectileStopAndStick
		{
			get => GetProperty(ref _projectileStopAndStick);
			set => SetProperty(ref _projectileStopAndStick, value);
		}

		public ThrowingMeleeCollisionEvaluator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
