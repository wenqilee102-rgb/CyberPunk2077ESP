using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformMovementStateChanged : redEvent
	{
		private CBool _isMoving;

		[Ordinal(0)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetProperty(ref _isMoving);
			set => SetProperty(ref _isMoving, value);
		}

		public gameMovingPlatformMovementStateChanged(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
