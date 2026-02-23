using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ContactSelectionChangedEvent : redEvent
	{
		private wCHandle<ContactData> _contactData;

		[Ordinal(0)] 
		[RED("ContactData")] 
		public wCHandle<ContactData> ContactData
		{
			get => GetProperty(ref _contactData);
			set => SetProperty(ref _contactData, value);
		}

		public ContactSelectionChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
