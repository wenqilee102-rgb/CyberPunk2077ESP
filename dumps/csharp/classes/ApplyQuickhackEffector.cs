using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyQuickhackEffector : AbstractApplyQuickhackEffector
	{
		private TweakDBID _quickhackObjectActionID;
		private wCHandle<gamedataObjectAction_Record> _quickhackObjectActionRecord;
		private CFloat _maxUploadChance;
		private CFloat _uploadTime;

		[Ordinal(2)] 
		[RED("quickhackObjectActionID")] 
		public TweakDBID QuickhackObjectActionID
		{
			get => GetProperty(ref _quickhackObjectActionID);
			set => SetProperty(ref _quickhackObjectActionID, value);
		}

		[Ordinal(3)] 
		[RED("quickhackObjectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> QuickhackObjectActionRecord
		{
			get => GetProperty(ref _quickhackObjectActionRecord);
			set => SetProperty(ref _quickhackObjectActionRecord, value);
		}

		[Ordinal(4)] 
		[RED("MaxUploadChance")] 
		public CFloat MaxUploadChance
		{
			get => GetProperty(ref _maxUploadChance);
			set => SetProperty(ref _maxUploadChance, value);
		}

		[Ordinal(5)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get => GetProperty(ref _uploadTime);
			set => SetProperty(ref _uploadTime, value);
		}

		public ApplyQuickhackEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
