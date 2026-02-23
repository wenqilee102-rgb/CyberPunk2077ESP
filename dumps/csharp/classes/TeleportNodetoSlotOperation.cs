using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TeleportNodetoSlotOperation : DeviceOperationBase
	{
		private CName _slotName;
		private NodeRef _gameObjectRef;

		[Ordinal(5)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(6)] 
		[RED("gameObjectRef")] 
		public NodeRef GameObjectRef
		{
			get => GetProperty(ref _gameObjectRef);
			set => SetProperty(ref _gameObjectRef, value);
		}

		public TeleportNodetoSlotOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
