using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionTeleportTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _destinationPoint;
		private CHandle<AIArgumentMapping> _doNavTest;
		private CHandle<AIArgumentMapping> _rotation;
		private CHandle<AIArgumentMapping> _waitForPositionUpdate;

		[Ordinal(1)] 
		[RED("destinationPoint")] 
		public CHandle<AIArgumentMapping> DestinationPoint
		{
			get => GetProperty(ref _destinationPoint);
			set => SetProperty(ref _destinationPoint, value);
		}

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CHandle<AIArgumentMapping> DoNavTest
		{
			get => GetProperty(ref _doNavTest);
			set => SetProperty(ref _doNavTest, value);
		}

		[Ordinal(3)] 
		[RED("rotation")] 
		public CHandle<AIArgumentMapping> Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(4)] 
		[RED("waitForPositionUpdate")] 
		public CHandle<AIArgumentMapping> WaitForPositionUpdate
		{
			get => GetProperty(ref _waitForPositionUpdate);
			set => SetProperty(ref _waitForPositionUpdate, value);
		}

		public AIbehaviorActionTeleportTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
