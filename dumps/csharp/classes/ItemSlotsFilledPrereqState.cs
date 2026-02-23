using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemSlotsFilledPrereqState : gamePrereqState
	{
		private CHandle<redCallbackObject> _equipmentBlackboardCallback;
		private wCHandle<gameObject> _owner;
		private CArray<CEnum<gamedataEquipmentArea>> _equipAreas;

		[Ordinal(0)] 
		[RED("equipmentBlackboardCallback")] 
		public CHandle<redCallbackObject> EquipmentBlackboardCallback
		{
			get => GetProperty(ref _equipmentBlackboardCallback);
			set => SetProperty(ref _equipmentBlackboardCallback, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(2)] 
		[RED("equipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		public ItemSlotsFilledPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
