using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerRemoteControlVehicle_NodeType : questIEntityManager_NodeType
	{
		private gameEntityReference _parentRef;
		private CBool _enable;
		private CBool _shouldUnseatPassengers;
		private CBool _shouldModifyInteractionState;

		[Ordinal(0)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get => GetProperty(ref _parentRef);
			set => SetProperty(ref _parentRef, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(2)] 
		[RED("shouldUnseatPassengers")] 
		public CBool ShouldUnseatPassengers
		{
			get => GetProperty(ref _shouldUnseatPassengers);
			set => SetProperty(ref _shouldUnseatPassengers, value);
		}

		[Ordinal(3)] 
		[RED("shouldModifyInteractionState")] 
		public CBool ShouldModifyInteractionState
		{
			get => GetProperty(ref _shouldModifyInteractionState);
			set => SetProperty(ref _shouldModifyInteractionState, value);
		}

		public questEntityManagerRemoteControlVehicle_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
