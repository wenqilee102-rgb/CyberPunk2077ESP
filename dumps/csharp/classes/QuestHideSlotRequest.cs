using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestHideSlotRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataEquipmentArea> _slot;

		[Ordinal(1)] 
		[RED("slot")] 
		public CEnum<gamedataEquipmentArea> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		public QuestHideSlotRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
