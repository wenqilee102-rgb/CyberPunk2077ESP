using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDeviceMappinData : IScriptable
	{
		private entEntityID _ownerID;
		private CBool _isUsed;
		private Vector4 _position;
		private gameNewMappinID _mappinID;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(1)] 
		[RED("isUsed")] 
		public CBool IsUsed
		{
			get => GetProperty(ref _isUsed);
			set => SetProperty(ref _isUsed, value);
		}

		[Ordinal(2)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(3)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		public PerkDeviceMappinData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
