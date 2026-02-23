using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entUncontrolledMovementStartEvent : redEvent
	{
		private CFloat _ragdollNoGroundThreshold;
		private CBool _ragdollOnCollision;
		private CBool _calculateEarlyPositionGroundHeight;

		[Ordinal(0)] 
		[RED("ragdollNoGroundThreshold")] 
		public CFloat RagdollNoGroundThreshold
		{
			get => GetProperty(ref _ragdollNoGroundThreshold);
			set => SetProperty(ref _ragdollNoGroundThreshold, value);
		}

		[Ordinal(1)] 
		[RED("ragdollOnCollision")] 
		public CBool RagdollOnCollision
		{
			get => GetProperty(ref _ragdollOnCollision);
			set => SetProperty(ref _ragdollOnCollision, value);
		}

		[Ordinal(2)] 
		[RED("calculateEarlyPositionGroundHeight")] 
		public CBool CalculateEarlyPositionGroundHeight
		{
			get => GetProperty(ref _calculateEarlyPositionGroundHeight);
			set => SetProperty(ref _calculateEarlyPositionGroundHeight, value);
		}

		public entUncontrolledMovementStartEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
