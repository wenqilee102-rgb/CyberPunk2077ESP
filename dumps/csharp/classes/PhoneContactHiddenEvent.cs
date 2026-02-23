using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneContactHiddenEvent : redEvent
	{
		private wCHandle<inkVirtualCompoundItemController> _hiddenItem;

		[Ordinal(0)] 
		[RED("HiddenItem")] 
		public wCHandle<inkVirtualCompoundItemController> HiddenItem
		{
			get => GetProperty(ref _hiddenItem);
			set => SetProperty(ref _hiddenItem, value);
		}

		public PhoneContactHiddenEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
