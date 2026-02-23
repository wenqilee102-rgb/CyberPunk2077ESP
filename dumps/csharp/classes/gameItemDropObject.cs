using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemDropObject : gameLootObject
	{
		private CBool _isEmpty;
		private CBool _isIconic;
		private CBool _hasQuestItems;
		private gameItemID _spawnedItemID;

		[Ordinal(40)] 
		[RED("isEmpty")] 
		public CBool IsEmpty
		{
			get => GetProperty(ref _isEmpty);
			set => SetProperty(ref _isEmpty, value);
		}

		[Ordinal(41)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		[Ordinal(42)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get => GetProperty(ref _hasQuestItems);
			set => SetProperty(ref _hasQuestItems, value);
		}

		[Ordinal(43)] 
		[RED("spawnedItemID")] 
		public gameItemID SpawnedItemID
		{
			get => GetProperty(ref _spawnedItemID);
			set => SetProperty(ref _spawnedItemID, value);
		}

		public gameItemDropObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
