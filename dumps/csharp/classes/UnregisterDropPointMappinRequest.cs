using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnregisterDropPointMappinRequest : gameScriptableSystemRequest
	{
		private entEntityID _ownerID;
		private CBool _removeFromSystem;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(1)] 
		[RED("removeFromSystem")] 
		public CBool RemoveFromSystem
		{
			get => GetProperty(ref _removeFromSystem);
			set => SetProperty(ref _removeFromSystem, value);
		}

		public UnregisterDropPointMappinRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
