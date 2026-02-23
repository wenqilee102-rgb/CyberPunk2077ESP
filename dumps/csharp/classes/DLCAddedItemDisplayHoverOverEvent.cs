using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DLCAddedItemDisplayHoverOverEvent : redEvent
	{
		private TweakDBID _itemTDBID;

		[Ordinal(0)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetProperty(ref _itemTDBID);
			set => SetProperty(ref _itemTDBID, value);
		}

		public DLCAddedItemDisplayHoverOverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
