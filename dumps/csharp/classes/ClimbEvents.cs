using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClimbEvents : LocomotionGroundEvents
	{
		private CArray<CHandle<entIKTargetAddEvent>> _ikHandEvents;
		private CBool _shouldIkHands;
		private CInt32 _framesDelayingAnimStart;
		private wCHandle<entEntity> _climbedEntity;
		private Vector4 _playerCapsuleDimensions;

		[Ordinal(6)] 
		[RED("ikHandEvents")] 
		public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents
		{
			get => GetProperty(ref _ikHandEvents);
			set => SetProperty(ref _ikHandEvents, value);
		}

		[Ordinal(7)] 
		[RED("shouldIkHands")] 
		public CBool ShouldIkHands
		{
			get => GetProperty(ref _shouldIkHands);
			set => SetProperty(ref _shouldIkHands, value);
		}

		[Ordinal(8)] 
		[RED("framesDelayingAnimStart")] 
		public CInt32 FramesDelayingAnimStart
		{
			get => GetProperty(ref _framesDelayingAnimStart);
			set => SetProperty(ref _framesDelayingAnimStart, value);
		}

		[Ordinal(9)] 
		[RED("climbedEntity")] 
		public wCHandle<entEntity> ClimbedEntity
		{
			get => GetProperty(ref _climbedEntity);
			set => SetProperty(ref _climbedEntity, value);
		}

		[Ordinal(10)] 
		[RED("playerCapsuleDimensions")] 
		public Vector4 PlayerCapsuleDimensions
		{
			get => GetProperty(ref _playerCapsuleDimensions);
			set => SetProperty(ref _playerCapsuleDimensions, value);
		}

		public ClimbEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
