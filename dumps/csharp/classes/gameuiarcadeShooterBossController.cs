using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterBossController : gameuiarcadeShooterAIBase
	{
		private CBool _customBoundSize;
		private Vector2 _bossSize;

		[Ordinal(3)] 
		[RED("customBoundSize")] 
		public CBool CustomBoundSize
		{
			get => GetProperty(ref _customBoundSize);
			set => SetProperty(ref _customBoundSize, value);
		}

		[Ordinal(4)] 
		[RED("bossSize")] 
		public Vector2 BossSize
		{
			get => GetProperty(ref _bossSize);
			set => SetProperty(ref _bossSize, value);
		}

		public gameuiarcadeShooterBossController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
