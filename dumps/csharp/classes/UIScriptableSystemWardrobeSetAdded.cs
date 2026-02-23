using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemWardrobeSetAdded : gameScriptableSystemRequest
	{
		private CEnum<gameWardrobeClothingSetIndex> _wardrobeSet;

		[Ordinal(0)] 
		[RED("wardrobeSet")] 
		public CEnum<gameWardrobeClothingSetIndex> WardrobeSet
		{
			get => GetProperty(ref _wardrobeSet);
			set => SetProperty(ref _wardrobeSet, value);
		}

		public UIScriptableSystemWardrobeSetAdded(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
