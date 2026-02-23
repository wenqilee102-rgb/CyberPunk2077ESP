using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiChangeCameraControlHintVisibilityEvent : redEvent
	{
		private CBool _movementVisible;
		private CBool _rotationVisible;

		[Ordinal(0)] 
		[RED("movementVisible")] 
		public CBool MovementVisible
		{
			get => GetProperty(ref _movementVisible);
			set => SetProperty(ref _movementVisible, value);
		}

		[Ordinal(1)] 
		[RED("rotationVisible")] 
		public CBool RotationVisible
		{
			get => GetProperty(ref _rotationVisible);
			set => SetProperty(ref _rotationVisible, value);
		}

		public gameuiChangeCameraControlHintVisibilityEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
