using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericCodexEntryData : IScriptable
	{
		private CInt32 _hash;
		private CString _title;
		private CString _description;
		private CArray<CHandle<gameJournalEntryOverrideData>> _journalEntryOverrideDataList;
		private TweakDBID _imageId;
		private CInt32 _counter;
		private GameTime _timeStamp;
		private CBool _isNew;
		private CBool _isEp1;
		private CArray<CInt32> _newEntries;
		private gameItemID _itemID;
		private wCHandle<CodexListSyncData> _activeDataSync;

		[Ordinal(0)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(1)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(3)] 
		[RED("journalEntryOverrideDataList")] 
		public CArray<CHandle<gameJournalEntryOverrideData>> JournalEntryOverrideDataList
		{
			get => GetProperty(ref _journalEntryOverrideDataList);
			set => SetProperty(ref _journalEntryOverrideDataList, value);
		}

		[Ordinal(4)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetProperty(ref _imageId);
			set => SetProperty(ref _imageId, value);
		}

		[Ordinal(5)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		[Ordinal(6)] 
		[RED("timeStamp")] 
		public GameTime TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		[Ordinal(7)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(8)] 
		[RED("isEp1")] 
		public CBool IsEp1
		{
			get => GetProperty(ref _isEp1);
			set => SetProperty(ref _isEp1, value);
		}

		[Ordinal(9)] 
		[RED("newEntries")] 
		public CArray<CInt32> NewEntries
		{
			get => GetProperty(ref _newEntries);
			set => SetProperty(ref _newEntries, value);
		}

		[Ordinal(10)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(11)] 
		[RED("activeDataSync")] 
		public wCHandle<CodexListSyncData> ActiveDataSync
		{
			get => GetProperty(ref _activeDataSync);
			set => SetProperty(ref _activeDataSync, value);
		}

		public GenericCodexEntryData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
