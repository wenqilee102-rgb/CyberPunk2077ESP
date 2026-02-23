using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RestoreVisualSlot : redEvent
	{
		private CEnum<TransmogSlots> _slot;

		[Ordinal(0)] 
		[RED("slot")] 
		public CEnum<TransmogSlots> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		public RestoreVisualSlot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
