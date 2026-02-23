using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipWardrobeSetRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gameWardrobeClothingSetIndex> _setID;

		[Ordinal(1)] 
		[RED("setID")] 
		public CEnum<gameWardrobeClothingSetIndex> SetID
		{
			get => GetProperty(ref _setID);
			set => SetProperty(ref _setID, value);
		}

		public EquipWardrobeSetRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
