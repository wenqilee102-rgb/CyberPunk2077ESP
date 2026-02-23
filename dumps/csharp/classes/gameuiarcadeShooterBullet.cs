using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterBullet : gameuiarcadeShooterObjectController
	{
		private CBool _customBoundSize;
		private Vector2 _boundSize;

		[Ordinal(3)] 
		[RED("customBoundSize")] 
		public CBool CustomBoundSize
		{
			get => GetProperty(ref _customBoundSize);
			set => SetProperty(ref _customBoundSize, value);
		}

		[Ordinal(4)] 
		[RED("boundSize")] 
		public Vector2 BoundSize
		{
			get => GetProperty(ref _boundSize);
			set => SetProperty(ref _boundSize, value);
		}

		public gameuiarcadeShooterBullet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
