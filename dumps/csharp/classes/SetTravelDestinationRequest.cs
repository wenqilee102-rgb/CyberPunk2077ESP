using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTravelDestinationRequest : gameScriptableSystemRequest
	{
		private gameNewMappinID _mappinID;
		private CInt32 _cost;

		[Ordinal(0)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		[Ordinal(1)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get => GetProperty(ref _cost);
			set => SetProperty(ref _cost, value);
		}

		public SetTravelDestinationRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
