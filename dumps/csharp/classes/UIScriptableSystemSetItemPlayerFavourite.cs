using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemSetItemPlayerFavourite : gameScriptableSystemRequest
	{
		private gameItemID _itemID;
		private CBool _favourite;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("favourite")] 
		public CBool Favourite
		{
			get => GetProperty(ref _favourite);
			set => SetProperty(ref _favourite, value);
		}

		public UIScriptableSystemSetItemPlayerFavourite(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
