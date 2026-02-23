using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameClothingSet : IScriptable
	{
		private CEnum<gameWardrobeClothingSetIndex> _setID;
		private CArray<gameSSlotVisualInfo> _clothingList;
		private TweakDBID _iconID;

		[Ordinal(0)] 
		[RED("setID")] 
		public CEnum<gameWardrobeClothingSetIndex> SetID
		{
			get => GetProperty(ref _setID);
			set => SetProperty(ref _setID, value);
		}

		[Ordinal(1)] 
		[RED("clothingList")] 
		public CArray<gameSSlotVisualInfo> ClothingList
		{
			get => GetProperty(ref _clothingList);
			set => SetProperty(ref _clothingList, value);
		}

		[Ordinal(2)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetProperty(ref _iconID);
			set => SetProperty(ref _iconID, value);
		}

		public gameClothingSet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
