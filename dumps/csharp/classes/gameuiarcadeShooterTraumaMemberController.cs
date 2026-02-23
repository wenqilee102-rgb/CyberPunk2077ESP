using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterTraumaMemberController : gameuiarcadeShooterObjectController
	{
		private CFloat _baseFollowDelay;

		[Ordinal(3)] 
		[RED("baseFollowDelay")] 
		public CFloat BaseFollowDelay
		{
			get => GetProperty(ref _baseFollowDelay);
			set => SetProperty(ref _baseFollowDelay, value);
		}

		public gameuiarcadeShooterTraumaMemberController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
