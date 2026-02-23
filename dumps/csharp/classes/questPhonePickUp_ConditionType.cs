using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhonePickUp_ConditionType : questISystemConditionType
	{
		private CHandle<gameJournalPath> _caller;
		private CHandle<gameJournalPath> _addressee;
		private CBool _releaseOnRejection;

		[Ordinal(0)] 
		[RED("caller")] 
		public CHandle<gameJournalPath> Caller
		{
			get => GetProperty(ref _caller);
			set => SetProperty(ref _caller, value);
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CHandle<gameJournalPath> Addressee
		{
			get => GetProperty(ref _addressee);
			set => SetProperty(ref _addressee, value);
		}

		[Ordinal(2)] 
		[RED("releaseOnRejection")] 
		public CBool ReleaseOnRejection
		{
			get => GetProperty(ref _releaseOnRejection);
			set => SetProperty(ref _releaseOnRejection, value);
		}

		public questPhonePickUp_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
