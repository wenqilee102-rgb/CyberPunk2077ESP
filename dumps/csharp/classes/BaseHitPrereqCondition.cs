using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseHitPrereqCondition : IScriptable
	{
		private CBool _invert;
		private CBool _onlyOncePerShot;
		private CFloat _lastAttackTime;

		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(1)] 
		[RED("onlyOncePerShot")] 
		public CBool OnlyOncePerShot
		{
			get => GetProperty(ref _onlyOncePerShot);
			set => SetProperty(ref _onlyOncePerShot, value);
		}

		[Ordinal(2)] 
		[RED("lastAttackTime")] 
		public CFloat LastAttackTime
		{
			get => GetProperty(ref _lastAttackTime);
			set => SetProperty(ref _lastAttackTime, value);
		}

		public BaseHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
