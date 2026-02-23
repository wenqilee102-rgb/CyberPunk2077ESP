using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDManagerAssociationRequest : HUDManagerRequest
	{
		private entEntityID _associatedID;
		private CBool _isRegistering;

		[Ordinal(1)] 
		[RED("associatedID")] 
		public entEntityID AssociatedID
		{
			get => GetProperty(ref _associatedID);
			set => SetProperty(ref _associatedID, value);
		}

		[Ordinal(2)] 
		[RED("isRegistering")] 
		public CBool IsRegistering
		{
			get => GetProperty(ref _isRegistering);
			set => SetProperty(ref _isRegistering, value);
		}

		public HUDManagerAssociationRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
