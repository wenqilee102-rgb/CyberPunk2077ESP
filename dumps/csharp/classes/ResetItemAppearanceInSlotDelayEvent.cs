using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResetItemAppearanceInSlotDelayEvent : redEvent
	{
		private TweakDBID _slotID;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		public ResetItemAppearanceInSlotDelayEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
