using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionDemolition : ActionSkillCheck
	{
		private gamemountingMountingSlotId _slotID;

		[Ordinal(45)] 
		[RED("slotID")] 
		public gamemountingMountingSlotId SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		public ActionDemolition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
